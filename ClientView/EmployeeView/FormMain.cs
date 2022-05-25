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
using HotelBusinessLogic.ViewModels;

namespace EmployeeView
{
    public partial class FormMain : Form
    {
        private ConfLogic confLogic;
        private readonly ReportLogic reportLogic;
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
                List<ConfViewModel> list;
                if (checkBoxListVisit.Checked)
                {
                    list = confLogic.ReadEmployee(new ConfBindingModel());//вернет все свободные
                    list.AddRange(confLogic.ReadEmployee(new ConfBindingModel() { EmployeeId = Program.employee.Id }));//добавит привязанные к текущему
                }
                else
                {
                    list = confLogic.ReadEmployee(new ConfBindingModel()
                    {
                        EmployeeId = Program.employee.Id
                    });
                }
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
            checkBoxListVisit.Checked = true;
            LoadData();
        }

        private void buttonListVisit_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                var conf = confLogic.Read(new ConfBindingModel() { Id = id })[0];
                confLogic.CreateOrUpdate(new ConfBindingModel()
                {
                    Id = id,
                    ClientId = conf.ClientId,
                    Sum = conf.Sum,
                    RoomId = conf.RoomId,
                    ConfsDate = conf.ConfsDate,
                    EmployeeId = Program.employee.Id,
                    ConfRooms= conf.ConfRooms
                });
            }
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormRooms>();
            form.ShowDialog();
        }

        private void услугиПоВизитамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "docx|*.docx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                reportLogic.SaveRoomConfToWordFile(new ReportBindingModel
                {
                    FileName = dialog.FileName,
                    UserId = Program.employee.Id
                });
                MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void услугиПоВизитамExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    reportLogic.SaveRoomConfToExcelFile(new
                    ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        UserId = Program.employee.Id
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

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormReportConf>();
            form.ShowDialog();
        }

       
    }
}
