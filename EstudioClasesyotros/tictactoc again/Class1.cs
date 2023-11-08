using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tictactoc_again
{
    internal class triqui_juego
    {
        int jugada = 1;
        
        int jugada_Count=0;
        public triqui_juego()
        {
            jugada_Count = 0;
        }

        public int turno()
        {
            jugada++;
            if (jugada == 2) { jugada = 0; }
            return jugada;
        }

        public string Validar_Victoria(int[,] juego, out int win)
        {
            int ValidarX = 0;
            int ValidarY = 0;
            String Ganar = "";
            win = 0;
            int sumay = 0;

            for (int i = 0; i < 9; i += 3)
            {
                ValidarX = 0;
                ValidarY = 0;
                for (int j = 0; j < 3; j++)
                {
                    ValidarX = ValidarX + juego[0, j + i];
                    ValidarY = ValidarY + juego[1, j + i];
                }
                if (ValidarX == 3) { Ganar = "Win Player 1"; win = 1; }
                if (ValidarY == 3) { Ganar = "Win Player 2"; win = 1; }

            }



            for (int i = 0; i < 3; i++)
            {
                ValidarX = 0;
                ValidarY = 0;
                for (int j = 0; j < 9; j += 3)
                {
                    ValidarX = ValidarX + juego[0, j + i];
                    ValidarY = ValidarY + juego[1, j + i];
                }
                if (ValidarX == 3) { Ganar = "Win Player 1"; win = 1; }
                if (ValidarY == 3) { Ganar = "Win Player 2"; win = 1; }

            }

            ValidarX = 0;
            ValidarY = 0;

            for (int i = 0; i < 9; i += 4)
            {
                ValidarX = ValidarX + juego[0, i];
                ValidarY = ValidarY + juego[1, i];
            }
            if (ValidarX == 3) { Ganar = "Win Player 1"; win = 1; }
            if (ValidarY == 3) { Ganar = "Win Player 2"; win = 1; }
            ValidarX = 0;
            ValidarY = 0;

            for (int i = 6; i > 0; i -= 2)
            {
                ValidarX = ValidarX + juego[0, i];
                ValidarY = ValidarY + juego[1, i];
            }
            if (ValidarX == 3) { Ganar = "Win Player 1"; win = 1; }
            if (ValidarY == 3) { Ganar = "Win Player 2"; win = 1; }
            return (Ganar);

        }

        public int contador_jugadas(int jugada)
        {
            jugada_Count= jugada;
            jugada_Count++;
            if (jugada_Count == 9) { jugada_Count = 0; }
            return jugada_Count;
            
        }
        public void clean(triqui form)
        {
            form.textBox1.Visible = true;
            form.textBox2.Visible = true;
            form.textBox3.Visible = true;
            form.textBox4.Visible = true;
            form.textBox5.Visible = true;
            form.textBox6.Visible = true;
            form.textBox7.Visible = true;
            form.textBox8.Visible = true;
            form.textBox9.Visible = true;
        }

        
    }
}
