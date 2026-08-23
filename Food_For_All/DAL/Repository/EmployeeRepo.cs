using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class EmployeeRepo
    {
        FoodForAllContext db;
        public EmployeeRepo(FoodForAllContext db) { 
            this.db = db;
        }

        public List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return db.Employees.FirstOrDefault(e => e.Id == id);
        }

        public bool CreateEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            return db.SaveChanges() > 0;
        }

        public bool DeleteEmployee(int id) { 
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                db.Employees.Remove(employee);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            var existingEmployee = GetEmployeeById(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Email = employee.Email;
                existingEmployee.Phone = employee.Phone;
                existingEmployee.Status = employee.Status;
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
