namespace UI.Учет_программного_обеспечения
{
    partial class SoftLicenseAddForm
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
            label4 = new Label();
            keyLicenseTextBox3 = new TextBox();
            label3 = new Label();
            vendorTextBox2 = new TextBox();
            label2 = new Label();
            nameTextBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(87, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 15;
            label4.Text = "Дата окончания";
            // 
            // keyLicenseTextBox3
            // 
            keyLicenseTextBox3.Location = new Point(110, 64);
            keyLicenseTextBox3.Name = "keyLicenseTextBox3";
            keyLicenseTextBox3.Size = new Size(136, 23);
            keyLicenseTextBox3.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 13;
            label3.Text = "Ключ лицензии";
            // 
            // vendorTextBox2
            // 
            vendorTextBox2.Location = new Point(110, 35);
            vendorTextBox2.Name = "vendorTextBox2";
            vendorTextBox2.Size = new Size(136, 23);
            vendorTextBox2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 11;
            label2.Text = "Производитель";
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(110, 6);
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(136, 23);
            nameTextBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // SoftLicenseAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 162);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(keyLicenseTextBox3);
            Controls.Add(label3);
            Controls.Add(vendorTextBox2);
            Controls.Add(label2);
            Controls.Add(nameTextBox1);
            Controls.Add(label1);
            Name = "SoftLicenseAddForm";
            Text = "SoftLicenseAddForm";
            FormClosing += SoftLicenseAddForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox keyLicenseTextBox3;
        private Label label3;
        private TextBox vendorTextBox2;
        private Label label2;
        private TextBox nameTextBox1;
        private Label label1;
    }
}