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

        public string path = Application.StartupPath + "\\Resources\\Teste.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(path);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, richTextBox1.Text);
        }

    }
}
