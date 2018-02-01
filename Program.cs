using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toylist = new List<string>() { "action figure", "stuffed animal", "Legos" };

            //can add, but only one at a time...
            toylist.Add("Barbie");
            toylist.Add("remote control car");
            toylist.Add("Yo-yo");

            //foreach (string toy in toylist)
            //{
            //    Console.WriteLine(toy);
            //}


            //lists have built in properties and values.  the ones we will use the most are: .Count  .Insert()  .Add()  
            // .Remove() 

            //Console.WriteLine(toylist.Count);

            //toylist.Remove("Barbie");

            //Console.WriteLine(toylist.Count);


            // .Insert allows us to put a new element in the list 
            // and specify which index we want for that element

            toylist.Insert(0, "kite");
            toylist.Insert(2, "baby doll");
            toylist.Insert(1, "plastic dinosaur");

            //foreach (string toy in toylist)
            //{
            //    Console.WriteLine(toylist.Count);
            //}

            //another method that we will often use is .Contains()
            //it returns a boolean value

            if (toylist.Contains("plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never buy a dino.");
            }
            else
            {
                Console.WriteLine("Daniel might buy any of these toys.");
            }


            List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };

            for (int i = 0; i < shelfStatus.Count; i++)
            {
                if (shelfStatus[i] == true)
                {
                    Console.WriteLine("There are toys on this shelf.");
                }
                else if (shelfStatus[i] == false)
                {
                    Console.WriteLine("Shelf is empty");
                }
                else
                {
                    Console.WriteLine("You broke the code");
                }
            }

            //foreach loop instead of:

            //for (int i = 0; i < toylist.Count; i++)
            //{
            //    Console.WriteLine(toylist[i]);
            //}


            //List<string> employeeNames = new List<string>();
        }
    }
}
