using AutoMapper;
using BLL.Models;
using DAL.EF.Tables;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class EmployeeService
    {
        EmployeeRepo repo;
        IMapper mapper;
        public EmployeeService(EmployeeRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public List<Employee> GetAllEmployees()
        {
            var data = repo.GetAllEmployees();
            var mapped = mapper.Map<List<Employee>>(data);
            return mapped;
        }

        public Employee GetEmployeeById(int id)
        {
            var data = repo.GetEmployeeById(id);
            var mapped = mapper.Map<Employee>(data);
            return mapped;
        }

        public bool CreateEmployee(EmployeeModel employee)
        {
            var mapped = mapper.Map<Employee>(employee);
            return repo.CreateEmployee(mapped);
        }

        public bool DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public bool UpdateEmployee(EmployeeModel employee)
        {
            var mapped = mapper.Map<Employee>(employee);
            return repo.UpdateEmployee(mapped);
        }
    }
}
