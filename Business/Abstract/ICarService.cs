using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int carId);
        List<Car> GetByCarPrice(int min, int max);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
