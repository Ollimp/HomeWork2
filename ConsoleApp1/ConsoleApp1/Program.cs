using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] t = new string[18]{"    A","  B","  C","  D","  E","  F","  G","  S", " 8 ", " 7 ", " 6 ", " 5 ", " 4 ", " 3 ", " 2 ", " 1 ","░░░","▓▓▓" };
            //вывод букв
            for(int i=0;i<8;i++)
            {
                Console.Write(t[i]);
            }
            //вывод чисел и игрового поля
            for (int q = 8; q < 16; q++) {
                Console.WriteLine();
                Console.Write(t[q]);
                for (int y = 0; y < 8; y++)
                {
                        Console.Write((q + y) % 2 == 0 ? t[16] : t[17]);
                }
                Console.Write(t[q]);
            }
            Console.WriteLine();
            //вывод букв
            for (int i = 0; i < 8; i++)
            {
                Console.Write(t[i]);
            }
            // Старый вариант
            //Ожидание ответа пользователя.*/
            Console.ReadKey();
        }
    }
}
