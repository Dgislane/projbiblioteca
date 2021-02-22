using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string senha)
        {
            if(login != "admin" || senha != "123")
            {
                ViewData["Erro"] = "Senha inválida";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("user", "admin");
                return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
