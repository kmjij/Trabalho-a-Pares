using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhopares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1, N2, S;
            try
            {
                N1 = int.Parse(textBox1.Text);
                N2 = int.Parse(textBox2.Text);
                S = N1 + N2;
                label4.Text = S.ToString();
            }
                catch (Exception erro)
            {

                MessageBox.Show(erro.Message, " *** ERRO *** ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                label4.Text = "";
                textBox1.Focus();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            textBox1.Focus();
        }
    }
}
