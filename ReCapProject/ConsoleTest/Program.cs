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
                Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.Description);
            }

            Console.WriteLine("********************");            
            foreach (var c in carManager.GetCarsByBrandId(3))
            {
                Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.Description);
            }
            
            Console.WriteLine("*** ***** **** **** ****");            
            foreach (var c in carManager.GetCarsByColorId(9))
            {
                Console.WriteLine(c.Id + " " + c.BrandId + " " + c.ColorId + " " + c.ModelYear + " " + c.Description);
            }
        }
    }
}
