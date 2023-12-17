namespace QrCodeGen
{
    partial class QrCode
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
            qrCodeBox1 = new PictureBox();
            userInputBox = new TextBox();
            buttonGen = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)qrCodeBox1).BeginInit();
            SuspendLayout();
            // 
            // qrCodeBox1
            // 
            qrCodeBox1.Location = new Point(608, 51);
            qrCodeBox1.Name = "qrCodeBox1";
            qrCodeBox1.Size = new Size(180, 187);
            qrCodeBox1.TabIndex = 0;
            qrCodeBox1.TabStop = false;
            // 
            // userInputBox
            // 
            userInputBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userInputBox.Location = new Point(24, 66);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(526, 63);
            userInputBox.TabIndex = 1;
            userInputBox.Text = "www.google.com";
            // 
            // buttonGen
            // 
            buttonGen.Location = new Point(24, 164);
            buttonGen.Name = "buttonGen";
            buttonGen.Size = new Size(166, 62);
            buttonGen.TabIndex = 2;
            buttonGen.Text = "Generate QR Code";
            buttonGen.UseVisualStyleBackColor = true;
            buttonGen.Click += buttonGen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(216, 164);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(166, 62);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // QrCode
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 280);
            Controls.Add(buttonSave);
            Controls.Add(buttonGen);
            Controls.Add(userInputBox);
            Controls.Add(qrCodeBox1);
            Name = "QrCode";
            Text = "Qr Code Generator";
            ((System.ComponentModel.ISupportInitialize)qrCodeBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox qrCodeBox1;
        private TextBox userInputBox;
        private Button buttonGen;
        private Button buttonSave;
    }
}