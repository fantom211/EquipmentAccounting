using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public static class EquipmentMapper
    {
        public static EquipmentDto ToDto(Equipment eq)
        {
            if (eq == null) return null;

            return new EquipmentDto
            {
                Id = eq.Id,
                Name = eq.Name,
                TypeId = eq.TypeId,
                SerialNumber = eq.SerialNumber,
                EmployeeId = eq.EmployeeId,
                DateAdded = eq.DateAdded,
                Status = eq.Status
            };
        }
        
        public static Equipment ToEntity(EquipmentDto eqDto)
        {
            if (eqDto == null) return null;

            return new Equipment
            {
                Id = eqDto.Id,
                Name = eqDto.Name,
                TypeId = eqDto.TypeId,
                SerialNumber = eqDto.SerialNumber,
                EmployeeId = eqDto.EmployeeId,
                DateAdded = eqDto.DateAdded,
                Status = eqDto.Status
            };
        }

        public static List<EquipmentDto> ToDtoList(List<Equipment> eqs)
        {
            return eqs.Select(e=>ToDto(e)).ToList();
        }

        public static List<Equipment> ToEntityList(List<EquipmentDto> dtos)
        {
            return dtos.Select(d=>ToEntity(d)).ToList();
        }
    }
}
