using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public static class EmployeeMapper
    {
        public static EmployeeDto ToDto(Employee emp)
        {
            if (emp == null) return null;

            return new EmployeeDto
            {
                Id = emp.Id,
                FullName = emp.FullName,
                Position = emp.Position,
                DepartmentId = emp.DepartmentId,
                Departments = emp.Departments
                .Select(e => DepartmentMapper.ToDto(e))
                .ToList(),
                Equipments = emp.Equipment
                .Select(e => EquipmentMapper.ToDto(e))
                .ToList(),
                EqHistNewEmployees = emp.EquipmentHistoryNewEmployees
                .Select(e => EquipmentHistoryMapper.ToDto(e))
                .ToList(),
                EqHistOldEmployees = emp.EquipmentHistoryOldEmployees
                .Select(e => EquipmentHistoryMapper.ToDto(e))
                .ToList(),
            };
        }

        public static Employee ToEntity(EmployeeDto dto)
        {
            if (dto == null) return null;

            return new Employee
            {
                Id = dto.Id,
                FullName = dto.FullName,
                Position = dto.Position,
                DepartmentId = dto.DepartmentId,
                Departments = dto.Departments
                .Select(e => DepartmentMapper.ToEntity(e))
                .ToList(),
                Equipment = dto.Equipments
                .Select(e => EquipmentMapper.ToEntity(e))
                .ToList(),
                EquipmentHistoryNewEmployees = dto.EqHistNewEmployees
                .Select(e => EquipmentHistoryMapper.ToEntity(e))
                .ToList(),
                EquipmentHistoryOldEmployees = dto.EqHistOldEmployees
                .Select(e => EquipmentHistoryMapper.ToEntity(e))
                .ToList(),
            };
        }
        public static List<EmployeeDto> ToDtoList(List<Employee> employees)
        {
            return employees.Select(e => ToDto(e)).ToList();
        }
        public static List<Employee> ToEntityList(List<EmployeeDto> dtos)
        {
            return dtos.Select(e => ToEntity(e)).ToList();
        }
    }
}
