using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class InstalledSoftwareMapper
    {
        public static InstalledSoftwareDto ToDto(InstalledSoftware entity)
        {
            if (entity == null) return null!;

            return new InstalledSoftwareDto
            {
                EquipmentId = entity.EquipmentId,
                LicenseId = entity.LicenseId,
                InstallDate = entity.InstallDate
            };
        }

        public static InstalledSoftware ToEntity(InstalledSoftwareDto dto)
        {
            if (dto == null) return null!;

            return new InstalledSoftware
            {
                EquipmentId = dto.EquipmentId,
                LicenseId = dto.LicenseId,
                InstallDate = dto.InstallDate
            };
        }

        public static List<InstalledSoftwareDto> ToDtoList(List<InstalledSoftware> entities)
            => entities.Select(e => ToDto(e)).ToList();

        public static List<InstalledSoftware> ToEntityList(List<InstalledSoftwareDto> dtos)
            => dtos.Select(d => ToEntity(d)).ToList();
    }
}
