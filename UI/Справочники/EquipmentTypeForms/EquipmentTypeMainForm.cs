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
                try
                {
                    EquipmentType eqType = Mapper.EquipmentTypeFromDto(addForm.EquipmentType);
                    if (!service.TryValidate(eqType))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Add(eqType);
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
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as EquipmentType;
            if (selectedItem == null) return;

            var eqType = service.GetById<EquipmentType>(selectedItem.Id);
            if (eqType == null) return;

            var updateForm = new EquipmentTypeAddForm(Mapper.EquipmentTypeFromEntity(eqType));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    eqType.Name = updateForm.EquipmentType.Name;

                    if (!service.TryValidate(eqType))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Update(eqType);
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
