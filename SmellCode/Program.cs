using System;

namespace SmellCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a;
            a = new int[3, 3];
            int x = 0;
            a[0, 0] = -1;
            a[0, 1] = -1;
            a[0, 2] = -1;
            a[1, 0] = -1;
            a[1, 1] = -1;
            a[1, 2] = -1;
            a[2, 0] = -1;
            a[2, 1] = -1;
            a[2, 2] = -1;
            Console.WriteLine();
            Console.WriteLine("-------------");
            for (int fila = 0; fila < 3; fila++)
            {
                Console.Write("|");
                for (int columna = 0; columna < 3; columna++)
                    Console.Write("   |");
                Console.WriteLine();
                Console.WriteLine("-------------");
            }

            for (int f = 0; f < 3 && x == 0; f++)
            {
                for (int c = 0; c < 3 && x == 0; c++)
                {
                    Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    a[f, c] = int.Parse(linea);
                    Console.WriteLine();
                    if (a[0, 0] == 0 && a[0, 1] == 0 && a[0, 2] == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[1, 0] == 0 && a[1, 1] == 0 && a[1, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[2, 0] == 0 && a[2, 1] == 0 && a[2, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[1, 0] == 0 && a[1, 0] == 0 && a[2, 0] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 1] == 0 && a[1, 1] == 0 && a[2, 1] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 2] == 0 && a[1, 2] == 0 && a[2, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 0] == 0 && a[1, 1] == 0 && a[2, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[2, 0] == 0 && a[1, 1] == 0 && a[0, 2] == 0 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[0, 0] == 1 && a[0, 1] == 1 && a[0, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador X");
                        x = 1;
                    }
                    if (a[1, 0] == 1 && a[1, 1] == 1 && a[1, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[2, 0] == 1 && a[2, 1] == 1 && a[2, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[1, 0] == 1 && a[1, 0] == 1 && a[2, 0] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[0, 1] == 1 && a[1, 1] == 1 && a[2, 1] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[0, 2] == 1 && a[1, 2] == 1 && a[2, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[0, 0] == 1 && a[1, 1] == 1 && a[2, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    if (a[2, 0] == 1 && a[1, 1] == 1 && a[0, 2] == 1 && x == 0)
                    {
                        Console.Write("Gano el jugador O");
                        x = 1;
                    }
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    for (int fila = 0; fila < 3; fila++)
                    {
                        Console.Write("|");
                        for (int columna = 0; columna < 3; columna++)
                            Console.Write(" {0} |", (a[fila, columna] == -1 ? " " : (a[fila, columna]).ToString()) + " ");
                        Console.WriteLine();
                        Console.WriteLine("-------------");
                    }

                }
            }


            if (x == 0)
            {
                Console.WriteLine("Empate");
            }

        }
    }
}
