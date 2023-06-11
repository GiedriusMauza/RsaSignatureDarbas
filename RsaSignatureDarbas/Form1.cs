using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace RsaSignatureDarbas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            using SHA256 alg = SHA256.Create();

            var message = inputTextBox.Text;

            byte[] data = Encoding.ASCII.GetBytes(message);
            byte[] hash = alg.ComputeHash(data);

            RSAParameters sharedParameters;
            byte[] signedHash;

            if (message != String.Empty)
            {
                // Generate signature
                using (RSA rsa = RSA.Create())
                {
                    // Public key
                    publicKeyTextBox.Text = Convert.ToBase64String(rsa.ExportRSAPublicKey());

                    sharedParameters = rsa.ExportParameters(false);

                    RSAPKCS1SignatureFormatter rsaFormatter = new(rsa);
                    rsaFormatter.SetHashAlgorithm(nameof(SHA256));

                    signedHash = rsaFormatter.CreateSignature(hash);
                    string signedHashString = Convert.ToBase64String(signedHash);

                    // Signature
                    outputTextBox.Text = signedHashString;
                }
            }
            else
            {
                publicKeyTextBox.Text = "Enter message first";
                outputTextBox.Text = "Enter message first";
            }
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            using Socket client = await SendMessage("M@" + inputTextBox.Text);
            using Socket client3 = await SendMessage("K@" + publicKeyTextBox.Text);
            using Socket client4 = await SendMessage("S@" + outputTextBox.Text);
        }

        private async Task<Socket> SendMessage(String messageText)
        {
            IPHostEntry ipHostInfo = await Dns.GetHostEntryAsync(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint ipEndPoint = new(ipAddress, 11_000);
            Socket client = new(
                                    ipEndPoint.AddressFamily,
                                    SocketType.Stream,
                                    ProtocolType.Tcp);

            await client.ConnectAsync(ipEndPoint);
            while (true)
            {
                // Send message.
                var message = messageText + "<|EOM|>";
                var messageBytes = Encoding.UTF8.GetBytes(message);
                _ = await client.SendAsync(messageBytes, SocketFlags.None);
                Console.WriteLine($"Socket client sent message: \"{message}\"");

                // Receive ack.
                var buffer = new byte[1_024];
                var received = await client.ReceiveAsync(buffer, SocketFlags.None);
                var response = Encoding.UTF8.GetString(buffer, 0, received);
                if (response == "<|ACK|>")
                {
                    Console.WriteLine(
                        $"Socket client received acknowledgment: \"{response}\"");
                    break;
                }
            }

            client.Shutdown(SocketShutdown.Both);
            return client;
        }
    }
}