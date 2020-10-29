using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            bool b = false;
            int x;
            int y;
            string[,] mas = { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    Console.Write(mas[i, j]);
            }
            Console.WriteLine();

            while (a == false)
            {
                Console.WriteLine("Ваш ход - строка, столбец:");
                string str = Console.ReadLine();
                y = Convert.ToInt32(str);
                y -= 1;
                if (y > 2)
                {
                    Console.WriteLine("Выход за пределы столбцов");
                    return;
                }
                string sto = Console.ReadLine();
                x = Convert.ToInt32(sto);
                x -= 1;
                if (x > 2)
                {
                    Console.WriteLine("Выход за пределы строк");
                    return;
                }
                mas[y, x] = "0";
                Window(mas);
                Win(mas, b);

                if (a == false)
                {
                    Console.WriteLine("Ход компьютера: ");
                    CMove(mas);
                    Window(mas);
                }
            }
            Console.ReadLine();
        }
        public static void CMove(string[,] mas)
        {
            if (mas[0, 0] != "-" & mas[0, 1] != "-" & mas[0, 0] == mas[0, 1] & mas[0, 2] == "-")
                mas[0, 2] = "X";
            else
            {
                if (mas[0, 1] != "-" & mas[0, 2] != "-" & mas[0, 1] == mas[0, 2] & mas[0, 0] == "-")
                    mas[0, 0] = "X";
                else
                {
                    if (mas[0, 2] != "-" & mas[0, 0] != "-" & mas[0, 2] == mas[0, 0] & mas[0, 1] == "-")
                        mas[0, 1] = "X";
                    else
                    {
                        if (mas[1, 0] != "-" & mas[1, 1] != "-" & mas[1, 0] == mas[1, 1] & mas[1, 2] == "-")
                            mas[1, 2] = "X";
                        else
                        {
                            if (mas[1, 1] != "-" & mas[1, 2] != "-" & mas[1, 1] == mas[1, 2] & mas[1, 0] == "-")
                                mas[1, 0] = "X";
                            else
                            {
                                if (mas[1, 2] != "-" & mas[1, 0] != "-" & mas[1, 2] == mas[1, 0] & mas[1, 1] == "-")
                                    mas[1, 1] = "X";
                                else
                                {
                                    if (mas[2, 0] != "-" & mas[2, 1] != "-" & mas[2, 0] == mas[2, 1] & mas[2, 2] == "-")
                                        mas[2, 2] = "X";
                                    else
                                    {
                                        if (mas[2, 1] != "-" & mas[2, 2] != "-" & mas[2, 1] == mas[2, 2] & mas[2, 0] == "-")
                                            mas[2, 0] = "X";
                                        else
                                        {
                                            if (mas[2, 2] != "-" & mas[2, 0] != "-" & mas[2, 2] == mas[2, 0] & mas[2, 1] == "-")
                                                mas[2, 1] = "X";
                                            else
                                            {
                                                if (mas[0, 0] != "-" & mas[1, 1] != "-" & mas[0, 0] == mas[1, 1] & mas[2, 2] == "-")
                                                    mas[2, 2] = "X";
                                                else
                                                {
                                                    if (mas[1, 1] != "-" & mas[2, 2] != "-" & mas[1, 1] == mas[2, 2] & mas[0, 0] == "-")
                                                        mas[0, 0] = "X";
                                                    else
                                                    {
                                                        if (mas[2, 2] != "-" & mas[0, 0] != "-" & mas[2, 2] == mas[0, 0] & mas[1, 1] == "-")
                                                            mas[1, 1] = "X";
                                                        else
                                                        {
                                                            if (mas[0, 2] != "-" & mas[1, 1] != "-" & mas[0, 2] == mas[1, 1] & mas[2, 0] == "-")
                                                                mas[2, 0] = "X";
                                                            else
                                                            {
                                                                if (mas[1, 1] != "-" & mas[2, 0] != "-" & mas[1, 1] == mas[2, 0] & mas[0, 2] == "-")
                                                                    mas[0, 2] = "X";
                                                                else
                                                                {
                                                                    if (mas[0, 2] != "-" & mas[2, 0] != "-" & mas[0, 2] == mas[2, 0] & mas[1, 1] == "-")
                                                                        mas[1, 1] = "X";
                                                                    else
                                                                    {
                                                                        if (mas[0, 0] != "-" & mas[1, 0] != "-" & mas[0, 0] == mas[1, 0] & mas[2, 0] == "-")
                                                                            mas[2, 0] = "X";
                                                                        else
                                                                        {
                                                                            if (mas[1, 0] != "-" & mas[2, 0] != "-" & mas[1, 0] == mas[2, 0] & mas[0, 0] == "-")
                                                                                mas[0, 0] = "X";
                                                                            else
                                                                            {
                                                                                if (mas[2, 0] != "-" & mas[0, 0] != "-" & mas[2, 0] == mas[0, 0] & mas[1, 0] == "-")
                                                                                    mas[1, 0] = "X";
                                                                                else
                                                                                {
                                                                                    if (mas[0, 1] != "-" & mas[1, 1] != "-" & mas[0, 1] == mas[1, 1] & mas[2, 1] == "-")
                                                                                        mas[2, 1] = "X";
                                                                                    else
                                                                                    {
                                                                                        if (mas[1, 1] != "-" & mas[2, 1] != "-" & mas[1, 1] == mas[2, 1] & mas[0, 1] == "-")
                                                                                            mas[0, 1] = "X";
                                                                                        else
                                                                                        {
                                                                                            if (mas[0, 1] != "-" & mas[2, 1] != "-" & mas[0, 1] == mas[2, 1] & mas[1, 1] == "-")
                                                                                                mas[1, 1] = "X";
                                                                                            else
                                                                                            {
                                                                                                if (mas[0, 2] != "-" & mas[1, 2] != "-" & mas[0, 2] == mas[1, 2] & mas[2, 2] == "-")
                                                                                                    mas[2, 2] = "X";
                                                                                                else
                                                                                                {
                                                                                                    if (mas[1, 2] != "-" & mas[2, 2] != "-" & mas[1, 2] == mas[2, 2] & mas[0, 2] == "-")
                                                                                                        mas[0, 2] = "X";
                                                                                                    else
                                                                                                    {
                                                                                                        if (mas[0, 2] != "-" & mas[2, 2] != "-" & mas[0, 2] == mas[2, 2] & mas[1, 2] == "-")
                                                                                                            mas[1, 2] = "X";
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Random rnd = new Random();
            int st, s;
            bool a = false;
            while (a == false)
            {
                st = rnd.Next(0, 2);
                s = rnd.Next(0, 2);
                if (mas[s, st] != "X" & mas[s, st] != "0")
                {
                    mas[s, st] = "X";
                    a = true;
                }
            }
        }
        public static bool Win(string[,] mas, bool b)
        {
            if (mas[0, 0] != "-" & mas[0, 0] == mas[0, 1] & mas[0, 1] == mas[0, 2])
            {
                if (mas[0, 0] == "0")
                    Console.WriteLine("Вы победили");
                else
                    Console.WriteLine("Вы проиграли");
            }
            else
            {
                if (mas[1, 0] != "-" & mas[1, 0] == mas[1, 1] & mas[1, 1] == mas[1, 2])
                {
                    if (mas[1, 0] == "0")
                        Console.WriteLine("Вы победили");
                    else
                        Console.WriteLine("Вы проиграли");
                }
                else
                {
                    if (mas[2, 0] != "-" & mas[2, 0] == mas[2, 1] & mas[2, 1] == mas[2, 2])
                    {
                        if (mas[2, 0] == "0")
                            Console.WriteLine("Вы победили");
                        else
                            Console.WriteLine("Вы проиграли");
                    }
                    else
                    {
                        if (mas[0, 0] != "-" & mas[0, 0] == mas[1, 0] & mas[1, 0] == mas[2, 0])
                        {
                            if (mas[0, 0] == "0")
                                Console.WriteLine("Вы победили");
                            else
                                Console.WriteLine("Вы проиграли");
                        }
                        else
                        {
                            if (mas[0, 1] != "-" & mas[0, 1] == mas[1, 1] & mas[1, 1] == mas[2, 1])
                            {
                                if (mas[0, 1] == "0")
                                    Console.WriteLine("Вы победили");
                                else
                                    Console.WriteLine("Вы проиграли");
                            }
                            else
                            {
                                if (mas[0, 2] != "-" & mas[0, 2] == mas[1, 2] & mas[1, 2] == mas[2, 2])
                                {
                                    if (mas[0, 2] == "0")
                                        Console.WriteLine("Вы победили");
                                    else
                                        Console.WriteLine("Вы проиграли");
                                }
                                else
                                {
                                    if (mas[1, 1] != "-" & mas[1, 1] == mas[1, 1] & mas[1, 1] == mas[2, 2])
                                    {
                                        if (mas[1, 1] == "0")
                                            Console.WriteLine("Вы победили");
                                        else
                                            Console.WriteLine("Вы проиграли");
                                    }
                                    else
                                    {
                                        if (mas[2, 2] != "-" & mas[0, 2] == mas[1, 1] & mas[1, 1] == mas[2, 0])
                                        {
                                            if (mas[2, 2] == "0")
                                                Console.WriteLine("Вы победили");
                                            else
                                                Console.WriteLine("Вы проиграли");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return b;
        }
        public static void Window(string[,] mas)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    Console.Write(mas[i, j]);
            }
            Console.WriteLine();
        }
    }
}
