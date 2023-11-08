using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Boton_Calculo_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Double IngresoMensual;
            Double porcentaje;
            string porcentaje_string;
            
            while (true)
            {
                
                if (Double.TryParse(Ingreso_Bruto.Text, out IngresoMensual) == false)
                {

                    MessageBox.Show("Ingrese valor correcto try again!");
                    Ingreso_Bruto.Text = "0.0";
                    Ingreso_Bruto.Focus();
                }

                else
                {
                    
                    break;
                }


            }
            if(Ingreso_Bruto.Text != "0.0")
            Ingreso_Neto.Visible = true;
            porcentaje_string = Impuesto.Text;
            porcentaje_string=porcentaje_string.Remove(porcentaje_string.Length - 1,1);
            porcentaje=double.Parse(porcentaje_string)/100;
            double IngresoMensualNeto = IngresoMensual - (IngresoMensual * porcentaje);
            Ingreso_Neto.Text= IngresoMensualNeto.ToString();
            Ingreso_Neto.Text = string.Format("{0:C2}", IngresoMensualNeto);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Hope you aret having fun!");
        }


    }
}
