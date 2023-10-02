using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyNamespace
{
    class Dictionary 
    {
        static void Main ()
        {
            Dictionary<string, int> Vegetable = new Dictionary<string, int> ();
            Vegetable.Add("Banana", 12345);
            Vegetable.Add("Orange", 236545);
            Vegetable.Remove("Banana");
            Vegetable.Add("Cherry", 35678);
            Vegetable.Clear();

            //Console.WriteLine("Dictionary");


            foreach (KeyValuePair<string, int> item in Vegetable)
            {
                Console.WriteLine("Vegetable: {0}, Value :{1}", item.Key, item.Value);
            }

        }
          
    }
}
