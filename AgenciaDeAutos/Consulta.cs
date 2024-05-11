using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

using LibreriaAutos;

namespace AgenciaDeAutos
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        public string marca = "";
        public string fechainicio = "";
        public string fechaentrega = "";
        public string nombre = "";
        public string apellido = "";
        public string telefono = "";
        public string domicilio = "";
        public int precio = 0;

        //Variables que se usaran para guardar la informacion de la base de datos
        public string Marca = "";
        public string Fechainicio = "";
        public string Fechaentrega = "";
        public string Nombre = "";
        public string Apellido = "";
        public string Telefono = "";
        public string Domicilio = "";
        public int Precio = 0;

        public bool SiEsta = false;


        //metodo en el cual se buscaran los datos y me los traera de la base de datos, si existen, si no, no.
        private void btnBuscarDatos_Click(object sender, EventArgs e)
        {

            Class1 class1 = new Class1();
            

            //llama al metodo que buscara en la base de datos, si encuentra algo lo regresara para guardarlo en unas variables
            if (class1.BuscarFolio(tbConsultarFolio.Text, out marca, out fechainicio, out fechaentrega, out nombre, out apellido, out telefono, out domicilio, out precio))
            {
                Marca = marca;
                Fechainicio = fechainicio;
                Fechaentrega = fechaentrega;
                Nombre = nombre;
                Apellido = apellido;
                Telefono = telefono;
                Domicilio = domicilio;
                Precio = precio;

                SiEsta = true;
                MessageBox.Show("El folio se encontro");

                Consulta cerrar = new Consulta();
                cerrar.Close();

                

            }
            else
            {
                MessageBox.Show("El folio no existe en la base de datos");
                
            }
        }

        //Se encarga de poner los datos en los textBox

        private void Consulta_FormClosing(object sender, FormClosingEventArgs e)
        {

            
            if (SiEsta == true)
            {
                DialogResult resultado = MessageBox.Show("¿Deseas pegar la informacion?", "Confirmación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    menuPrincipal Datos = new menuPrincipal();
                    Datos.comboBox1.Text = Marca;
                    Datos.dateTimePicker1.Text = Fechainicio;
                    Datos.dateTimePicker2.Text = Fechaentrega;
                    Datos.tbNombre.Text = Nombre;
                    Datos.tbApellido.Text = Apellido;
                    Datos.tbTelefono.Text = Telefono;
                    Datos.tbDomicilio.Text = Domicilio;
                    Datos.monto.Text = Precio.ToString();

                    this.Hide();
                    Datos.ShowDialog();
                }
                else
                {
                    menuPrincipal Datos = new menuPrincipal();
                    this.Hide();
                    Datos.ShowDialog();
                }
            }
            else
            {
                menuPrincipal Datos = new menuPrincipal();
                this.Hide();
                Datos.ShowDialog();
            }



        }
    }
}
