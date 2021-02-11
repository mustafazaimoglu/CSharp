using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car c);
        void Delete(Car c);
        void Update(Car c);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);


    }
}
