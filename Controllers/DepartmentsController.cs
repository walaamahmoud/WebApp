using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.BL.Interfaces;
using WebApp.BL.Models;
using WebApp.DAL.Entity;

namespace WebApp.Controllers
{
    public class DepartmentsController : Controller
    {

        #region Fields
        private readonly IDepartmentsRepo departments;
        private readonly IMapper mapper;
        #endregion
        #region Constructor
        public DepartmentsController(IDepartmentsRepo departments, IMapper mapper)
        {
            this.departments = departments;
            this.mapper = mapper;
        }
        #endregion
        #region Actions
        public IActionResult Index(string SearchValue = null)
        {
            if (SearchValue == null || SearchValue == "")
            {
                var data = departments.Get();
                var result = mapper.Map<IEnumerable<DepartmentsVM>>(data);
                return View(result);
            }
            else
            {
                var data = departments.SearchByName(SearchValue);
                var result = mapper.Map<IEnumerable<DepartmentsVM>>(data);
                return View(result);
            }

        }
        public IActionResult Details(int id)
        {

            var data = departments.GetByID(id);
            var result = mapper.Map<DepartmentsVM>(data);
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentsVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Departments>(model);
                    departments.Create(data);
                    return RedirectToAction("Index");
                }
                return View();

            }
            catch (Exception)
            {
                return View();
            }

        }
        public IActionResult Edit(int id)
        {

            var data = departments.GetByID(id);
            var result = mapper.Map<DepartmentsVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentsVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Departments>(model);
                    departments.Edit(data);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception)
            {
                return View();
            }
        }
        public IActionResult Delete(int id)
        {

            var data = departments.GetByID(id);
            var result = mapper.Map<DepartmentsVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(DepartmentsVM model)
        {
            try
            {
                var oldData = departments.GetByID(model.Id);
                departments.Delete(oldData);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }

        }
        #endregion


    }
}
