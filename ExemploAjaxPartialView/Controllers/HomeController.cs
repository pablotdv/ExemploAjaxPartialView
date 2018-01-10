using ExemploAjaxPartialView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploAjaxPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            List<DataViewModel> dados = new List<DataViewModel>();

            for (int i = 0; i < 10; i++)
            {
                dados.Add(new DataViewModel() { Id = i, Descricao = $"Descricao {i}", DataHora = DateTime.Now });
            }

            return PartialView("_Data", dados);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}