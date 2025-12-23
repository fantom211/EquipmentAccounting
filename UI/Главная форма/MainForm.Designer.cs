namespace UI.Главная_форма
{
    partial class MainForm
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
            TreeNode treeNode1 = new TreeNode("Подразделения");
            TreeNode treeNode2 = new TreeNode("Сотрудники");
            TreeNode treeNode3 = new TreeNode("Типы оборудования");
            TreeNode treeNode4 = new TreeNode("Справочники", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Оборудование");
            TreeNode treeNode6 = new TreeNode("История перемещений");
            TreeNode treeNode7 = new TreeNode("Учет оборудования", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Лицензии ПО");
            TreeNode treeNode9 = new TreeNode("Установленное ПО");
            TreeNode treeNode10 = new TreeNode("Учет программного обеспечения", new TreeNode[] { treeNode8, treeNode9 });
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            покдлючитьToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            treeView1 = new TreeView();
            panelMain = new Panel();
            toolStrip1 = new ToolStrip();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.5F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panelMain, 1, 1);
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(872, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { покдлючитьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(248, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // покдлючитьToolStripMenuItem
            // 
            покдлючитьToolStripMenuItem.Name = "покдлючитьToolStripMenuItem";
            покдлючитьToolStripMenuItem.Size = new Size(89, 20);
            покдлючитьToolStripMenuItem.Text = "Покдлючить";
            // 
            // panel1
            // 
            panel1.Controls.Add(treeView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 394);
            panel1.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Подразделения";
            treeNode1.Text = "Подразделения";
            treeNode2.Name = "Сотрудники";
            treeNode2.Text = "Сотрудники";
            treeNode3.Name = "Типы оборудования";
            treeNode3.Text = "Типы оборудования";
            treeNode4.Name = "Справочники";
            treeNode4.Text = "Справочники";
            treeNode5.Name = "Оборудование";
            treeNode5.Text = "Оборудование";
            treeNode6.Name = "История перемещений";
            treeNode6.Text = "История перемещений";
            treeNode7.Name = "Учет оборудования";
            treeNode7.Text = "Учет оборудования";
            treeNode8.Name = "Лицензии ПО";
            treeNode8.Text = "Лицензии ПО";
            treeNode9.Name = "Установленное ПО";
            treeNode9.Text = "Установленное ПО";
            treeNode10.Name = "Учет программного обеспечения";
            treeNode10.Text = "Учет программного обеспечения";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7, treeNode10 });
            treeView1.Size = new Size(242, 394);
            treeView1.TabIndex = 4;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(251, 28);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(618, 394);
            panelMain.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(248, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem покдлючитьToolStripMenuItem;
        private Panel panel1;
        private TreeView treeView1;
        private Panel panelMain;
        private ToolStrip toolStrip1;
    }
}