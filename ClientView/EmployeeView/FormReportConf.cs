using EmployeeView;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.BusinessLogic;
using HotelBusinessLogic.Interfaces;
using HotelBusinessLogic.ViewModels;

namespace EmployeeView
{
    public partial class FormReportConf : Form
    {
        private readonly ReportViewer reportViewer;
        private readonly ReportLogic _logic;
        private readonly MailWorker worker;
        public FormReportConf(ReportLogic logic, MailWorker mailWorker)
        {
            worker = mailWorker;
            InitializeComponent();
            _logic = logic;
            reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill
            };

            reportViewer.LocalReport.LoadReportDefinition(new
           FileStream("../../../ReportOrder.rdlc", FileMode.Open));
            Controls.Clear();
            Controls.Add(reportViewer);
            Controls.Add(panel);
        }
        private void ButtonMake_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var dataSource = _logic.GetRooms(new ReportBindingModel
                {
                    DateFrom = dateTimePickerFrom.Value,
                    DateTo = dateTimePickerTo.Value
                });
               List<ReportViewerRoomModel> listSource = dataSource.Rooms.Select(r=>new ReportViewerRoomModel()
               {
                   Count = r.Value,
                   Name = r.Key
               }).ToList(); 
                var source = new ReportDataSource("DataSetOrders", listSource);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(source);
                var parameters = new[] { new ReportParameter("ReportParameterPeriod", "c " + dateTimePickerFrom.Value.ToShortDateString() +
                " по " + dateTimePickerTo.Value.ToShortDateString()) };
                reportViewer.LocalReport.SetParameters(parameters);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonToPdf_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _logic.SaveOrdersToPdfFileRoom(new ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        DateFrom = dateTimePickerFrom.Value,
                        DateTo = dateTimePickerTo.Value
                    });
                    MessageBox.Show("Выполнено", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonMail_Click(object sender, EventArgs e)
        {
            var listVisit = _logic.GetRooms(new ReportBindingModel
            {
                DateFrom = dateTimePickerFrom.Value,
                DateTo = dateTimePickerTo.Value
            });
            string str = "";
            foreach(var item in listVisit.Rooms)
            {
                str+=(item.Key + " : " + item.Value+Environment.NewLine);
            }
            str+=(listVisit.Sum.ToString()+Environment.NewLine);
            worker.MailSendAsync(new MailSendInfoBindingModel
            {
                MailAddress = Program.employee.Email,
                Subject = $"Отчет по услугам",
                Text = $"{str}"
            });
        }
    }
}
