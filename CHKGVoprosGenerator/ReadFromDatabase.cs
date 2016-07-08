using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace CHKGVoprosGenerator
{
    public static class ReadFromDatabase
    {
        static string connection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=MyDatabase.accdb;";
        static List<Vopros> Nvopros;


        public static string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public static List<Vopros> NVopros
        {
            get { return Nvopros; }
        }

        public static List<Vopros> VoprosFromDatabase(int number)
        {
            Nvopros = new List<Vopros>();
            string sstrSQL = "SELECT * FROM Voprosy WHERE ID = " + number;
            OleDbConnection myConnection = new OleDbConnection(Connection);
            OleDbCommand selectCommand = new OleDbCommand(sstrSQL, myConnection);
            OleDbDataReader myDataReader;
            Vopros newVopros;
            try
            {

                myConnection.Open();
                myDataReader = selectCommand.ExecuteReader();
                while (myDataReader.Read())
                {
                    int Id = Convert.ToInt32(myDataReader["ID"]);
                    string vopross = myDataReader["Vopros"].ToString();
                    string picName = myDataReader["File"].ToString();
                    newVopros = new Vopros(Id, vopross, picName);
                    Nvopros.Add(newVopros);
                }
            }
            catch (OleDbException)
            { }
            finally { myConnection.Close(); }
            return Nvopros;

        }
    }
}
