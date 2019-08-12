using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTrekNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> maleStart = new List<string>() {"S", "Sp", "Sk", "St", "T" };
            List<string> vocals = new List<string>() {"a", "e", "i", "o", "u", "y" };
            List<string> consonants = new List<string>() {"r" , "t", "p", "d", "f", "j" ,"k", "l", "v", "b", "n", "m" };
            List<string> maleEnd = new List<string>() {"q", "p", "k", "ck", "l" };
            List<string> femaleStart = new List<string>() {"P", "K", "Q" };
            List<string> femaleEnd = new List<string>() {"r", "j", "’p", "k", "l" };
            List<string> males = new List<string>();

            Console.WriteLine("Vælg Køn: \n1: Male\n2: Female");
            string choice = Console.ReadLine().ToLower();
            Console.Clear();
            if (choice == "1" || choice == "m" || choice == "male")
            {

            //Male Vulcan names 
            foreach (var start in maleStart)
            {
                string namePart1 = start;
                foreach (var vocal in vocals)
                {
                    string namePart2 = namePart1 + vocal;
                    foreach (var cons in consonants)
                    {
                        string namePart3 = namePart2 + cons;
                        foreach (var vocal2 in vocals)
                        {
                            string namePart4 = namePart3 + vocal2;
                            foreach (var end in maleEnd)
                            {
                                string randomName = namePart4 + end;
                                males.Add(randomName);
                                Console.WriteLine(randomName);
                            }
                        }
                    }
                }
            }

            //Male Vulcan names 2
            foreach (var start in maleStart)
            {
                string namePart1 = start;
                foreach (var vocal in vocals)
                {
                    string namePart2 = namePart1 + vocal;
                    foreach (var end in maleEnd)
                    {
                        string randomName = namePart2 + end;
                        males.Add(randomName);
                        Console.WriteLine(randomName);
                    }
                }
            }

            }
            else if(choice == "2" || choice == "f" || choice == "female")
            {

                //Female Vulcan names
                foreach (var start in femaleStart)
                {
                    string namePart1 = "T’" + start;
                    foreach (var vocal in vocals)
                    {
                        string namePart2 = namePart1 + vocal;
                        foreach (var end in femaleEnd)
                        {
                            string randomName = namePart2 + end;
                            Console.WriteLine(randomName);
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Fejl");
            }
            Console.ReadKey();
        }
    }
}
