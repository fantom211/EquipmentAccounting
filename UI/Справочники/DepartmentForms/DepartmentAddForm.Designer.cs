namespace UI.Справочники.CRUD_Forms
{
    partial class DepartmentAddForm
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
            NameTextBox = new TextBox();
            ManagerTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(105, 34);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(139, 23);
            NameTextBox.TabIndex = 1;
            // 
            // ManagerTextBox
            // 
            ManagerTextBox.Location = new Point(105, 75);
            ManagerTextBox.Name = "ManagerTextBox";
            ManagerTextBox.Size = new Size(139, 23);
            ManagerTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 37);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 78);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "ID руководителя";
            // 
            // AddButton
            // 
            AddButton.DialogResult = DialogResult.OK;
            AddButton.Location = new Point(85, 121);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DepartmentAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 174);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ManagerTextBox);
            Controls.Add(NameTextBox);
            Name = "DepartmentAddForm";
            Text = "DepartmentAddForm";
            FormClosing += DepartmentAddForm_FormClosing;
            Load += DepartmentAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameTextBox;
        private TextBox ManagerTextBox;
        private Label label2;
        private Label label3;
        private Button AddButton;
    }
}