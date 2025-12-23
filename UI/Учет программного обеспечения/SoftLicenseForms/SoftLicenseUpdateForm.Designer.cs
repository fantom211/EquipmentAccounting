namespace UI.Учет_программного_обеспечения
{
    partial class SoftLicenseUpdateForm
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
            nameTextBox1 = new TextBox();
            vendorTextBox2 = new TextBox();
            label2 = new Label();
            keyLicenseTextBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(116, 21);
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(136, 23);
            nameTextBox1.TabIndex = 1;
            // 
            // vendorTextBox2
            // 
            vendorTextBox2.Location = new Point(116, 50);
            vendorTextBox2.Name = "vendorTextBox2";
            vendorTextBox2.Size = new Size(136, 23);
            vendorTextBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 53);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 2;
            label2.Text = "Производитель";
            // 
            // keyLicenseTextBox3
            // 
            keyLicenseTextBox3.Location = new Point(116, 79);
            keyLicenseTextBox3.Name = "keyLicenseTextBox3";
            keyLicenseTextBox3.Size = new Size(136, 23);
            keyLicenseTextBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 82);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Ключ лицензии";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 114);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Дата окончания";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(93, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            // 
            // SoftLicenseUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 178);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(keyLicenseTextBox3);
            Controls.Add(label3);
            Controls.Add(vendorTextBox2);
            Controls.Add(label2);
            Controls.Add(nameTextBox1);
            Controls.Add(label1);
            Name = "SoftLicenseUpdateForm";
            Text = "SoftLicenseUpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox1;
        private TextBox vendorTextBox2;
        private Label label2;
        private TextBox keyLicenseTextBox3;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
    }
}