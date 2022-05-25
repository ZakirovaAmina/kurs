namespace EmployeeView
{
    partial class FormRooms
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
            this.buttonCreateVisit = new System.Windows.Forms.Button();
            this.buttonUpdateVisit = new System.Windows.Forms.Button();
            this.groupeBox = new System.Windows.Forms.GroupBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonDeleteVisit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Column1,
            this.Column2});
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
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Стоимость";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // buttonCreateVisit
            // 
            this.buttonCreateVisit.Location = new System.Drawing.Point(21, 26);
            this.buttonCreateVisit.Name = "buttonCreateVisit";
            this.buttonCreateVisit.Size = new System.Drawing.Size(135, 40);
            this.buttonCreateVisit.TabIndex = 6;
            this.buttonCreateVisit.Text = "Создать";
            this.buttonCreateVisit.UseVisualStyleBackColor = true;
            this.buttonCreateVisit.Click += new System.EventHandler(this.buttonCreateService_Click);
            // 
            // buttonUpdateVisit
            // 
            this.buttonUpdateVisit.Location = new System.Drawing.Point(175, 26);
            this.buttonUpdateVisit.Name = "buttonUpdateVisit";
            this.buttonUpdateVisit.Size = new System.Drawing.Size(126, 40);
            this.buttonUpdateVisit.TabIndex = 7;
            this.buttonUpdateVisit.Text = "Изменить";
            this.buttonUpdateVisit.UseVisualStyleBackColor = true;
            this.buttonUpdateVisit.Click += new System.EventHandler(this.buttonUpdateService_Click);
            // 
            // groupeBox
            // 
            this.groupeBox.Controls.Add(this.buttonPay);
            this.groupeBox.Controls.Add(this.buttonDeleteVisit);
            this.groupeBox.Controls.Add(this.buttonCreateVisit);
            this.groupeBox.Controls.Add(this.buttonUpdateVisit);
            this.groupeBox.Location = new System.Drawing.Point(12, 28);
            this.groupeBox.Name = "groupeBox";
            this.groupeBox.Size = new System.Drawing.Size(597, 84);
            this.groupeBox.TabIndex = 8;
            this.groupeBox.TabStop = false;
            this.groupeBox.Text = "Номера";
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(312, 26);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(126, 40);
            this.buttonPay.TabIndex = 9;
            this.buttonPay.Text = "Обновить";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonDeleteVisit
            // 
            this.buttonDeleteVisit.Location = new System.Drawing.Point(449, 26);
            this.buttonDeleteVisit.Name = "buttonDeleteVisit";
            this.buttonDeleteVisit.Size = new System.Drawing.Size(142, 40);
            this.buttonDeleteVisit.TabIndex = 8;
            this.buttonDeleteVisit.Text = "Удалить";
            this.buttonDeleteVisit.UseVisualStyleBackColor = true;
            this.buttonDeleteVisit.Click += new System.EventHandler(this.buttonDeleteService_Click);
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupeBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormRooms";
            this.Text = "Номера";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupeBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCreateVisit;
        private System.Windows.Forms.Button buttonUpdateVisit;
        private System.Windows.Forms.GroupBox groupeBox;
        private System.Windows.Forms.Button buttonDeleteVisit;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
