using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class EquipmentHistoryMapper
    {
        public static EquipmentHistoryDto ToDto(EquipmentHistory eqh)
        {
            if (eqh == null) return null;

            return new EquipmentHistoryDto
            {
                Id = eqh.Id,
                EquipmentId = eqh.EquipmentId,
                DateMoved = eqh.DateMoved,
                OldEmployeeId = eqh.OldEmployeeId,
                NewEmployeeId = eqh.NewEmployeeId
            };
        }

        public static EquipmentHistory ToEntity(EquipmentHistoryDto dto)
        {
            if (dto == null) return null;

            return new EquipmentHistory
            {
                Id = dto.Id,
                EquipmentId = dto.EquipmentId,
                DateMoved = dto.DateMoved,
                OldEmployeeId = dto.OldEmployeeId,
                NewEmployeeId = dto.NewEmployeeId
            };
        }

        public static List<EquipmentHistoryDto> ToDtoList(List<EquipmentHistory> eqhs)
        {
            return eqhs.Select(e => ToDto(e)).ToList();
        }

        public static List<EquipmentHistory> ToEntityList(List<EquipmentHistoryDto> dtos)
        {
            return dtos.Select(d => ToEntity(d)).ToList();
        }
    }
}
