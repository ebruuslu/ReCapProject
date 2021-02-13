using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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

            carManager.Add(new Car { BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 100, Description = "yeni",ModelName = "Reno" });

            carManager.Update(new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 100, Description = "yeni", ModelName = "Reno" });

            carManager.Delete(new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 100, Description = "yeni", ModelName = "Reno" });

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarId + "  " + car.BrandId);
            }

            //Console.WriteLine(carManager.GetById(1));

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            colorManager.Update(new Color { ColorId = 1, ColorName = "Kırmızı" });
            colorManager.Delete(new Color { ColorId = 1, ColorName = "Kırmızı" });


            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Renault" });
            brandManager.Update(new Brand { BrandId= 2 ,BrandName = "Renault" });
            brandManager.Delete(new Brand { BrandId= 2, BrandName = "Renault" });




        }
    }
}
