using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XOR_encryption
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public int XOR(string bit1, string bit2)
        {
            if (bit1 == bit2)
            {
                return 0;
            }
            else { return 1; }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnKeyGen_Click(object sender, EventArgs e)
        {
            txtKeyHist.Text += (txtKey.Text + "\r\n");
            string key = "";
            var rand = new Random();

            for (int i = 0; i < 8; i++)
            {
                key+= rand.Next(0, 2);
            }

            txtKey.Text = key;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length == 8)
            {
                string key = txtKey.Text;
                if (radEnc.Checked)
                {
                    txtCipher.Text = "";
                    var plaintext = new string[9999];
                    txtPlain.Lines.CopyTo(plaintext, 0);
                    Array.Resize(ref plaintext, txtPlain.Lines.Length);

                    for (int i = 0; i < plaintext.Length; i++)                                      //looping through textbox
                    {       
                        for (int j = 0; j < plaintext[i].Length; j++)                                 //looping through line
                        {
                            int plainAscii = Convert.ToChar(plaintext[i].Substring(j, 1));
                            string plainAsciiBin = Convert.ToString(plainAscii, 2);
                            if (plainAsciiBin.Length == 6) { plainAsciiBin = "00" + plainAsciiBin; }
                            else if (plainAsciiBin.Length == 7) { plainAsciiBin = "0" + plainAsciiBin; }
                            
                            for (int k = 0; k < plainAsciiBin.Length; k++)                                               //looping through line
                            { 
                                txtCipher.Text += XOR(plainAsciiBin.Substring(k, 1), key.Substring(k, 1));
                            }
                            txtCipher.Text += " ";
                        }
                    }
                }
                else if (radDec.Checked)
                {
                    txtPlain.Text = "";
                    var enctext = new string[9999];
                    txtCipher.Lines.CopyTo(enctext, 0);
                    Array.Resize(ref enctext, txtCipher.Lines.Length);

                    for (int i = 0; i < enctext.Length; i++)                    //looping through text box
                    {
                        string currBinNum = "";
                        string plainAsciiBin = "";
                        for (int j = 0; j < enctext[i].Length; j++)             //looping through line
                        {

                            if (enctext[i].Substring(j, 1) == " ")
                            {
                                for (int k = 0; k < currBinNum.Length; k++)
                                {
                                    plainAsciiBin += XOR(currBinNum.Substring(k, 1), key.Substring(k, 1));
                                }
                                int plainAscii = Convert.ToInt32(plainAsciiBin, 2);
                                char plainText = (char)plainAscii;
                                txtPlain.Text += plainText;
                                plainAsciiBin = "";
                                currBinNum = "";
                            }
                            else
                            {
                                currBinNum += enctext[i].Substring(j, 1);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an option to encrypt or decrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter an 8-bit binary number for a key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClrPlain_Click(object sender, EventArgs e)
        {
            txtPlain.Text = "";
        }

        private void btnClrCipher_Click(object sender, EventArgs e)
        {
            txtCipher.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCipher.Text = "";
            txtPlain.Text = "";
            txtKey.Text = "";
        }

        private void btnPlainCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPlain.Text);
        }

        private void btnEncCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCipher.Text);
        }
    }
}
