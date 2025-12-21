namespace UI.Справочники.EmployeesForms
{
    partial class EmployeesAddForm
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
            fullNameTextBox = new TextBox();
            positionTextBox = new TextBox();
            idDepatmentTextBox = new TextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Полное имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 110);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "ID отдела";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(99, 29);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(147, 23);
            fullNameTextBox.TabIndex = 3;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(99, 70);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(147, 23);
            positionTextBox.TabIndex = 4;
            // 
            // idDepatmentTextBox
            // 
            idDepatmentTextBox.Location = new Point(99, 107);
            idDepatmentTextBox.Name = "idDepatmentTextBox";
            idDepatmentTextBox.Size = new Size(147, 23);
            idDepatmentTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.DialogResult = DialogResult.OK;
            addButton.Location = new Point(110, 152);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 201);
            Controls.Add(addButton);
            Controls.Add(idDepatmentTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeesAddForm";
            Text = "EmployeesAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox fullNameTextBox;
        private TextBox positionTextBox;
        private TextBox idDepatmentTextBox;
        private Button addButton;
    }
}