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

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=100000, Description="Yeni" ,  ModelYear="2021" },
                new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=120000, Description="Yeni2" , ModelYear="2020"},
                new Car{CarId=3, BrandId=2, ColorId=3, DailyPrice=150000, Description="Yeni3" , ModelYear="2000"},
                new Car{CarId=4, BrandId=3, ColorId=4, DailyPrice=170000, Description="Yeni4" , ModelYear="2020"},
                new Car{CarId=5, BrandId=4, ColorId=5, DailyPrice=200000, Description="Yeni5" , ModelYear="2019"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }



        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }



        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(car => car.BrandId == car.BrandId).ToList();
        }

        public List<Car> GetAllByColor(int ColorId)
        {
            return _cars.Where(car => car.ColorId == car.ColorId).ToList();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

        public Car GetById(Car car)
        {
            return _cars.Where(c => c.CarId == c.CarId).FirstOrDefault();
        }
    }
}
