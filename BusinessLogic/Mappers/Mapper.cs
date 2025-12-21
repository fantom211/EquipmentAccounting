using BusinessLogic.DTOs;
using BusinessLogic.Services;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class Mapper
    {
        public static Department DepartmentFromDto(DepartmentDto dto)
        {
            return new Department
            {
                Name = dto.Name,
                ManagerId = dto.ManagerId,
            };
        }
        
        public static DepartmentDto DepartmentFromEntity(Department dep)
        {
            return new DepartmentDto
            {
                Name = dep.Name,
                ManagerId = dep.ManagerId
            };
        }

        public static Employee EmployeeFromDto(EmployeeDto employee)
        {
            return new Employee
            {
                FullName = employee.FullName,
                Position = employee.Position,
                DepartmentId = employee.DepartmentId,
            };
        }

        public static EmployeeDto EmployeeFromEntity(Employee emp)
        {
            return new EmployeeDto
            {
                FullName = emp.FullName,
                Position = emp.Position,
                DepartmentId = emp.DepartmentId,
            };
        }
    }
}
