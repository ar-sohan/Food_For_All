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

        public List<EmployeeModel> GetAllEmployees()
        {
            var employees = repo.GetAllEmployees();
            return mapper.Map<List<EmployeeModel>>(employees);
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            var employee = repo.GetEmployeeById(id);
            return mapper.Map<EmployeeModel>(employee);
        }

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            var employee = mapper.Map<Employee>(employeeModel);
            return repo.AddEmployee(employee);
        }
    }
}
