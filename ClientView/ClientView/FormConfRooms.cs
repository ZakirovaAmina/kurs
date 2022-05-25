using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBusinessLogic.BusinessLogics;
using HotelBusinessLogic.ViewModels;

namespace ClientView
{
    public partial class FormConfRooms : Form
    {
        public int Id
        {
            get { return Convert.ToInt32(comboBoxRoom.SelectedValue); }
            set { comboBoxRoom.SelectedValue = value; }
        }
        public string RoomName { get { return comboBoxRoom.Text; } }
        public FormConfRooms(RoomLogic logic)
        {
            InitializeComponent();
            List<RoomViewModel> list = logic.Read(null);
            if (list != null)
            {
                comboBoxRoom.DisplayMember = "Name";
                comboBoxRoom.ValueMember = "Id";
                comboBoxRoom.DataSource = list;
                comboBoxRoom.SelectedItem = null;
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxRoom.SelectedValue == null)
            {
                MessageBox.Show("Выберите компонент", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
