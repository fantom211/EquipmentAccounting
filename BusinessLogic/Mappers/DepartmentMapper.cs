using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public static class DepartmentMapper
    {
        public static DepartmentDto ToDto(Department dep)
        {
            if (dep == null) return null;

            return new DepartmentDto
            {
                Id = dep.Id,
                Name = dep.Name,
                ManagerId = dep.ManagerId,
                Employees = dep.Employees
                .Select(e => EmployeeMapper.ToDto(e))
                .ToList()
            };
        }

        public static Department ToEntity(DepartmentDto dto)
        {
            if (dto == null) return null;

            return new Department
            {
                Id = dto.Id,
                Name = dto.Name,
                ManagerId = dto.ManagerId,
                Employees = dto.Employees
                .Select(e => EmployeeMapper.ToEntity(e))
                .ToList()
            };
        }

        public static List<DepartmentDto> ToDtoList(List<Department> deps)
        {
            return deps.Select(e => ToDto(e)).ToList();
        }

        public static List<Department> ToEntityList(List<DepartmentDto> dtos)
        {
            return dtos.Select(d => ToEntity(d)).ToList();
        }
    }
}
