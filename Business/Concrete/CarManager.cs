using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            if (car.Name.Length >= 2 && car.Price > 0)
            {
             
                _carDal.Add(car);
                Console.WriteLine("The Car : " + car.Name + " was added to database with the price : "+ car.Price);
            }

            else
            
                Console.WriteLine("NOT A VALID DATA. CHECK PRICE AND NAME OF THE CAR");
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(car => car.Brand.Id == id).ToList();
             
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(car => car.Color.Id == id);
        }



        

    }
}
