namespace UI.Учет_оборудования.EquipmentHistoryForms
{
    partial class EquipmentHistoryAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idEquipmentTextBox1 = new TextBox();
            newEmpTextBox2 = new TextBox();
            oldEmpTextBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "ID оборудования";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 55);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата перемещения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 84);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 2;
            label3.Text = "Прошлый сотрудник";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 115);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Новый сотрудник";
            // 
            // idEquipmentTextBox1
            // 
            idEquipmentTextBox1.Location = new Point(137, 16);
            idEquipmentTextBox1.Name = "idEquipmentTextBox1";
            idEquipmentTextBox1.Size = new Size(181, 23);
            idEquipmentTextBox1.TabIndex = 4;
            // 
            // newEmpTextBox2
            // 
            newEmpTextBox2.Location = new Point(137, 112);
            newEmpTextBox2.Name = "newEmpTextBox2";
            newEmpTextBox2.Size = new Size(181, 23);
            newEmpTextBox2.TabIndex = 5;
            // 
            // oldEmpTextBox3
            // 
            oldEmpTextBox3.Location = new Point(137, 81);
            oldEmpTextBox3.Name = "oldEmpTextBox3";
            oldEmpTextBox3.Size = new Size(181, 23);
            oldEmpTextBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(137, 141);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // EquipmentHistoryAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 177);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(oldEmpTextBox3);
            Controls.Add(newEmpTextBox2);
            Controls.Add(idEquipmentTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EquipmentHistoryAddForm";
            Text = "EquipmentHistoryAddForm";
            FormClosing += EquipmentHistoryAddForm_FormClosing;
            Load += EquipmentHistoryAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idEquipmentTextBox1;
        private TextBox newEmpTextBox2;
        private TextBox oldEmpTextBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}