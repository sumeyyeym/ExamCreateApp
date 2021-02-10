using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Areas.Admin.Controllers
{
    public class ExamsController : Controller
    {
        private readonly IExamService _examService;
        public ExamsController(IExamService examService)
        {
            _examService = examService;
        }

        public IActionResult Index()
        {
            var exams = _examService.GetAll();
            return View(exams);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Exam exam)
        {
            if (ModelState.IsValid)
            {
                _examService.Add(exam);
                bool result = _examService.Save() > 0;
                if (result)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(exam);
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = _examService.GetById(id.Value);
            if (exam == null)
            {
                return NotFound();
            }
            return View(exam);

        }

        public IActionResult Delete(Guid? id)
        {
            if (id.HasValue)
            {
                var exam = _examService.GetById(id.Value);
                if (exam == null)
                {
                    return NotFound();
                }

                _examService.Remove(exam);
                _examService.Save();
            }
            return RedirectToAction("Index");
        }
    }
}