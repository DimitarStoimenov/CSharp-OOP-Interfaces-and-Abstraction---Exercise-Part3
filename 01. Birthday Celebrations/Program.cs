using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IBirthable> ids = new List<IBirthable>();
            
            while (command != "End")
            {
                string[] input = command.Split();
                IBirthable member = null;

                if (input[0] == "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string birthdate = input[4];

                    member = new Citizen(name, age, id, birthdate);
                    ids.Add(member);

                }
                else if (input[0] == "Pet")
                {
                    string name = input[1];
                    string birthdate = input[2];

                    member = new Pet(name, birthdate);
                    ids.Add(member);
                }
                
                command = Console.ReadLine();
                

            }
            string number = Console.ReadLine();
            foreach (IBirthable ib in ids)
            {
                if (ib.Birthdate.EndsWith(number))
                {
                    Console.WriteLine(ib.Birthdate);
                }
            }
        }
    }
}
