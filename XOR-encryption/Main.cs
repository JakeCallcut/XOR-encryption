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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnKeyGen_Click(object sender, EventArgs e)
        {
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
            if (radEnc.Checked)
            {
                var plaintext = new string[9999];
                txtPlain.Lines.CopyTo(plaintext, 0);

                txtCipher.Lines = plaintext;                    //last edit

            }
            else if (radDec.Checked)
            {

            }
            else
            {
                MessageBox.Show("Please select an option to encrypt or decrypt", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
