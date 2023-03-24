using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static int Add(int A, int B)
        {
            return A + B;
        }
        static void Main(string[] args)
        {
            int res = 0;
            int exit = -1;
            Console.WriteLine("Введите число A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int B = Convert.ToInt32(Console.ReadLine());
            while (exit != 0)
            {
                Console.WriteLine("1 + ) 2 - ) 3 * ) 4 / )");
                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            res = Add(A,B);
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;

                        }

                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введите правильный пункт меню");
                            break;
                        }
                }

            }
        }
    }
}