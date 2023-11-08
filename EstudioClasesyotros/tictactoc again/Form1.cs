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

namespace tictactoc_again
{
    public partial class triqui : Form
    {
        triqui_juego triqui_j=new triqui_juego();
        int[,] juego = new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        int win;
        int turno_juagada = 0;
        

        public triqui()
        {
            InitializeComponent();
            
        }

        private void pos1_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            
            if(turno_triqui == 0) 
            { 
                juego[0, 0] = 1;
                textBox1.Visible = true;
                textBox1.Text = "X";
                pos1.Visible = false;
            }
            else
            {
                juego[1, 0] = 1;
                textBox1.Visible = true;
                textBox1.Text = "0";
                pos1.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win==1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible= true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }


        }
        private void pos2_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 1] = 1;
                textBox2.Visible = true;
                textBox2.Text = "X";
                pos2.Visible = false;
            }
            else
            {
                juego[1, 1] = 1;
                textBox2.Visible = true;
                textBox2.Text = "0";
                pos2.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }


        }

        private void pos3_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 2] = 1;
                textBox3.Visible = true;
                textBox3.Text = "X";
                pos3.Visible = false;
            }
            else
            {
                juego[1, 2] = 1;
                textBox3.Visible = true;
                textBox3.Text = "0";
                pos3.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }


        }
        private void pos4_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 3] = 1;
                textBox4.Visible = true;
                textBox4.Text = "X";
                pos4.Visible = false;
            }
            else
            {
                juego[1, 3] = 1;
                textBox4.Visible = true;
                textBox4.Text = "0";
                pos4.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }


        }
        private void pos5_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 4] = 1;
                textBox5.Visible = true;
                textBox5.Text = "X";
                pos5.Visible = false;
            }
            else
            {
                juego[1, 4] = 1;
                textBox5.Visible = true;
                textBox5.Text = "0";
                pos5.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }


        }
        private void pos6_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 5] = 1;
                textBox6.Visible = true;
                textBox6.Text = "X";
                pos6.Visible = false;
            }
            else
            {
                juego[1, 5] = 1;
                textBox6.Visible = true;
                textBox6.Text = "0";
                pos6.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }

        }
        private void pos7_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 6] = 1;
                textBox7.Visible = true;
                textBox7.Text = "X";
                pos7.Visible = false;
            }
            else
            {
                juego[1, 6] = 1;
                textBox7.Visible = true;
                textBox7.Text = "0";
                pos7.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
            }

        }
        private void pos8_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 7] = 1;
                textBox8.Visible = true;
                textBox8.Text = "X";
                pos8.Visible = false;
            }
            else
            {
                juego[1, 7] = 1;
                textBox8.Visible = true;
                textBox8.Text = "0";
                pos8.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win != 1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }

        }
        private void pos9_Click(object sender, EventArgs e)
        {

            int turno_triqui = triqui_j.turno();
            if (turno_triqui == 0)
            {
                juego[0, 8] = 1;
                textBox9.Visible = true;
                textBox9.Text = "X";
                pos9.Visible = false;
            }
            else
            {
                juego[1, 8] = 1;
                textBox9.Visible = true;
                textBox9.Text = "0";
                pos9.Visible = false;
            }
            string ganar = triqui_j.Validar_Victoria(juego, out win);
            if (win == 1)
            {
                textwin.Visible = true;
                textwin.Text = ganar;
                triqui_j.clean(this);
                Clean.Visible = true;

            }
            turno_juagada=triqui_j.contador_jugadas(turno_juagada);
            if (turno_juagada == 0 & win!=1)
            {
                textwin.Visible = true;
                textwin.Text = "Nadie Gana";
                Clean.Visible = true;
            }

        }









        private void triqui_Load(object sender, EventArgs e)
        {
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            textwin.Visible = false;
            textwin.Text = " ";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            pos1.Visible = true;
            pos2.Visible = true;
            pos3.Visible = true;
            pos4.Visible = true;
            pos5.Visible = true;
            pos6.Visible = true;
            pos7.Visible = true;
            pos8.Visible = true;
            pos9.Visible = true;
            triqui_juego triqui_j = new triqui_juego();
            juego =new int[,] { { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            turno_juagada=triqui_j.contador_jugadas(-1);
            win = 0;
            triqui_j.Validar_Victoria(juego, out win);   
            
            

        }
    }
   
}
