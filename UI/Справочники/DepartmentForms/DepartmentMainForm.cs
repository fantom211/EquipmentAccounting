using BusinessLogic.DTOs;
using BusinessLogic.Mappers;
using BusinessLogic.Services;
using DAL;
using DAL.Context;
using EquipmentDatabase.Models;
using Microsoft.EntityFrameworkCore;
using UI.Ñïğàâî÷íèêè.CRUD_Forms;
using UI.Ñïğàâî÷íèêè.Department;

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

        private void äîáàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new DepartmentAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Department department = Mapper.DepartmentFromDto(addForm.Department);
                service.Add(department);
            }
            RefreshData();
        }

        private void èçìåíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Department;
            if (selectedItem == null) return;

            var dept = service.GetById<Department>(selectedItem.Id);
            if (dept == null) return;

            var updateForm = new DepartmentUpdateForm(Mapper.DepartmentFromEntity(dept));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                dept.Name = updateForm.Department.Name;
                dept.ManagerId = updateForm.Department.ManagerId;
                service.Update(dept);
                RefreshData();
            }
        }

        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
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
