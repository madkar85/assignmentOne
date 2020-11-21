using System;
using System.Collections.Generic;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren om ett par operatorer

            Console.Title = "Inlämningsuppgift 1";

            List<double> totalSum = new List<double>();

            while()

            Console.WriteLine("Enter one of the operators +,-,/,* :");
            string operator1 = Console.ReadLine();

            Console.WriteLine("Enter another of the operators +,-,/,* :");
            string operator2 = Console.ReadLine();

            Console.WriteLine("Enter first number: ");
            string noInputOne = Console.ReadLine();
            double no1 = Convert.ToInt32(noInputOne);

            Console.WriteLine("Enter second number: ");
            string noInputTwo = Console.ReadLine();
            double no2 = Convert.ToInt32(noInputTwo);

            Console.WriteLine("Enter third number: ");
             string noInputThree = Console.ReadLine();
             double no3 = Convert.ToInt32(noInputThree);

            //Visa ekvationen och resultatet
            double sum = 0;

            

           

            if (operator1 == "+")
            {
                sum = no1 + no2;
                
            }
            else if (operator1 == "-")
            {
                sum = no1 - no2;
            }
            else if (operator1 == "/")
            {
                sum = no1 / no2;
            }
            else if (operator1 == "*")
            {
                sum = no1 * no2;
            }
            else
            {
                Console.WriteLine("fel!");
            }

            double sum2 = 0;


            if (operator2 == "+")
            {
                sum2 = sum + no3;
            }
            else if (operator2 == "-")
            {
                sum2 = sum - no3;
            }
            else if (operator2 == "/")
            {
                sum2 = sum / no3;
            }
            else if (operator2 == "*")
            {
                sum2 = sum * no3;
            }
            else
            {
                Console.WriteLine("Fel!");
            }


            Console.WriteLine(sum);
            Console.WriteLine(sum2);


            Console.WriteLine($"{no1} {operator1} {no2} {operator2} {no3} = {sum2}");
            //Console.WriteLine(no1 + operator1 + no2 + operator2 + no3 + "=" + sum2);

            //Lägg till resultatet i en list

            

            //Om resultatet är mindre än 100, skriv ut Less than a hundred
            //Om den är större, skriv More than a hundred
            //Om summan är lika med, skriv ut Cool, now you have a hundred clap clap

            if (sum2 < 100)
            {
                Console.WriteLine("The sum is less than one hundred");
            }
            else if (sum2 > 100)
            {
                Console.WriteLine("The sum is greater than one hundred");
            }
            else if (sum2 == 100)
            {
                Console.WriteLine("Cool, you got one hundred!");
            }

            totalSum.Add(sum2);



            //Modifiera titeln

            //Upprepa programmet tills användaren avslutar

            //Vid avslut, skriv ut summan av alla resultat
        }
    }
}
