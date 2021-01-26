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
        public String x { get; private set; }
        public String y { get; private set; }
        public String z { get; private set; }

        public Connection(int Id, string x , string y ,string z)
        {
            this.Id = Id;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Connection(string x, string y, string z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
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

        public static List<Connection> GetUsers()
        {
            List<Connection> users = new List<Connection>();

            String query = "SELECT * FROM imtis";


            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                String x = (String)reader["X"];
                String y = (String)reader["Y"];
                String z = (String)reader["Z"];

                Connection u = new Connection(id, x, y, z);

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
            String x = (String)"1";
            String y = (String)"2";
            String z = (String)"???";

            Connection u = new Connection(x, y, z);

            Objektai.Add(u);

            // Initialize Objektai Klasifikavimui 2
             x = (String)"0";
             y = (String)"2";
             z = (String)"???";

            Connection u2 = new Connection(x, y, z);

            Objektai.Add(u2);

            return Objektai;
        }


    }
}
