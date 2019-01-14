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

            SQLiteConnection.CreateFile("C:\\Users\\reberja\\Documents\\newzComplexMoviez\\releases.sqlite");

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=C:\\Users\\reberja\\Documents\\newzComplexMoviez\\releases.sqlite;Version=3;");
            m_dbConnection.Open();
            m_dbConnection.Close();

            string sql = "CREATE TABLE MovieRelease (NzbLink VARCHAR(150) NOT NULL,ReleaseName VARCHAR(100) NOT NULL,Category VARCHAR(50) NOT NULL,Description VARCHAR(100) NOT NULL,DetailLink VARCHAR(100) NOT NULL,Score DOUBLE NOT NULL,Imdb DOUBLE NOT NULL,Imdbtitle VARCHAR(50) NOT NULL,Guid VARCHAR(100) NOT NULL, PRIMARY KEY (Guid))";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            m_dbConnection.Open();
            command.ExecuteNonQuery();

            
            m_dbConnection.Close();
            
        }

        public static void release2db (MovieRelease release)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=C:\\Users\\reberja\\Documents\\newzComplexMoviez\\releases.sqlite;Version=3;");
            m_dbConnection.Open();

            string insertsql = "insert into MovieRelease ";
            string coloumn = "(NzbLink,Releasename,Category,Description, DetailLink, Score, Imdb, Imdbtitle,Guid) ";
            string values = "VALUES (\"" + release.NzbLink + "\",\"" + release.ReleaseName + "\",\"" + release.Category + "\",\"" + release.Description + "\",\"" + release.DetailLink + "\"," + release.Score + "," + release.Imdb + ",\"" + release.Imdbtitle + "\",\""+release.Guid+"\"); ";

            insertsql += coloumn + values;

            SQLiteCommand command = new SQLiteCommand(insertsql, m_dbConnection);
            try { command.ExecuteNonQuery(); }
            catch { }
            


            m_dbConnection.Close();

        }

       




    }
   

}
