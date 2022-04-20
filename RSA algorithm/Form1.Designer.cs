namespace RC4_algorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.origText = new System.Windows.Forms.RichTextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptText = new System.Windows.Forms.RichTextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce a Text";
            // 
            // origText
            // 
            this.origText.BackColor = System.Drawing.Color.Bisque;
            this.origText.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.origText.Location = new System.Drawing.Point(12, 47);
            this.origText.Name = "origText";
            this.origText.Size = new System.Drawing.Size(187, 391);
            this.origText.TabIndex = 1;
            this.origText.Text = "";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encryptBtn.Location = new System.Drawing.Point(205, 192);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(93, 70);
            this.encryptBtn.TabIndex = 2;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(295, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Encrypted Text";
            // 
            // encryptText
            // 
            this.encryptText.BackColor = System.Drawing.Color.SandyBrown;
            this.encryptText.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.encryptText.Location = new System.Drawing.Point(304, 47);
            this.encryptText.Name = "encryptText";
            this.encryptText.Size = new System.Drawing.Size(187, 391);
            this.encryptText.TabIndex = 1;
            this.encryptText.Text = "";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Font = new System.Drawing.Font("Stencil", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decryptBtn.Location = new System.Drawing.Point(493, 192);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(111, 70);
            this.decryptBtn.TabIndex = 2;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(594, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Decrypted Text";
            // 
            // decryptedText
            // 
            this.decryptedText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.decryptedText.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decryptedText.Location = new System.Drawing.Point(605, 47);
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.Size = new System.Drawing.Size(187, 391);
            this.decryptedText.TabIndex = 1;
            this.decryptedText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.decryptedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.origText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox origText;
        private Button encryptBtn;
        private Label label2;
        private RichTextBox encryptText;
        private Button decryptBtn;
        private Label label3;
        private RichTextBox decryptedText;
    }
}