namespace ClientView
{
    partial class FormReportConf
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.С = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMake = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonMail = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(35, 16);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(147, 23);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(224, 16);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(138, 23);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // С
            // 
            this.С.AutoSize = true;
            this.С.Location = new System.Drawing.Point(3, 20);
            this.С.Name = "С";
            this.С.Size = new System.Drawing.Size(15, 15);
            this.С.TabIndex = 2;
            this.С.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "по";
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(375, 16);
            this.buttonMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(108, 22);
            this.buttonMake.TabIndex = 4;
            this.buttonMake.Text = "Сформировать";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.ButtonMake_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(489, 17);
            this.buttonPdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(82, 22);
            this.buttonPdf.TabIndex = 5;
            this.buttonPdf.Text = "В pdf";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.ButtonToPdf_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonMail);
            this.panel.Controls.Add(this.buttonPdf);
            this.panel.Controls.Add(this.С);
            this.panel.Controls.Add(this.dateTimePickerFrom);
            this.panel.Controls.Add(this.buttonMake);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.dateTimePickerTo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(694, 58);
            this.panel.TabIndex = 6;
            // 
            // buttonMail
            // 
            this.buttonMail.Location = new System.Drawing.Point(577, 17);
            this.buttonMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMail.Name = "buttonMail";
            this.buttonMail.Size = new System.Drawing.Size(97, 22);
            this.buttonMail.TabIndex = 6;
            this.buttonMail.Text = "На почту";
            this.buttonMail.UseVisualStyleBackColor = true;
            this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
            // 
            // FormReportConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 334);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReportConf";
            this.Text = "Отчет";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label С;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonMail;
    }
}