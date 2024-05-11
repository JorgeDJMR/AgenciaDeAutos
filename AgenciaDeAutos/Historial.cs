using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreriaAutos;
using Raven.Database.Util;

namespace AgenciaDeAutos
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }
        //Muestra los datos de la tabla en el dtgv

        Class1 dtgvMostrar = new Class1(); 
        private void Historial_Load(object sender, EventArgs e)
        {
            //carga los datos
            DataTable dataTable = dtgvMostrar.ObtenerTabla();
            dtgvHistorial.DataSource = dataTable;

            Class1 class1 = new Class1();
            //dinero
            double DineroTotal = class1.ObtenerElTotalDelCosto();
            tbGanancias.Text = Convert.ToString(DineroTotal);

            //foreach (DataRow dr in dataTable.Rows)
            //{
            //    dtgvHistorial.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8]);
            //}


        }

        private void dtgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //El boton de los filtros
        private void btFiltro_Click(object sender, EventArgs e)
        {
            bool Entra = true;

            if(cbCarro.Text != "")
            {
                try
                {
                    // Comprobar si hay algún elemento seleccionado en el ComboBox
                    if (cbCarro.SelectedItem != null)
                    {
                        // Obtener el nombre del carro seleccionado en el ComboBox
                        string nombreCarro = cbCarro.SelectedItem.ToString();

                        // Crear una instancia de la clase MiClase
                        Class1 miClase = new Class1();

                        // Llamar al método FiltrarPorNombreCarro y asignar el resultado a la propiedad DataSource del DataGridView
                        dtgvHistorial.DataSource = miClase.FiltrarPorNombreCarro(nombreCarro);


                        // Actualizar la vista del DataGridView
                        dtgvHistorial.Refresh();

                        //Actualiza precio
                        double DineroTotal = miClase.ObtenerElTotalDelCosto();
                        tbGanancias.Text = Convert.ToString(DineroTotal);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un carro.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
                






            }
            else
            {
                DateTime fechaInicio = fechaInicial.Value;
                DateTime fechaFin = fechaFinal.Value;
                Class1 class1 = new Class1();
                DataTable rentasFiltradas = Class1.FiltrarPorFechas(fechaInicio, fechaFin);
                

                dtgvHistorial.DataSource = rentasFiltradas;
                //Actualiza precio
                double DineroTotal = class1.ObtenerElTotalDelCosto();
                tbGanancias.Text = Convert.ToString(DineroTotal);
            }
            






        }

        private void FiltrarTodo_Click(object sender, EventArgs e)
        {
            //Hace los 2
            try
            {
                // Obtener los valores seleccionados en los filtros
                string nombreCarro = cbCarro.SelectedItem?.ToString();
                DateTime fechaInicio = fechaInicial.Value;
                DateTime fechaFin = fechaFinal.Value;

                // Crear una instancia de la clase Class1 de la DLL
                Class1 miClase = new Class1();

                // Llamar al método FiltrarPorFechaYNombreCarro y asignar el resultado a la propiedad DataSource del DataGridView
                DataTable rentasFiltradas = Class1.FiltrarPorFechaYNombreCarro(fechaInicio, fechaFin, nombreCarro);
                dtgvHistorial.DataSource = rentasFiltradas;



                // Actualizar la vista del DataGridView
                dtgvHistorial.Refresh();

                //Actualiza precio

                double DineroTotal = miClase.ObtenerElTotalDelCosto();
                tbGanancias.Text = Convert.ToString(DineroTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, faltan parametros");
            }
        }





        //Borran la fila que elegiste
        int filaSeleccionada = -1; // Inicialmente no hay ninguna fila seleccionada
        private void btEliminar_Click(object sender, EventArgs e)
        {

            Class1 miClase = new Class1();
            if (filaSeleccionada >= 0) // Verifica que se haya seleccionado una fila válida
            {
                string user = dtgvHistorial.Rows[filaSeleccionada].Cells["Folio"].Value.ToString(); // Obtiene el valor de la celda correspondiente al campo que identifica cada fila
                if (miClase.DeleteDatoss(int.Parse(user))) // Llama al método DeleteDatos() con el valor obtenido
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que deceas eliminar la informacion?", "Confirmación", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        //Actualiza el precio
                        double DineroTotal = miClase.ObtenerElTotalDelCosto();
                        tbGanancias.Text = Convert.ToString(DineroTotal);

                        dtgvHistorial.Rows.RemoveAt(filaSeleccionada); // Elimina la fila seleccionada del DataGridView
                        MessageBox.Show("Datos eliminados correctamente.");
                    }

                }
                else
                {
                    MessageBox.Show("Error al eliminar los datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }
        private void dtgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que se haya seleccionado una fila válida
            {
                filaSeleccionada = e.RowIndex; // Actualiza la variable global con el índice de la fila seleccionada
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            menuPrincipal menuPrincipal = new menuPrincipal();
            this.Hide();
            menuPrincipal.ShowDialog();
        }

        private void btRecargarDTGV_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dtgvMostrar.ObtenerTabla();
            dtgvHistorial.DataSource = dataTable;
        }


    }
}
