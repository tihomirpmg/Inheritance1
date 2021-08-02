namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Type: Cat, Dog, Frog, Kitten or Tomcat");
            Console.WriteLine("Type Beast! for ending.");
            Console.WriteLine("After choosing between the choices you should insert on one line- Name, age and gender");
            Console.WriteLine("If you choose Tomcat or Kitten you should only insert- name and age");
            string animalType;
            while ((animalType = Console.ReadLine()) != "Beast!")
            {

                try
                {
                    var animalInfo = Console.ReadLine().Split(' ');
                    switch (animalType)
                    {
                        case "Cat":
                            var cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Dog":
                            var dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            var frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));
                            Console.WriteLine(tomcat);
                            break;
                        default:
                            throw new Invalid();
                    }
                }
                catch (Invalid iie)
                {
                    Console.WriteLine(iie.Message);
                }
            }
        }
    }
}
