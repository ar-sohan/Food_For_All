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
        public bool AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            return db.SaveChanges() > 0;
        }

    }
}
