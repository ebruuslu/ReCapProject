using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<Car> GetCarsId(int carId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.Where(c => c.CarId == carId).ToList();
            }

        }
    }
}
