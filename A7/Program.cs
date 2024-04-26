using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            string x = "5";
            string str
            var funcs = new Features();

            List<string> dinosaurs = new List<string>();
            dinosaurs.Add("Gorgosaurus");
            dinosaurs.Add("Allosaurus");
            dinosaurs.Add("Aardonyx");
            dinosaurs.Add("Megalosaurus");
            dinosaurs.Add("Abrosaurus");
            dinosaurs.Add("Homalocephale");
            dinosaurs.Add("Alvarezsaurus");
            dinosaurs.Add("Datousaurus");
            dinosaurs.Add("Ammosaurus");
            dinosaurs.Add("Capitalsaurus");

            while (choice == 1)
            {
                Console.WriteLine("Main menu");
                Console.WriteLine("1. random number");
                Console.WriteLine("2. today`s date");
                Console.WriteLine("3. list of dinosaurs");
                Console.WriteLine("4. string magic");
                Console.WriteLine("5. exit");
                Console.WriteLine("Choose 1-5:");
                x = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                if (x == "1")
                {
                    int r = funcs.randomnumber();
                    Console.WriteLine("The random number: {0}", r);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "2")
                {
                    string s = funcs.daytime();
                    Console.WriteLine("Today's date: {0}", s);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "3")
                {
                    Console.WriteLine("unordered list: ");
                    funcs.unorderedlist(dinosaurs);
                    Console.WriteLine();
                    Console.WriteLine("ordered list: ");
                    funcs.orderedlist(dinosaurs);
                    Console.WriteLine();
                    var r = funcs.randomdinosaur();
                    Console.WriteLine("Random dinosaur picked: {0}", dinosaurs[r]);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (x == "4")
                {
                    Console.WriteLine("give a string, at least 10 characters:");
                    str = Console.ReadLine();
                    Console.WriteLine("something random happens to the string:");
                    string s = funcs.stringrandom(str);
                    Console.WriteLine(s);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                if (x == "5") { choice = 0; }
            }

            Console.WriteLine("Exiting program... Press enter");
            Console.ReadLine();
        }
    }
}
