using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentACarContext>, IBrandDal
    {
        public List<Car> GetCarsByBrandId(int brandId)
        {
            using (RentACarContext context= new RentACarContext())
            {
                return context.Cars.Where(c => c.BrandId == brandId).ToList();
            } 
        }
    }
}
