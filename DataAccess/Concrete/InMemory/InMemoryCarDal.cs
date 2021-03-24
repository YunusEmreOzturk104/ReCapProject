using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=100,Description="Bugatti"},
                new Car{Id=2,BrandId=3,ColorId=2,ModelYear=2015,DailyPrice=150,Description="Ferrari"},
                new Car{Id=3,BrandId=4,ColorId=2,ModelYear=2013,DailyPrice=130,Description="Skoda"},
                new Car{Id=4,BrandId=5,ColorId=3,ModelYear=2012,DailyPrice=110,Description="Honda"},
                new Car{Id=5,BrandId=6,ColorId=4,ModelYear=2019,DailyPrice=120,Description="Opel"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _cars.SingleOrDefault(c => c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
