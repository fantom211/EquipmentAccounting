using BusinessLogic.Mappers;
using BusinessLogic.Services;
using DAL.Context;
using EquipmentDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Учет_программного_обеспечения.InstalledSoftForms
{
    public partial class InstalledSoftMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();

        public InstalledSoftMainForm(EquipmentContext context)
        {
            InitializeComponent();
            this._context = context;
            RefreshData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new InstalledSoftAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    InstalledSoftware installedSoft = Mapper.InstalledSoftwareFromDto(addForm.InstalledSoftware);
                    if (!service.TryValidate(installedSoft))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Add(installedSoft);
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
            var selectedItem = dataGridView1.CurrentRow?.DataBoundItem as InstalledSoftware;
            if (selectedItem == null) return;

            var entity = service.GetById<InstalledSoftware>(selectedItem.Id);
            if (entity == null) return;

            var updateForm = new InstalledSoftAddForm(Mapper.InstalledSoftwareFromEntity(entity));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    entity.EquipmentId = updateForm.InstalledSoftware.EquipmentId;
                    entity.LicenseId = updateForm.InstalledSoftware.LicenseId;
                    entity.InstallDate = updateForm.InstalledSoftware.InstallDate;

                    if (!service.TryValidate(entity))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Update(entity);
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
            var selectedItem = dataGridView1.CurrentRow?.DataBoundItem as InstalledSoftware;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<InstalledSoftware>(index);
            RefreshData();
        }

        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<InstalledSoftware>();
        }
    }
}

