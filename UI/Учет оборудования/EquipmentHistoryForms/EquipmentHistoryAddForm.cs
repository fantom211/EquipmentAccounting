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
    }
}
