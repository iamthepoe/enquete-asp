using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using enquete_asp.Models;

namespace enquete_asp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Responder(RespostaModel form)
    {
        Repositorio.AdicionarResposta(form);
        return View("Obrigado");
    }

}
