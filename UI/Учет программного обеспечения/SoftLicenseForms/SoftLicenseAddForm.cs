using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Учет_программного_обеспечения
{
    public partial class SoftLicenseAddForm : Form
    {
        public SoftwareLicenseDto SoftwareLicense
        {
            get
            {
                SoftwareLicenseDto dto = null;
                try
                {
                    dto = new SoftwareLicenseDto
                    {
                        Name = nameTextBox1.Text,
                        Vendor = vendorTextBox2.Text,
                        LicenseKey = keyLicenseTextBox3.Text,
                        ExpirationDate = DateOnly.FromDateTime(dateTimePicker1.Value)
                    };
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                return dto;
            }
        }
        public SoftLicenseAddForm()
        {
            InitializeComponent();
        }
    }
}
