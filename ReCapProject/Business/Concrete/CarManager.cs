using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if(c.Description.Length >= 2)
            {
                if(c.DailyPrice > 0)
                {
                    _carDal.Add(c);
                    return;
                }
            }

            Console.WriteLine("İstenilen değerleri sağlamadığı için eklenemedi!!!");
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

        public List<CarDetailDto> GetAllDetailsOfCar()
        {
            return _carDal.GetAllDetailsOfCar();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car c)
        {
            _carDal.Update(c);
        }
    }
}
