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

            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Getting cars with brandid : 5");
            foreach (var item in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine(item.Name + " \t " + item.BrandId + " \t "+ item.Price);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Gettin cars with colorid :5");
            foreach(var item in carManager.GetCarsByColorId(5))
            {
                Console.WriteLine(item.Name + " \t  " + item.ColorId +" \t  " + item.Price);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Car List");

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Name + " " + item.Price + "  Brand: " + item.BrandId + " ColorCode : " + item.ColorId );
            }

            Console.Read();


        }
    }
}