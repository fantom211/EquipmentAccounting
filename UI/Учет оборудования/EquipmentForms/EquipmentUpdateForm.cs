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

namespace UI.Учет_оборудования
{
    public partial class EquipmentUpdateForm : Form
    {
        public EquipmentDto Equipment
        {
            get
            {
                EquipmentDto dto = null;
                try
                {
                    dto = new EquipmentDto
                    {
                        Name = nameTextBox.Text,
                        TypeId = Convert.ToInt32(idTypeTextBox.Text),
                        SerialNumber = serialNumberTextBox4.Text.ToString(),
                        EmployeeId = Convert.ToInt32(idEmployeeTextBox3.Text),
                        DateAdded = DateOnly.FromDateTime(dateTimePicker1.Value),
                        Status = statusComboBox1.SelectedItem.ToString()
                    };
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                return dto;
            }

        }
        public EquipmentUpdateForm(EquipmentDto dto)
        {
            InitializeComponent();
            nameTextBox.Text = dto.Name;
            idTypeTextBox.Text = dto.TypeId.ToString();
            serialNumberTextBox4.Text = dto.SerialNumber;
            idEmployeeTextBox3.Text = dto.EmployeeId.ToString();
            dateTimePicker1.Value = dto.DateAdded.ToDateTime(TimeOnly.MinValue);
            statusComboBox1.SelectedText = dto.Status;
        }

        private void EquipmentUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
