using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace HotelBookApplication
{
    public partial class Main : Form
    {

        //makes a streamReader to read the files
        //also makes variables containing the filename
        //makes reference to the form
        CheckIn CheckIn;
        RemovingClients RemovingClients;
        RoomForm RoomForm;

        List<Client> Clients = new List<Client>();
        List<dynamic> Rooms = new List<dynamic>();
        List<Occupancies> Occ = new List<Occupancies>();
        public Main()
        {
            InitializeComponent();
            CheckIn = new CheckIn(this);
            RemovingClients = new RemovingClients(this);
            RoomForm = new RoomForm(this);
            
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        //exits application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(Result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //shows all the room currently occupied by a guest
        private void bookedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                Occ = da.GetBookedRooms();
                dataTest.DataSource = Occ;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        //shows available rooms that can be checked into
        private void availableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            Rooms = da.GetAvailableRooms();
            dataTest.DataSource = Rooms;
        }

        //shows rooms that are currently unavailable due to repairs
        private void unavailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                Rooms = da.GetUnavailableRooms();
                dataTest.DataSource = Rooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        //shows a list of customers
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                Clients = da.GetClients();
                dataTest.DataSource = Clients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        //check in
        private void button1_Click(object sender, EventArgs e)
        {
            CheckIn.Show();
        }

        //check out
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int rm = Convert.ToInt32(dataTest.SelectedCells[0].Value);
                
                DataAccess da = new DataAccess();
                da.CheckOut(rm);
                Occ = da.GetBookedRooms();
                dataTest.DataSource = Occ;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dataTest_BackgroundColorChanged(object sender, EventArgs e)
        {

        }

        private void dataTest_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        //removes clients
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovingClients.Show();
        }

        private void roomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //RoomForm.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm.Show();
        }
    }
}
