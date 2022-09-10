using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int carId);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
