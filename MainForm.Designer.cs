namespace UberTracker
{
    partial class MainForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.logbookTabPage = new System.Windows.Forms.TabPage();
            this.logbookDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dailySummaryTabPage = new System.Windows.Forms.TabPage();
            this.weeklySummaryTabPage = new System.Windows.Forms.TabPage();
            this.monthlySummaryTabPage = new System.Windows.Forms.TabPage();
            this.earningsTabPage = new System.Windows.Forms.TabPage();
            this.operatingExpensesTabPage = new System.Windows.Forms.TabPage();
            this.drivingStatisticsTabPage = new System.Windows.Forms.TabPage();
            this.dailySummaryDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.weeklySummaryDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.monthlySummaryDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.earningsDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.expensesDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.logbookTabPage.SuspendLayout();
            this.dailySummaryTabPage.SuspendLayout();
            this.weeklySummaryTabPage.SuspendLayout();
            this.monthlySummaryTabPage.SuspendLayout();
            this.earningsTabPage.SuspendLayout();
            this.operatingExpensesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logbookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailySummaryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySummaryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySummaryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.logbookTabPage);
            this.tabControl1.Controls.Add(this.dailySummaryTabPage);
            this.tabControl1.Controls.Add(this.weeklySummaryTabPage);
            this.tabControl1.Controls.Add(this.monthlySummaryTabPage);
            this.tabControl1.Controls.Add(this.earningsTabPage);
            this.tabControl1.Controls.Add(this.operatingExpensesTabPage);
            this.tabControl1.Controls.Add(this.drivingStatisticsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1326, 652);
            this.tabControl1.TabIndex = 3;
            // 
            // logbookTabPage
            // 
            this.logbookTabPage.Controls.Add(this.logbookDataGrid);
            this.logbookTabPage.Location = new System.Drawing.Point(4, 24);
            this.logbookTabPage.Name = "logbookTabPage";
            this.logbookTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logbookTabPage.Size = new System.Drawing.Size(1318, 624);
            this.logbookTabPage.TabIndex = 0;
            this.logbookTabPage.Text = "Ride Logbook";
            this.logbookTabPage.UseVisualStyleBackColor = true;
            // 
            // dailySummaryTabPage
            // 
            this.dailySummaryTabPage.Controls.Add(this.dailySummaryDataGrid);
            this.dailySummaryTabPage.Location = new System.Drawing.Point(4, 24);
            this.dailySummaryTabPage.Name = "dailySummaryTabPage";
            this.dailySummaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dailySummaryTabPage.Size = new System.Drawing.Size(1318, 624);
            this.dailySummaryTabPage.TabIndex = 1;
            this.dailySummaryTabPage.Text = "Daily Summary";
            this.dailySummaryTabPage.UseVisualStyleBackColor = true;
            // 
            // weeklySummaryTabPage
            // 
            this.weeklySummaryTabPage.Controls.Add(this.weeklySummaryDataGrid);
            this.weeklySummaryTabPage.Location = new System.Drawing.Point(4, 24);
            this.weeklySummaryTabPage.Name = "weeklySummaryTabPage";
            this.weeklySummaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.weeklySummaryTabPage.Size = new System.Drawing.Size(1318, 624);
            this.weeklySummaryTabPage.TabIndex = 2;
            this.weeklySummaryTabPage.Text = "Weekly Summary";
            this.weeklySummaryTabPage.UseVisualStyleBackColor = true;
            // 
            // monthlySummaryTabPage
            // 
            this.monthlySummaryTabPage.Controls.Add(this.monthlySummaryDataGrid);
            this.monthlySummaryTabPage.Location = new System.Drawing.Point(4, 24);
            this.monthlySummaryTabPage.Name = "monthlySummaryTabPage";
            this.monthlySummaryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.monthlySummaryTabPage.Size = new System.Drawing.Size(1318, 624);
            this.monthlySummaryTabPage.TabIndex = 3;
            this.monthlySummaryTabPage.Text = "Monthly Summary";
            this.monthlySummaryTabPage.UseVisualStyleBackColor = true;
            // 
            // earningsTabPage
            // 
            this.earningsTabPage.Controls.Add(this.earningsDataGrid);
            this.earningsTabPage.Location = new System.Drawing.Point(4, 24);
            this.earningsTabPage.Name = "earningsTabPage";
            this.earningsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.earningsTabPage.Size = new System.Drawing.Size(1318, 624);
            this.earningsTabPage.TabIndex = 6;
            this.earningsTabPage.Text = "Income & Earnings";
            this.earningsTabPage.UseVisualStyleBackColor = true;
            // 
            // operatingExpensesTabPage
            // 
            this.operatingExpensesTabPage.Controls.Add(this.expensesDataGrid);
            this.operatingExpensesTabPage.Location = new System.Drawing.Point(4, 24);
            this.operatingExpensesTabPage.Name = "operatingExpensesTabPage";
            this.operatingExpensesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.operatingExpensesTabPage.Size = new System.Drawing.Size(1318, 624);
            this.operatingExpensesTabPage.TabIndex = 4;
            this.operatingExpensesTabPage.Text = "Operating Expenses";
            this.operatingExpensesTabPage.UseVisualStyleBackColor = true;
            // 
            // drivingStatisticsTabPage
            // 
            this.drivingStatisticsTabPage.Location = new System.Drawing.Point(4, 24);
            this.drivingStatisticsTabPage.Name = "drivingStatisticsTabPage";
            this.drivingStatisticsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.drivingStatisticsTabPage.Size = new System.Drawing.Size(1318, 624);
            this.drivingStatisticsTabPage.TabIndex = 5;
            this.drivingStatisticsTabPage.Text = "Driving Statistics";
            this.drivingStatisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // logbookDataGrid
            // 
            this.logbookDataGrid.AccessibleName = "Table";
            this.logbookDataGrid.Location = new System.Drawing.Point(6, 6);
            this.logbookDataGrid.Name = "logbookDataGrid";
            this.logbookDataGrid.Size = new System.Drawing.Size(1306, 612);
            this.logbookDataGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.logbookDataGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.logbookDataGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.logbookDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.logbookDataGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.logbookDataGrid.TabIndex = 0;
            this.logbookDataGrid.Text = "logbookDataGrid";
            // 
            // dailySummaryDataGrid
            // 
            this.dailySummaryDataGrid.AccessibleName = "Table";
            this.dailySummaryDataGrid.Location = new System.Drawing.Point(6, 6);
            this.dailySummaryDataGrid.Name = "dailySummaryDataGrid";
            this.dailySummaryDataGrid.Size = new System.Drawing.Size(1306, 612);
            this.dailySummaryDataGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dailySummaryDataGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dailySummaryDataGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dailySummaryDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dailySummaryDataGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dailySummaryDataGrid.TabIndex = 0;
            this.dailySummaryDataGrid.Text = "dailySummaryDataGrid";
            // 
            // weeklySummaryDataGrid
            // 
            this.weeklySummaryDataGrid.AccessibleName = "Table";
            this.weeklySummaryDataGrid.Location = new System.Drawing.Point(6, 6);
            this.weeklySummaryDataGrid.Name = "weeklySummaryDataGrid";
            this.weeklySummaryDataGrid.Size = new System.Drawing.Size(1306, 612);
            this.weeklySummaryDataGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.weeklySummaryDataGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.weeklySummaryDataGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.weeklySummaryDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.weeklySummaryDataGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.weeklySummaryDataGrid.TabIndex = 1;
            this.weeklySummaryDataGrid.Text = "weeklySummaryDataGrid";
            // 
            // monthlySummaryDataGrid
            // 
            this.monthlySummaryDataGrid.AccessibleName = "Table";
            this.monthlySummaryDataGrid.Location = new System.Drawing.Point(6, 6);
            this.monthlySummaryDataGrid.Name = "monthlySummaryDataGrid";
            this.monthlySummaryDataGrid.Size = new System.Drawing.Size(1306, 612);
            this.monthlySummaryDataGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.monthlySummaryDataGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.monthlySummaryDataGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.monthlySummaryDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.monthlySummaryDataGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.monthlySummaryDataGrid.TabIndex = 1;
            this.monthlySummaryDataGrid.Text = "monthlySummaryDataGrid";
            // 
            // earningsDataGrid
            // 
            this.earningsDataGrid.AccessibleName = "Table";
            this.earningsDataGrid.Location = new System.Drawing.Point(6, 6);
            this.earningsDataGrid.Name = "earningsDataGrid";
            this.earningsDataGrid.Size = new System.Drawing.Size(1306, 612);
            this.earningsDataGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.earningsDataGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.earningsDataGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.earningsDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.earningsDataGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.earningsDataGrid.TabIndex = 1;
            this.earningsDataGrid.Text = "earningsDataGrid";
            // 
            // expensesDataGrid
            // 
            this.expensesDataGrid.AccessibleName = "Table";
            this.expensesDataGrid.Location = new System.Drawing.Point(6, 6);
            this.expensesDataGrid.Name = "expensesDataGrid";
            this.expensesDataGrid.Size = new System.Drawing.Size(1306, 612);
            this.expensesDataGrid.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.expensesDataGrid.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expensesDataGrid.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expensesDataGrid.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expensesDataGrid.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expensesDataGrid.TabIndex = 1;
            this.expensesDataGrid.Text = "expensesDataGrid";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "UberTracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.logbookTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logbookDataGrid)).EndInit();
            this.dailySummaryTabPage.ResumeLayout(false);
            this.weeklySummaryTabPage.ResumeLayout(false);
            this.monthlySummaryTabPage.ResumeLayout(false);
            this.earningsTabPage.ResumeLayout(false);
            this.operatingExpensesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dailySummaryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklySummaryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySummaryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earningsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage logbookTabPage;
        private TabPage dailySummaryTabPage;
        private TabPage weeklySummaryTabPage;
        private TabPage monthlySummaryTabPage;
        private TabPage operatingExpensesTabPage;
        private TabPage drivingStatisticsTabPage;
        private TabPage earningsTabPage;
        private Syncfusion.WinForms.DataGrid.SfDataGrid logbookDataGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dailySummaryDataGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid weeklySummaryDataGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid monthlySummaryDataGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid earningsDataGrid;
        private Syncfusion.WinForms.DataGrid.SfDataGrid expensesDataGrid;
    }
}