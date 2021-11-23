using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace HotelBookApplication
{
    public class DataAccess
    {
        public List<Client> GetClients()
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = "select * FROM[HotelBookingDB].[dbo].[Clients] ORDER BY [LastName]";
                return connection.Query<Client>(sql, connection).ToList();
            }

        }

        public List<dynamic> GetUnavailableRooms()
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = "select * FROM[HotelBookingDB].[dbo].[Rooms] WHERE [DownForRepair] = '1' ORDER BY [RoomNumber]";
                return connection.Query<dynamic>(sql, connection).ToList();
            }

        }

        public List<Occupancies> GetBookedRooms()
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = "select RoomNumber, clients.ClientId, clients.LastName FROM[HotelBookingDB].[dbo].[Occupancies] AS occupancies Inner Join[HotelBookingDB].[dbo].[Clients] AS clients ON[clients].ClientId = [occupancies].ClientId ORDER BY[RoomNumber]";
                return connection.Query<Occupancies>(sql, connection).ToList();
            }

        }

        public List<dynamic> GetAvailableRooms()
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = "select * FROM[HotelBookingDB].[dbo].[Rooms] AS rooms WHERE rooms.RoomNumber NOT IN (SELECT Occupancies.RoomNumber FROM [HotelBookingDB].[dbo].[Occupancies]) ORDER BY RoomNumber";
                return connection.Query<dynamic>(sql, connection).ToList();
            }

        }

        public List<dynamic> GetAllRooms()
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = "select * FROM[HotelBookingDB].[dbo].[Rooms] ORDER BY RoomNumber";
                return connection.Query<dynamic>(sql, connection).ToList();
            }

        }

        public void CheckInClient(int id, string fn, string ln, string pn, string address)
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {

                int clientId = id;

                List<Client> client = new List<Client>();

                client.Add(new Client { ClientId = clientId, FirstName = fn, LastName = ln, PhoneNumber = pn, Address = address });

                var sql = $"insert into [HotelBookingDB].[dbo].[Clients] (ClientId, FirstName, LastName, PhoneNumber, Address) values ({clientId}, '{fn}', '{ln}', '{pn}', '{address}')";

                connection.Execute(sql);
            }

        }

        public void CheckInOccupancy(string fn, string ln, string pn, string address, int rn)
        {
            Random rand = new Random();
            int clientId = rand.Next(1, 10000);

            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                List<Occupancies> occ = new List<Occupancies>();

                occ.Add(new Occupancies { RoomNumber = rn, ClientId = clientId, LastName = ln });

                var sql = $"insert into [HotelBookingDB].[dbo].[Occupancies] (RoomNumber, ClientId, LastName) values ('{rn}', {clientId}, '{ln}')";

                connection.Execute(sql);
            }

            CheckInClient(clientId, fn, ln, pn, address);

        }

        public List<int> GetAvailableRoomNumber()
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = "select RoomNumber FROM[HotelBookingDB].[dbo].[Rooms] AS rooms WHERE rooms.RoomNumber NOT IN (SELECT Occupancies.RoomNumber FROM [HotelBookingDB].[dbo].[Occupancies]) ORDER BY RoomNumber";
                return connection.Query<int>(sql, connection).ToList();
            }

        }

        public void CheckOut(int rm)
        {
            
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = $"Delete FROM Occupancies WHERE RoomNumber = '{rm}'";

                connection.Execute(sql);
            }

            
        }

        public void RemoveClient(int Clientid)
        {

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = $"Delete FROM Occupancies WHERE RoomNumber = '{Clientid}'";

                connection.Execute(sql);
            }


        }

        public void AddRoom(int rn, string roomtype, bool balcony, bool downforRepair, int numberofBeds, bool smokin, int numberofrooms)
        {
            //creates a connection to the data server
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = $"insert into [HotelBookingDB].[dbo].[Rooms] (RoomNumber, RoomType, Balcony, DownForRepair, NumberOfBeds, Smoking, NumberOfRooms) values ({rn}, '{roomtype}', '{balcony}', '{downforRepair}', '{numberofBeds}', '{smokin}', '{numberofrooms}')";

                connection.Execute(sql);
            }

        }

        public void RemoveRoom(int RoomId)
        {

            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("HotelBookingApllicationDB")))
            {
                var sql = $"Delete FROM Rooms WHERE RoomNumber = '{RoomId}'";

                connection.Execute(sql);
            }


        }
    }
}
