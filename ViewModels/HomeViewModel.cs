using itprogershop.Data.Interfaces;
using itprogershop.Data.Models;

namespace itprogershop.ViewModels;

public class HomeViewModel {
    public IEnumerable<Car> favCars { get; set; }
}