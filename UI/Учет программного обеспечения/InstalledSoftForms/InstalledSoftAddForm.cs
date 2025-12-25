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

namespace UI.Учет_программного_обеспечения.InstalledSoftForms
{
    public partial class InstalledSoftAddForm : Form
    {
        public InstalledSoftwareDto InstalledSoftware
        {
            get
            {
                if (!int.TryParse(idEquipTextBox1.Text, out int equipmentId))
                {
                    MessageBox.Show("Введите корректный ID оборудования.");
                    return null;
                }

                if (!int.TryParse(idLicenseTextBox2.Text, out int licenseId))
                {
                    MessageBox.Show("Введите корректный ID лицензии.");
                    return null;
                }

                try
                {
                    return new InstalledSoftwareDto
                    {
                        EquipmentId = equipmentId,
                        LicenseId = licenseId,
                        InstallDate = DateOnly.FromDateTime(dateTimePicker1.Value)
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании установленного ПО: " + ex.Message);
                    return null;
                }
            }
        }
        public InstalledSoftAddForm()
        {
            InitializeComponent();
        }

        public InstalledSoftAddForm(InstalledSoftwareDto dto)
        {
            InitializeComponent();
            idEquipTextBox1.Text = dto.EquipmentId.ToString();
            idLicenseTextBox2.Text = dto.LicenseId.ToString();
            dateTimePicker1.Value = dto.InstallDate.ToDateTime(TimeOnly.MinValue);
        }

        private void InstalledSoftAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && InstalledSoftware == null)
            {
                MessageBox.Show("Заполните все поля.");
                e.Cancel = true;
            }
        }
    }
}
