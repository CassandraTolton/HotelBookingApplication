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
    public partial class RemovingClients : Form
    {
        Main main;
        List<Client> Clients = new List<Client>();
        public RemovingClients(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void RemovingClients_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            Clients = da.GetClients();
            DataClient.DataSource = Clients;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            int ClientId = Convert.ToInt32(DataClient.SelectedCells[0].Value);

            DataAccess da = new DataAccess();
            da.RemoveClient(ClientId);
            Clients = da.GetClients();
            DataClient.DataSource = Clients;
        }
    }
}
