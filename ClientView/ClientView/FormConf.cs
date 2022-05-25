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

namespace ClientView
{
    public partial class FormConf : Form
    {
        public int Id { set { id = value; } }
        private PaymentLogic paymentLogic;
        private readonly ConfLogic _logic;
        private readonly RoomLogic roomLogic;
        private int? id;
        private Dictionary<int, string> confRooms;
        public FormConf(ConfLogic logic, RoomLogic roomLogic, PaymentLogic paymentLogic)
        {
            this.paymentLogic = paymentLogic;
            this.roomLogic= roomLogic;
            InitializeComponent();
            _logic = logic;
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ConfViewModel view = _logic.Read(new ConfBindingModel
                    {Id =id.Value})?[0];
                    if (view != null)
                    {
                        dateTimePicker1.Value = view.ConfsDate;
                        confRooms = view.ConfRooms;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                confRooms = new Dictionary<int, string>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (confRooms != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var pc in confRooms)
                    {
                        dataGridView.Rows.Add(new object[] { pc.Key, pc.Value});
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormConfRooms>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (confRooms.ContainsKey(form.Id))
                {
                    confRooms[form.Id] = (form.RoomName);
                }
                else
                {
                    confRooms.Add(form.Id, form.RoomName);
                }
                LoadData();
            }
        }
        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormConfRooms>();
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    confRooms[form.Id] = form.RoomName;
                    LoadData();
                }
            }
        }
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        confRooms.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
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
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value<DateTime.Now)
            {
                MessageBox.Show("Выберите дату позже текущей", "Ошибка", MessageBoxButtons.OK,

               MessageBoxIcon.Error);
                return;
            }
            if (confRooms == null || confRooms.Count == 0)
            {
                MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                var listRoom = roomLogic.Read(null);
                decimal sumCurrent = listRoom
                    .Where(r => confRooms.ContainsKey(r.Id)).Sum(r => r.Cost);
                if (id.HasValue)
                {

                     decimal sumLast = _logic.Read(new ConfBindingModel()
                    {
                        Id = id.Value
                    })[0].Sum;
                    var lastPay = paymentLogic.Read(new PaymentBindingModel() { ConfId = (int)id }).Last();
                    sumCurrent-=(sumLast-lastPay.Remains);
                    paymentLogic.CreateOrUpdate(new PaymentBindingModel()
                    {
                        Id = lastPay.Id,
                        Remains = sumCurrent
                    });
                }

                _logic.CreateOrUpdate(new ConfBindingModel
                {
                    Id = id,
                    ConfsDate= dateTimePicker1.Value,
                    Sum=sumCurrent,
                    ClientId=Program.client.Id,
                    ConfRooms = confRooms
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
