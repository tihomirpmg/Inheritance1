using System;
using System.Collections.Generic;

namespace Players_and_monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elfs: ");
            Console.WriteLine();
            Console.WriteLine("MuseElfs: ");
            List<MuseElf> elfs = new List<MuseElf>();
            elfs.AddRange(new List<MuseElf>
            {
                new MuseElf("Georgi", 1234),
                new MuseElf("Ivan", 123),
                new MuseElf("Shumi", 12345),
            });
            for (int i = 0; i < elfs.Count; i++)
                Console.WriteLine(elfs[i]);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Knights: ");
            Console.WriteLine();
            Console.WriteLine("DarkKnights: ");
            List<DarkKnight> knights = new List<DarkKnight>();
            knights.AddRange(new List<DarkKnight>
            {
                new DarkKnight("Tisho", 12334),
                new DarkKnight("Ivan", 123),
                new DarkKnight("Diqn", 145),
            });
            for (int i = 0; i < knights.Count; i++)
                Console.WriteLine(knights[i]);
            Console.WriteLine("------------------------------------------");
            
            
            Console.WriteLine("BladeKnights: ");
            List<BladeKnight> bknights = new List<BladeKnight>();
            bknights.AddRange(new List<BladeKnight>
            {
                new BladeKnight("Ishos", 123234),
                new BladeKnight("Ivanos", 12453),
                new BladeKnight("Diqnos", 14895),
            });
            for (int i = 0; i < bknights.Count; i++)
                Console.WriteLine(bknights[i]);
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Wizards: ");
            Console.WriteLine();
            Console.WriteLine("DarkWizard: ");
            List<DarkWizard> dwizard = new List<DarkWizard>();
            dwizard.AddRange(new List<DarkWizard>
            {
                new DarkWizard("Gers", 14),
                new DarkWizard("Nos", 153),
                new DarkWizard("Qnos", 1434895),
            });
            for (int i = 0; i < dwizard.Count; i++)
                Console.WriteLine(dwizard[i]);
            Console.WriteLine("------------------------------------------");


            Console.WriteLine("SoulMaster: ");
            List<SoulMaster> smaster = new List<SoulMaster>();
            smaster.AddRange(new List<SoulMaster>
            {
                new SoulMaster("Hos", 234),
                new SoulMaster("Ios", 453),
                new SoulMaster("Dqn", 148295),
            });
            for (int i = 0; i < smaster.Count; i++)
                Console.WriteLine(smaster[i]);
            Console.WriteLine("------------------------------------------");
        }
    }
}
