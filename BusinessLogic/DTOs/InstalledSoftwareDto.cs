using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class InstalledSoftwareDto
    {
        public int EquipmentId { get; set; }
        public int LicenseId { get; set; }
        public DateOnly InstallDate { get; set; }
    }
}
