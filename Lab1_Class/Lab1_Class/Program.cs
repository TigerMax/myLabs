using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1_Class
{
    class Program
    {
        public string[] transports= new string[10];
        static void Main(string[] args)
        {
            bool cycle = true;
            while (cycle)
            {
                string type=null, temp=null;
                int state=0;
                System.Console.WriteLine("Input 'Create <type>' to make new transport.(Aircraft/Ground/Naval)");// state 1
                System.Console.WriteLine("Input 'Read' to list all created transports");// state 2
                System.Console.WriteLine("Input 'Quit' to stop this program");//state 3

                string input = System.Console.ReadLine();
                if (input.Equals("Quit"))
                {
                    cycle=false;
                    state = 3;
                }
                if (input.Equals("Read"))
                {
                    state = 2;
                }
                if ((input.Length >= 6) && (input.Substring(0, 6).Equals("Create")))
                {
                    state = 1;
                    input = input.Remove(0, 7);
                    input.Trim();
                    switch (input)
                    {
                        case "Naval": type = "Naval";
                            break;
                        case "Aircraft": type = "Aircraft";
                            break;
                        case "Ground": type = "Ground";
                            break;
                        default: System.Console.WriteLine("Not suitable <type> input");
                            break;
                    }
                }
                System.Console.WriteLine("Type " + type + " acquired. Input <name>");
                input=System.Console.ReadLine();

                



            }
        }
    }
}
