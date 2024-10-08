using Core_Departmant.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Departmant.Controllers;

public class personelController : Controller
{
    Context c = new Context();
    public IActionResult Index()
    {

        var degerler = c.Personels.ToList();
        return View(degerler);
    }
}