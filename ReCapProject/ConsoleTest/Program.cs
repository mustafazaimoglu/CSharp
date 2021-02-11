using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // MKZ
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.ModelYear + " " + c.Description);
            }
        }
    }
}
