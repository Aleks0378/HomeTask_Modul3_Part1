using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Journal
    {
        public string name;
        public int year;
        public string comment;
        public string phone;
        public string email;
        public Journal() { }
        public Journal(string name, int year, string comment, string phone, string email)
        {
            this.name = name;
            this.year = year;
            this.comment = comment;
            this.phone = phone;
            this.email = email;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                name = value;
            }
        }
        public int Year { get { return year; } set {  year = value; } }
        public string Comment 
        { 
            get { return comment; }
            set 
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                comment = value; 
            }
        }
        public string Phone
        {
            get { return phone; }
            set 
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set 
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                email = value;
            }
        }
        public override string ToString()
        {
            return $"\nНазвание журнала: {name}\tГод выпуска: {year}\t" +
                $"Описание журнала: {comment}\tКонтактный телефон: {phone}\tКонтактный e-mail: {email}\n";
        }
        public void Input()
        {
            Console.WriteLine("Введите название журнала: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите год выпуска журнала: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите описание журнала: ");
            Comment = Console.ReadLine();
            Console.WriteLine("Введите контактный телефон журнала: ");
            Phone = Console.ReadLine();            
            Console.WriteLine("Введите контактный e-mail журнала: ");
            Email = Console.ReadLine();
        }
    }
}
