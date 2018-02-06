using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrare el formulario actual
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtHoras.Text != "" && txtNombre.Text != "" && txtPaga.Text != "" && txtTasa.Text != "")
            {

                int horastrabajadas = 0;
                float tasaimpuesto = 0, pagoxhora = 0;
                float pagobruto = 0, pagoimpuesto = 0, pagoneto = 0;
                string nombre;
                string salida;


                tasaimpuesto = float.Parse(txtTasa.Text);

                pagoxhora = float.Parse(txtPaga.Text);

                horastrabajadas = int.Parse(txtHoras.Text);

                nombre = txtNombre.Text;

                // Realizar el calculo
                pagobruto = (horastrabajadas * pagoxhora);
                pagoimpuesto = (pagobruto * tasaimpuesto);
                pagoneto = (pagobruto - pagoimpuesto);

                lblResultado.Text = "El empleado " + nombre +
                    " tiene un sueldo bruto de " + pagobruto +
                    " y un pago neto de " + pagoneto;
            }
        }
    }
}
