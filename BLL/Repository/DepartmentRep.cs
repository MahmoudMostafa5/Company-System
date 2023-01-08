using BLL.Interfaces;
using BLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Database;
using Template.DAL.Entities;

namespace BLL.Repository
{
    public class DepartmentRep : IDepartmentRep
    {
        //TemplateContext db = new TemplateContext();

        private readonly TemplateContext db;
        public DepartmentRep(TemplateContext db)
        {
            this.db = db;
        }

        public IEnumerable<Department> Get()
        {
            var data = GetAllDEpartment();
            return data;
        }

        public Department GetById(int id)
        {
            var data = GetDepartmentById(id);
            return data;
        }


        public IEnumerable<Department> SearchByName(string Name)
        {
            //IQueryable<DepartmentVM> data = GetDepartmentName(Name);
            var data = GetDepartmentName(Name);

            return data;
        }

        public Department Details(int id)
        {
            //DepartmentVM data = GetDepartmentDetails(id);
            var data = GetDepartmentDetails(id);
            return data;
        }

        public void Create(Department obj)
        {
            //Department dpt = new Department();
            //dpt.Code = obj.Code;
            //dpt.Name = obj.Name;

            db.Department.Add(obj);
            db.SaveChanges();
        }

        public void Update(Department obj)
        {
            //Department dpt = new Department();
            //dpt.Id = obj.Id;
            //dpt.Code = obj.Code;
            //dpt.Name = obj.Name;

            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(Department obj)
        {
            //var OldData = db.Department.Find(obj.Id);

            db.Department.Remove(obj);
            db.SaveChanges();
        }


        //  ------------  Refactor   ------------
        private IQueryable<Department> GetAllDEpartment()
        {
            //return db.Department.Select(x =>
            //            new DepartmentVM { Code = x.Code, Id = x.Id, Name = x.Name });
            return db.Department.Select(x => x);
        }
        private IQueryable<Department> GetDepartmentName(string Name)
        {
            //return db.Department.Where(x => x.Name == Name).Select(x =>
            //new DepartmentVM { Id = x.Id, Name = x.Name, Code = x.Code });

            return db.Department.Where(x => x.Name == Name).Select(x => x);
        }
        private Department GetDepartmentDetails(int id)
        {
            //return db.Department.Where(x => x.Id == id).Select(x =>
            //            new DepartmentVM { Id = x.Id, Name = x.Name, Code = x.Code }).
            //            FirstOrDefault();

            return db.Department.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
        }
        private Department GetDepartmentById(int id)
        {
            //return db.Department.Where(x => x.Id == id)
            //        .Select(x => new DepartmentVM { Code = x.Code, Id = x.Id, Name = x.Name })
            //        .FirstOrDefault();

            return db.Department.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
        }
    }
}
