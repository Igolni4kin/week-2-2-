using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приложение просит пользователя ввести PIN-код.
            //Если введёный PIN-код "1234", то приложение приветствует пользователя
            //* и спрашивает его имя. А затем, приветствует пользователя, используя его имя по имени.
            //В ином случае, консоль выводит на экран сообщение об ошибке Invalid  PIN.
            Console.WriteLine("Please enter your PIN:");
            string userName = Console.ReadLine();

            if (userName == "1234")
            {
                Console.WriteLine("What is Your name?");
                string name = Console.ReadLine();

                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }





    }
}
