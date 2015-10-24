using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_Class
{
    class Program
    {
        static Transport[] transports= new Transport[10];
        static int current = 0;
        static void Main(string[] args)
        {
            bool cycle = true;
            while (cycle)
            {
                string type = null;
                int state=0;
                System.Console.WriteLine("Input 'Create <type>' to make new transport.(Aircraft/Ground/Naval)");
                System.Console.WriteLine("Input 'List' to list all created transports");
                System.Console.WriteLine("Input 'Quit' to stop this program");

                string input = System.Console.ReadLine();
                if (input.Equals("Quit"))
                {
                    cycle=false;
                  }
                if (input.Equals("List"))
                {
                    System.Console.WriteLine("Listing created transports");
                    System.Console.WriteLine("--------------------------");
                    if(current>0)
                    for (int i=0;i< current; i++)
                    {
                        System.Console.WriteLine(transports[i].getName()+"-"+transports[i].getType()+"-"+ transports[i].makeSound());
    
                    }
                    System.Console.WriteLine("--------------------------");

                }
                if ((input.Length >= 6) && (input.Substring(0, 6).Equals("Create")))
                {
                    state = 1;
                    input = input.Remove(0, 7);
                    input.Trim();
                    switch (input)
                    {
                        case "Naval": type = "Naval";
                            System.Console.WriteLine("Type " + type + " acquired. Input <name>");
                            input = System.Console.ReadLine();
                            transports[current] = new Boat(input);
                            current++;
                            break;

                        case "Aircraft": type = "Aircraft";
                            System.Console.WriteLine("Type " + type + " acquired. Input <name>");
                            input = System.Console.ReadLine();
                            transports[current] = new Plane(input);
                            current++;
                            break;

                        case "Ground": type = "Ground";
                            System.Console.WriteLine("Type " + type + " acquired. Input <name>");
                            input = System.Console.ReadLine();
                            transports[current] = new Car(input);
                            current++;
                            break;

                        default: System.Console.WriteLine("Not suitable <type> input");
                            break;
                    }
                }
                



            }
        }
    }
}
