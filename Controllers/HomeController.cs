using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.BL.Interfaces;
using WebApp.BL.Models;
using WebApp.BL.Repository;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        #region Fields
        private readonly IDepartmentsRepo departments;
        private readonly IEmployeesRepo employees;
        private readonly IMapper mapper;
        #endregion
        #region Constructor
        public HomeController(IDepartmentsRepo departments,IEmployeesRepo employees,IMapper mapper)
        {
            this.departments = departments;
            this.employees = employees;
            this.mapper = mapper;
        }
        #endregion

        public IActionResult Index()
        {
            var data = employees.Get();
            var result = mapper.Map<IEnumerable<EmployeesVM>>(data);
            return View(result);
        }
    }
}
