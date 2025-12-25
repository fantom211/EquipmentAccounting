using BusinessLogic.DTOs;
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

namespace UI.Учет_оборудования.EquipmentHistoryForms
{
    public partial class EquipmentHistoryAddForm : Form
    {
        public EquipmentHistoryDto EquipmentHistory
        {
            get
            {
                EquipmentHistoryDto dto = null;
                try
                {
                    dto = new EquipmentHistoryDto
                    {
                        EquipmentId = Convert.ToInt32(idEquipmentTextBox1.Text),
                        DateMoved = DateOnly.FromDateTime(dateTimePicker1.Value),
                        OldEmployeeId = Convert.ToInt32(oldEmpTextBox3.Text),
                        NewEmployeeId = Convert.ToInt32(newEmpTextBox2.Text),
                    };
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                return dto;
            }
        }
        public EquipmentHistoryAddForm()
        {
            InitializeComponent();
        }

        public EquipmentHistoryAddForm(EquipmentHistoryDto dto)
        {
            InitializeComponent();
            idEquipmentTextBox1.Text = dto.EquipmentId.ToString();
            dateTimePicker1.Value = dto.DateMoved.ToDateTime(TimeOnly.MinValue);
            oldEmpTextBox3.Text = dto.OldEmployeeId.ToString();
            newEmpTextBox2.Text = dto.NewEmployeeId.ToString();
        }

        private void EquipmentHistoryAddForm_Load(object sender, EventArgs e)
        {

        }

        private void EquipmentHistoryAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK && EquipmentHistory == null)
            {
                MessageBox.Show("Заполните все поля.");
                e.Cancel = true;
            }
        }
    }
}
