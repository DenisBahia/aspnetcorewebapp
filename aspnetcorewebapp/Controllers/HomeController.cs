using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcorewebapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcorewebapp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [HttpPost]
        public IActionResult Index(HomeModel form)
        {
            CarregaDados();
            if (form.id != 0)
            {
                HomeModel item = new HomeModel();
                item.id = form.id;
                item.Nome = form.Nome;
                ViewBag.lista.Add(item);
            }

            return View();
        }

        public void CarregaDados()
        {
            HomeModel objHomeModel = new HomeModel();
            ViewBag.lista = objHomeModel.GetAll();
        }

    }
}