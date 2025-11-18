using Microsoft.AspNetCore.Mvc;
using Lab1_Uppg4.Models;


public class BagareController : Controller
{
    public IActionResult Index()
    {
        var bagareLista = new List<BagareModel>
        {
            new BagareModel() { Id = 1, Name = "Adam" },
            new BagareModel() { Id = 2, Name = "Elvira" },
            new BagareModel() {Id = 3, Name = "Mattias"},
            new BagareModel() {Id = 4, Name = "Greta" },
            new BagareModel()
        };

        return View(bagareLista);
    }
}
