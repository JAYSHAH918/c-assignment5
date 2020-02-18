using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> Name = new List<string>();
            Name.Add("Atal Bihari Vajpayee");
            Name.Add("Narendra Modi,");
            Name.Add("Manmohan Singh");


            IList<int> Year = new List<int>();
            
            Year.Add(1998);
            Year.Add(2014);
            Year.Add(2004);
        
            
            Console.WriteLine("PM of 2004-----------------------");
            for (int i = 0; i < 3; i++)
            {
                if (Year[i] == 2004)
                {
                    Console.WriteLine(Name[i]);
                }
            }

            Console.WriteLine("Current pm-----------------------");
            for (int i = 0; i < 4; i++)
            {
                Name.Add("Narendra Modi");
                Year.Add(2019);
                
             
            }
            Console.WriteLine(Name[3]);
            Console.WriteLine("Sorting by year-----------------------");
            

            // use of List<T>.Sort() method 
            Year.Sort(); 
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Name + " :" + Year);
            }


        }


    }
}