using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


/*
 * Задание 2
Динамическая матрица содержит числа - оценки студентов.
Каждая строка соответствует одному студенту.
Найти номер студента (номер строки), у которого максимальный средний балл.
Если таких студентов несколько (баллы равные), вывести номер первого или последнего - на усмотрение разработчика программы.
Количество студентов и оценок вводится с клавиатуры. Количество должно быть положительным числом.
Оценки генерируются случайным образом в диапазоне от 1 до 12 включительно.
Предусмотреть вывод на экран матрицы оценок и найденного номера.
Программа должна содержать комментарии относительно основных логических блоков (пошаговая детализация).
 */

namespace dzCh2
{
    //Класс студентов
      class Student
    {
        public int Students { get; set; }
        public int bols { get; set; }
        public static int[,] Group;
        public int[] sredbol;
        //заполение студентов
        public void RetStudent()
        {
            Random random = new Random();
            Console.WriteLine("Введите кол-во Студентов");
            Math.Abs( Students =Convert.ToInt32( Console.ReadLine()));
            Console.WriteLine("Введите кол-во оценок");
            Math.Abs(bols = Convert.ToInt32(Console.ReadLine()));
            Group = new int[Students,bols];
            sredbol = new int[Students];
            for (int i = 0; i < Students; i++)
            {
                for (int t = 0; t < bols; t++)
                {
                    Group[i, t] = random.Next(1, 13);
                    sredbol[i] += Group[i, t];
                }
                sredbol[i] = sredbol[i] / bols;
            }
        }
        //поиск студентов
        public void Rezult()
        { string[] t = new string[2];
            int H = 0;
            for(int i=0;i<Students;i++)
            {
                if (H < sredbol[i])
                {
                    H = sredbol[i];
                    t[0] = ($"Имя: {i + 1}  Бал: { H }");
                }
                if (H <= sredbol[i])
                {
                    H = sredbol[i];
                    t[1] = ($"Имя: {i + 1}  Бал: { H }");
                    if (t[0] == t[1]) t[1] = ($"Такого студента нет");
                }
             }
            Console.WriteLine($"Самые крутые студениты: {t[0]}| {t[1]}");
        }
        //Вывод студентов
        public void GetInfo()
        {
            for (int i = 0; i < Students; i++)
            {
                Console.WriteLine($"Студент номер: {i+1}");
                for (int t = 0; t < bols; t++)
                {
                    Console.Write($"Балы: {Group[i, t]}|| ");
                }
                Console.WriteLine("");
            }
        }
        //вывод максимальной оценки студента
        public void GetMaxBoll()
        {
            string[] t = new string[Students];
            int H = 0;
           for (int i = 0; i < Students; i++)
           {
                H = 0;
               for (int q = 0; q < bols; q++)
               {
                   if (H < Group[i, q])
                   {
                       H = Group[i, q];
                       t[i] = ($"Имя: {i+1}  Бал: {H}\n");
                   }
               }
           }
           for(int Fq=0;Fq< Students; Fq++) { Console.Write(t[Fq]); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //вызов класа
            Student student = new Student();
            student.RetStudent();
            student.Rezult();
            Console.WriteLine("Вывести весь список студентов ?(1->yes, 2->No) Введите число -:>");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 1)
            {
                student.GetInfo();
            }
            Console.WriteLine("Вывести максимальные балы студентов ?(1->yes, 2->No) Введите число -:>");
            int T = Convert.ToInt32(Console.ReadLine());
            if (T == 1)
            {
                student.GetMaxBoll();
            }
            Console.ReadKey();
        }
    }
}
