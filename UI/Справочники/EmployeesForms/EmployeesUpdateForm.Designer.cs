namespace UI.Справочники.EmployeesForms
{
    partial class EmployeesUpdateForm
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
            updateButton = new Button();
            idDepatmentTextBox = new TextBox();
            positionTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.DialogResult = DialogResult.OK;
            updateButton.Location = new Point(104, 140);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 13;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // idDepatmentTextBox
            // 
            idDepatmentTextBox.Location = new Point(93, 95);
            idDepatmentTextBox.Name = "idDepatmentTextBox";
            idDepatmentTextBox.Size = new Size(147, 23);
            idDepatmentTextBox.TabIndex = 12;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(93, 58);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(147, 23);
            positionTextBox.TabIndex = 11;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(93, 17);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(147, 23);
            fullNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 98);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "ID отдела";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 8;
            label2.Text = "Должность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 7;
            label1.Text = "Полное имя";
            // 
            // EmployeesUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 186);
            Controls.Add(updateButton);
            Controls.Add(idDepatmentTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeesUpdateForm";
            Text = "EmployeesUpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateButton;
        private TextBox idDepatmentTextBox;
        private TextBox positionTextBox;
        private TextBox fullNameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}