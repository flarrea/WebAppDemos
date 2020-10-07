using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppDemos.Data.Interfaces;
using WebAppDemos.Models;
using WebAppDemos;


namespace WebAppDemos.Controllers
{

    public class EmpleadoController : Controller
    {
        private readonly IGetDataRepository _data;

        public EmpleadoController(IGetDataRepository data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GetNameById(int id)
        {
            return _data.GetNameById(id);
        }
    }
}