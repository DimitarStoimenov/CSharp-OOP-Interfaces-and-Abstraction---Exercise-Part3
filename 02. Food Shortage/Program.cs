using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<IBuyer> citizens = new List<IBuyer>();
            List<IBuyer> rebels = new List<IBuyer>();
            
           
            
            int num = int.Parse(Console.ReadLine());
            
            IBuyer member = null;
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    member = new Citizen(name, age, id, birthdate);

                    citizens.Add(member);
                   
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    member = new Rebel(name, age, group);

                    rebels.Add(member);

                }
            }


            string number = Console.ReadLine();
            int sum = 0;

            while (number != "End")
            {
                foreach (Citizen item in citizens)
                {
                    if (item.Name == number)
                    {
                        item.BuyFood();
                        
                    }
                }
                foreach (Rebel item in rebels)
                {
                    if (item.Name == number)
                    {
                        item.BuyFood();
                    }
                }

                number = Console.ReadLine();
            }
             sum = citizens.Sum(x => x.Food) + rebels.Sum(x => x.Food);
            Console.WriteLine(sum);
        }
    }
}
