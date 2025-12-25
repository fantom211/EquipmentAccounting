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
                if (string.IsNullOrWhiteSpace(nameTextBox1.Text))
                    return null;

                if (string.IsNullOrWhiteSpace(vendorTextBox2.Text))
                    return null;

                if (string.IsNullOrWhiteSpace(keyLicenseTextBox3.Text))
                    return null;

                if (dateTimePicker1.Value.Date < DateTime.Today)
                    return null;


                try
                {
                    return new SoftwareLicenseDto
                    {
                        Name = nameTextBox1.Text,
                        Vendor = vendorTextBox2.Text,
                        LicenseKey = keyLicenseTextBox3.Text,
                        ExpirationDate = DateOnly.FromDateTime(dateTimePicker1.Value)
                    };
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); return null; }

            }
        }
        public SoftLicenseAddForm()
        {
            InitializeComponent();
        }

        public SoftLicenseAddForm(SoftwareLicenseDto dto)
        {
            InitializeComponent();
            nameTextBox1.Text = dto.Name;
            vendorTextBox2.Text = dto.Vendor;
            keyLicenseTextBox3.Text = dto.LicenseKey;
            dateTimePicker1.Value = dto.ExpirationDate.ToDateTime(TimeOnly.MinValue);
        }

        private void SoftLicenseAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if(SoftwareLicense == null)
                {
                    MessageBox.Show("Заполните все поля.");
                    e.Cancel = true;
                }
            }
        }
    }
}
