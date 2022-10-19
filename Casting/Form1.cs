using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExplicita_Click(object sender, EventArgs e)
        {
            if (txtExplicita.Text != "" && txtExplicita.Text.Contains(",") || txtExplicita.Text != "" && txtExplicita.Text.Contains("."))
            {
                // Si se ingresó el decimal separado con un PUNTO
                // Lo reemplazamos por una COMA, para obtener el dato correcto
                if (txtExplicita.Text.Contains("."))
                {
                    txtExplicita.Text = txtExplicita.Text.Replace(".", ",");
                }

                // Obtenemos el dato del campo de texto y se lo informamos al usuario
                double numero = Convert.ToDouble(txtExplicita.Text);
                Type numDoubleType = numero.GetType();
                MessageBox.Show("Número ingresado: " + numero.ToString() + ", tipo de dato: "+ numDoubleType.ToString());


                // Lo convertimos y se lo informamos al usuario
                int numeroConvertido = Convert.ToInt32(numero);
                Type numIntType = numeroConvertido.GetType();
                MessageBox.Show("Número convertido: " + numeroConvertido.ToString() + ", tipo de dato resultante: " + numIntType.ToString() + ". Hay pérdida de información.");

            } else
            {
                MessageBox.Show("Ingresá un número con decimales para realizar la conversión.");
            }
        }

        private void btnImplicita_Click(object sender, EventArgs e)
        {
            if (txtImplicita.Text != "" && !txtImplicita.Text.Contains(",")  && !txtImplicita.Text.Contains("."))
            {
                
                // Obtenemos el dato del campo de texto y se lo informamos al usuario
                int numero = Convert.ToInt32(txtImplicita.Text);
                Type numIntType = numero.GetType();
                MessageBox.Show("Número ingresado: " + numero.ToString() + ", tipo de dato: " + numIntType.ToString());


                // Lo convertimos y se lo informamos al usuario
                double numeroConvertido = numero;
                Type numDoubleType = numeroConvertido.GetType();
                MessageBox.Show("Número convertido: " + numeroConvertido.ToString() + ", tipo de dato resultante: " + numDoubleType.ToString() + ". Observamos que NO hay pérdida de información.");

            }
            else
            {
                MessageBox.Show("Ingresá un número SIN decimales para realizar la conversión.");
            }
        }
    }
}
