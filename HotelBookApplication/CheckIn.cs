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
    public partial class CheckIn : Form
    {
        Main Main;
        public CheckIn(Main main)
        {
            InitializeComponent();
            this.Main = main;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //book
        private void button1_Click(object sender, EventArgs e)
        {
            int roomnumber = Convert.ToInt32(comboRoom.SelectedItem);
            string address = Convert.ToString(txtAddress.Text);
            DataAccess da = new DataAccess();
            da.CheckInOccupancy(txtFirst.Text, txtLast.Text, txtPhone.Text, address, roomnumber);
            this.Hide();
        }

        //Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtLast.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            
            this.Hide();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.Abort)
                {
                    this.Hide();
                }

                List<int> RoomNumbers = new List<int>();
                DataAccess da = new DataAccess();
                RoomNumbers = da.GetAvailableRoomNumber();

                foreach (var room in RoomNumbers)
                {
                    comboRoom.Items.Add(room);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
