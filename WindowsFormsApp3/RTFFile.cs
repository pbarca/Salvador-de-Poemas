using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class RTFFile
    {
        private string _path = Application.StartupPath + "\\Resources\\Teste.txt";
        private string _texto;

        public string Texto
        {
            get
            {
                _texto = File.ReadAllText(_path);
                return _texto;
            }
            set { _texto = value; }
        }

        public void Salvar()
        {
            File.WriteAllText(_path, _texto);
        }

        public void Reset()
        {
            _texto = "";
        }

    }
}
