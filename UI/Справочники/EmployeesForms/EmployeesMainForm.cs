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
        public EmployeesMainForm(EquipmentContext _context)
        {
            InitializeComponent();
            this._context = _context;

            LoadData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EmployeesAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Employee employee = Mapper.EmployeeFromDto(addForm.Employee);
                    if (!service.TryValidate(employee))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Add(employee);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка валидации.");
                }
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Employee;
            if (selectedItem == null) return;

            var emp = service.GetById<Employee>(selectedItem.Id);
            if (emp == null) return;

            var updateForm = new EmployeesAddForm(Mapper.EmployeeFromEntity(emp));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    emp.FullName = updateForm.Employee.FullName;
                    emp.Position = updateForm.Employee.Position;
                    emp.DepartmentId = updateForm.Employee.DepartmentId;

                    if (!service.TryValidate(emp))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Update(emp);
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка валидации.");
                }
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
