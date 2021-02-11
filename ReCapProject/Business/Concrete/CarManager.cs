using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car c)
        {
            _carDal.Add(c);
        }

        public void Delete(Car c)
        {
            _carDal.Delete(c);
        }

        public List<Car> GetAll()
        {
            // İŞ KODLARI

            return _carDal.GetAll();
        }
    }
}
