using BusinessLogic.Services;
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

namespace UI.Отчеты
{
    public partial class ReportForm : Form
    {
        private Service service = new Service();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void оборудованиеПоПодразделениямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var data = service.GetEquipmentByDepartments();

            var result = data.SelectMany(dept => dept.Equipments.Select(eq => new
            {
                DepartmentName = dept.DepartmentName,
                EquipmentName = eq.Name
            })).ToList();

            dataGridView1.DataSource = result;
        }

        private void списокПОНаКомпьютереСотрудникаXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (comboBox1.SelectedValue == null) return;

            int employeeId = Convert.ToInt32(comboBox1.SelectedValue);
            var softwareList = service.GetSoftwareByEmployee(employeeId);

            dataGridView1.DataSource = softwareList.Select(s => new
            {
                SoftwareName = s.License.Name
            }).ToList();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            var employees = service.GetAll<Employee>();
            comboBox1.DataSource = employees;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
        }
    }
}
