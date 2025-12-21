using BusinessLogic.Mappers;
using BusinessLogic.Services;
using DAL;
using DAL.Context;
using EquipmentDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Справочники.CRUD_Forms;
using UI.Справочники.EmployeesForms;

namespace UI.Справочники
{
    public partial class EmployeesMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();
        public EmployeesMainForm()
        {
            InitializeComponent();
            _context = new EquipmentContext(new DbContextOptionsBuilder<EquipmentContext>()
                .UseSqlServer(AppConfig.connectionString)
                .Options);

            LoadData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EmployeesAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Employee employee = Mapper.EmployeeFromDto(addForm.Employee);
                service.Add(employee);
            }
            RefreshData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Employee;
            if (selectedItem == null) return;

            var emp = service.GetById<Employee>(selectedItem.Id);
            if (emp == null) return;

            var updateForm = new EmployeesUpdateForm(Mapper.EmployeeFromEntity(emp));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                emp.FullName = updateForm.Employee.FullName;
                emp.Position = updateForm.Employee.Position;
                emp.DepartmentId = updateForm.Employee.DepartmentId;
                service.Update(emp);
                RefreshData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Employee;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<Employee>(index);
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<Employee>();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = service.GetAll<Employee>();
        }

    }
}
