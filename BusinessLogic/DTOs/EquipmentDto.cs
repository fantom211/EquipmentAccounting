using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class EquipmentDto
    {
        public string Name { get; set; } = null!;
        public int TypeId { get; set; }
        public string SerialNumber { get; set; } = null!;
        public int? EmployeeId { get; set; }
        public DateOnly DateAdded { get; set; }
        public string Status { get; set; } = null!;
    }
}
