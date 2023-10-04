using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
     class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;

        TKey[] tempKeys;
        TValue[] tempValues;

        //constructor
        public MyDictionary() {
            
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey item, TValue item2)
        {
            tempKeys = keys;
            tempValues = values;

            keys=new TKey[keys.Length+1];
            values=new TValue[values.Length+1];

            for(int i=0; i<keys.Length; i++)
            {
                keys[i]=tempKeys[i];
                values[i]=tempValues[i];
            }
            keys[keys.Length-1]=item;
            values[values.Length-1]=item2;

             Console.WriteLine("Vegetable: {0}, Value :{1}", item, item2);
        }

     }
}
