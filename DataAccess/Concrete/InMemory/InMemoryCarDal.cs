using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
            
        {
            _car = new List<Car>
            {
               new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=150,Description ="Audi A5",ModelYear=2017},
               new Car {CarId=2,BrandId=1,ColorId=1,DailyPrice=200,Description ="Audi Q7",ModelYear=2015},
               new Car {CarId=3,BrandId=2,ColorId=2,DailyPrice=125,Description ="BMW x7",ModelYear=2012},
               new Car {CarId=4,BrandId=2,ColorId=3,DailyPrice=175,Description ="BMW 318i",ModelYear=2019},
               new Car {CarId=5,BrandId=3,ColorId=5,DailyPrice=300,Description ="Toyota Corolla",ModelYear=2023}
            };

        }

        public void Add(Car car)
        {
           _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete= _car.SingleOrDefault(c=>c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c=>c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c=>c.CarId ==car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            car.ColorId = car.ColorId;
            car.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

       
        }
    }
}
