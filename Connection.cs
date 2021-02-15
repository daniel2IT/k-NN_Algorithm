using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Neighbors
{
    public class Connection
    {

        //Database stuff
        private const String Server = "127.0.0.1";
        private const String Database = "neighbor";
        private const String UID = "root";
        private const String Password = "";
        private static MySqlConnection dbConn;

        // User Class Stuff
        public int Id { get; private set; }
        public string Idd { get; private set; }
        public String x { get; private set; }
        public String y { get; private set; }
        public String z { get; private set; }
        public String pozicija { get; private set; }
        public String amziuss { get; private set; }
        public String zaidejas { get; private set; }

        public Connection(int Id, string x , string y ,string z, string pozicija, string amzius, string zaidejas)
        {
            this.Id = Id;
            this.x = x;
            this.y = y;
            this.z = z;
            this.pozicija = pozicija;
            this.amziuss = amzius;
            this.zaidejas = zaidejas;
        }

        public Connection(string Id, string x, string y, string z, string pozicija, string amzius, string zaidejas)
        {
            this.Idd = Id;
            this.x = x;
            this.y = y;
            this.z = z;
            this.pozicija = pozicija;
            this.amziuss = amzius;
            this.zaidejas = zaidejas;
        }

        public static void Initialize()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Server;
            builder.UserID = UID;
            builder.Password = Password;
            builder.Database = Database;


            String ConnString = builder.ToString();


            builder = null;

            Console.WriteLine(ConnString);

            dbConn = new MySqlConnection(ConnString);
        }
        
        public static string DeleteUser()
        {

            try
            {

                string sql = "DELETE FROM `neighbor`.`new_imtis2` WHERE(`id` = '0');";


                MySqlCommand cmd = new MySqlCommand(sql, dbConn);

                dbConn.Open();


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            dbConn.Close();

            return "Deleted";
        }

        public static string AddUsers(string Value)
        {
          
            try
            {

                string sql = $"INSERT INTO new_imtis2 (X, Y, Z) VALUES ('1','2','{Value}')";
               

                MySqlCommand cmd = new MySqlCommand(sql, dbConn);

                         dbConn.Open();


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            dbConn.Close();

            return "Created";
        }

        public static List<Connection> GetUsers()
        {
            List<Connection> users = new List<Connection>();

            String query = "SELECT * FROM new_imtis2";


            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                String x = (String)reader["X"];
                String y = (String)reader["Y"];
                String z = (String)reader["SportoSaka"];
                String pozicija = (String)reader["Pozicija"];
                String amziuss = (String)reader["Amzius"];
                String zaidejas = (String)reader["Zaidejas"];


                Connection u = new Connection(id, x, y, z, pozicija, amziuss, zaidejas);

                users.Add(u);
            }

            dbConn.Close();


            return users;
        }


        // TASK Object 
        public static List<Connection> GetObjektaiKlasifikavimui()
        {
            List<Connection> Objektai = new List<Connection>();

            // Initialize Objektai Klasifikavimui 1 
            String id = (String)"1";
            String x = (String)"185";
            String y = (String)"99";
            String z = (String)"???";
            String pozicija = (String)"";
            String amzius = (String)"20";
            String zaidejas = (String)"Ronaldo";

            Connection u = new Connection(id ,x, y, z, pozicija, amzius, zaidejas);

            Objektai.Add(u);

            return Objektai;
        }


    }
}
