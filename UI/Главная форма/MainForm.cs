using DAL;
using DAL.Context;
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
using UI.Справочники;
using UI.Учет_оборудования;
using UI.Учет_оборудования.EquipmentHistoryForms;
using UI.Учет_программного_обеспечения;
using UI.Учет_программного_обеспечения.InstalledSoftForms;

namespace UI.Главная_форма
{
    public partial class MainForm : Form
    {
        private Form? currentForm;
        private readonly EquipmentContext _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new EquipmentContext(new DbContextOptionsBuilder<EquipmentContext>()
            .UseSqlServer(AppConfig.connectionString)
            .Options);
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            currentForm?.Close();

            Form formToOpen = null;

            switch (selectedNode.Text)
            {
                case "Подразделения":
                    formToOpen = new DepartmentMainForm(_context);
                    break;
                case "Сотрудники":
                    formToOpen = new EmployeesMainForm(_context);
                    break;
                case "Типы оборудования":
                    formToOpen = new EquipmentTypeMainForm(_context);
                    break;
                case "Оборудование":
                    formToOpen = new EquipmentMainForm(_context);
                    break;
                case "История перемещений":
                    formToOpen = new EquipmentHistoryMainForm(_context);
                    break;
                case "Лицензии ПО":
                    formToOpen = new InstalledSoftMainForm();
                    break;
                case "Установленное ПО":
                    formToOpen = new SoftLicenseMainForm(_context);
                    break;
            }
            if (formToOpen != null)
            {
                currentForm = formToOpen;
                formToOpen.TopLevel = false; // Чтобы форма была дочерней внутри MainForm
                formToOpen.FormBorderStyle = FormBorderStyle.None;
                formToOpen.Dock = DockStyle.Fill;
                this.panelMain.Controls.Clear(); // panelMain — панель для отображения форм
                this.panelMain.Controls.Add(formToOpen);
                formToOpen.Show();
            }
        }
    }
}
