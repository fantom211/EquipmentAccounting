using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public void AddEmployee(Employee employee)
        {
            _repository.Add(employee);
        }

        public void DeleteEmployee(int id)
        {
            _repository.Delete(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _repository.Update(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAll();
        }
        
    }
}
