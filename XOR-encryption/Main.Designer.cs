namespace XOR_encryption
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlain = new System.Windows.Forms.RichTextBox();
            this.radEnc = new System.Windows.Forms.RadioButton();
            this.radDec = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.txtCipher = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyHist = new System.Windows.Forms.RichTextBox();
            this.btnClrPlain = new System.Windows.Forms.Button();
            this.btnClrCipher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlainCopy = new System.Windows.Forms.Button();
            this.btnEncCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlain
            // 
            this.txtPlain.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlain.Location = new System.Drawing.Point(29, 161);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(495, 494);
            this.txtPlain.TabIndex = 0;
            this.txtPlain.Text = "";
            // 
            // radEnc
            // 
            this.radEnc.AutoSize = true;
            this.radEnc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnc.Location = new System.Drawing.Point(972, 25);
            this.radEnc.Name = "radEnc";
            this.radEnc.Size = new System.Drawing.Size(110, 34);
            this.radEnc.TabIndex = 1;
            this.radEnc.TabStop = true;
            this.radEnc.Text = "Encrypt";
            this.radEnc.UseVisualStyleBackColor = true;
            // 
            // radDec
            // 
            this.radDec.AutoSize = true;
            this.radDec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDec.Location = new System.Drawing.Point(972, 65);
            this.radDec.Name = "radDec";
            this.radDec.Size = new System.Drawing.Size(114, 34);
            this.radDec.TabIndex = 2;
            this.radDec.TabStop = true;
            this.radDec.Text = "Decrypt";
            this.radDec.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(1092, 26);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(121, 73);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(78, 37);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(183, 36);
            this.txtKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key:";
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyGen.Location = new System.Drawing.Point(277, 15);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(124, 77);
            this.btnKeyGen.TabIndex = 6;
            this.btnKeyGen.Text = "Generate Key";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.btnKeyGen_Click);
            // 
            // txtCipher
            // 
            this.txtCipher.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipher.Location = new System.Drawing.Point(555, 161);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(495, 494);
            this.txtCipher.TabIndex = 0;
            this.txtCipher.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Plaintext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciphertext";
            // 
            // txtKeyHist
            // 
            this.txtKeyHist.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyHist.Location = new System.Drawing.Point(1077, 161);
            this.txtKeyHist.Name = "txtKeyHist";
            this.txtKeyHist.Size = new System.Drawing.Size(163, 494);
            this.txtKeyHist.TabIndex = 10;
            this.txtKeyHist.Text = "Key History";
            // 
            // btnClrPlain
            // 
            this.btnClrPlain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrPlain.Location = new System.Drawing.Point(434, 597);
            this.btnClrPlain.Name = "btnClrPlain";
            this.btnClrPlain.Size = new System.Drawing.Size(79, 47);
            this.btnClrPlain.TabIndex = 11;
            this.btnClrPlain.Text = "Clear";
            this.btnClrPlain.UseVisualStyleBackColor = true;
            this.btnClrPlain.Click += new System.EventHandler(this.btnClrPlain_Click);
            // 
            // btnClrCipher
            // 
            this.btnClrCipher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrCipher.Location = new System.Drawing.Point(958, 599);
            this.btnClrCipher.Name = "btnClrCipher";
            this.btnClrCipher.Size = new System.Drawing.Size(79, 45);
            this.btnClrCipher.TabIndex = 12;
            this.btnClrCipher.Text = "Clear";
            this.btnClrCipher.UseVisualStyleBackColor = true;
            this.btnClrCipher.Click += new System.EventHandler(this.btnClrCipher_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(772, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 66);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlainCopy
            // 
            this.btnPlainCopy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlainCopy.Location = new System.Drawing.Point(349, 597);
            this.btnPlainCopy.Name = "btnPlainCopy";
            this.btnPlainCopy.Size = new System.Drawing.Size(79, 47);
            this.btnPlainCopy.TabIndex = 14;
            this.btnPlainCopy.Text = "Copy";
            this.btnPlainCopy.UseVisualStyleBackColor = true;
            this.btnPlainCopy.Click += new System.EventHandler(this.btnPlainCopy_Click);
            // 
            // btnEncCopy
            // 
            this.btnEncCopy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncCopy.Location = new System.Drawing.Point(873, 599);
            this.btnEncCopy.Name = "btnEncCopy";
            this.btnEncCopy.Size = new System.Drawing.Size(79, 45);
            this.btnEncCopy.TabIndex = 15;
            this.btnEncCopy.Text = "Copy";
            this.btnEncCopy.UseVisualStyleBackColor = true;
            this.btnEncCopy.Click += new System.EventHandler(this.btnEncCopy_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 682);
            this.Controls.Add(this.btnEncCopy);
            this.Controls.Add(this.btnPlainCopy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClrCipher);
            this.Controls.Add(this.btnClrPlain);
            this.Controls.Add(this.txtKeyHist);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.radDec);
            this.Controls.Add(this.radEnc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKeyGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtPlain);
            this.Name = "Main";
            this.Text = "XOR Cipher Encryption Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPlain;
        private System.Windows.Forms.RadioButton radEnc;
        private System.Windows.Forms.RadioButton radDec;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.RichTextBox txtCipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtKeyHist;
        private System.Windows.Forms.Button btnClrPlain;
        private System.Windows.Forms.Button btnClrCipher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlainCopy;
        private System.Windows.Forms.Button btnEncCopy;
    }
}

