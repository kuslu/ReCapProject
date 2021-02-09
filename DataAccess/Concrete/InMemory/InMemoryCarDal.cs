using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Color> _colors;
        List<Brand> _brands;
        public InMemoryCarDal()
        {
            _brands = new List<Brand>
            {
                new Brand { BrandId=1, BrandName="Mercedes"},
                new Brand { BrandId=2, BrandName="BMW"},
                new Brand { BrandId=3, BrandName="Totota"},                
            };
            _colors = new List<Color>
            {
                new Color{ ColorId=1, CarColor="Siyah"},
                new Color{ ColorId=2, CarColor="Beyaz"},
                new Color{ ColorId=3, CarColor="Kırmızı"},
                new Color{ ColorId=4, CarColor="Mavi"},
            };
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=1500, ModelYear="2015", Description="87.000Km'de Mercedes E300"},
                new Car {Id=2, BrandId=2, ColorId=3, DailyPrice=1300, ModelYear="2005", Description="157.000Km'de BMW 3.25"},
                new Car {Id=3, BrandId=3, ColorId=4, DailyPrice=1250, ModelYear="2019", Description="85.000Km'de Totota Corolla"},
                new Car {Id=4, BrandId=3, ColorId=2, DailyPrice=800, ModelYear="2012", Description="160.000Km'de Toyota RAW4"},                
                new Car {Id=6, BrandId=2, ColorId=1, DailyPrice=12000, ModelYear="2015", Description="88.000Km'de Siyah BMW Z4"},
                new Car {Id=7, BrandId=1, ColorId=2, DailyPrice=10000, ModelYear="2018", Description="120.000Km'de Beyaz Mercedes GLC"},
            };
        }
        public void Add(Car car) 
        {
            _cars.Add(car);
        }

        public void Delete(int carId)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==carId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId) //Kullanıcı sadece CarId gönderirse CarId (int) göre arama yap
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        /*
        public Car GetById(Car car) //Kullanıcı Car gönderirse Onun içindeki id'ye göre arama yap
        {
            return _cars.SingleOrDefault(p => p.Id == car.Id);
        }
        */

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
