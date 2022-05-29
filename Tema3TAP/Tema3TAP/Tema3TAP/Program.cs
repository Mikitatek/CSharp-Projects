using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            startloop: while (true)
            {
                int input_2 = 0;
                Console.WriteLine("\nIntroduceti actiunea de efectuat");
                Console.WriteLine("1 pentru Adaugare");
                Console.WriteLine("2 pentru Scadere");
                Console.WriteLine("3 pentru inmultire");
                Console.WriteLine("4 pentru Diviziune");
                Console.WriteLine("5 pentru a reseta rezultatul (Rezultat curent = " + result + ")");
                Console.WriteLine("-1 pentru a iesi din aplicatie \n");
                int action = Convert.ToInt32(Console.ReadLine());

                if(action == -1)
                {
                    System.Environment.Exit(1);
                } else
                if(action == 5)
                {
                    result = 0;
                    goto startloop;
                }
                    

                Console.WriteLine("Scrieti primul numar");
                int input_1 = Convert.ToInt32(Console.ReadLine());
                if (result == 0)
                {
                    Console.WriteLine("Scrieti al doilea numar");
                    input_2 = Convert.ToInt32(Console.ReadLine());
                }

                switch (action)
                {
                    case 1:
                        {
                            if (result == 0)
                                result = CalcOperations.Addition(input_1, input_2);
                            else
                                result = CalcOperations.Addition(result, input_1);
                            break;
                        }
                    case 2:
                        {
                            if (result == 0)
                                result = CalcOperations.Subtraction(input_1, input_2);
                            else
                                result = CalcOperations.Subtraction(result, input_1);
                            break;
                        }
                    case 3:
                        {
                            if (result == 0)
                                result = CalcOperations.Multiplication(input_1, input_2);
                            else
                                result = CalcOperations.Multiplication(result, input_1);
                            break;
                        }
                    case 4:
                        {
                            if (result == 0)
                                result = CalcOperations.Division(input_1, input_2);
                            else
                                result = CalcOperations.Division(result, input_1);
                            break;
                        }
                    default:
                        Console.WriteLine("Actiune gresita!! incearca din nou");
                        break;
                }
                Console.WriteLine("Rezultatul este: {0}\n", result);
            }
        }

        class CalcOperations
        {
            //Addition  
            public static float Addition(float input_1, float input_2)
            {
                float result = input_1 + input_2;
                return result;
            }
            //Substraction  
            public static float Subtraction(float input_1, float input_2)
            {
                float result = input_1 - input_2;
                return result;
            }
            //Multiplication  
            public static float Multiplication(float input_1, float input_2)
            {
                float result = input_1 * input_2;
                return result;
            }
            //Division  
            public static float Division(float input_1, float input_2)
            {
                float result = input_1 / input_2;
                return result;
            }
        }
    }
}