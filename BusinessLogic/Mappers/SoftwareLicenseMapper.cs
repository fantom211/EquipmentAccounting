using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class SoftwareLicenseMapper
    {
        public static SoftwareLicenseDto ToDto(SoftwareLicense entity)
        {
            if (entity == null) return null!;

            return new SoftwareLicenseDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Vendor = entity.Vendor,
                LicenseKey = entity.LicenseKey,
                ExpirationDate = entity.ExpirationDate,
                InstalledSoftwares = entity.InstalledSoftwares
                .Select(s => InstalledSoftwareMapper.ToDto(s))
                .ToList()
            };
        }

        public static SoftwareLicense ToEntity(SoftwareLicenseDto dto)
        {
            if (dto == null) return null!;

            return new SoftwareLicense
            {
                Id = dto.Id,
                Name = dto.Name,
                Vendor = dto.Vendor,
                LicenseKey = dto.LicenseKey,
                ExpirationDate = dto.ExpirationDate,
                InstalledSoftwares = dto.InstalledSoftwares
                .Select(s => InstalledSoftwareMapper.ToEntity(s))
                .ToList()
            };
        }

        public static List<SoftwareLicenseDto> ToDtoList(List<SoftwareLicense> entities)
            => entities.Select(e => ToDto(e)).ToList();

        public static List<SoftwareLicense> ToEntityList(List<SoftwareLicenseDto> dtos)
            => dtos.Select(d => ToEntity(d)).ToList();
    }
}
