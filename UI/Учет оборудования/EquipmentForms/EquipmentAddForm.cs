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
    public partial class EquipmentAddForm : Form
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
        public EquipmentAddForm()
        {
            InitializeComponent();
        }

        private void EquipmentAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
