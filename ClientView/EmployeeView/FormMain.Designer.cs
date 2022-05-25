namespace EmployeeView
{
    partial class FormMain
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
            if (disposing && (components != null))
            {
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxListVisit = new System.Windows.Forms.CheckBox();
            this.buttonListVisit = new System.Windows.Forms.Button();
            this.buttonVisit = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.НомераПоКонфToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.НомераПоКонфExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.НомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(39, 138);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(713, 300);
            this.dataGridView.TabIndex = 4;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Дата";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Остаток";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Имя клиента";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Имя работника";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // checkBoxListVisit
            // 
            this.checkBoxListVisit.AutoSize = true;
            this.checkBoxListVisit.Location = new System.Drawing.Point(118, 90);
            this.checkBoxListVisit.Name = "checkBoxListVisit";
            this.checkBoxListVisit.Size = new System.Drawing.Size(279, 24);
            this.checkBoxListVisit.TabIndex = 6;
            this.checkBoxListVisit.Text = "Включать свободные конференции";
            this.checkBoxListVisit.UseVisualStyleBackColor = true;
            // 
            // buttonListVisit
            // 
            this.buttonListVisit.Location = new System.Drawing.Point(118, 31);
            this.buttonListVisit.Name = "buttonListVisit";
            this.buttonListVisit.Size = new System.Drawing.Size(169, 53);
            this.buttonListVisit.TabIndex = 7;
            this.buttonListVisit.Text = "Получить список приемов";
            this.buttonListVisit.UseVisualStyleBackColor = true;
            this.buttonListVisit.Click += new System.EventHandler(this.buttonListVisit_Click);
            // 
            // buttonVisit
            // 
            this.buttonVisit.Location = new System.Drawing.Point(327, 33);
            this.buttonVisit.Name = "buttonVisit";
            this.buttonVisit.Size = new System.Drawing.Size(158, 51);
            this.buttonVisit.TabIndex = 8;
            this.buttonVisit.Text = "Оформить прием";
            this.buttonVisit.UseVisualStyleBackColor = true;
            this.buttonVisit.Click += new System.EventHandler(this.buttonVisit_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.Location = new System.Drawing.Point(514, 36);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(152, 48);
            this.buttonServices.TabIndex = 9;
            this.buttonServices.Text = "Номера";
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.НомераПоКонфToolStripMenuItem,
            this.НомераПоКонфExcelToolStripMenuItem,
            this.НомераToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // НомераПоКонфToolStripMenuItem
            // 
            this.НомераПоКонфToolStripMenuItem.Name = "НомераПоКонфToolStripMenuItem";
            this.НомераПоКонфToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.НомераПоКонфToolStripMenuItem.Text = "Номера по конф Word";
            this.НомераПоКонфToolStripMenuItem.Click += new System.EventHandler(this.услугиПоВизитамToolStripMenuItem_Click);
            // 
            // НомераПоКонфExcelToolStripMenuItem
            // 
            this.НомераПоКонфExcelToolStripMenuItem.Name = "НомераПоКонфExcelToolStripMenuItem";
            this.НомераПоКонфExcelToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.НомераПоКонфExcelToolStripMenuItem.Text = "Номера по конф Excel";
            this.НомераПоКонфExcelToolStripMenuItem.Click += new System.EventHandler(this.услугиПоВизитамExcelToolStripMenuItem_Click);
            // 
            // НомераToolStripMenuItem
            // 
            this.НомераToolStripMenuItem.Name = "НомераToolStripMenuItem";
            this.НомераToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.НомераToolStripMenuItem.Text = "Список номеров ";
            this.НомераToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonVisit);
            this.Controls.Add(this.buttonListVisit);
            this.Controls.Add(this.checkBoxListVisit);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "Номера";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckBox checkBoxListVisit;
        private System.Windows.Forms.Button buttonListVisit;
        private System.Windows.Forms.Button buttonVisit;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem НомераПоКонфToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem НомераПоКонфExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem НомераToolStripMenuItem;
    }
}