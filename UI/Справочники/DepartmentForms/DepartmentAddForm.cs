using BusinessLogic.DTOs;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Справочники.CRUD_Forms
{
    public partial class DepartmentAddForm : Form
    {
        public DepartmentDto Department
        {
            get
            {
                if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                    return null;

                if (!int.TryParse(ManagerTextBox.Text, out int managerId))
                    return null;

                try
                {
                    return new DepartmentDto
                    {
                        Name = NameTextBox.Text.Trim(),
                        ManagerId = managerId
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании отдела: " + ex.Message);
                    return null;
                }
                
            }
        }

        public DepartmentAddForm()
        {
            InitializeComponent();
        }

        public DepartmentAddForm(DepartmentDto dto)
        {
            InitializeComponent();
            NameTextBox.Text = dto.Name;
            ManagerTextBox.Text = Convert.ToString(dto.ManagerId);
        }

        private void DepartmentAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if(Department == null)
                {
                    MessageBox.Show("Заполните все поля.");
                    e.Cancel = true;
                }
            }
        }
    }
}
