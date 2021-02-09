using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        CarDTO GetById(int CarId);
        List<CarDTO> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(int carId);

    }
}
