using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Models;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/Places")]
    public ActionResult Places()
    {
      List<PlacesObject> allPlaces = PlacesObject.GetAll();
      return View(allPlaces);
    }
    [HttpGet("/Places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/Places")]
    public ActionResult Create()
    {
      PlacesObject newPlace = new PlacesObject(Request.Form["new-place"],Request.Form["new-length"]);
      List<PlacesObject> allPlaces = PlacesObject.GetAll();
      return View("Places", allPlaces);
    }
    [HttpGet("/Places/{id}")]
    public ActionResult Details(int id)
    {
      PlacesObject place = PlacesObject.Find(id);
      return View(place);
    }
    [HttpPost("/Places/delete")]
    public ActionResult DeleteAll()
    {
      PlacesObject.ClearAll();
      return View();
    }

  }
}
