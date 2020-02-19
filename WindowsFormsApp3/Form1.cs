using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RTFFile MeuTexto = new RTFFile();
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = MeuTexto.Texto;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MeuTexto.Texto = richTextBox1.Text;
            MeuTexto.Salvar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MeuTexto.Texto = richTextBox1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = MeuTexto.Texto;
        }
    }

}
