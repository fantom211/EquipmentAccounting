using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.DTOs;
using DAL;

namespace UI.Справочники.Department
{
    public partial class DepartmentUpdateForm : Form
    {
        public DepartmentDto Department
        {
            get
            {
                DepartmentDto dto = null;
                try
                {
                    dto = new DepartmentDto
                    {
                        Name = NameTextBox.Text,
                        ManagerId = Convert.ToInt32(ManagerTextBox.Text),
                    };
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                return dto;
            }
            set
            {

            }
        }

        public DepartmentUpdateForm(DepartmentDto department)
        {
            InitializeComponent();
            NameTextBox.PlaceholderText = department.Name;
            ManagerTextBox.PlaceholderText = Convert.ToString(department.ManagerId);
        }

        private void DepartmentUpdateForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
