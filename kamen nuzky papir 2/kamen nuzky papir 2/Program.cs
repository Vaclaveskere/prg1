using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamen_nuzky_papir_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("zahrajeme si kamen nuzky papir");
            
            Console.Write("vyber možnost:");
            string playerChoice = Console.ReadLine().ToLower();

            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            string computerChoiceStr = "";
            switch (computerChoice)
            {
                case 1:
                    computerChoiceStr = "rock";
                    break;
                case 2:
                    computerChoiceStr = "paper";
                    break;
                case 3:
                    computerChoiceStr = "scissors";
                    break;
            }
            Console.WriteLine($"Computer chose {computerChoiceStr}.");

            if (playerChoice== computerChoiceStr) 
            {
                Console.WriteLine("remiza");

            }
            else if  { 
            
            
            }
         
            

         
            













        }
    }
}
