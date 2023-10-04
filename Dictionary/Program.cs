using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyNamespace
{
    class Dictionary 
    {
        class MyDictionary<TKey, TValue>
        {
            private List<KeyValuePair<TKey, TValue>> items;

            public MyDictionary()
            {
                items = new List<KeyValuePair<TKey, TValue>>();
            }

            public void Add(TKey key, TValue value)
            {
                items.Add(new KeyValuePair<TKey, TValue>(key, value));
            }

            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            {
                return items.GetEnumerator();
            }
        }
        static void Main ()
        {
            MyDictionary<string, int> vegetableDictionary = new MyDictionary<string, int> ();
            vegetableDictionary.Add("Banana", 12345);
            vegetableDictionary.Add("Orange", 236545);
          
            vegetableDictionary.Add("Cherry", 35678);
            

           

            foreach (KeyValuePair<string, int> item in vegetableDictionary)
            {
                Console.WriteLine("Vegetable: {0}, Value :{1}", item.Key, item.Value);
            }


            //KeyValuePair string int şeklinde yazdırır. Karışıklığı önler. "var" da yazabilirsin.

        }
          
    }
}
