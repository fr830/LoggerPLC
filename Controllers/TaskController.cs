using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LoggerPLC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LoggerPLC.Controllers
{
    public class TaskController : Controller
    {
        private IRepository repository;

        public TaskController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
             return View(repository.Tasks);
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            repository.DeleteTask(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            return View(repository.Tasks.Where(p => p.TaskName == id).First());
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            repository.EditTask(task); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
           return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {   
                repository.CreateTask(task);
                return RedirectToAction("Index");
        }


        public IActionResult Error(int id)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
