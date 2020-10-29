using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КрестикиНолики
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
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

            while (count == 0)
            {
                Console.WriteLine("Ваш ход(два числа через Enter - строка, столбец):");
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
                Ekran(mas);
                Pobeda(mas, count);

                if (count == 0)
                {
                    Console.WriteLine("Ход компьютера: ");
                    kompP(mas);
                    Ekran(mas);
                    Proigrish(mas, count);
                }
            }
            Console.ReadLine();
        }
        public static void kompP(string[,] mas)
        {
            if (mas[0, 0] != "-" & mas[0, 1] != "-" & mas[0, 0] == mas[0, 1] & mas[0, 2] == "-")
            {
                mas[0, 2] = "X";
                return;
            }
            if (mas[0, 1] != "-" & mas[0, 2] != "-" & mas[0, 1] == mas[0, 2] & mas[0, 0] == "-")
            {
                mas[0, 0] = "X";
                return;
            }
            if (mas[0, 2] != "-" & mas[0, 0] != "-" & mas[0, 2] == mas[0, 0] & mas[0, 1] == "-")
            {
                mas[0, 1] = "X";
                return;
            }
            if (mas[1, 0] != "-" & mas[1, 1] != "-" & mas[1, 0] == mas[1, 1] & mas[1, 2] == "-")
            {
                mas[1, 2] = "X";
                return;
            }
            if (mas[1, 1] != "-" & mas[1, 2] != "-" & mas[1, 1] == mas[1, 2] & mas[1, 0] == "-")
            {
                mas[1, 0] = "X";
                return;
            }
            if (mas[1, 2] != "-" & mas[1, 0] != "-" & mas[1, 2] == mas[1, 0] & mas[1, 1] == "-")
            {
                mas[1, 1] = "X";
                return;
            }
            if (mas[2, 0] != "-" & mas[2, 1] != "-" & mas[2, 0] == mas[2, 1] & mas[2, 2] == "-")
            {
                mas[2, 2] = "X";
                return;
            }
            if (mas[2, 1] != "-" & mas[2, 2] != "-" & mas[2, 1] == mas[2, 2] & mas[2, 0] == "-")
            {
                mas[2, 0] = "X";
                return;
            }
            if (mas[2, 2] != "-" & mas[2, 0] != "-" & mas[2, 2] == mas[2, 0] & mas[2, 1] == "-")
            {
                mas[2, 1] = "X";
                return;
            }
            if (mas[0, 0] != "-" & mas[1, 1] != "-" & mas[0, 0] == mas[1, 1] & mas[2, 2] == "-")
            {
                mas[2, 2] = "X";
                return;
            }
            if (mas[1, 1] != "-" & mas[2, 2] != "-" & mas[1, 1] == mas[2, 2] & mas[0, 0] == "-")
            {
                mas[0, 0] = "X";
                return;
            }
            if (mas[2, 2] != "-" & mas[0, 0] != "-" & mas[2, 2] == mas[0, 0] & mas[1, 1] == "-")
            {
                mas[1, 1] = "X";
                return;
            }
            if (mas[0, 2] != "-" & mas[1, 1] != "-" & mas[0, 2] == mas[1, 1] & mas[2, 0] == "-")
            {
                mas[2, 0] = "X";
                return;
            }
            if (mas[1, 1] != "-" & mas[2, 0] != "-" & mas[1, 1] == mas[2, 0] & mas[0, 2] == "-")
            {
                mas[0, 2] = "X";
                return;
            }
            if (mas[0, 2] != "-" & mas[2, 0] != "-" & mas[0, 2] == mas[2, 0] & mas[1, 1] == "-")
            {
                mas[1, 1] = "X";
                return;
            }
            if (mas[0, 0] != "-" & mas[1, 0] != "-" & mas[0, 0] == mas[1, 0] & mas[2, 0] == "-")
            {
                mas[2, 0] = "X";
                return;
            }
            if (mas[1, 0] != "-" & mas[2, 0] != "-" & mas[1, 0] == mas[2, 0] & mas[0, 0] == "-")
            {
                mas[0, 0] = "X";
                return;
            }
            if (mas[2, 0] != "-" & mas[0, 0] != "-" & mas[2, 0] == mas[0, 0] & mas[1, 0] == "-")
            {
                mas[1, 0] = "X";
                return;
            }
            if (mas[0, 1] != "-" & mas[1, 1] != "-" & mas[0, 1] == mas[1, 1] & mas[2, 1] == "-")
            {
                mas[2, 1] = "X";
                return;
            }
            if (mas[1, 1] != "-" & mas[2, 1] != "-" & mas[1, 1] == mas[2, 1] & mas[0, 1] == "-")
            {
                mas[0, 1] = "X";
                return;
            }
            if (mas[0, 1] != "-" & mas[2, 1] != "-" & mas[0, 1] == mas[2, 1] & mas[1, 1] == "-")
            {
                mas[1, 1] = "X";
                return;
            }
            if (mas[0, 2] != "-" & mas[1, 2] != "-" & mas[0, 2] == mas[1, 2] & mas[2, 2] == "-")
            {
                mas[2, 2] = "X";
                return;
            }
            if (mas[1, 2] != "-" & mas[2, 2] != "-" & mas[1, 2] == mas[2, 2] & mas[0, 2] == "-")
            {
                mas[0, 2] = "X";
                return;
            }
            if (mas[0, 2] != "-" & mas[2, 2] != "-" & mas[0, 2] == mas[2, 2] & mas[1, 2] == "-")
            {
                mas[1, 2] = "X";
                return;
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
            return;
        }
        public static void Pobeda(string[,] mas, int count)
        {
            if (mas[0, 0] == "0" & mas[0, 0] == mas[0, 1] & mas[0, 1] == mas[0, 2])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[1, 0] == "0" & mas[1, 0] == mas[1, 1] & mas[1, 1] == mas[1, 2])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[2, 0] == "0" & mas[2, 0] == mas[2, 1] & mas[2, 1] == mas[2, 2])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[0, 0] == "0" & mas[0, 0] == mas[1, 0] & mas[1, 0] == mas[2, 0])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[0, 1] == "0" & mas[0, 1] == mas[1, 1] & mas[1, 1] == mas[2, 1])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[0, 2] == "0" & mas[0, 2] == mas[1, 2] & mas[1, 2] == mas[2, 2])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[1, 1] == "0" & mas[1, 1] == mas[1, 1] & mas[1, 1] == mas[2, 2])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            if (mas[2, 2] == "0" & mas[0, 2] == mas[1, 1] & mas[1, 1] == mas[2, 0])
            {
                Console.WriteLine("Вы победили");
                count++;
                return;
            }
            return;
        }
        public static void Proigrish(string[,] mas, int count)
        {
            if (mas[0, 0] == "X" & mas[0, 0] == mas[0, 1] & mas[0, 1] == mas[0, 2])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[1, 0] == "X" & mas[1, 0] == mas[1, 1] & mas[1, 1] == mas[1, 2])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[2, 0] == "X" & mas[2, 0] == mas[2, 1] & mas[2, 1] == mas[2, 2])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[0, 0] == "X" & mas[0, 0] == mas[1, 0] & mas[1, 0] == mas[2, 0])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[0, 1] == "X" & mas[0, 1] == mas[1, 1] & mas[1, 1] == mas[2, 1])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[0, 2] == "X" & mas[0, 2] == mas[1, 2] & mas[1, 2] == mas[2, 2])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[0, 0] == "X" & mas[0, 0] == mas[1, 1] & mas[1, 1] == mas[2, 2])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            if (mas[2, 0] == "X" & mas[0, 2] == mas[1, 1] & mas[1, 1] == mas[2, 0])
            {
                Console.WriteLine("Вы проиграли");
                count++;
                return;
            }
            return;
        }
        public static void Ekran(string[,] mas)
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
