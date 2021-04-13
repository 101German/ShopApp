using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c=>c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Современный автомомбиль",
                        longDesc = "Автомобиль комании Tesla",
                        img = "/img/Tesla-Model_S.jpg",
                        price = 40000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
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
                         Category = Categories["Классические автомобили"]
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
                         Category = Categories["Классические автомобили"]
                     },
                     new Car
                     {
                         name = "Mercedes cls",
                         shortDesc = "-",
                         longDesc = "-",
                         img = "/img/mercedes_cls.jpg",
                         price = 55000,
                         isFavourite = false,
                         available = true,
                         Category = Categories["Классические автомобили"]
                     }
                    
                    );

            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                     new Category{categoryName="Электромобили",desc="Современный вид транспорта"},
                     new Category{categoryName="Классические автомобили",desc="Машины с двигателем внутреннего сгорания"}

                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
