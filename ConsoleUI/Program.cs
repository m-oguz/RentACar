using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //TEST 
            Car car = new Car
            {
                BrandId = 2,
                ColorId = 5,
                Id = 43,
                Name = "Mercedes-Benz",
                Price = 332
            };
            CarManager carManager = new CarManager(new EfCarDal());
         
            carManager.AddCar(car);
        



            Console.WriteLine("Getting cars with brandid : 1");
            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }
            Console.WriteLine("Got cars with brandid : 1");

        }
    }
}