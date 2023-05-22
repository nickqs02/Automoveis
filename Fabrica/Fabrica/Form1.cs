using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private Automovel CarroObj;
        private void btCriarCarro_Click(object sender, EventArgs e)
        {
            CarroObj = new Carro();
            CarroObj.cor = tbCorCarro.Text;
            CarroObj.chassi = int.Parse(tbChassiCarro.Text);
            CarroObj.placa = int.Parse(tbPlacaCarro.Text);
            CarroObj.marca = tbMarcaCarro.Text;
            CarroObj.modelo = tbModeloCarro.Text;
            CarroObj.preco = double.Parse(tbPrecoCarro.Text);
            CarroObj.ano = int.Parse(tbAnoCarro.Text);
            CarroObj.qntdrodas = int.Parse(tbQntdRodasCarro.Text);
            (CarroObj as Carro).carroceria = tbCarroceriaCarro.Text;
            (CarroObj as Carro).tetosolar = tbTetoSolarCarro.Text;
            (CarroObj as Carro).conversivel = tbConversivelCarro.Text;
            (CarroObj as Carro).aberto = bool.Parse(tbAbertoCarro.Text);
        }

        private void btMoverCarro_Click(object sender, EventArgs e)
        {
            CarroObj.mover();                       
        }

        private void btPararCarro_Click(object sender, EventArgs e)
        {
            CarroObj.Parar();
        }

        private void btAbrirFecharCarro_Click(object sender, EventArgs e)
        {
            (CarroObj as Carro).abrirFechar();
        }

        private Automovel MotoObj;
        private void btCriarMoto_Click(object sender, EventArgs e)
        {
            MotoObj = new Moto();
            MotoObj.cor = tbCorMoto.Text;
            MotoObj.chassi = int.Parse(tbChassiMoto.Text);
            MotoObj.placa = int.Parse(tbPlacaMoto.Text);
            MotoObj.marca = tbMarcaMoto.Text;
            MotoObj.modelo = tbModeloMoto.Text;
            MotoObj.preco = double.Parse(tbPrecoMoto.Text);
            MotoObj.ano = int.Parse(tbAnoMoto.Text);
            MotoObj.qntdrodas = int.Parse(tbQntdRodasMoto.Text);
            (MotoObj as Moto).freioabs = tbFreioAbsMoto.Text;
            (MotoObj as Moto).partidaeletrica = tbPartidaEletricaMoto.Text;
            (MotoObj as Moto).bau = tbBauMoto.Text;
        }

        private void btMoverMoto_Click(object sender, EventArgs e)
        {
            MotoObj.mover();        
        }

        private void btPararMoto_Click(object sender, EventArgs e)
        {
            MotoObj.Parar();
        }

        private void btBuzinarMoto_Click(object sender, EventArgs e)
        {
            (MotoObj as Moto).buzinar();
        }        
    }
}
