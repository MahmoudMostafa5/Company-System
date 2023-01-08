using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Repository;
using BLL.Models;
using BLL.Interfaces;
using AutoMapper;
using Template.DAL.Entities;

namespace WorkShop.Controllers
{
    public class DepartmentController : Controller
    {
        //tightly coupled
        //DepartmentRep department = new DepartmentRep(); //Declaration

        //Loosly coupled
        //IDepartmentRep department;      //Declaration
        //public DepartmentController(IDepartmentRep _Department)
        //{
        //    this.department = _Department;
        //}

        private readonly IDepartmentRep department;
        private readonly IMapper mapper;

        public DepartmentController(IDepartmentRep department , IMapper mapper)
        {
            this.department = department;
            this.mapper = mapper;
        }

        public IActionResult Index(string SearchValue ="")
        {
            if(SearchValue=="" || SearchValue ==null)
            {
                var data = mapper.Map<IEnumerable<DepartmentVM>>(department.Get());
                return View(data);
            }
            else
            {
                var data = mapper.Map<IEnumerable<DepartmentVM>>(department.SearchByName(SearchValue));
                return View(data);
            }
        }

        public IActionResult Details(int id)
        {
            var data = mapper.Map<DepartmentVM>(department.GetById(id));
            return View(data);
        }
        
        //----------- CREATE ----------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var result = mapper.Map<Department>(model);
                    department.Create(result);
                    return RedirectToAction("Index");
                }

                return View(model);
                
            }catch(Exception ex)
            {
                return View(model);
            }
            
        }

        //----------- Edit ----------
        public IActionResult Edit(int id)
        {
            var data = mapper.Map<DepartmentVM>(department.GetById(id));
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(DepartmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = mapper.Map<Department>(model);

                    department.Update(result);
                    return RedirectToAction("Index");
                }

                return View(model);

            }
            catch (Exception ex)
            {
                return View(model);
            }

        }

        //----------- Delete ----------
        public IActionResult Delete(int id)
        {
            var data = mapper.Map<DepartmentVM>(department.GetById(id));
            return View(data);
        }

        [HttpPost]
        public IActionResult Delete(DepartmentVM model)
        {
            try
            {
                var result = mapper.Map<Department>(model);
                department.Delete(result);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }

        }

        //public IActionResult Search(string SearchValue)
        //{
        //    var data = department.SearchByName(SearchValue);
        //    return View(data);
        //}

    }
}
