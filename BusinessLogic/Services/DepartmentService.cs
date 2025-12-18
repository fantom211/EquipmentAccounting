using BusinessLogic.Interfaces;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class DepartmentService
    {
        public class DepartmentService
        {
            private readonly IRepository<Department> _repository;

            public DepartmentService(IRepository<Department> repository)
            {
                _repository = repository;
            }

            public void AddDepartment(Department department)
            {
                _repository.Add(department);
            }

            public void DeleteDepartment(int id)
            {
                _repository.Delete(id);
            }

            public void UpdateDepartment(Department department)
            {
                _repository.Update(department);
            }

            public Department GetDepartmentById(int id)
            {
                return _repository.GetById(id);
            }

            public List<Department> GetAllDepartments()
            {
                return _repository.GetAll();
            }
        }
    }
}
