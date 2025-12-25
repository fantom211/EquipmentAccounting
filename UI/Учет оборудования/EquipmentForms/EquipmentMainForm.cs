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

namespace UI.Учет_оборудования
{
    public partial class EquipmentMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();
        public EquipmentMainForm(EquipmentContext _context)
        {
            InitializeComponent();
            this._context = _context;

            RefreshData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new EquipmentAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Equipment eq = Mapper.EquipmentFromDto(addForm.Equipment);
                    if (!service.TryValidate(eq))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Add(eq);
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
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Equipment;
            if (selectedItem == null) return;

            var eq = service.GetById<Equipment>(selectedItem.Id);
            if (eq == null) return;

            var updateForm = new EquipmentAddForm(Mapper.EquipmentFromEntity(eq));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    eq.Name = updateForm.Equipment.Name;
                    eq.EmployeeId = updateForm.Equipment.EmployeeId;
                    eq.SerialNumber = updateForm.Equipment.SerialNumber;
                    eq.TypeId = updateForm.Equipment.TypeId;
                    eq.DateAdded = updateForm.Equipment.DateAdded;
                    eq.Status = updateForm.Equipment.Status;

                    if (!service.TryValidate(eq))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Update(eq);
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
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as Equipment;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<Equipment>(index);
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<Equipment>();
        }
    }
}
