using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        // CRUD
        void Create(Car car);
        List<Car> ReadAll();
        void Update(Car car);
        void Delete(Car car);

        List<Car> ReadAllByBrandId(int brandId);


    }
}
