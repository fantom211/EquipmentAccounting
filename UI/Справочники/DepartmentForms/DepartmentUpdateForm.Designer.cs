namespace UI.Справочники.Department
{
    partial class DepartmentUpdateForm
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
            AddButton = new Button();
            label3 = new Label();
            label2 = new Label();
            ManagerTextBox = new TextBox();
            NameTextBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.DialogResult = DialogResult.OK;
            AddButton.Location = new Point(89, 113);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 11;
            AddButton.Text = "Обновить";
            AddButton.UseVisualStyleBackColor = true;
            //AddButton.Click += this.AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 70);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "ID руководителя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "Название";
            // 
            // ManagerTextBox
            // 
            ManagerTextBox.Location = new Point(109, 67);
            ManagerTextBox.Name = "ManagerTextBox";
            ManagerTextBox.Size = new Size(139, 23);
            ManagerTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(109, 26);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(139, 23);
            NameTextBox.TabIndex = 7;
            // 
            // DepartmentUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 156);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ManagerTextBox);
            Controls.Add(NameTextBox);
            Name = "DepartmentUpdateForm";
            Text = "DepartmentUpdateForm";
            Load += DepartmentUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label3;
        private Label label2;
        private TextBox ManagerTextBox;
        private TextBox NameTextBox;
    }
}