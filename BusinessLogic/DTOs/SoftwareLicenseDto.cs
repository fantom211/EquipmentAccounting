using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class SoftwareLicenseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vendor {  get; set; }
        public string LicenseKey { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public List<InstalledSoftwareDto> InstalledSoftwares { get; set; } = new List<InstalledSoftwareDto>();
    }
}
