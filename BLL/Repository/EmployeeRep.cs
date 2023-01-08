using BLL.Interfaces;
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
    public class EmployeeRep : IEmployeeRep
    {
        private readonly TemplateContext db;
        public EmployeeRep(TemplateContext db)
        {
            this.db = db;
        }
        public IEnumerable<Employee> Get()
        {
            var data = GetAllEmployee();
            return data;
        }

        public Employee GetById(int id)
        {
            var data = GetEmployeeById(id);
            return data;
        }

        public IEnumerable<Employee> SearchByName(string Name)
        {
            var data = GetEmployeeName(Name);

            return data;
        }

        public Employee Details(int id)
        {
            var data = GetEmployeeDetails(id);
            return data;
        }

        public void Create(Employee obj)
        {
            db.employee.Add(obj);
            db.SaveChanges();
        }
        
        public void Update(Employee obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
        
        public void Delete(Employee obj)
        {
            db.employee.Remove(obj);
            db.SaveChanges();
        }

        //  ------------  Refactor   ------------
        private IQueryable<Employee> GetAllEmployee()
        {
            return db.employee.Include("Department").Select(x => x);
        }
        private IQueryable<Employee> GetEmployeeName(string Name)
        {
            return db.employee.Include("Department").Where(x => x.Name == Name).Select(x => x);
        }
        private Employee GetEmployeeDetails(int id)
        {
            return db.employee.Include("Department").Where(x => x.Id == id).Select(x => x).FirstOrDefault();
        }
        private Employee GetEmployeeById(int id)
        {
            return db.employee.Include("Department").Where(x => x.Id == id).Select(x => x).FirstOrDefault();
        }
    }
}
