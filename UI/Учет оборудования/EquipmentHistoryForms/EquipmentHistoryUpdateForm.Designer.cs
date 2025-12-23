namespace UI.Учет_оборудования.EquipmentHistoryForms
{
    partial class EquipmentHistoryUpdateForm
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
            dateTimePicker1 = new DateTimePicker();
            oldEmpTextBox3 = new TextBox();
            newEmpTextBox2 = new TextBox();
            idEquipmentTextBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(137, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(137, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // oldEmpTextBox3
            // 
            oldEmpTextBox3.Location = new Point(137, 71);
            oldEmpTextBox3.Name = "oldEmpTextBox3";
            oldEmpTextBox3.Size = new Size(181, 23);
            oldEmpTextBox3.TabIndex = 15;
            // 
            // newEmpTextBox2
            // 
            newEmpTextBox2.Location = new Point(137, 102);
            newEmpTextBox2.Name = "newEmpTextBox2";
            newEmpTextBox2.Size = new Size(181, 23);
            newEmpTextBox2.TabIndex = 14;
            // 
            // idEquipmentTextBox1
            // 
            idEquipmentTextBox1.Location = new Point(137, 6);
            idEquipmentTextBox1.Name = "idEquipmentTextBox1";
            idEquipmentTextBox1.Size = new Size(181, 23);
            idEquipmentTextBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 105);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 12;
            label4.Text = "Новый сотрудник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 74);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 11;
            label3.Text = "Прошлый сотрудник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 45);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 10;
            label2.Text = "Дата перемещения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 9;
            label1.Text = "ID оборудования";
            // 
            // EquipmentHistoryUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 171);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(oldEmpTextBox3);
            Controls.Add(newEmpTextBox2);
            Controls.Add(idEquipmentTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EquipmentHistoryUpdateForm";
            Text = "EquipmentHistoryUpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox oldEmpTextBox3;
        private TextBox newEmpTextBox2;
        private TextBox idEquipmentTextBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}