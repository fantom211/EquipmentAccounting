namespace UI.Учет_оборудования
{
    partial class EquipmentUpdateForm
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
            button1 = new Button();
            statusComboBox1 = new ComboBox();
            label5 = new Label();
            idEmployeeTextBox3 = new TextBox();
            label3 = new Label();
            serialNumberTextBox4 = new TextBox();
            label4 = new Label();
            idTypeTextBox = new TextBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(95, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            // 
            // statusComboBox1
            // 
            statusComboBox1.FormattingEnabled = true;
            statusComboBox1.Items.AddRange(new object[] { "В работе", "На списании", "В ремонте" });
            statusComboBox1.Location = new Point(115, 175);
            statusComboBox1.Name = "statusComboBox1";
            statusComboBox1.Size = new Size(138, 23);
            statusComboBox1.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 178);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 30;
            label5.Text = "Статус";
            // 
            // idEmployeeTextBox3
            // 
            idEmployeeTextBox3.Location = new Point(115, 117);
            idEmployeeTextBox3.Name = "idEmployeeTextBox3";
            idEmployeeTextBox3.Size = new Size(140, 23);
            idEmployeeTextBox3.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 120);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 28;
            label3.Text = "ID сотрудника";
            // 
            // serialNumberTextBox4
            // 
            serialNumberTextBox4.Location = new Point(115, 88);
            serialNumberTextBox4.Name = "serialNumberTextBox4";
            serialNumberTextBox4.Size = new Size(140, 23);
            serialNumberTextBox4.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 91);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 26;
            label4.Text = "Серийный номер";
            // 
            // idTypeTextBox
            // 
            idTypeTextBox.Location = new Point(115, 59);
            idTypeTextBox.Name = "idTypeTextBox";
            idTypeTextBox.Size = new Size(140, 23);
            idTypeTextBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 24;
            label2.Text = "ID тип";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(115, 30);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(140, 23);
            nameTextBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 33);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 22;
            label1.Text = "Название";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 152);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 32;
            label6.Text = "Дата добавления";
            // 
            // EquipmentUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 241);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(statusComboBox1);
            Controls.Add(label5);
            Controls.Add(idEmployeeTextBox3);
            Controls.Add(label3);
            Controls.Add(serialNumberTextBox4);
            Controls.Add(label4);
            Controls.Add(idTypeTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "EquipmentUpdateForm";
            Text = "EquipmentUpdateForm";
            Load += EquipmentUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ComboBox statusComboBox1;
        private Label label5;
        private TextBox idEmployeeTextBox3;
        private Label label3;
        private TextBox serialNumberTextBox4;
        private Label label4;
        private TextBox idTypeTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}