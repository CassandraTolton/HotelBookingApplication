using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookApplication
{
    public partial class AddingRoom : Form
    {
        RoomForm roomForm;
        public AddingRoom(RoomForm rf)
        {
            InitializeComponent();
            roomForm = rf;
        }

        private void AddingRoom_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BalconyText_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //deletes room
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //adds room
        private void button1_Click(object sender, EventArgs e)
        {
            if (BasicRadio.Checked)
            {
                DataAccess da = new DataAccess();
                da.AddRoom(Convert.ToInt32(roomnumbertextbox.Text), "Basic", Convert.ToBoolean(balconycomb.SelectedItem), Convert.ToBoolean(downforrepaircombo.SelectedItem), Convert.ToInt32(numberofbedsText.Text), Convert.ToBoolean(smokingTextBox.Text), Convert.ToInt32(NumberOfRoomsTextBox.Text));
            }

            if (NumberOfRoomsSuite.Checked)
            {
                DataAccess da = new DataAccess();
                da.AddRoom(Convert.ToInt32(roomnumbertextbox.Text), "Suite", Convert.ToBoolean(balconycomb.SelectedItem), Convert.ToBoolean(downforrepaircombo.SelectedItem), Convert.ToInt32(numberofbedsText.Text), Convert.ToBoolean(smokingTextBox.Text), Convert.ToInt32(NumberOfRoomsTextBox.Text));
            }
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (BasicRadio.Checked)
                {
                    NumberOfRoomsTextBox.Enabled = false;
                    NumberOfRoomsTextBox.Text = "1";
                    smokingTextBox.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (NumberOfRoomsSuite.Checked)
            {
                smokingTextBox.Enabled = false;
                smokingTextBox.Text = "False";
                NumberOfRoomsTextBox.Enabled = true;
            }
        }
    }
}
