using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] systems = { "Split Units", "Chiller", "VRF System" };
            Console.WriteLine("Welcome to HVAC Cost Estimation in Egypt");
            Console.WriteLine("Available HVAC Systems:");
            
            for (int i = 0; i < systems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {systems[i]}"); 
            }
            Console.WriteLine("Choose a system");
             try
             {
                int choice = int.Parse(Console.ReadLine());

                if (choice >= 1 && choice <= systems.Length)
                {
                    switch (choice)
                    {
                        case 1:
                            HandleSplitUnit();
                            break;
                        case 2:
                            HandleChiller();
                            break;
                        case 3:
                            HandleVRF();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please run the program again.");
                }
             }
             catch 
             {
                Console.WriteLine("Invalid input. Please enter a number only.");
             }
        }
        static void HandleSplitUnit() 
        {
            string[] DX = { "Decorative", "Ducted"};
            Console.WriteLine("What type do you prefer ? (Decorative or Ducted)");
            string answer = Console.ReadLine();
            
            if (answer.Equals("Decorative", StringComparison.OrdinalIgnoreCase))
            {
                string[] decorative = { "High wall", "Floor&Ceiling", "Cassette", "Free split" };
                ShowOptions("Choose a unit", decorative);
                try
                {
                    int unit = int.Parse(Console.ReadLine());

                    if (unit >= 1 && unit <= decorative.Length)
                    {
                        double[] Load = { 1.5, 2.25, 3 };
                        ShowOptions("Choose the load needed in HP", Load);
                        int HP = int.Parse(Console.ReadLine());

                        if (HP >= 1 && HP <= Load.Length)
                        {
                            switch (HP)
                            {
                                case 1:
                                    string[] brands =
                                    {
                                    "25,000 - 40,000 Carrier , Approximate price = 27,000 EP",
                                    "34,000 - 49,000 LG , Approximate price = 33,000 EP ",
                                    "22,000 - 26,000 Toshiba , Approximate price = 24,000 EP ",
                                    "25,000 - 35,000 Sharp , Approximate price = 29,000 EP ",
                                    "40,000 - 50,000 Daikin , Approximate price = 31,000 EP ",
                                    "30,000 - 40,000 Panasonic , Approximate price = 35,000 EP "
                                    };
                                    Console.WriteLine("\nAvailable Options:");
                                    foreach (string brand in brands)
                                    {
                                        Console.WriteLine(brand);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("details coming soon");
                                    break;
                                case 3:
                                    Console.WriteLine("details coming soon");
                                    break;
                            }
                        }

                        else
                        {
                            Console.WriteLine("Invalid choice. Please run the program again.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please run the program again.");
                    }
                }
                catch 
                { 
                    Console.WriteLine("Invalid input. Please enter a number only.");
                }

            }
            else if (answer.Equals("Ducted", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("details coming soon");
            }
            else
            {
                Console.WriteLine("Invalid option. Please type Decorative or Ducted.");
            }
        }
        static void HandleChiller()
        {
            Console.WriteLine("details coming soon");
        }
        static void HandleVRF()
        {
            Console.WriteLine("details coming soon");
        }
        static void ShowOptions(string message, string[] options)
        {
            Console.WriteLine(message);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }
        static void ShowOptions(string message, double[] options)
        {
            Console.WriteLine(message);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }
    }
}
