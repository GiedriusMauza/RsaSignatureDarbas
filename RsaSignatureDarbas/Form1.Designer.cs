namespace RsaSignatureDarbas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new RichTextBox();
            outputTextBox = new RichTextBox();
            btnSign = new Button();
            messagelb = new Label();
            signaturelb = new Label();
            publicKeyTextBox = new RichTextBox();
            publiclb = new Label();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 31);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(242, 79);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(448, 277);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(340, 161);
            outputTextBox.TabIndex = 1;
            outputTextBox.Text = "";
            // 
            // btnSign
            // 
            btnSign.Location = new Point(316, 59);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(75, 23);
            btnSign.TabIndex = 2;
            btnSign.Text = "Sign";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // messagelb
            // 
            messagelb.AutoSize = true;
            messagelb.Location = new Point(16, 7);
            messagelb.Name = "messagelb";
            messagelb.Size = new Size(53, 15);
            messagelb.TabIndex = 3;
            messagelb.Text = "Message";
            // 
            // signaturelb
            // 
            signaturelb.AutoSize = true;
            signaturelb.Location = new Point(453, 249);
            signaturelb.Name = "signaturelb";
            signaturelb.Size = new Size(57, 15);
            signaturelb.TabIndex = 4;
            signaturelb.Text = "Signature";
            // 
            // publicKeyTextBox
            // 
            publicKeyTextBox.Location = new Point(16, 277);
            publicKeyTextBox.Name = "publicKeyTextBox";
            publicKeyTextBox.Size = new Size(375, 161);
            publicKeyTextBox.TabIndex = 5;
            publicKeyTextBox.Text = "";
            // 
            // publiclb
            // 
            publiclb.AutoSize = true;
            publiclb.Location = new Point(16, 249);
            publiclb.Name = "publiclb";
            publiclb.Size = new Size(62, 15);
            publiclb.TabIndex = 6;
            publiclb.Text = "Public Key";
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(453, 59);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 7;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSend);
            Controls.Add(publiclb);
            Controls.Add(publicKeyTextBox);
            Controls.Add(signaturelb);
            Controls.Add(messagelb);
            Controls.Add(btnSign);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox inputTextBox;
        private RichTextBox outputTextBox;
        private Button btnSign;
        private Label messagelb;
        private Label signaturelb;
        private RichTextBox publicKeyTextBox;
        private Label publiclb;
        private Button buttonSend;
    }
}