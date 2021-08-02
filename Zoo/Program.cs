using Microsoft.IdentityModel.Protocols.WSIdentity;
using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When you want to quit type end! Press enter to start");
            string end = Console.ReadLine();
            do
            {
                Console.WriteLine("Type: Mammal or Reptile?");
                string animalType = Console.ReadLine();
                if (animalType == "Mammal")
                {
                    Console.Write("Type name for gorilla: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Type name for bear: ");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Gorilla: {0}, Bear: {1}", name1, name2);
                    Console.WriteLine("Continue or end? Press enter to continue");
                    end = Console.ReadLine();
                }
                else
                {
                    Console.Write("Type name for snake: ");
                    string name1 = Console.ReadLine();
                    Console.Write("Type name for lizard: ");
                    string name2 = Console.ReadLine();
                    Console.WriteLine("Snake: {0}, Lizard: {1}", name1, name2);
                    Console.WriteLine("Continue or end? Press enter to continue");
                    end = Console.ReadLine();
                }
                Console.WriteLine();
            } while (end != "end");
            Console.WriteLine();
        }
    }
}
