using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDtoDal : ICarDTO
    {
        public void Add(CarDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(CarDTO entity)
        {
            throw new NotImplementedException();
        }

        public CarDTO Get(Expression<Func<CarDTO, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDTO> GetAll(Expression<Func<CarDTO, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(CarDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
