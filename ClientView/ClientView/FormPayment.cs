using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBusinessLogic.BindingModels;
using HotelBusinessLogic.BusinessLogic;
using HotelBusinessLogic.BusinessLogics;
using HotelBusinessLogic.ViewModels;

namespace ClientView
{
    
    public partial class FormPayment : Form
    {
        private readonly PaymentLogic _logic;
        private readonly ConfLogic _logicConf;
        public int Id { set { id = value; } }
        private int id;
        public FormPayment(PaymentLogic paymentLogic, ConfLogic logicConf)
        {
            _logicConf = logicConf;
            _logic = paymentLogic;
            InitializeComponent();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            try
            {
                var listPay = _logic.Read(new PaymentBindingModel() { ConfId = id });
                PaymentViewModel lastPay;
                if (listPay.Count > 0)
                {
                    lastPay=listPay[0];
                }
                else    
                {
                    lastPay = new PaymentViewModel()
                    {
                        Remains = _logicConf.Read(new ConfBindingModel() { Id = id })[0].Sum
                    };
                }
                if(!int.TryParse(textBoxSum.Text, out int i))
                {
                    MessageBox.Show("Сумма должна быть числом", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                    return;
                }
                _logic.CreateOrUpdate(new PaymentBindingModel()
                {
                    DateOfPayment = DateTime.Now,
                    ConfId = id,
                    Sum = Convert.ToDecimal(textBoxSum.Text),
                    Remains = lastPay.Remains - Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Оплата прошла успешно, внесено: " + textBoxSum.Text, "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            try
            {
                labelSum.Text = _logicConf.Read(new ConfBindingModel() { Id = id })[0].Sum.ToString();
                var list = _logic.Read(new PaymentBindingModel() { ConfId = id });
                if (list != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var conf in list)
                    {
                        dataGridView.Rows.Add(new object[] { conf.Sum, conf.Remains , conf.DateOfPayment });
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
