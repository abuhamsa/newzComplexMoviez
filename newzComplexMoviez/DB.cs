using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newzComplexMoviez
{
    class DB
    {
        private string location;
        private string createQuery;

        //CONSTRUCTOR1
        public DB(string location, string createQuery)
        {
            this.location = location;
            this.createQuery = createQuery;

            if (File.Exists(location))
            {
                Console.WriteLine("DB already exists");

            }
            else
            {

                SQLiteConnection.CreateFile(location);

                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + location + ";Version=3;");
                m_dbConnection.Open();
                m_dbConnection.Close();

                SQLiteCommand command = new SQLiteCommand(createQuery, m_dbConnection);

                m_dbConnection.Open();
                command.ExecuteNonQuery();


                m_dbConnection.Close();
            }

        }


        public void release2db(MovieRelease release)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=" + this.location + ";Version=3;");
            m_dbConnection.Open();

            string insertsql = "insert into MovieRelease ";
            string coloumn = "(NzbLink,Releasename,Category,Description, DetailLink, Score, Imdb, Imdbtitle,Guid) ";
            string values = "VALUES (\"" + release.NzbLink + "\",\"" + release.ReleaseName + "\",\"" + release.Category + "\",\"" + release.Description + "\",\"" + release.DetailLink + "\"," + release.Score + "," + release.Imdb + ",\"" + release.Imdbtitle + "\",\"" + release.Guid + "\"); ";

            insertsql += coloumn + values;

            SQLiteCommand command = new SQLiteCommand(insertsql, m_dbConnection);
            try { SQLiteDataReader reader = command.ExecuteReader() ;

            }
            catch (Exception e){ Console.WriteLine(e.Message);  }



            m_dbConnection.Close();

        }









    }
}
