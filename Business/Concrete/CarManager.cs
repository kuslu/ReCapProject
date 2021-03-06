﻿using Business.Abstract;
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

        public void Add(Car car)
        {            
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _carDal.GetAll();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetByBrandId(int carId)
        {
            return _carDal.GetAll(p => p.Id == carId);
        }

        public List<Car> GetByCarPrice(int min, int max)
        {
            return _carDal.GetAll(p=> p.DailyPrice>=min && p.DailyPrice<=max);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public List<CarDTO> GetCarDTOs(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
