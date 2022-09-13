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

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 1, ColorId = 10, DailyPrice = 40000, ModelYear = "2010", Description = "E200" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.BrandId + " " + car.Description);
            }



        }
    }
}