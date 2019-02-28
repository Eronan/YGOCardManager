using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace YGOCardManager
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            //Load Table from Files
            DataTable[] mainTable = new DataTable[2];
            string sqliteDBFile = @".\cards.cdb";
            string[] sql = new string[2] { "select * from datas", "select * from texts" };
            int count = 0;
            foreach (string str in sql)
            {
                using (SQLiteConnection cnn = new SQLiteConnection("datasource=" + sqliteDBFile))
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        SQLiteCommand cmd = new SQLiteCommand(str, cnn);
                        cnn.Open();

                        SQLiteDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);

                        dt.CaseSensitive = false;

                        mainTable[count] = dt;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        if (cnn != null) cnn.Close();
                    }
                }

                count++;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainTable[0], mainTable[1]));
        }
    }
}
