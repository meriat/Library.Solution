using System;
using System.Collections.Generic;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
  public class PatronsController : Controller
  {
    [HttpGet("/patrons")]
    public ActionResult Index()
    {
      List<Patron> allPatrons = Patron.GetAll();
      return View(allPatrons);
    }
    [HttpPost("/patrons/new")]
    public ActionResult Create(string newPatron)
    {
      Patron newPerson = new Patron(newPatron);
      newPerson.Save();
      return RedirectToAction("Index");
    }

  }
}