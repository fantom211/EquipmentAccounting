namespace UI.Учет_оборудования
{
    partial class EquipmentAddForm
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
            statusComboBox1 = new ComboBox();
            label5 = new Label();
            idEmployeeTextBox3 = new TextBox();
            label3 = new Label();
            serialNumberTextBox4 = new TextBox();
            label4 = new Label();
            idTypeTextBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            nameTextBox = new TextBox();
            label1 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // statusComboBox1
            // 
            statusComboBox1.FormattingEnabled = true;
            statusComboBox1.Items.AddRange(new object[] { "В работе", "На списании", "В ремонте" });
            statusComboBox1.Location = new Point(119, 169);
            statusComboBox1.Name = "statusComboBox1";
            statusComboBox1.Size = new Size(138, 23);
            statusComboBox1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 172);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 20;
            label5.Text = "Статус";
            // 
            // idEmployeeTextBox3
            // 
            idEmployeeTextBox3.Location = new Point(119, 104);
            idEmployeeTextBox3.Name = "idEmployeeTextBox3";
            idEmployeeTextBox3.Size = new Size(140, 23);
            idEmployeeTextBox3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 107);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 18;
            label3.Text = "ID сотрудника";
            // 
            // serialNumberTextBox4
            // 
            serialNumberTextBox4.Location = new Point(119, 75);
            serialNumberTextBox4.Name = "serialNumberTextBox4";
            serialNumberTextBox4.Size = new Size(140, 23);
            serialNumberTextBox4.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 78);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 16;
            label4.Text = "Серийный номер";
            // 
            // idTypeTextBox
            // 
            idTypeTextBox.Location = new Point(119, 46);
            idTypeTextBox.Name = "idTypeTextBox";
            idTypeTextBox.Size = new Size(140, 23);
            idTypeTextBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 49);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 14;
            label2.Text = "ID тип";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(108, 198);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(119, 17);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(140, 23);
            nameTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "Название";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 143);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 22;
            label6.Text = "Дата добавления";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // EquipmentAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 245);
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
            Controls.Add(button1);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "EquipmentAddForm";
            Text = "EquipmentAddForm";
            FormClosing += EquipmentAddForm_FormClosing;
            Load += EquipmentAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox statusComboBox1;
        private Label label5;
        private TextBox idEmployeeTextBox3;
        private Label label3;
        private TextBox serialNumberTextBox4;
        private Label label4;
        private TextBox idTypeTextBox;
        private Label label2;
        private Button button1;
        private TextBox nameTextBox;
        private Label label1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}