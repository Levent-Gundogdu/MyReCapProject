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
            CarTest();
            //BrandTest();
            //ColorManager colorManager = new ColorManager();
            //foreach (var color in colorManager.GetColorDetails())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetBrandDetails())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 1, ColorId = 10, DailyPrice = 40000, ModelYear = "2010", Description = "E200" });

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName);
            }
        }
    }
}