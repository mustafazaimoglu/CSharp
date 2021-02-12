using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T = Type
    {
        T[] Items;
        public MyList() // ctor - constructor
        {
            Items = new T[0];
        }
        public void Add(T item)
        {
            T[] temp = Items;
            Items = new T[Items.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                Items[i] = temp[i];
            }

            Items[temp.Length] = item;
        }

        public void Print()
        {
            foreach (var i in Items)
            {
                Console.WriteLine(i);
            }
        }
    }
}
