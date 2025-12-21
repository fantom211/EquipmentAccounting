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

namespace UI.Справочники.CRUD_Forms
{
    public partial class DepartmentAddForm : Form
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
        }

        public DepartmentAddForm()
        {
            InitializeComponent();
        }

        private void DepartmentAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
