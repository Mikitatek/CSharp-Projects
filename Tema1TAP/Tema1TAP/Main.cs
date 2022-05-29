using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tema1TAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Adunare");
            Console.WriteLine("2.Inmultire");
            Console.WriteLine("3.Inmultire cu un scalar");
            Console.WriteLine("4.Exit");
            //Console.WriteLine(args[0]);
            int input = 0;
            while (input <= 0 || input > 4)
            input = GetNumar();
            switch (input)
            {
                case 1:
                        Adunare();
                        break;
                case 2:
                        Inmultire();
                        break;
                case 3:
                        InmultireScalar();
                        break;
                case 4:
                        System.Environment.Exit(0);
                        break;
            }

            int[,] CreazaMatrice()
            {
                Console.WriteLine("Input i:");
                int m = GetNumar();
                Console.WriteLine("Input j:");
                int n = GetNumar();
                int[,] matrice = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("matrice[" + i + "," + j + "]=");
                        matrice[i, j] = GetNumar();
                    }
                    Console.WriteLine("\n");
                }
                return matrice;
            }

            void Adunare()
            {
                Console.WriteLine("Matricea 1:");
                int[,] a = CreazaMatrice();
                Console.WriteLine("Matricea 2:");
                int[,] b = CreazaMatrice();
                Console.WriteLine("Suma Matricelor:");
                if (a.Length == b.Length)
                {
                    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            c[i, j] = a[i, j] + b[i, j];
                            Console.Write(c[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                    Console.WriteLine("Matricile nu sunt egale.");
            }
            
            void Inmultire()
            {
                Console.WriteLine("Matricea 1:");
                int[,] a = CreazaMatrice();
                Console.WriteLine("Matricea 2:");
                int[,] b = CreazaMatrice();
                Console.WriteLine("Produsul matricelor:");
                if (a.GetLength(1) == b.GetLength(0))
                {
                    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < b.GetLength(1); j++)
                        {
                            c[i, j] = 0;
                            for (int k = 0; k < a.GetLength(1); k++)
                            {
                                c[i, j] += a[i, k] * b[k, j];
                            }
                        }
                    }
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        for (int j = 0; j < a.GetLength(1); j++)
                        {
                            Console.Write(c[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
                else 
                Console.WriteLine("Multiplicarea matricelor nu e posibila");
            }

            void InmultireScalar()
            {
                Console.WriteLine("Matricea:");
                int[,] a = CreazaMatrice();
                Console.WriteLine("Numar scalar:");
                int nr = GetNumar();
                Console.WriteLine("Inmultirea matricei cu un scalar:");
                int[,] r = new int[a.GetLength(0), a.GetLength(1)];
                for(int i = 0; i < a.GetLength(0); i++)
                    for(int j = 0; j < a.GetLength(1); j++)
                        r[i, j] = a[i, j]*nr;
                for (int i = 0; i < r.GetLength(0); i++)
                {
                    for (int j = 0; j < r.GetLength(1); j++)
                    {
                        Console.Write(r[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            int GetNumar()
            {
                bool isNumar = false;
                string str = String.Empty;
                while (!isNumar) {
                    str = Console.ReadLine();
                    int numericValue;
                    isNumar = int.TryParse(str, out numericValue);
                }
                int numar = Convert.ToInt32(str);
                if (numar == -1)
                    System.Environment.Exit(0);
                return numar;
            }
        }
    }
}
