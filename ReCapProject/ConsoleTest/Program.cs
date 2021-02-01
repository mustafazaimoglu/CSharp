using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.ReadAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
