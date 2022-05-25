using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.BusinessLogic;
using HotelBusinessLogic.BusinessLogics;

namespace ClientView
{
    public partial class FormMain : Form
    {
        private ConfLogic confLogic;
        private ReportLogic reportLogic;
        public FormMain(ConfLogic conf, ReportLogic reportLogic)
        {
            this.reportLogic = reportLogic;
            confLogic = conf;
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                var list = confLogic.Read(new ConfBindingModel()
                {
                    ClientId = Program.client.Id
                });
                if (list != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var conf in list)
                    {
                        dataGridView.Rows.Add(new object[] {conf.Id,  conf.ConfsDate, conf.Sum,
                            conf.ClientName, conf.EmployeeName});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelName.Text = Program.client.Name;
            LoadData();
        }

        private void buttonCreateVisit_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormConf>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonDeleteVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        confLogic.Delete(new ConfBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpdateVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormConf>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormPayment>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void визитыПоУслугамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "docx|*.docx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                reportLogic.SaveConfRoomToExcelFile(new ReportBindingModel
                {
                    FileName = dialog.FileName,
                    UserId=Program.client.Id
                });
                MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void визитыПоУслугамExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    reportLogic.SaveConfRoomToExcelFile(new
                    ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        UserId=Program.client.Id
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

        private void списокВизитовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormReportConf>();
            form.ShowDialog();
        }
    }
}
