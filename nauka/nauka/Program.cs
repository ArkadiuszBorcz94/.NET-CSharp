using System;




namespace NumberGuesser
{
     class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();
            string userName=GetUserName();

            GreetUser(userName);

            Random random=new Random();
            int correctNumber = random.Next(1,11);
            bool correctAnswer = false;

            Console.WriteLine("Zgadnij wylosowaną liczbe od 1 do 10");

            while (correctAnswer == false) 
            {
                string input = Console.ReadLine();

                int guess;

              bool isNumber=  int.TryParse(input, out guess);


                if (!isNumber)
                {
                    PrintColorMessage(ConsoleColor.Yellow, "Prosze wprowadzić lliczbe.");
                    continue;


                }


                if (guess < 1 || guess > 10) 
                {

                    PrintColorMessage(ConsoleColor.Yellow, "Prosze wprowadzić liczbe od 1 do 10");
                    continue;
                }


                if (guess < correctNumber) 
                {
                    PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedź wylosowana liczba jest WIĘKSZA");
                    continue;
                
                }
               else if (guess > correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Błędna odpowiedź wylosowana liczba jest MNIEJSZA");
                    continue;

                }

                else
                {
                    PrintColorMessage(ConsoleColor.Green, "Gratulacje ODGADŁEŚ LICZBE");
                    continue;

                }



            }


        }

        static void GetAppInfo()
        {
            string appName = "Zgadywanie liczby";
            int appVersion = 1;
            string appAuthor = "Arkadiusz Borcz";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();

            string info = $"{appName} Version: 0.0.{appVersion}   Autor: {appAuthor}  ";

            PrintColorMessage(ConsoleColor.Magenta, info);

        }

        static string GetUserName() 
        {
            Console.WriteLine("Jak masz na imie?");
            string inputUserName = Console.ReadLine();

            return inputUserName;
        
        }


        static void GreetUser(string userName)

        {
            Console.ForegroundColor = ConsoleColor.Blue;

            string greet= $"Powodzenia {userName}, odgadnij liczbę....  ";

            Console.ResetColor();

           
            PrintColorMessage(ConsoleColor.Blue, greet);


        }



        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        

        }








    }
}
