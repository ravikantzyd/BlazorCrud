using BlazorCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public interface IEmployeeService
    {
        bool AddUpdate(Employee employee);
        bool Delete(int id);
        Employee FindById(int id);
        List<Employee> GetAll();
    }
}
