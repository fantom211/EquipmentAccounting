using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public static class EquipmentTypeMapper
    {
        public static EquipmentTypeDto ToDto(EquipmentType type)
        {
            if (type == null) return null!;

            return new EquipmentTypeDto
            {
                Id = type.Id,
                Name = type.Name,
                Equipments = type.Equipment
                .Select(e => EquipmentMapper.ToDto(e))
                .ToList()
            };
        }

        public static EquipmentType ToEntity(EquipmentTypeDto dto)
        {
            if (dto == null) return null!;

            return new EquipmentType
            {
                Id = dto.Id,
                Name = dto.Name,
                Equipment = dto.Equipments
                .Select(eDto => EquipmentMapper.ToEntity(eDto))
                .ToList()
            };
        }

        public static List<EquipmentTypeDto> ToDtoList(List<EquipmentType> types)
            => types.Select(t => ToDto(t)).ToList();

        public static List<EquipmentType> ToEntityList(List<EquipmentTypeDto> dtos)
            => dtos.Select(d => ToEntity(d)).ToList();
    }
}
