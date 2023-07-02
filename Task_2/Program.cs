//Задание 2
//Напишите метод, который проверяет является ли 
//переданное число «палиндромом». Число передаётся в 
//качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
//Палиндром — число, которое читается одинаково как 
//справа налево, так и слева направо. Например:
//1221 — палиндром;
//3443 — палиндром;
//7854 — не палиндром.

namespace Task_2
{
    internal class Program
    {
        static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; ++i)
                if (s[i] != s[s.Length - 1 - i]) return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string num=Console.ReadLine();
            if (IsPalindrome(num))
                Console.WriteLine("Это число - Палиндром");
            else Console.WriteLine("Это число - не Палиндром");
        }
    }
}