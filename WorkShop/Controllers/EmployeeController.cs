using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template.DAL.Entities;

namespace WorkShop.Controllers
{
    public class EmployeeController : Controller
    {
        #region Field
        private readonly IDepartmentRep department;
        private readonly IEmployeeRep Employee;
        private readonly IMapper mapper;
        #endregion

        #region Constructor
        public EmployeeController(IEmployeeRep Employee, IMapper mapper , IDepartmentRep department )
        {
            this.Employee = Employee;
            this.department = department;
            this.mapper = mapper;
        }

        #endregion

        #region Actions
        public IActionResult Index(string SearchValue = "")
        {
            if (SearchValue == "" || SearchValue == null)
            {
                var data = mapper.Map<IEnumerable<EmployeeVM>>(Employee.Get());
                return View(data);
            }
            else
            {
                var data = mapper.Map<IEnumerable<EmployeeVM>>(Employee.SearchByName(SearchValue));
                return View(data);
            }
        }

        public IActionResult Details(int id)
        {
            var data = mapper.Map<EmployeeVM>(Employee.GetById(id));
            return View(data);
        }

        //----------- CREATE ----------
        public IActionResult Create()
        {
            ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = mapper.Map<Employee>(model);
                    Employee.Create(result);
                    return RedirectToAction("Index");
                }
                ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name");
                return View(model);

            }
            catch (Exception ex)
            {
                ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name");
                return View(model);
            }

        }

        //----------- Edit ----------
        public IActionResult Edit(int id)
        {
            var data = mapper.Map<EmployeeVM>(Employee.GetById(id));
            ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name", data.DepartmentId);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = mapper.Map<Employee>(model);

                    Employee.Update(result);
                    return RedirectToAction("Index");
                }
                ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name", model.DepartmentId);
                return View(model);

            }
            catch (Exception ex)
            {
                ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name", model.DepartmentId);
                return View(model);
            }

        }

        //----------- Delete ----------
        public IActionResult Delete(int id)
        {
            var data = mapper.Map<EmployeeVM>(Employee.GetById(id));
            ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name", data.DepartmentId);
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(EmployeeVM model)
        {
            try
            {
                var result = mapper.Map<Employee>(model);
                Employee.Delete(result);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.DepartmentList = new SelectList(department.Get(), "Id", "Name", model.DepartmentId);
                return View(model);
            }

        }

        #endregion

        #region Ajax Call

        #endregion
    }
}
