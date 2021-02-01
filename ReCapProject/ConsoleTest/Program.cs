using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // MKZ
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var c in carManager.ReadAll())
            {
                Console.WriteLine(c.ModelYear + " " + c.Description);
            }
        }
    }
}
