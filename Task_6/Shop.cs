using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Создайте класс «Магазин». Необходимо хранить в 
//полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
//Реализуйте методы класса для ввода данных, вывода 
//данных, реализуйте доступ к отдельным полям через 
//методы класса.
namespace Task_6
{
    internal class Shop
    {
        public string name;
        public string adres;
        public string comments;
        public string phone;
        public string email;

        public Shop() { }
        public Shop(string name, string adres, string comments, string phone, string email)
        {
            this.name = name;
            this.adres = adres;
            this.comments = comments;
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
        public string Adres
        {
            get { return adres; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                adres = value;
            }
        }
        public string Comments
        {
            get { return comments; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                comments = value;
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
            return $"\nНазвание магазина: {name}\n\tАдрес: {adres}\n\t" +
                $"Описание: {comments}\n\tКонтактный телефон: {phone}\n\tКонтактный e-mail: {email}\n";
        }
        public void Input()
        {
            Console.WriteLine("Введите название магазина: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите адрес магазина: ");
            Adres = Console.ReadLine();
            Console.WriteLine("Введите описание магазина: ");
            Comments = Console.ReadLine();
            Console.WriteLine("Введите контактный телефон магазина: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Введите контактный e-mail магазина: ");
            Email = Console.ReadLine();
        }
    }
}
