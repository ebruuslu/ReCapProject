using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {
        public List<Car> GetCarsByColorId(int colorId)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Cars.Where(c => c.ColorId == colorId).ToList();
            }
                
        }
    }
}
