using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica
{
    class Carro : Automovel
    {
        public string carroceria;
        public string tetosolar;
        public string conversivel;
        public bool aberto;

        protected override void ligar()
        {    
            MessageBox.Show("Ligando " + modelo);
        }

        //private bool Fechado;
        public void abrirFechar()
        {
            if (aberto)
            {
                aberto = true;
                MessageBox.Show(modelo + " está aberto!");              
            }
            else
            {
                aberto = false;
                MessageBox.Show(modelo + " está fechado!");
            }           
        }
    }
}