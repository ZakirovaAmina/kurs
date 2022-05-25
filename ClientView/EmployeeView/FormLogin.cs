using EmployeeView;
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
using HotelBusinessLogic.ViewModels;

namespace EmployeeView
{
    public partial class FormLogin : Form
    {
        private readonly EmployeeLogic _logic;
        public FormLogin(EmployeeLogic employeeLogic)
        {
            _logic = employeeLogic;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный пароль", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxPhoneNumber.Text == String.Empty)
            {
                MessageBox.Show("Телефон не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            EmployeeViewModel viewModel =
            _logic.Check(new EmployeeBindingModel()
            {
                Password = textBoxPassword.Text,
                Phone = textBoxPhoneNumber.Text,
            });
            if (viewModel == null)
            {
                MessageBox.Show("Такого сотрудника не существует, проверьте данные.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.employee = viewModel;
            var form = Program.Container.Resolve<FormMain>();
            form.ShowDialog();

        }

        private void labelEnter_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }
    }
}
