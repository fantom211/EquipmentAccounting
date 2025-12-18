using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int DepartmentId { get; set; }
        public List<DepartmentDto> Departments {get; set;}
        public List<EquipmentDto> Equipments {get; set; } = new List<EquipmentDto>();
        public List<EquipmentHistoryDto> EqHistNewEmployees { get; set; } = new List<EquipmentHistoryDto>();
        public List<EquipmentHistoryDto> EqHistOldEmployees { get; set; } = new List<EquipmentHistoryDto>();
    }
}
