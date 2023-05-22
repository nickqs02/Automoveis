using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica
{
    public abstract class Automovel
    {
        public string cor;
        public int qntdrodas;
        public int chassi;
        public int placa;
        public string marca;
        public string modelo;
        public double preco;
        public int ano;

        protected abstract void ligar();
        
        public void mover()
        {
            ligar();
            MessageBox.Show(modelo + " entrou em movimento!");
        }

        public void Parar()
        {
            mover();
            MessageBox.Show(modelo + " está parando!");
        }
    }
}
