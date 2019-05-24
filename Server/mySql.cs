using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Server
{
    public class mySql
    {
        
        public MySqlConnection baglanti = new MySqlConnection(
            "Data Source=ashran.guzelhosting.com; " + 
            "Database=algoritma_chat;" +
            "User Id=algoritma_israfil; " +
            "Password=CX47tr453+;"
            );
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter adapter = null;
        public MySqlDataReader reader;
        public DataSet ds = new DataSet();



        public bool baglantiDurum()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
        }

    }

}

