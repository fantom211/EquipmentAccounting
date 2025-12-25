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

namespace UI.Справочники.EmployeesForms
{
    public partial class EmployeesAddForm : Form
    {
        public EmployeeDto Employee
        {
            get
            {
                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                {
                    MessageBox.Show("Введите ФИО сотрудника.");
                    return null;
                }

                if (string.IsNullOrWhiteSpace(positionTextBox.Text))
                {
                    MessageBox.Show("Введите должность сотрудника.");
                    return null;
                }

                if (!int.TryParse(idDepatmentTextBox.Text, out int departmentId))
                {
                    MessageBox.Show("Введите корректный ID отдела.");
                    return null;
                }

                try
                {
                    return new EmployeeDto
                    {
                        FullName = fullNameTextBox.Text.Trim(),
                        Position = positionTextBox.Text.Trim(),
                        DepartmentId = departmentId
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании сотрудника: " + ex.Message);
                    return null;
                }
            }
        }

        public EmployeesAddForm()
        {
            InitializeComponent();
        }

        public EmployeesAddForm(EmployeeDto employee)
        {
            InitializeComponent();
            fullNameTextBox.Text = employee.FullName;
            positionTextBox.Text = employee.Position;
            idDepatmentTextBox.Text = Convert.ToString(employee.DepartmentId);
        }

        private void EmployeesAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && Employee == null)
            {
                MessageBox.Show("Заполните все поля.");
                e.Cancel = true;
            }
        }
    }
}
