//Задание 4
//Создайте класс «Веб-сайт». Необходимо хранить в 
//полях класса: название сайта, путь к сайту, описание 
//сайта, ip адрес сайта. Реализуйте методы класса для ввода 
//данных, вывода данных, реализуйте доступ к отдельным 
//полям через методы класса.

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Web web = new Web();

            try
            {
                web.Input();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"\n\n{web}\n\n");
        }

    }
}