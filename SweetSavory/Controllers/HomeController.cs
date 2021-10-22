using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using SweetSavory.Models;
using System.Linq;

namespace SweetSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetSavoryContext _db;

    public HomeController(SweetSavoryContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      dynamic model = new ExpandoObject();
      model.Treats = _db.Treats.ToList();
      model.Flavors = _db.Flavors.ToList();
      return View(model);
    }
  }
}