using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByCarPrice(10000,15000) )
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}",car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            foreach (var car in carManager.GetByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

            

            //InMemorydenCalisma(carManager);           
        }

        private static void InMemorydenCalisma(CarManager carManager)
        {
            Console.WriteLine("Eklendikten sonraki liste");
            Car car1 = new Car { Id = 8, BrandId = 1, ColorId = 2, DailyPrice = 5000, ModelYear = "2014", Description = "Eklenen Araba 1" };
            carManager.Add(car1);
            ListCars(carManager);

            Console.WriteLine("Düzenlemeden Sonraki Liste");
            car1.Description = "Düzenlenen Araba Bilgisi";
            carManager.Update(car1);
            ListCars(carManager);

            Console.WriteLine("Sadece Belirtilen Arabanın Görüntülenmesi");
            carManager.GetByBrandId(8);

            Console.WriteLine("Silindikten Sonraki Liste");
            //carManager.Delete(8);
            ListCars(carManager);
        }

        private static void ListCars(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
