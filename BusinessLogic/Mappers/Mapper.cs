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

        public static EquipmentType EquipmentTypeFromDto(EquipmentTypeDto dto)
        {
            return new EquipmentType
            {
                Name = dto.Name
            };
        }

        public static EquipmentTypeDto EquipmentTypeFromEntity(EquipmentType entity)
        {
            return new EquipmentTypeDto
            {
                Name = entity.Name
            };
        }

        public static Equipment EquipmentFromDto(EquipmentDto dto)
        {
            return new Equipment
            {
                Name = dto.Name,
                TypeId = dto.TypeId,
                SerialNumber = dto.SerialNumber,
                DateAdded = dto.DateAdded,
                EmployeeId = dto.EmployeeId,
                Status = dto.Status
            };
        }

        public static EquipmentDto EquipmentFromEntity(Equipment entity)
        {
            return new EquipmentDto
            {
                Name = entity.Name,
                TypeId = entity.TypeId,
                SerialNumber = entity.SerialNumber,
                DateAdded = entity.DateAdded,
                EmployeeId = entity.EmployeeId,
                Status = entity.Status
            };
        }

        public static SoftwareLicense SoftwareLicenseFromDto(SoftwareLicenseDto dto)
        {
            return new SoftwareLicense
            {
                Name = dto.Name,
                LicenseKey = dto.LicenseKey,
                Vendor = dto.Vendor,
                ExpirationDate = dto.ExpirationDate
            };
        }

        public static SoftwareLicenseDto SoftwareLicenseFromEntity(SoftwareLicense entity)
        {
            return new SoftwareLicenseDto
            {
                Name = entity.Name,
                LicenseKey = entity.LicenseKey,
                Vendor = entity.Vendor,
                ExpirationDate = entity.ExpirationDate
            };
        }

        public static EquipmentHistory EquipmentHistoryFromDto(EquipmentHistoryDto dto)
        {
            return new EquipmentHistory
            {
                EquipmentId = dto.EquipmentId,
                DateMoved = dto.DateMoved,
                OldEmployeeId = dto.OldEmployeeId,
                NewEmployeeId = dto.NewEmployeeId
            };
        }

        public static EquipmentHistoryDto EquipmentHistoryFromEntity(EquipmentHistory entity)
        {
            return new EquipmentHistoryDto
            {
                EquipmentId = entity.EquipmentId,
                DateMoved = entity.DateMoved,
                OldEmployeeId = entity.OldEmployeeId,
                NewEmployeeId = entity.NewEmployeeId
            };
        }
    }
}
