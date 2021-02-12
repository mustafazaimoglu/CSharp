using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THOSE SHITS ARE IMPORTANT DUDE */ 
            // int, decimal,float,double,bool = deger tip
            /* değerler sadece stack üzerinde tutularak saklanır (PRIMITIVE VARIABLES) */
            // array,class,interface = referans tip
            /* new leme işlemi sonrası heaptan bellek konumu atanır. değişkenler değer değil adres tutar.*/
            /* herhangi bir yere atanmamış adresler garbage collector tarafında silinir. */

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);

            // Stack         // Heap
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

        }
    }
}
