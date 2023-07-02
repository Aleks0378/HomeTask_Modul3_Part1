//Задание 6
//Создайте класс «Магазин». Необходимо хранить в 
//полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
//Реализуйте методы класса для ввода данных, вывода 
//данных, реализуйте доступ к отдельным полям через 
//методы класса.


namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop newshop = new Shop();
            try
            {
                newshop.Input();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"\n{newshop}\n");
        }
    }
}