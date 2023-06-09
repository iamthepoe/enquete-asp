﻿using System.Diagnostics;
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
        if (ModelState.IsValid)
        {
            Repositorio.AdicionarResposta(form);
            return View("Obrigado");
        }
        else
        {
            return View(form);
        }

    }

    [HttpGet]
    public IActionResult Resultado()
    {
        return View(Repositorio.Respostas);
    }

}
