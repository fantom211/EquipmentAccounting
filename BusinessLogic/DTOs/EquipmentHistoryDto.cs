using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class EquipmentHistoryDto
    {
        public int EquipmentId { get; set; }
        public DateOnly DateMoved { get; set; }
        public int? OldEmployeeId {  get; set; }
        public int? NewEmployeeId {  get; set; }
    }
}
