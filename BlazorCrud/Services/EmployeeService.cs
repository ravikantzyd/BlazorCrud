using BlazorCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _ctx;
        public EmployeeService(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddUpdate(Employee employee)
        {
            try
            {
                if (employee.Id == 0)
                    _ctx.Employee.Add(employee);
                else
                    _ctx.Employee.Update(employee);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var employee = FindById(id);
                if (employee == null)
                    return false;
                _ctx.Employee.Remove(employee);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Employee FindById(int id)
        {
            return _ctx.Employee.Find(id);
        }

        public List<Employee> GetAll()
        {
            return _ctx.Employee.ToList();
        }
    }
}
