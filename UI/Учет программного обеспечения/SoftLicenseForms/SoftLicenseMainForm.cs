using BusinessLogic.DTOs;
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
using UI.Учет_оборудования;

namespace UI.Учет_программного_обеспечения
{
    public partial class SoftLicenseMainForm : Form
    {
        private readonly EquipmentContext _context;
        private Service service = new Service();
        public SoftLicenseMainForm(EquipmentContext context)
        {
            InitializeComponent();
            RefreshData();
            this._context = context;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new SoftLicenseAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SoftwareLicense softLicense = Mapper.SoftwareLicenseFromDto(addForm.SoftwareLicense);
                    if (!service.TryValidate(softLicense))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Add(softLicense);
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
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as SoftwareLicense;
            if (selectedItem == null) return;

            var sl = service.GetById<SoftwareLicense>(selectedItem.Id);
            if (sl == null) return;

            var updateForm = new SoftLicenseAddForm(Mapper.SoftwareLicenseFromEntity(sl));
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sl.Name = updateForm.SoftwareLicense.Name;
                    sl.Vendor = updateForm.SoftwareLicense.Vendor;
                    sl.LicenseKey = updateForm.SoftwareLicense.LicenseKey;
                    sl.ExpirationDate = updateForm.SoftwareLicense.ExpirationDate;

                    if (!service.TryValidate(sl))
                    {
                        MessageBox.Show("Ошибка валидации.");
                        return;
                    }

                    service.Update(sl);
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
            var selectedItem = dataGridView1.CurrentRow.DataBoundItem as SoftwareLicense;
            if (selectedItem == null) return;

            int index = selectedItem.Id;

            service.Delete<SoftwareLicense>(index);
            RefreshData();
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = service.GetAll<SoftwareLicense>();
        }
    }
}
