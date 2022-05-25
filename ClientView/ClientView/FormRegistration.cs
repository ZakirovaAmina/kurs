﻿using System;
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

namespace ClientView
{
    public partial class FormRegistration : Form
    {
        private readonly ClientLogic _logic;
        public FormRegistration(ClientLogic clientLogic)
        {
            _logic = clientLogic;
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный пароль", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxName.Text == String.Empty)
            {
                MessageBox.Show("Имя не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            
            if (textBoxMail.Text == String.Empty)
            {
                MessageBox.Show("Введите корректную почту ", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxPhoneNumber.Text == String.Empty)
            {
                MessageBox.Show("Введите корректный телефон", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClientBindingModel bindingModel = new ClientBindingModel()
                {
                    Name = textBoxName.Text,
                    Password = textBoxPassword.Text,
                    Phone = textBoxPhoneNumber.Text,
                   
                    Email = textBoxMail.Text,
               
                };
                _logic.CreateOrUpdate(bindingModel);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                var form = Program.Container.Resolve<FormLogin>();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void labelEnter_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormLogin>();
            form.ShowDialog();
        }
    }
}
