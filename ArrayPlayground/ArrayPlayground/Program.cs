using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] nums = {1,2,3,4,5};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("vypis for cyklus");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
           
            int sum = 0;
            foreach (int i in nums)
            {
                sum += sum;//+=, *=, ==

            }


            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum/ nums.Length;
            Console.WriteLine(average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = nums[0];
            for(int i = 0;i<nums.Length;i++)
            {
                if (nums[i] > max)
                {

                    max = nums[i]; 
                }


            }

            Console.WriteLine(max);
            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = nums.Min();
            Console.WriteLine(min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int number = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(nums, number);
            if (index == -1)
            {
                  Console.Write("cislo v poli neexistuje");  
            }
            else
            {
                Console.WriteLine($"prvek{number}je na indexu{index}");
            }
            


            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rng = new Random();
            nums = new int[100];
            for (int i = 0; i < 100; i++) 
            {
                nums[1] = rng.Next(0,10) ;
                Console.WriteLine($"{i} prvek je pole {nums[1]}");
            }





            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            foreach (int num in nums) ;
            {
                counts[num]++;
            }
            
            
            
            for (int i = 0;i<counts.Length;i++)
            {
                Console.WriteLine($"Četnosti{i}je counts {counts[1]}");
            }



            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] reverseArray = new int[100];
            for (int i = reverseArray.Length - 1, i >= 0; i--)
            {

                reverseArray[1] = nums[99 - 1];

            }
            for(int )




            Console.ReadKey();
        }
    }
}
