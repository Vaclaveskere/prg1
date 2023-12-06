using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassesSeptimy.Program;

namespace ClassesSeptimy
{
    internal class Program
    {
        public class Human
        {
            public int age;
            public int height;
            public int weight;
            public string name;
            public string eyeColor;
            public Human partner;

            public Human()
            {

            }

            public Human(string name)
            {
                this.name = name;

                //Ručně vyplním zbytek proměnných, nebo neřeším vůbec.
            }

            public Human(int age, int height, int weight, string name)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.name = name;
            }

            public void IntroduceHuman()
            {
                Console.WriteLine($"Jmenuji se {name}, je mi {age} let, měřím {height} cm a vážím {weight} kg");
            }

            public float BodyMassIndex()
            {
                float heightForBMI = height / 100f;
                float bmi = weight / (heightForBMI * heightForBMI);
                return bmi;
            }

            public static Human MakeChild(Human human1, Human human2)
            {
                if (human1.partner == human2 && human2.partner == human1)
                {
                    Human child = new Human();
                    child.age = 0;
                    child.height = (human1.height + human2.height) / 2;
                    child.weight = (human1.weight + human2.weight) / 2;
                    child.name = human1.name + " " + human2.name;
                    child.partner = null;
                    return child;
                }
                else
                {
                    Console.WriteLine("Tady někdo zahýbá.");
                    return new Human("Bastard");
                }
            }

            public Human MakeChildWith(Human human2)
            {
                if (partner == human2)
                {
                    Human child = new Human();
                    child.age = 0;
                    child.height = (height + human2.height) / 3;
                    child.weight = (weight + human2.weight);
                    child.name = name + " " + human2.name;
                    child.partner = null;
                    return child;
                }
                else
                {
                    Console.WriteLine("Tady někdo zahýbá.");
                    return new Human("Bastard");
                }
            }
        }

        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.age = 32;
            human1.height = 180;
            human1.weight = 80;
            human1.name = "Lojza";
            human1.IntroduceHuman();

            Human human2 = new Human(20, 165, 65, "Marie");
            human2.IntroduceHuman();

            float bmi = human2.BodyMassIndex();

            Console.WriteLine($"{human2.name} má BMI {bmi}");

            human2.eyeColor = "Pink";

            Console.WriteLine($"{human2.name} má barvu pleti {human2.eyeColor}");

            human1.partner = human2;
            human2.partner = human1;

            Human newChild = Human.MakeChild(human1, human2);
            newChild.IntroduceHuman();

            Human newerChild = human2.MakeChildWith(human1);
            newerChild.IntroduceHuman();
            Console.WriteLine(newerChild.BodyMassIndex());

            Console.ReadKey();
        }
    }
}
