using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Web
    {
        string name;
        string path;
        string comment;
        string Ip;
        public Web()
        { }
        public Web(string name, string path, string comment, string ip)
        {
            this.name = name;
            this.path = path;
            this.comment = comment;
            Ip = ip;
        }
        // Реализуйте методы класса для ввода
        //данных, вывода данных, реализуйте доступ к отдельным 
        //полям через методы класса.

        public string Name
        {
            get { return name; }
            set 
            {
                if(value==" " || value.Length==0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                name = value; 
            }
        }
        public string Path
        {   get { return path; }
            set { path = value; }
        }
        public string Comment
        {   get { return comment;}
            set { comment = value;}
        }
        public string IP
        {
            get { return Ip; }
            set { Ip = value;}
        }
        public override string ToString()
        {
            return $"{name}\t\t{Ip}\t{Path}\t{Comment}\n";
        }
        public void Input()
        {
            Console.WriteLine("Введите название сайта: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите путь к сайту: ");
            Path = Console.ReadLine();
            Console.WriteLine("Введите описание сайта: ");
            Comment = Console.ReadLine();
            Console.WriteLine("Введите ip адрес сайта: ");
            IP = Console.ReadLine();
        }
    }
}
