using Microsoft.AspNetCore.Builder;
using itprogershop.Data.Models;

namespace itprogershop.Data;

public class DBObject {
    public static void Initial(AppDBContent content) {

        if (!content.Category.Any())
            content.Category.AddRange(Categories.Select(c => c.Value));

        if (!content.Car.Any()) {
            content.AddRange(
                new Car { 
                    name = "Tesla Model S", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                    img = "/img/tesla.jpg", 
                    price = 45000, 
                    isFavourite = true,
                    available = true,
                    category = Categories["Электромобили"]
                },
                new Car { 
                    name = "Ford Fiesta", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Ford",
                    img = "/img/ford.jpg", 
                    price = 11000, 
                    isFavourite = false,
                    available = true,
                    category = Categories["Классические автомобили"]
                },
                new Car { 
                    name = "BMW M3", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании BMW",
                    img = "/img/bmw.jpg", 
                    price = 65000, 
                    isFavourite = true,
                    available = true,
                    category = Categories["Классические автомобили"]
                },
                new Car { 
                    name = "Marcedes C class", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Marcedes",
                    img = "/img/merc.jpg", 
                    price = 40000, 
                    isFavourite = false,
                    available = false,
                    category = Categories["Классические автомобили"]
                },
                new Car { 
                    name = "Nissan Leaf", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Nissan",
                    img = "/img/nissan.jpg", 
                    price = 14000, 
                    isFavourite = true,
                    available = true,
                    category = Categories["Электромобили"]
                }
            );
        }  

        content.SaveChanges();  
    }

    private static Dictionary<string, Category> category;
    public static Dictionary<string, Category> Categories {
        get {
            if (category == null) {
                var list = new Category[] {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                };
                category = new Dictionary<string, Category>();
                foreach(Category el in list) {
                    category.Add(el.categoryName, el);
                }
            }
            return category;
        }
    }
}