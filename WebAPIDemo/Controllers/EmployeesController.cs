using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeDataAccess;
using System.Net;
using System.Net.Http;

namespace WebAPIDemo.Controllers
{
    //public class EmployeesController : Controller
    //{
    //    public IEnumerable<Employee> Get()
    //    {
    //        using (EmployeeDBEntities entities = new EmployeeDBEntities())
    //        {
    //            return entities.Employees.ToList();
    //        }   
    //    }

    //    public Employee Get(int id)
    //    {
    //        using (EmployeeDBEntities entities = new EmployeeDBEntities())
    //        {
    //            return entities.Employees.FirstOrDefault(e => e.ID == id);
    //        }
    //    }
}