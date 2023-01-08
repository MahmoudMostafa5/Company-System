using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Entities;

namespace BLL.Interfaces
{
    public interface IEmployeeRep
    {
        IEnumerable<Employee> Get();
        Employee GetById(int id);
        IEnumerable<Employee> SearchByName(string Name);
        Employee Details(int id);
        void Create(Employee obj);
        void Update(Employee obj);
        void Delete(Employee obj);
    }
}
