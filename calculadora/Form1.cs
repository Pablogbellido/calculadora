using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void buttonSuma_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxOperador1.Text != "" || textBoxOperador2.Text != "")
            {
                int operador1 = Convert.ToInt32(textBoxOperador1.Text);
                int operador2 = Convert.ToInt32(textBoxOperador2.Text);

                int resultado = operador1 + operador2;

                textBoxResultado.Text = Convert.ToString(resultado);
            }


        }

        private void buttonResta_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxOperador1.Text != "" || textBoxOperador2.Text != "")
            {
                int operador1 = Convert.ToInt32(textBoxOperador1.Text);
                int operador2 = Convert.ToInt32(textBoxOperador2.Text);
                int resultado = operador1 - operador2;

                textBoxResultado.Text = Convert.ToString(resultado);
            }
        }
        private void buttonMultiplica_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxOperador1.Text != "" || textBoxOperador2.Text != "")
            {
                int operador1 = Convert.ToInt32(textBoxOperador1.Text);
                int operador2 = Convert.ToInt32(textBoxOperador2.Text);
                int resultado = operador1 * operador2;

                textBoxResultado.Text = Convert.ToString(resultado);
            }
        }
        private void buttonDivision_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxOperador1.Text != "" || textBoxOperador2.Text != "")
            {
                int operador1 = Convert.ToInt32(textBoxOperador1.Text);
                int operador2 = Convert.ToInt32(textBoxOperador2.Text);
                if (operador2 != 0)
                {

                    int resultado = operador1 / operador2;
                    textBoxResultado.Text = Convert.ToString(resultado);

                }
                else
                {
                    textBoxResultado.Text = "ERROR";
                }
            }
                
            
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOperador1.Text = "";
            textBoxOperador2.Text = "";
            textBoxResultado.Text = "";
        }
    }
}
