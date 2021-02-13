using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
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


        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
