using itprogershop.Data.Interfaces;
using itprogershop.Data.Models;

namespace itprogershop.ViewModels;

public class CarsListViewModel {
    public IEnumerable<Car> allCars { get; set; }
    public string currCategory;
}