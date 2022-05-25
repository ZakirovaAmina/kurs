namespace ClientView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateVisit = new System.Windows.Forms.Button();
            this.buttonUpdateVisit = new System.Windows.Forms.Button();
            this.groupeBox = new System.Windows.Forms.GroupBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonDeleteVisit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КонференцииПоНомерамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КонференцииПоНомерамExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКонференцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupeBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(538, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(152, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(26, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Неизвестно";
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
            this.dataGridView.Location = new System.Drawing.Point(34, 104);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(624, 225);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Мои конференции";
            // 
            // buttonCreateVisit
            // 
            this.buttonCreateVisit.Location = new System.Drawing.Point(18, 20);
            this.buttonCreateVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateVisit.Name = "buttonCreateVisit";
            this.buttonCreateVisit.Size = new System.Drawing.Size(118, 30);
            this.buttonCreateVisit.TabIndex = 6;
            this.buttonCreateVisit.Text = "Создать";
            this.buttonCreateVisit.UseVisualStyleBackColor = true;
            this.buttonCreateVisit.Click += new System.EventHandler(this.buttonCreateVisit_Click);
            // 
            // buttonUpdateVisit
            // 
            this.buttonUpdateVisit.Location = new System.Drawing.Point(153, 20);
            this.buttonUpdateVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateVisit.Name = "buttonUpdateVisit";
            this.buttonUpdateVisit.Size = new System.Drawing.Size(110, 30);
            this.buttonUpdateVisit.TabIndex = 7;
            this.buttonUpdateVisit.Text = "Изменить";
            this.buttonUpdateVisit.UseVisualStyleBackColor = true;
            this.buttonUpdateVisit.Click += new System.EventHandler(this.buttonUpdateVisit_Click);
            // 
            // groupeBox
            // 
            this.groupeBox.Controls.Add(this.buttonPay);
            this.groupeBox.Controls.Add(this.buttonDeleteVisit);
            this.groupeBox.Controls.Add(this.buttonCreateVisit);
            this.groupeBox.Controls.Add(this.buttonUpdateVisit);
            this.groupeBox.Location = new System.Drawing.Point(10, 21);
            this.groupeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupeBox.Name = "groupeBox";
            this.groupeBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupeBox.Size = new System.Drawing.Size(522, 63);
            this.groupeBox.TabIndex = 8;
            this.groupeBox.TabStop = false;
            this.groupeBox.Text = "Конференция";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(273, 20);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(110, 30);
            this.buttonPay.TabIndex = 9;
            this.buttonPay.Text = "Оплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonDeleteVisit
            // 
            this.buttonDeleteVisit.Location = new System.Drawing.Point(393, 20);
            this.buttonDeleteVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteVisit.Name = "buttonDeleteVisit";
            this.buttonDeleteVisit.Size = new System.Drawing.Size(124, 30);
            this.buttonDeleteVisit.TabIndex = 8;
            this.buttonDeleteVisit.Text = "Удалить";
            this.buttonDeleteVisit.UseVisualStyleBackColor = true;
            this.buttonDeleteVisit.Click += new System.EventHandler(this.buttonDeleteVisit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.КонференцииПоНомерамToolStripMenuItem,
            this.КонференцииПоНомерамExcelToolStripMenuItem,
            this.списокКонференцийToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // КонференцииПоНомерамToolStripMenuItem
            // 
            this.КонференцииПоНомерамToolStripMenuItem.Name = "КонференцииПоНомерамToolStripMenuItem";
            this.КонференцииПоНомерамToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.КонференцииПоНомерамToolStripMenuItem.Text = "Конференции по номерам Word";
            this.КонференцииПоНомерамToolStripMenuItem.Click += new System.EventHandler(this.визитыПоУслугамToolStripMenuItem_Click);
            // 
            // КонференцииПоНомерамExcelToolStripMenuItem
            // 
            this.КонференцииПоНомерамExcelToolStripMenuItem.Name = "КонференцииПоНомерамExcelToolStripMenuItem";
            this.КонференцииПоНомерамExcelToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.КонференцииПоНомерамExcelToolStripMenuItem.Text = "Конференции по номерам Excel";
            this.КонференцииПоНомерамExcelToolStripMenuItem.Click += new System.EventHandler(this.визитыПоУслугамExcelToolStripMenuItem_Click);
            // 
            // списокКонференцийToolStripMenuItem
            // 
            this.списокКонференцийToolStripMenuItem.Name = "списокКонференцийToolStripMenuItem";
            this.списокКонференцийToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.списокКонференцийToolStripMenuItem.Text = "Список конференций";
            this.списокКонференцийToolStripMenuItem.Click += new System.EventHandler(this.списокВизитовToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.groupeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Мои Конференции";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupeBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateVisit;
        private System.Windows.Forms.Button buttonUpdateVisit;
        private System.Windows.Forms.GroupBox groupeBox;
        private System.Windows.Forms.Button buttonDeleteVisit;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КонференцииПоНомерамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КонференцииПоНомерамExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКонференцийToolStripMenuItem;
    }
}