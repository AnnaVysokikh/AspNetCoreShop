using itprogershop.Data.Interfaces;
using itprogershop.Data.Models;

namespace itprogershop.Data.mocks;

public class MockCategory : ICarsCategory {
    public IEnumerable<Category> AllCategories {
        get {
            return new List<Category> {
                new Category { categoryName = "Электромобили", desc = "Современный вид транспорта"},
                new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
            };
        }
    }

}