using Lab1_Uppg4.Models;
using Microsoft.AspNetCore.Mvc;


public class ReceptController : Controller
{
    public IActionResult Index()

    {
        var receptList = new List<ReceptModel>
    {
        new ReceptModel() {Id = 1, Name = "Kanelbullar", BagareId = 2},
        new ReceptModel() {Id = 2, Name = "Biskvi", BagareId = 4},
        new ReceptModel() {Id = 3, Name = "Chokladbollar", BagareId = 1},
        new ReceptModel() {Id = 4, Name = "Kladdkaka", BagareId = 3},
        new ReceptModel() {Id = 5, Name = "Prinsesstårta", BagareId = 3},
        new ReceptModel() 

    };
        return View(receptList);
    }
}

