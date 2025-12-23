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

namespace UI.Учет_оборудования.EquipmentHistoryForms
{
    public partial class EquipmentHistoryMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();
        public EquipmentHistoryMainForm(EquipmentContext _context)
        {
            InitializeComponent();
            RefreshData();
            this._context = _context;
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EquipmentHistoryAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                EquipmentHistory equipment = Mapper.EquipmentHistoryFromDto(addForm.EquipmentHistory);
                service.Add(equipment);
            }
            RefreshData();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as EquipmentHistory;
            if (selectedItem == null) return;

            var eq = service.GetById<EquipmentHistory>(selectedItem.Id);
            if (eq == null) return;

            var updateForm = new EquipmentHistoryUpdateForm(Mapper.EquipmentHistoryFromEntity(eq));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                eq.EquipmentId = updateForm.EquipmentHistory.EquipmentId;
                eq.DateMoved = updateForm.EquipmentHistory.DateMoved;
                eq.OldEmployeeId = updateForm.EquipmentHistory.OldEmployeeId;
                eq.NewEmployeeId = updateForm.EquipmentHistory.NewEmployeeId;

                service.Update(eq);
                RefreshData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as EquipmentHistory;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<EquipmentHistory>(index);
            RefreshData();
        }

        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<EquipmentHistory>();
        }
    }
}
