using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository <Color>
    {
        List<Car> GetCarsByColorId(int colorId);
    }
}
