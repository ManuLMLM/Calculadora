using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double valor1=0;
        private double valor2= 0;
        private double resultado= 0;
        private int operador = 0;
        private int punto = 0;
        
        private void buttonN0_Click(object sender, EventArgs e)
        {           
            if (Pantalla.Text.Substring(0) != "0")
            {

                if (Pantalla.Text.Substring(0) == "0")
                {
                    Pantalla.Text = "0";
                }
                else if(Pantalla.Text!="0" && resultado == 0)
                {
                    Pantalla.Text = Pantalla.Text + "0";
                }
                else if (Pantalla.Text!="0" && resultado!=0)
                {
                    Pantalla.Text = Convert.ToString(resultado)+"0";
                    resultado = 0;
                }              
            }
                    
        }
        private void buttonN1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado == 0)
            {
                Pantalla.Text = "1";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "1";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
            }

        }
        private void buttonN2_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "2";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "2";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
            }
        }
        private void buttonN3_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "3";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "3";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
            }
        }
        private void buttonN4_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "4";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "4";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
            }
        }
        private void buttonN5_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "5";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "5";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
            }
        }
        private void buttonN6_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "6";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "6";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
            }
        }
        private void buttonN7_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "7";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "7";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
            }
        }
        private void buttonN8_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "8";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "8";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
            }
        }
        private void buttonN9_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Substring(0) == "0" && resultado==0)
            {
                Pantalla.Text = "9";
            }
            else if (Pantalla.Text != "0" && resultado != 0)
            {
                Pantalla.Text = Convert.ToString(resultado) + "9";
                resultado = 0;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
            }
        }
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length>=1)
            {

                if (punto==0)
                {
                    Pantalla.Text = Pantalla.Text + ".";
                    punto = 1;
                }
            }  
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "0";valor1 = 0;valor2 = 0;resultado = 0;operador = 0;punto = 0;
            buttonSuma.Enabled = true;
            buttonResta.Enabled = true;
            buttonMultiplicar.Enabled = true;
            buttonDividir.Enabled = true;
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (valor1!=0 && Pantalla.Text!="0")
            {
                valor2 = Convert.ToDouble(Pantalla.Text);
                if (valor1 != 0 && valor2 != 0)
                {
                    switch (operador)
                    {
                        case 1:
                            resultado = valor1 + valor2;
                            Pantalla.Text = Convert.ToString(resultado);
                            operador = 0;
                            valor1 = resultado;
                            
                            break;
                        case 2:
                            resultado = valor1 - valor2;
                            Pantalla.Text = Convert.ToString(resultado);
                            operador = 0;
                            valor1 = resultado;
                            break;
                        case 3:
                            resultado = valor1 * valor2;
                            Pantalla.Text = Convert.ToString(resultado);
                            operador = 0;
                            valor1 = resultado;
                            break;
                        case 4:
                            resultado = valor1 / valor2;
                            Pantalla.Text = Convert.ToString(resultado);
                            operador = 0;
                            valor1 = resultado;
                            break;
                    }
                }
                else
                {
                    Pantalla.Text = Pantalla.Text;
                }
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            buttonResta.Enabled= false;
            buttonMultiplicar.Enabled = false;
            buttonDividir.Enabled = false;
            valor1 = Convert.ToDouble(Pantalla.Text);
            operador = 1;
            Pantalla.Text = "0";
            punto = 0;
            
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            buttonSuma.Enabled = false;
            buttonResta.Enabled = false;
            buttonDividir.Enabled = false;
            valor1 = Convert.ToDouble(Pantalla.Text);
            operador = 3;
            Pantalla.Text = "0";
            punto = 0;
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            buttonResta.Enabled = false;
            buttonSuma.Enabled = false;
            buttonMultiplicar.Enabled = false;
            valor1 = Convert.ToDouble(Pantalla.Text);
            operador = 4;
            Pantalla.Text = "0";
            punto = 0;
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            buttonDividir.Enabled = false;
            buttonMultiplicar.Enabled = false;
            buttonSuma.Enabled = false;
            valor1 = Convert.ToDouble(Pantalla.Text);
            operador = 2;
            Pantalla.Text = "0";
            punto = 0;
        }
    }
}
