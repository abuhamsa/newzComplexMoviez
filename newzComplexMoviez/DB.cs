using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{   //A CLASS THATS NOT USED ATM AND MIGHT NOT WORK
    class DB
    {
        public static void db_create()
        {

            SQLiteConnection.CreateFile("releases.sqlite");

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=releases.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "create table releases (";
            sql += "releaseName varchar(1000),";
            sql +=  "detailLinscore int)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('Me', 9001)";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
            
        }

        public static void release2db (MovieRelease release)
        {




        }

       




    }
   

}
