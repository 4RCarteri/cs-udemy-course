using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            #region SQL Server CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeEngine db = new SqlCeEngine(strConection);

            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            ////conexao.ConnectionString = strConection;

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar Sql Server CE \n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}
            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;password=logan";
            ////string strConnection2 = "server=127.0.0.1;User Id=root;database=curso_db;password=logan";

            //MySqlConnection conexao = new MySqlConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    labelResultado.Text = "Conectado MySQL";

            //    MySqlCommand comando = new MySqlCommand();

            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";

            //    comando.ExecuteNonQuery();
            //    labelResultado.Text = "Base de Dados criada com sucesso.";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = "Erro ao Conectar MySQL \n" + ex;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion


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

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            #region SQLite
            string dataBase = @"db\DBSQLite.db";
            string strConn = @"Data Source = " + dataBase + "; Version = 3;";

            SQLiteConnection conn = new SQLiteConnection(strConn);

            try
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conn;

                cmd.CommandText = "CREATE TABLE person ( id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name NVARCHAR(50), email NVARCHAR(50))";
                cmd.ExecuteNonQuery();
                lblResult.Text = "Table created";
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            #endregion

            #region SQLServerCE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50), email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela Criada Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySQL

            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=logan";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas ( id INT NOT NULL, nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Tabela Criada MySQL";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region SQLite
            string dataBase = @"db\DBSQLite.db";
            string strConn = @"Data Source = " + dataBase + "; Version = 3;";

            SQLiteConnection conn = new SQLiteConnection(strConn);

            try
            {
                conn.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conn;

                comando.CommandText = "INSERT INTO person (name, email) VALUES ('" + tbName.Text + "', '" + tbEmail.Text + "')";

                comando.ExecuteNonQuery();

                lblResult.Text = "Register inserted SQLite";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            #endregion

            #region MySql
            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=logan";
            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";

            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido MySql";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLServerCE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource = " + baseDados + "; Password = '1234'";
            //SqlCeConnection conexao = new SqlCeConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";

            //    comando.ExecuteNonQuery();

            //    labelResultado.Text = "Registro inserido Sql Server Ce";
            //    comando.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    labelResultado.Text = ex.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }
    }
}
