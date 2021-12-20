﻿namespace XOR_encryption
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
            this.radEnc.Location = new System.Drawing.Point(438, 18);
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
            this.radDec.Location = new System.Drawing.Point(438, 58);
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
            this.btnGo.Location = new System.Drawing.Point(570, 26);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(121, 54);
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
            this.txtCipher.Location = new System.Drawing.Point(570, 161);
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
            this.label3.Location = new System.Drawing.Point(573, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciphertext";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 682);
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
    }
}

