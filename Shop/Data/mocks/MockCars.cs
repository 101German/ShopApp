using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Современный автомомбиль",
                        longDesc = "Автомобиль комании Tesla",
                        img = "/img/Tesla-Model_S.jpg",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                     new Car
                    {
                        name = "Mercedes S-class",
                        shortDesc = "-",
                        longDesc = "-",
                        img = "/img/mercedes223.jpg",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car
                    {
                        name = "BMW X5",
                        shortDesc = "-",
                        longDesc = "-",
                        img = "/img/bmwx5.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car
                    {
                        name = "Mercedes cls",
                        shortDesc = "-",
                        longDesc = "-",
                        img = "/img/mercedes_cls.jpg",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
