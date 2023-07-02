//Задание 5
//Создайте класс «Журнал». Необходимо хранить в 
//полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
//Реализуйте методы класса для ввода данных, вывода 
//данных, реализуйте доступ к отдельным полям через 
//методы класса.


namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Journal jour=new Journal();
            try 
            {
                jour.Input();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"\n{jour}\n");
        }
    }
}