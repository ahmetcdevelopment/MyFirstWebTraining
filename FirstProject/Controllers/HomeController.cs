using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 24;
        }
        public string Index4()
        {
            return "Bugün hava çok sıcak";
        }
        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){Id =1,KitapAdı="80 günde devri alem",Yazar="Joule Verne"},
                new Kitap(){Id =2,KitapAdı="Az",Yazar="Hakan Günday"},
                new Kitap(){Id =3,KitapAdı="Kinyas ve Kayra",Yazar="Hakan Günday"},


            };
            return View(ktp);
        }
        public IActionResult Index6()
        {
            ViewBag.deger1 = "Merhaba core dersleri devam ediyor";
            ViewBag.deger2 = "Sizden bir ricam var";
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public IActionResult Index9()
        {
            return View();
        }
    }
}
