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
using UI.Справочники.Department;
using UI.Справочники.EquipmentTypeForms;

namespace UI.Справочники
{
    public partial class EquipmentTypeMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();
        public EquipmentTypeMainForm(EquipmentContext _context)
        {
            InitializeComponent();
            this._context = _context;

            RefreshData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EquipmentTypeAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                EquipmentType equipmentType = Mapper.EquipmentTypeFromDto(addForm.EquipmentType);
                service.Add(equipmentType);
            }
            RefreshData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as EquipmentType;
            if (selectedItem == null) return;

            var eqType = service.GetById<EquipmentType>(selectedItem.Id);
            if (eqType == null) return;

            var updateForm = new EquipmentTypeUpdateForm(Mapper.EquipmentTypeFromEntity(eqType));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                eqType.Name = updateForm.EquipmentType.Name;
                service.Update(eqType);
                RefreshData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as EquipmentType;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<EquipmentType>(index);
            RefreshData();
        }

        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<EquipmentType>();
        }
    }
}
