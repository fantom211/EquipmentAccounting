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
    public partial class EquipmentTypeUpdateForm : Form
    {
        public EquipmentTypeDto EquipmentType
        {
            get
            {
                EquipmentTypeDto dto = null;
                {
                    try
                    {
                        dto = new EquipmentTypeDto
                        {
                            Name = nameTextBox.Text
                        };
                        
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    return dto;
                }
            }
        }
        public EquipmentTypeUpdateForm(EquipmentTypeDto dto)
        {
            InitializeComponent();
            nameTextBox.PlaceholderText = dto.Name;
        }
    }
}
