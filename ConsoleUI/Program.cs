using Business.Concrete;
using Data_Access.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Description = "Car";
            car.DailyPrice = 1;

            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine(car.ColorId + " " + car.Description);
            //}

            carManager.Add(car);

        }
    }
}