using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_DataBases
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            #region SQLite
            string dataBase = @"db\DBSQLite.db";
            string strConn = @"Data Source = " + dataBase + "; Version = 3;";


            if(!File.Exists(dataBase))
            {
                SQLiteConnection.CreateFile(dataBase);
            }
            SQLiteConnection db = new SQLiteConnection(strConn);

            try
            {
                db.Open();
                lblResult.Text = "Connected";
            }
            catch (Exception ex) {
                lblResult.Text = "Error " + ex;
            }
            finally
            {
                db.Close();
            }

            #endregion
        }
    }
}
