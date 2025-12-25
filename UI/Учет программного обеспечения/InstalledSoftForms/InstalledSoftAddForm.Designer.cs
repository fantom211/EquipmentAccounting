namespace UI.Учет_программного_обеспечения.InstalledSoftForms
{
    partial class InstalledSoftAddForm
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
            idEquipTextBox1 = new TextBox();
            idLicenseTextBox2 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "ID оборудования";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 44);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "ID лицензии";
            // 
            // idEquipTextBox1
            // 
            idEquipTextBox1.Location = new Point(116, 12);
            idEquipTextBox1.Name = "idEquipTextBox1";
            idEquipTextBox1.Size = new Size(148, 23);
            idEquipTextBox1.TabIndex = 2;
            // 
            // idLicenseTextBox2
            // 
            idLicenseTextBox2.Location = new Point(116, 41);
            idLicenseTextBox2.Name = "idLicenseTextBox2";
            idLicenseTextBox2.Size = new Size(148, 23);
            idLicenseTextBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 76);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата установки";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(100, 106);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // InstalledSoftAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 141);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(idLicenseTextBox2);
            Controls.Add(idEquipTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InstalledSoftAddForm";
            Text = "InstalledSoftAddForm";
            FormClosing += InstalledSoftAddForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox idEquipTextBox1;
        private TextBox idLicenseTextBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}