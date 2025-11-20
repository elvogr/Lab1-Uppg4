using Lab1_Uppg4.Models;
using Microsoft.AspNetCore.Mvc;


public class ReceptController : Controller
{
        private static List<ReceptModel> _recept = new()
    {
        new ReceptModel() {Id = 1, Name = "Kanelbullar", BagareNamn = "Elvira"},
        new ReceptModel() {Id = 2, Name = "Biskvi", BagareNamn = "Greta"},
        new ReceptModel() {Id = 3, Name = "Chokladbollar", BagareNamn = "Adam"},
        new ReceptModel() {Id = 4, Name = "Kladdkaka", BagareNamn = "Mattias"},
        new ReceptModel() {Id = 5, Name = "Prinsesstårta", BagareNamn = "Mattias"},
        new ReceptModel() 

    };


    public IActionResult Index()
    {
        return View(_recept); // skicka listan till vyn
    }

    // GET: visar formuläret
    [HttpGet]
    public IActionResult Formular()
    {
        return View();
    }

    // POST: tar emot data från formuläret
    [HttpPost]
    public IActionResult Formular(ReceptModel model)
    {
        if (!ModelState.IsValid)
        {
            // Om nåt saknas, visa samma formulär igen
            return View(model);
        }

        // Sätt ett nytt Id och lägg till i listan
        model.Id = _recept.Any() ? _recept.Max(r => r.Id) + 1 : 1;
        _recept.Add(model);

        // Efter att vi sparat: gå tillbaka till tabellen
        return RedirectToAction("Index");
    }
}

