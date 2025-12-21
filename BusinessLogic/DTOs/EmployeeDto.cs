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
        public string FullName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int DepartmentId { get; set; }
    }
}
