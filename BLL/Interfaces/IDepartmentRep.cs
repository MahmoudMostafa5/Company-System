using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Entities;

namespace BLL.Interfaces
{
    public interface IDepartmentRep
    {
        IEnumerable<Department> Get();
        Department GetById(int id);
        IEnumerable<Department> SearchByName(string Name);
        Department Details(int id);
        //IEnumerable<DepartmentVM> GetById(int id);

        void Create(Department obj);
        void Update(Department obj);
        void Delete(Department obj); 
    }
}
