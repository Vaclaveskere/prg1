using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vysledek = 0,mocnina; // zadefinovat integrovanou hodnotu nula, když např dělíme nulou vyjde nula 
            string a, b, operace, číslo, mocnitel;

            bool error = false; // zadefinujeme si error datový typ jako bool true/false
            Console.WriteLine("kalkulajda");



            while (true)
            {

                Console.WriteLine(" Menu:");
                Console.WriteLine("1. Aritmetické počty");
                Console.WriteLine("2. Factorial");
                Console.WriteLine("3. Mocniny");
                Console.WriteLine("4. Exit");

                Console.Write("Enter (1/2/3/4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {


                    case "1":

                            Console.WriteLine("Zadej 1. číslo:");
                            a = Console.ReadLine();

                        if (!double.TryParse(a, out double num1))  // místo integeru jsem to hodil rovnou do doublu (přišlo mi to jako míň práce)

                        {
                            Console.WriteLine("Neplatné číslo. Zadejte platné číslo.");
                            continue;
                        }
                            
                    


                    while (true)
                    {
                        Console.WriteLine("zadej jednu z možností: + - * /");
                        operace = Console.ReadLine();


                        if (operace == "+" || operace == "-" || operace == "*" || operace == "/") // || je nebo, , rovná se + ano/ne...  jde dál
                            break;     // ukončení cyklu, když pravda operace = jedna z možností

                    }



                    Console.WriteLine("Zadej 2. číslo:");
                    b = Console.ReadLine();

                    if (!double.TryParse(b, out double num2))
                    {
                        Console.WriteLine("Neplatné číslo. Zadejte platné číslo.");
                        continue;
                    }



                    switch (operace)
                    {


                        case "+":
                            vysledek = num1 + num2;

                            break;
                        case "-":
                            vysledek = num1 - num2;

                            break;
                        case "*":
                            vysledek = num1 * num2;

                            break;
                        case "/":


                            if (num2 == 0)   // nemůžem dělit nulou
                            {
                                Console.WriteLine("neděl nulou ty trubko!");
                                error = true;    // pokud je error true dostaneme error message, pokud jde na else a dostaneme vysledek
                            }
                            else
                                vysledek = num1 / num2;


                            break;


                    }
                    if (error == false)  // error nebyl true, tudíž je false podmínka splněna dostaneme výsledek
                    {
                        Console.WriteLine("Result: " + vysledek.ToString());

                    }

                    break;


                case "2":
                    Console.WriteLine("vypočet faktorialu");
                    int n = int.Parse(Console.ReadLine());
                    int factorial = Factorial(n);

                    Console.WriteLine($"Pro cislo {n} je faktorial {factorial} ");

                    break;


                case "3":
                        Console.WriteLine("Zadej číslo: ¨");
                        číslo = Console.ReadLine();

                        if (!double.TryParse(číslo, out double num3)) 
                        {
                            Console.WriteLine("Neplatné číslo. Zadejte platné číslo.");
                            continue;
                        }


                        Console.WriteLine("zadej mocnitel: ");
                        mocnitel = Console.ReadLine();
                        if (!double.TryParse(mocnitel, out double num4))  

                        {
                            Console.WriteLine("Neplatné číslo. Zadejte platné číslo.");
                            continue;
                        }

                       

                        mocnina = Math.Pow(num3,num4); 
                        Console.WriteLine("Result: " + mocnina.ToString());

                        break;


                case "4":
                    Environment.Exit(0);
                    break;
                }
                static int Factorial(int n)
                {

                    if (n == 1)

                    {
                        return 1;

                    }
                    int nFactorial = n * Factorial(n - 1);
                    return nFactorial;

                }

            


                    Console.Write("Přejete si pokračovat (ano/ne): ");
                    string response = Console.ReadLine();

                    if (response.ToLower() != "ano")  //Tolower všechno hodí na malý písmenka,pokud podmínka splněna ukončení programu jinak se opakije while cyklus
                    {
                        break; // ukončí kalkulačku
                    }
                    



              
                Console.ReadKey(); 
            }
        }
    }
}