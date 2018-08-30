using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main()
        {
            // #1 & #2
            HashSet<string> Showroom = new HashSet<string>{"Accord", "Altima", "Camry", "Civic"};

            // #3
            Console.WriteLine(Showroom.Count);

            // #4 & #5
            // foreach (string car in Showroom)
            // {
            //     if (car == "Altima") 
            //     {
            //         // Console.WriteLine(car);
            //         Showroom.Add(car);
            //     }   
            //     Console.WriteLine(car);
            // }

            // #6
            HashSet<string> UsedLot = new HashSet<string>{"Cruze", "Impala"};
            
            // #7 & #8
            Showroom.UnionWith(UsedLot);
            Showroom.Remove("Altima");
            foreach (string car in Showroom)
            {
                // Console.WriteLine(car);
            }

            // Aquiring More Cars ------->

            // #1 
            HashSet<string> Junkyard = new HashSet<string>{"Titan", "Prius", "Leaf"};
            Junkyard.UnionWith(Showroom);
            Junkyard.Remove("Camry");
            Junkyard.Remove("Impala");
            // Console.WriteLine(Junkyard.Count);

            // #2 & #3
            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(Junkyard);
            foreach (string car in clone)
            {
                // Console.WriteLine(car);
            }

            // #4 & #5
            Showroom.UnionWith(Junkyard);
            Showroom.Remove("Prius");
            Showroom.Remove("Leaf");
            foreach (string car in Showroom)
            {
                Console.WriteLine(car);
            }

        }
    }
}
