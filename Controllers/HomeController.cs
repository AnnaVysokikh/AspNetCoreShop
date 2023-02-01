using itprogershop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using itprogershop.ViewModels;

namespace itprogershop.Controllers;

public class HomeController : Controller {
    private readonly IAllCars _carRep;
    public HomeController(IAllCars carRep) {
        _carRep = carRep;
    }

    public ViewResult Index() {
        var homeCars = new HomeViewModel {
            favCars = _carRep.getFavCars
        };
        return View(homeCars);
    }
}