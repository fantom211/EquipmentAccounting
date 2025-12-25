using BusinessLogic.DTOs;
using BusinessLogic.Mappers;
using BusinessLogic.Services;
using DAL;
using DAL.Context;
using EquipmentDatabase.Models;
using Microsoft.EntityFrameworkCore;
using UI.Справочники.CRUD_Forms;

namespace UI
{
    public partial class DepartmentMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();
        public DepartmentMainForm(EquipmentContext _context)
        {
            InitializeComponent();

            this._context = _context;

            RefreshData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new DepartmentAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Department department = Mapper.DepartmentFromDto(addForm.Department);
                    if (!service.TryValidate(department))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }
                        
                    service.Add(department);
                    RefreshData();
                }
                catch (Exception ex) { MessageBox.Show("Ошибка валидации"); }
            }  
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Department;
            if (selectedItem == null) return;

            var dept = service.GetById<Department>(selectedItem.Id);
            if (dept == null) return;

            var updateForm = new DepartmentAddForm(Mapper.DepartmentFromEntity(dept));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dept.Name = updateForm.Department.Name;
                    dept.ManagerId = updateForm.Department.ManagerId;
                    if (!service.TryValidate(dept))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }
                    service.Update(dept);
                    RefreshData();
                }
                catch (Exception ex) { MessageBox.Show("Ошибка валидации."); }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Department;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<Department>(index);
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<Department>();
        }

        private void DepartmentMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
