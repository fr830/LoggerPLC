using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LoggerPLC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LoggerPLC.Controllers
{
    public class ErrorController : Controller
    {
        private IRepository repository;

        public ErrorController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.Errors);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            repository.DeleteError(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete()
        {
            return RedirectToAction("Index");
        }

    }
}
