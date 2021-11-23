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
    
    public partial class RoomForm : Form
    {
        Main Main;
        AddingRoom addingRoom;

        List<dynamic> rooms = new List<dynamic>();
        public RoomForm(Main main)
        {
            Main = main;
            addingRoom = new AddingRoom(this);
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            addingRoom.Show();
            rooms = da.GetAllRooms();
        }

        private void RemoveRoomBtn_Click(object sender, EventArgs e)
        {
            int rm = Convert.ToInt32(DataRooms.SelectedCells[0].Value);

            DataAccess da = new DataAccess();
            da.RemoveRoom(rm);
            rooms = da.GetAllRooms();
            DataRooms.DataSource = rooms;
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            rooms = da.GetAllRooms();
            DataRooms.DataSource = rooms;
        }
    }
}
