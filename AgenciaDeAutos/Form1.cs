using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaAutos;

namespace AgenciaDeAutos
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
            Thread hilo = new Thread(new ThreadStart(this.ActualizarReloj));
            hilo.Start();

        }


        //public ComboBox tbAuto { get { return this.comboBox1; } }
        //public DateTimePicker tbFechaInicio { get { return this.dateTimePicker1; } }
        //public DateTimePicker tbFechaEntrega { get { return this.dateTimePicker2; } }
        //public TextBox txbNombre { get { return this.tbNombre; } }
        //public TextBox txbApellido { get { return this.tbApellido; } }
        //public TextBox txbTelefono { get { return this.tbTelefono; } }
        //public TextBox txbDomicilio { get { return this.tbDomicilio; } }
        //public TextBox txbPrecio { get { return this.monto; } }

        private void ActualizarReloj()
        {
            while (true)
            {
                // Redibujamos el reloj cada segundo
                pictureBox1.Invalidate();
                Thread.Sleep(1000);
            }
        }
        double costoauto = 0;

        private void comboBox1_Click(object sender, EventArgs e)
        {
            GaleriaAutos formulario2 = new GaleriaAutos();

            formulario2.ShowDialog();
            lbDatosAuto.Text = formulario2.Autoelegido;
            pictureBox2.Image = formulario2.Carro;
            costoauto = formulario2.costoo;
            comboBox1.Text = formulario2.nombreAuto;


        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centroX = pictureBox1.Width / 2;
            int centroY = pictureBox1.Height / 2;
            int largoManecillaHoras = 25;
            int largoManecillaMinutos = 42;
            int largoManecillaSegundos = 50;

            // Obtenemos la hora actual
           
            DateTime horaActual = DateTime.Now;

            //Se calcula el ángulo en grados para la manecilla de las horas utilizando el operador de módulo para calcular el valor
            //de la hora en formato de 12 horas (en lugar de 24 horas) y se multiplica por 30 (360/12) para convertir la hora a un
            //ángulo. También se divide el valor de los minutos por 2, ya que la manecilla de las horas se mueve gradualmente a lo
            //largo de la hora actual en función de los minutos transcurridos. Se convierte el ángulo en grados a radianes.
            // Dibujamos la manecilla de las horas
            int anguloHoras = (horaActual.Hour % 12) * 30 + horaActual.Minute / 2;
            double radianesHoras = anguloHoras * Math.PI / 180;
            int xHoras = centroX + (int)(largoManecillaHoras * Math.Sin(radianesHoras));
            int yHoras = centroY - (int)(largoManecillaHoras * Math.Cos(radianesHoras));
            g.DrawLine(Pens.Black, centroX, centroY, xHoras, yHoras);

            // Dibujamos la manecilla de los minutos
            int anguloMinutos = horaActual.Minute * 6;
            double radianesMinutos = anguloMinutos * Math.PI / 180;
            int xMinutos = centroX + (int)(largoManecillaMinutos * Math.Sin(radianesMinutos));
            int yMinutos = centroY - (int)(largoManecillaMinutos * Math.Cos(radianesMinutos));
            g.DrawLine(Pens.Black, centroX, centroY, xMinutos, yMinutos);

            // Dibujamos la manecilla de los segundos
            int anguloSegundos = horaActual.Second * 6;
            double radianesSegundos = anguloSegundos * Math.PI / 180;
            int xSegundos = centroX + (int)(largoManecillaSegundos * Math.Sin(radianesSegundos));
            int ySegundos = centroY - (int)(largoManecillaSegundos * Math.Cos(radianesSegundos));
            g.DrawLine(Pens.Red, centroX, centroY, xSegundos, ySegundos);
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permitir caracteres que no sean números
            }
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dateTimePicker1.Value;
            DateTime entrega = dateTimePicker2.Value;
            int diasRenta = (int)(entrega - inicio).TotalDays + 1;

            monto.Text = Convert.ToString(costoauto * diasRenta);
            double costoDiario = 0;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dateTimePicker1.Value;
            DateTime entrega = dateTimePicker2.Value;
            int diasRenta = (int)(entrega - inicio).TotalDays + 1;

            monto.Text = Convert.ToString(costoauto * diasRenta);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                MessageBox.Show("falto llenar el nombre", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbTelefono.Text))
            {
                MessageBox.Show("falto llenar el telefono", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(tbDomicilio.Text))
            {
                MessageBox.Show("Falto llenar el domicilio", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(tbApellido.Text))
            {
                MessageBox.Show("Falto llenar el apellido", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Class1 Lib = new Class1();
                Lib.AbrirConexion();
                
                if (Lib.InsertarDatos( comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, tbNombre.Text, tbApellido.Text, tbTelefono.Text, tbDomicilio.Text, int.Parse(monto.Text)))
                {
                   
                    MessageBox.Show("Se a guardado correctamente");
                }
               




            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // No permitir caracteres que no sean números
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsNumber(e.KeyChar))
            {
                e.Handled = true; // No permitir caracteres que no sean números
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Class1 Lib2 = new Class1();
            Lib2.AbrirConexion();

            Historial abrir = new Historial();
            this.Hide();
            abrir.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            Class1 Lib2 = new Class1();
            Lib2.AbrirConexion();


            Consulta abrir = new Consulta();
            this.Hide();
            abrir.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Class1 Lib = new Class1();
            try
            {
                Lib.ModificarDatos(int.Parse(textBox1.Text), comboBox1.Text, dateTimePicker1.Text, dateTimePicker2.Text, tbNombre.Text, tbApellido.Text, tbTelefono.Text, tbDomicilio.Text, int.Parse(monto.Text));
                MessageBox.Show("Modificado Correctamente :3");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero busca el carro que deceas modificar o coloca su folio");
              
            }
            
        }
    }
}
