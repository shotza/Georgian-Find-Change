using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = vipovot.Text;
            string b = shevcvalot.Text;

            if (textBox1.Text.Length > 0)
            {
                if (checkBox1.Checked)
                {
                    textBox2.Text = textBox1.Text.Replace(System.Environment.NewLine, b);
                }
                if (!checkBox1.Checked)
                {
                    textBox2.Text = textBox1.Text.Replace(a, b);
                }
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Shota Abzhandadze");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
