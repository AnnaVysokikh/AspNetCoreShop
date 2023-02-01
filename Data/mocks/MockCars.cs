using itprogershop.Data.Interfaces;
using itprogershop.Data.Models;

namespace itprogershop.Data.mocks;

public class MockCars : IAllCars {

    private readonly ICarsCategory _categoryCars = new MockCategory();
    public IEnumerable<Car> Cars {
        get {
            return new List<Car> {
                new Car { 
                    name = "Tesla Model S", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                    img = "/img/tesla.jpg", 
                    price = 45000, 
                    isFavourite = true,
                    available = true,
                    category = _categoryCars.AllCategories.First()
                },
                new Car { 
                    name = "Ford Fiesta", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Ford",
                    img = "/img/ford.jpg", 
                    price = 11000, 
                    isFavourite = false,
                    available = true,
                    category = _categoryCars.AllCategories.Last()
                },
                new Car { 
                    name = "BMW M3", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании BMW",
                    img = "/img/bmw.jpg", 
                    price = 65000, 
                    isFavourite = true,
                    available = true,
                    category = _categoryCars.AllCategories.Last()
                },
                new Car { 
                    name = "Marcedes C class", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Marcedes",
                    img = "/img/merc.jpg", 
                    price = 40000, 
                    isFavourite = false,
                    available = false,
                    category = _categoryCars.AllCategories.Last()
                },
                new Car { 
                    name = "Nissan Leaf", 
                    shortDesc = "Быстрый автомобиль", 
                    longDesc = "Красивый, быстрый и очень тихий автомобиль компании Nissan",
                    img = "/img/nissan.jpg", 
                    price = 14000, 
                    isFavourite = true,
                    available = true,
                    category = _categoryCars.AllCategories.First()
                },
            };
        }
    }
    public IEnumerable<Car> getFavCars { get;set;

    }

    public Car getObjectCar(int carId) {
        throw new NotImplementedException();
    }


}