using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class EquipmentTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EquipmentDto> Equipments { get; set; } = new List<EquipmentDto>();
    }
}
