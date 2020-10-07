using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemos.Models;

namespace WebAppDemos.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public int Add(int lhs, int rhs)
        {
            return lhs + rhs;
        }

        public string GetNombreEmpleado(int empId)
        {
            string nombre;

            if (empId == 1)
            {
                nombre = "Laura";
            }
            else if (empId == 2)
            {
                nombre = "Miguel";
            }
            else
            {
                nombre = "No Encontado";
            }
            return nombre;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
