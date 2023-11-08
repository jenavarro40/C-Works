using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace estudiodelistbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = "";
            /*foreach (string lbox in Escojer.SelectedItems)
                result = result + " " + lbox;*/
            for (int i = 0; i < Escojer.SelectedItems.Count; i++) { result = result + " " + Escojer.SelectedItems[i].ToString(); }
            Escribirseleccion.Text = result;
            resultado.Text = result;
            if (Escojer.SelectedItems.Contains("Angela"))
            {
                combo1.Items.Clear();

                combo1.Items.Add("Salud");
                combo1.Items.Add("Dinero");
                combo1.Items.Add("Amor");
            }
            else if (Escojer.SelectedItems.Contains("Sara"))
            {
                combo1.Items.Clear();

                combo1.Items.Add("Juego");
                combo1.Items.Add("Colegio");
                combo1.Items.Add("Amor");
            }
            else if (Escojer.SelectedItems.Contains("Carolina"))
            {
                combo1.Items.Clear();

                combo1.Items.Add("Juegos");
                combo1.Items.Add("Trabajo");
                combo1.Items.Add("Amor");
            }
            else
            {
                combo1.Items.Clear();
            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        { 
            if (Escojer.Items.Contains(ingresarnewname.Text.Trim()) || ingresarnewname.Text.Trim() == "")
            {
                MessageBox.Show("Name ya existe o esta vacio try again");
            }
            else
            {
                Escojer.Items.Add(ingresarnewname.Text);
                ingresarnewname.Clear();
            }
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resultado = "";
            for ( int i = 0; i < combo1.Items.Count;i++)
            {
                resultado=resultado+" "+combo1.Items[i];
            }
            textdelcombobox.Text = resultado;
            object valorSeleccionado = combo1.SelectedIndex;
            textcombo1.Text=valorSeleccionado.ToString();

            // Obtener el valor seleccionado como una cadena (si los elementos son de tipo string)
            string valorSeleccionadoString = combo1.SelectedItem as string;
            textcombo2.Text = combo1.SelectedItem as string;

            // Obtener el valor seleccionado utilizando la propiedad SelectedValue (si has asignado valores a los elementos)

            textdelcombobox.Text = resultado;
           
            textcombo3.Text = combo1.Text;

           


        }

        private void nuevo_nombre_2_Click(object sender, EventArgs e)
        {
            
            if(combo1.Items.Contains(ingresarnewname.Text.Trim())|| ingresarnewname.Text.Trim()=="")
            {
                MessageBox.Show("Name ya existe o esta vacio try again");
            }
            else
            {
                {
                    combo1.Items.Add(ingresarnewname.Text);
                    ingresarnewname.Clear();
                }
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            textcombo3.Text = "Corregir";
            textBoxResultado1.Text = "Item1-1";
            textBoxResultado2.Text = "Item1-2";
        }

        private void corregirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textcombo3.Text = "Recordar";
            textBoxResultado1.Text = "Item2-1";
            textBoxResultado2.Text = "Item2-2";
        }

        private void mamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textcombo3.Text = "Bueno";
            textBoxResultado1.Text = "Item3-1";
            textBoxResultado2.Text = "Item3-2";
        }

        private void textBoxResultado1_TextChanged(object sender, EventArgs e)
        {
            Escojer.Items.AddRange(new string[] { "j", "p" });
        }
    }
}
