using System;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren om ett par operatorer

            Console.Title = "Inlämningsuppgift 1";

            Console.WriteLine("Enter one of the operators +,-,/,* :");
            string operatorOne = Console.ReadLine();

            Console.WriteLine("Enter another of the operators +,-,/,* :");
            string operatorTwo = Console.ReadLine();

            Console.WriteLine("Enter first number: ");
            string noInputOne = Console.ReadLine();
            int noOne = Convert.ToInt32(noInputOne);

            Console.WriteLine("Enter second number: ");
            string noInputTwo = Console.ReadLine();
            int noTwo = Convert.ToInt32(noInputTwo);

            Console.WriteLine("Enter third number: ");
            string noInputThree = Console.ReadLine();
            int noThree = Convert.ToInt32(noInputThree);

            //Visa ekvationen och resultatet

            int caseSwitch = 1;

            switch (operatorOne)
            {

                case "+":
                   int sum = noOne + noTwo;
                    break;

                case "-":
                    sum = noOne - noTwo;
                    break;
                case "/":
                    sum = noOne - noTwo;
                    break;
                case "*":
                    sum = noOne * noTwo;
                    break;
            }            

            //Lägg till resultatet i en list

            //Om resultatet är mindre än 100, skriv ut Less than a hundred

            //Om den är större, skriv More than a hundred

            //Om summan är lika med, skriv ut Cool, now you have a hundred clap clap

            //Modifiera titeln

            //Upprepa programmet tills användaren avslutar

            //Vid avslut, skriv ut summan av alla resultat
        }
    }
}
