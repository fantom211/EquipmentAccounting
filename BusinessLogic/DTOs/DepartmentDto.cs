using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ManagerId {  get; set; }
        public List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
        public EmployeeDto? Manager { get; set; }
    }
}
