using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает у пользователя его имя
            //если его имя пользователя совпадает с зарегестрированным именем пользователя admin,
            //приложение приветствует пользователя, выводя в консоль слово Welcome!
            //в ином случае, консоль выводит ошибку Oops! Invalid usernam
            Console.WriteLine("Please enter your username:");
            string userName = Console.ReadLine();

            if (userName == "admin")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("oops! Invalid username.");
            }
            Console.WriteLine("Have a nice day");

        }
    }
}  
            
            
            


