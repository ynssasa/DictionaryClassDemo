using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryClassDemo
{
    class MyDictionary<TKey,TValue>
    {
        List<TKey> Keys;
        List<TValue> Values;
        
        public MyDictionary()
        {
            Keys = new List<TKey>();
            Values = new List<TValue>();
        }

        public void Add(TKey tKey,TValue tValue)
        {          
            Keys.Add(tKey);
            Values.Add(tValue); 
        }

        public TKey GetKey (TValue value)
        {
             int index = Values.IndexOf(value);
             return Keys[index];
           
        }

        public TValue GetValue (TKey key)
        {
            int index = Keys.IndexOf(key);
            return Values[index];

        }

    }
}
