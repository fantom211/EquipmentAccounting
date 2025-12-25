using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquipmentDatabase.Models;

namespace BusinessLogic.DTOs
{
    public class DepartmentEquipmentDto
    {
        public string DepartmentName { get; set; }
        public List<Equipment> Equipments { get; set; }
    }
}
