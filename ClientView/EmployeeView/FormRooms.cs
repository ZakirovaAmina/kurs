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
using HotelBusinessLogic.BusinessLogics;

namespace EmployeeView
{
    public partial class FormRooms : Form
    {
        private RoomLogic serviceLogic;
        public FormRooms(RoomLogic service)
        {
            serviceLogic = service;
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                var list = serviceLogic.Read(null);
                if (list != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var service in list)
                    {
                        dataGridView.Rows.Add(new object[] {service.Id,  service.Cost, service.Name});
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
            LoadData();
        }

        private void buttonCreateService_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormRoom>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
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
                        serviceLogic.Delete(new RoomBindingModel { Id = id });
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

        private void buttonUpdateService_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormRoom>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
