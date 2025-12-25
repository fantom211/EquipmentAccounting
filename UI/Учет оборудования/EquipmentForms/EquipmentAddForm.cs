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
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название оборудования.");
                    return null;
                }

                if (!int.TryParse(idTypeTextBox.Text, out int typeId))
                {
                    MessageBox.Show("Введите корректный ID типа оборудования.");
                    return null;
                }

                if (!int.TryParse(idEmployeeTextBox3.Text, out int employeeId))
                {
                    MessageBox.Show("Введите корректный ID сотрудника.");
                    return null;
                }

                if (string.IsNullOrWhiteSpace(serialNumberTextBox4.Text))
                {
                    MessageBox.Show("Введите серийный номер оборудования.");
                    return null;
                }

                if (statusComboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Выберите статус оборудования.");
                    return null;
                }

                try
                {
                    return new EquipmentDto
                    {
                        Name = nameTextBox.Text.Trim(),
                        TypeId = typeId,
                        SerialNumber = serialNumberTextBox4.Text.Trim(),
                        EmployeeId = employeeId,
                        DateAdded = DateOnly.FromDateTime(dateTimePicker1.Value),
                        Status = statusComboBox1.SelectedItem.ToString()
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании оборудования: " + ex.Message);
                    return null;
                }
            }
        }
        public EquipmentAddForm()
        {
            InitializeComponent();
        }
        public EquipmentAddForm(EquipmentDto dto)
        {
            InitializeComponent();
            nameTextBox.Text = dto.Name;
            idTypeTextBox.Text = dto.TypeId.ToString();
            serialNumberTextBox4.Text = dto.SerialNumber;
            idEmployeeTextBox3.Text = dto.EmployeeId.ToString();
            dateTimePicker1.Value = dto.DateAdded.ToDateTime(TimeOnly.MinValue);
            statusComboBox1.SelectedText = dto.Status;
        }
        private void EquipmentAddForm_Load(object sender, EventArgs e)
        {

        }
        private void EquipmentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && Equipment == null)
            {
                MessageBox.Show("Заполните все поля.");
                e.Cancel = true;
            }
        }
    }
}
