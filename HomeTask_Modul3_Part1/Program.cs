//Задание 1
//Напишите метод, который отображает квадрат из
//некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.

namespace HomeTask_Modul3_Part1
{
    internal class Program
    {
        public static void Square(int l,char s) 
        {
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (i == 0 || j == 0 || i == l - 1 || j == l - 1)
                    {
                        Console.Write(s);
                    }
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну стороны квадрата: ");
            int l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите символ: ");
            char s= char.Parse(Console.ReadLine());
            Square(l, s);
        }
    }
}