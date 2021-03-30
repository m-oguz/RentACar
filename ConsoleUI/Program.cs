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
            Car car1 = new Car
            {
                Id = 32,
                Price = 310.00,
                Brand = new Brand { Id = 12, Name = "407" },
                Color = new Color { Id = 3, Name = "WHITE" },
                Name = "KIA"
            };

            CarManager carManager = new CarManager(new EfCarDal());

            carManager.AddCar(car1);




        }
    }
}
    
