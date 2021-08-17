using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.BL.Interfaces;
using WebApp.BL.Models;
using WebApp.DAL.Entity;

namespace WebApp.Controllers
{
    public class EmployeesController : Controller
    {

        #region Fields
        private readonly IEmployeesRepo employees;
        private readonly IDepartmentsRepo departments;
        private readonly ICountriesRepo countries;
        private readonly ICitiesRepo cities;
        private readonly IDistrictsRepo districts;
        private readonly IMapper mapper;
        #endregion
        #region Constructor
        public EmployeesController(IEmployeesRepo employees,
                                   IDepartmentsRepo departments,
                                   ICountriesRepo countries,
                                   ICitiesRepo cities,
                                   IDistrictsRepo districts,
                                   IMapper mapper)
        {
            this.employees = employees;
            this.departments = departments;
            this.countries = countries;
            this.cities = cities;
            this.districts = districts;
            this.mapper = mapper;
        }
        #endregion
        #region Actions
        public IActionResult Index(string SearchValue = null)
        {
            if (SearchValue == null || SearchValue == "")
            {
                var data = employees.Get();
                var result = mapper.Map<IEnumerable<EmployeesVM>>(data);
                return View(result);
            }
            else
            {
                var data = employees.SearchByName(SearchValue);
                var result = mapper.Map<IEnumerable<EmployeesVM>>(data);
                return View(result);
            }

        }

        public IActionResult Details(int id)
        {

            var data = employees.GetByID(id);
            var result = mapper.Map<EmployeesVM>(data);
            return View(result);
        }

        public IActionResult Create()
        {
          
            ViewBag.DepartmentsList = new SelectList(departments.Get(), "Id", "DepartmentName");
            ViewBag.CountriesList = new SelectList(countries.Get(), "Id", "Name");
            
           

            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeesVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Employees>(model);
                    employees.Create(data);
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

            var data = employees.GetByID(id);
            var result = mapper.Map<EmployeesVM>(data);

            ViewBag.DepartmentsList = new SelectList(departments.Get(), "Id", "DepartmentName", data.DepartmentId);
            ViewBag.CountriesList = new SelectList(countries.Get(), "Id", "Name");
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(EmployeesVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Employees>(model);
                    employees.Edit(data);
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

            var data = employees.GetByID(id);
            var result = mapper.Map<EmployeesVM>(data);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(EmployeesVM model)
        {
            try
            {
                var oldData = employees.GetByID(model.Id);
                employees.Delete(oldData);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                return View();
            }

        }

        #endregion
        #region Ajax calls
        [HttpPost]
        public JsonResult GetDataByCountryId(int CtryId)
        {
            var data = cities.Get().Where(x => x.CountryId == CtryId);
            return Json(data);                   
        }
        [HttpPost]
        public JsonResult GetDataByCityId(int CtyId)
        {
            var data = districts.Get().Where(x => x.CityId == CtyId);
            return Json(data);
        }

        #endregion
    }
}
