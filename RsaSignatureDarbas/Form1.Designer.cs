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
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 12);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(392, 156);
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
            btnSign.Location = new Point(347, 208);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(75, 23);
            btnSign.TabIndex = 2;
            btnSign.Text = "Sign";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSign);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox inputTextBox;
        private RichTextBox outputTextBox;
        private Button btnSign;
    }
}