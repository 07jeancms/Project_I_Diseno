using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace ProyectoIDiseno.View
{
    public partial class FormIngresarCuenta : Form
    {
        public FormIngresarCuenta()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtNombre.Text;
                String tipoCuenta = comboTCuenta.Text;
                float monto = float.Parse(txtMonto.Text);
                int periodo = int.Parse(txtDias.Text);
                String moneda = comboMoneda.Text;
                String respuesta = ControladorViews.creaCuenta(nombre, tipoCuenta, monto, periodo, moneda);
                txtRespuesta.Text = respuesta;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Verifique los datos de entrada!");
            }
        }
    }
}
