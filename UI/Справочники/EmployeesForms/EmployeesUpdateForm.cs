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
    public partial class EmployeesUpdateForm : Form
    {
        public EmployeeDto Employee
        {
            get
            {
                EmployeeDto dto = null;
                try
                {
                    dto = new EmployeeDto
                    {
                        FullName = fullNameTextBox.Text,
                        Position = positionTextBox.Text,
                        DepartmentId = Convert.ToInt32(idDepatmentTextBox.Text)
                    };
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                return dto;
            }
            set
            {

            }
        }

        public EmployeesUpdateForm(EmployeeDto employee)
        {
            InitializeComponent();
            fullNameTextBox.PlaceholderText = employee.FullName;
            positionTextBox.PlaceholderText = employee.Position;
            idDepatmentTextBox.PlaceholderText = Convert.ToString(employee.DepartmentId);
        }
    }
}
