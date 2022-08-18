using System;
using System.Threading;

namespace Homework5PedShop
{
    internal class Program
    {
        static void Controller()
        {
            Animal[] animals = new Animal[]
{
                new Dog
                {
                   Age=1,
                   Energy=100,
                   Gender="Male",
                   NickName="Toplan",
                   Price=50,
                   Size=10
                },
                new Cat
                {
                    Age=2,
                    Size=5,
                    Price=20,
                    NickName="Mestan",
                    Gender="Famale",
                    Energy=100,
                },
                new Bird
                {
                     Age =3,
                     Energy=100,
                     Gender="Male",
                     NickName ="Totu",
                     Price =200,
                     Size=9
                },
                new Fish
                {
                    Age=4,
                    Energy=100,
                    Gender="Famale",
                    NickName="Nemo",
                    Price=10,
                    Size=3
                }
};

            do
            {
                Console.WriteLine(animals[0].ToString());
                Console.WriteLine(animals[1].ToString());
                Console.WriteLine(animals[2].ToString());
                Console.WriteLine(animals[3].ToString());
                animals[0].Play();
                animals[1].Play();
                animals[2].Play();
                animals[3].Play();
                Thread.Sleep(200);
                animals[0].Eat();
                animals[1].Eat();
                animals[2].Eat();
                animals[3].Eat();
                Console.Clear();
            } while (animals[0].Energy != 0 && animals[1].Energy != 0 && animals[2].Energy != 0 && animals[3].Energy != 0);

            Console.WriteLine(animals[0].ToString());
            Console.WriteLine(animals[1].ToString());
            Console.WriteLine(animals[2].ToString());
            Console.WriteLine(animals[3].ToString());

            var result = animals[0].Price;
            result+=animals[1].Price;
            result += animals[2].Price;
            result += animals[3].Price;

            Console.WriteLine($"Total Income: {result}");
            Console.ReadKey();
            
        }
        static void Main(string[] args)
        {
            Controller();
        }
    }
}
