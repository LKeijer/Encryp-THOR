using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encrypthor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputText = richTextBox1.Text.ToString();

            int key = 129;
            StringBuilder encr = new StringBuilder(inputText);
            StringBuilder decr = new StringBuilder(inputText.Length);
            char p;
            for (int i = 0; i < inputText.Length; i++)
            {
                p = encr[i];
                p = (char)(p ^ key);
                decr.Append(p);
            }
            richTextBox1.Text = decr.ToString();
        }
    }
}
