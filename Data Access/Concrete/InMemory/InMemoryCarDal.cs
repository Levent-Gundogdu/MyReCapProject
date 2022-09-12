using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = "2001", Description = "Mustang"},
                new Car {Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 180000, ModelYear = "2010", Description = "BMW"},
                new Car {Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 100000, ModelYear = "2005", Description = "Ford"},
                new Car {Id = 4, BrandId = 4, ColorId = 5, DailyPrice = 200000, ModelYear = "2020", Description = "Mercedes"},
                new Car {Id = 5, BrandId = 5, ColorId = 6, DailyPrice = 150000, ModelYear = "2021", Description = "Audi"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
