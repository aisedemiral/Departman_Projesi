using Microsoft.AspNetCore.Mvc;
using Core_Departmant.Models;

namespace Core_Departmant.Controllers;

public class DepartController : Controller
{
    Context c = new Context();
    
    public IActionResult Index()
    {
        var degerler = c.departmanlars.ToList();
        return View(degerler);
    }
    [HttpGet]
    public IActionResult YeniDepartman()
    {
        return View();
    }
    [HttpPost]
    public IActionResult YeniDepartman(departmanlar d)
    {
        c.departmanlars.Add(d);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DepartmanSil(int id)
    {
        var dep = c.departmanlars.Find(id);
        c.departmanlars.Remove(dep);
        c.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DepartmanGetir(int id)
    {
        var depart = c.departmanlars.Find(id);
        return View("DepartmanGetir",depart);
    }

    public IActionResult DepartmanGuncelle(departmanlar d)
    {
        var dep = c.departmanlars.Find(d.id);
        dep.departmanAd = d.departmanAd;
        c.SaveChanges();
        return RedirectToAction("Index");
    }
   
}