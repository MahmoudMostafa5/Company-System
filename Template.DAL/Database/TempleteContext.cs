using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DAL.Entities;

namespace Template.DAL.Database
{
    public class TemplateContext : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> employee { get; set; }
        public TemplateContext(DbContextOptions<TemplateContext> option) : base(option) { }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server = MAHMOUDMOSTAFA\\SQLEXPRESS ; database = TemplateDb ; Integrated Security = true");
        //}
    }
}
