using Business.Concrete;
using Data_Access.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.ColorId + " " + car.Description);
            }

        }
    }
}