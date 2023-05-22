using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica
{
    class Moto : Automovel
    {
        public string freioabs;
        public string partidaeletrica;
        public string bau;

        protected override void ligar()
        {
            MessageBox.Show("Ligando " + modelo);
        }

        public void buzinar()
        {
            ligar();
            MessageBox.Show("Buzinando...");
        }
    }
}
