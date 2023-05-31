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

            byte[] data = Encoding.ASCII.GetBytes(inputTextBox.ToString());
            byte[] hash = alg.ComputeHash(data);

            RSAParameters sharedParameters;
            byte[] signedHash;

            // Generate signature
            using (RSA rsa = RSA.Create())
            {
                sharedParameters = rsa.ExportParameters(false);

                RSAPKCS1SignatureFormatter rsaFormatter = new(rsa);
                rsaFormatter.SetHashAlgorithm(nameof(SHA256));

                signedHash = rsaFormatter.CreateSignature(hash);
                string signedHashString = Convert.ToBase64String(signedHash);
                outputTextBox.Text = signedHashString;
            }

        }
    }
}