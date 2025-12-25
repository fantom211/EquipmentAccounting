using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Справочники.EquipmentTypeForms
{
    public partial class EquipmentTypeAddForm : Form
    {
        public EquipmentTypeDto EquipmentType
        {
            get
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Введите название типа оборудования.");
                    return null;
                }

                try
                {
                    return new EquipmentTypeDto
                    {
                        Name = nameTextBox.Text.Trim()
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при создании типа оборудования: " + ex.Message);
                    return null;
                }
            }
        }

        public EquipmentTypeAddForm()
        {
            InitializeComponent();
        }

        public EquipmentTypeAddForm(EquipmentTypeDto dto)
        {
            InitializeComponent();
            nameTextBox.Text = dto.Name;
        }

        private void EquipmentTypeAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && EquipmentType == null)
            {
                MessageBox.Show("Заполните все поля.");
                e.Cancel = true;
            }
        }
    }
}
