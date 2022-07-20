using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizEmerios
{
    class Program
    {
        static readonly string fileText = @"D:\Personal\Emerios\Files\matriz.txt";
        static void Main(string[] args)
        {
            string[,] Caracteres = new string[4, 4];
            Caracteres[0, 0] = "B";
            Caracteres[0, 1] = "B";
            Caracteres[0, 2] = "D";
            Caracteres[0, 3] = "A";
            //Caracteres[0, 4] = "D";
            //Caracteres[0, 5] = "E";
            //Caracteres[0, 6] = "F";

            Caracteres[1, 0] = "B";
            Caracteres[1, 1] = "X";
            Caracteres[1, 2] = "C";
            Caracteres[1, 3] = "D";
            //Caracteres[1, 4] = "D";
            //Caracteres[1, 5] = "J";
            //Caracteres[1, 6] = "K";

            Caracteres[2, 0] = "A";
            Caracteres[2, 1] = "A";
            Caracteres[2, 2] = "A";
            Caracteres[2, 3] = "A";
            //Caracteres[2, 4] = "D";
            //Caracteres[2, 5] = "D";
            //Caracteres[2, 6] = "3";

            Caracteres[3, 0] = "R";
            Caracteres[3, 1] = "7";
            Caracteres[3, 2] = "O";
            Caracteres[3, 3] = "Ñ";
            //Caracteres[3, 4] = "G";
            //Caracteres[3, 5] = "D";
            //Caracteres[3, 6] = "E";

            /*Caracteres[4, 0] = "W";
            Caracteres[4, 1] = "N";
            Caracteres[4, 2] = "S";
            Caracteres[4, 3] = "P";
            Caracteres[4, 4] = "E";
            Caracteres[4, 5] = "0";
            Caracteres[4, 6] = "D";

            Caracteres[5, 0] = "A";
            Caracteres[5, 1] = "9";
            Caracteres[5, 2] = "C";
            Caracteres[5, 3] = "D";
            Caracteres[5, 4] = "D";
            Caracteres[5, 5] = "E";
            Caracteres[5, 6] = "F";

            Caracteres[6, 0] = "B";
            Caracteres[6, 1] = "X";
            Caracteres[6, 2] = "D";
            Caracteres[6, 3] = "D";
            Caracteres[6, 4] = "D";
            Caracteres[6, 5] = "J";
            Caracteres[6, 6] = "K";*/

            string[,] resultado = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Caracteres[i, j]);
                }
                Console.Write("\n");
            }


            //buscar en horizontal
            var cadena = "";
            var contador = 0;
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                //string a = Convert.ToString(Caracteres[i, 0]);
                //resultado[i, 0] = Caracteres[i, 0];
                for (int j = 0; j < 4; j++)
                {
                    string a = Caracteres[i, j];
                    
                    if (j < 3)
                    {
                        string b = Convert.ToString(Caracteres[i, j + 1]);
                        if (a == b)
                        {
                            resultado[i, j] = b;
                            contador++;
                        }
                    }
                }
                k++;
            }
            Console.Write("Resultado" + "\n");
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                for (int j = 0; j < resultado.GetLength(0); j++)
                {
                    Console.Write(resultado[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
