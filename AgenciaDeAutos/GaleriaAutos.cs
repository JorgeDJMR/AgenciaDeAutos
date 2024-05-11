
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeAutos
{
    public partial class GaleriaAutos : Form
    {
        public GaleriaAutos()
        {
            InitializeComponent();
        }
        public string Autoelegido ="";
        public Image Carro = null;
        public double costoo = 0;
        menuPrincipal secondForm = new menuPrincipal();


        public string nombreAuto = "";

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Carro = this.pictureBox1.Image;
            Autoelegido = "Nombre:Lamborghini Aventador SVJ\r\nMarca: Lamborghini\r\nColor: Verde lima\r\nAño: 2020\r\nPrecio: alrededor de $520,000 USD";
            costoo = 520000;
            nombreAuto = "Lamborghini Aventador SVJ";
            
            this.Close();


           // secondForm.Show();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Carro = this.pictureBox2.Image;
            Autoelegido = "Nombre:Porsche 911 GT3 RS\r\nMarca: Porsche\r\nColor: Blanco Carrera\r\nAño: 2021\r\nPrecio: alrededor de $187,500 USD";
            costoo = 187000;
            nombreAuto = "Porsche 911 GT3 RS";

            this.Close();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            Carro = this.pictureBox3.Image;
            Autoelegido = "Nombre:Ferrari F8 Tributo\r\nMarca: Ferrari\r\nColor: Rojo corsa\r\nAño: 2022\r\nPrecio: alrededor de $275,000 USD";
            costoo = 275000;
            nombreAuto = "Ferrari F8 Tributo";

            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GaleriaAutos_Load(object sender, EventArgs e)
        {

        }
    }
}
