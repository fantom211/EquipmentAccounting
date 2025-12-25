using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class SoftwareLicenseDto
    {
        public string Name { get; set; }
        public string Vendor {  get; set; }
        public string LicenseKey { get; set; }
        public DateOnly ExpirationDate { get; set; }
    }
}
