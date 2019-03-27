using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace SQL_Configuration_Tool
{
    public partial class Form1 : Form
    {
        DataFields df = new DataFields();

        public Form1()
        {
            InitializeComponent();
            LoadConnectionString();
        }

        //  /////////////////////////////////////////////////////////////////////////////////////
        //                              EVENT HANDLERS
        //  /////////////////////////////////////////////////////////////////////////////////////





        /// <summary>
        /// This method handles the button click event. It will check to see that
        /// the DataField instance has information in all its properties. If so, it will
        /// create a DataTable will all the fields in it to insert it into a SQL server table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_store_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = new SqlConnection(df.connectionString))
            {
                DataTable dataTableFirst = new DataTable();
                DataTable dataTableSecond = new DataTable();
                DataTable dataTableThird = new DataTable();
                DataTable dataTableFourth = new DataTable();

                // Create the query string
                string query = "SELECT * FROM dbo.Configuration_Table WHERE [Key] = 'TimeScale' OR [Key] = 'RefillRate'";

                using (SqlCommand cmd = new SqlCommand(query, db))
                {
                    db.Open();
                    cmd.Connection = db;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        // this will query your database and return the result to your datatable
                        da.Fill(dataTableFirst);
                        dataGridView1.DataSource = dataTableFirst;
                        dataGridView1.AutoResizeColumns(
                            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    }
                }

                query = "SELECT * FROM dbo.Configuration_Table WHERE [Key] = 'RookieDefectRate' OR [Key] = 'NormalDefectRate' OR [Key] = 'SuperDefecrRate'";
                using (SqlCommand cmd = new SqlCommand(query, db))
                {
                    cmd.Connection = db;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        // this will query your database and return the result to your datatable
                        da.Fill(dataTableSecond);
                        dataGridView2.DataSource = dataTableSecond;
                        dataGridView2.AutoResizeColumns(
                            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    }
                }

                //using (SqlCommand cmd = new SqlCommand(query, db))
                //{
                //    db.Open();
                //    cmd.Connection = db;
                //    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                //    {
                //        // this will query your database and return the result to your datatable
                //        da.Fill(dt);
                //        dataGridView1.DataSource = dt;
                //        dataGridView1.AutoResizeColumns(
                //            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                //    }
                //}

                //using (SqlCommand cmd = new SqlCommand(query, db))
                //{
                //    db.Open();
                //    cmd.Connection = db;
                //    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                //    {
                //        // this will query your database and return the result to your datatable
                //        da.Fill(dt);
                //        dataGridView1.DataSource = dt;
                //        dataGridView1.AutoResizeColumns(
                //            DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                //    }
                //}
            }
        }

        //  /////////////////////////////////////////////////////////////////////////////////////
        //                      INITIALIZE AND POPULATE
        //  /////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Load and test the connection string. This will alter the label at the beginning
        /// of the programs execution. If the connection is successful, we will show the connection status.
        /// If no connection, it will disable the button and show how to fix the error.
        /// </summary>
        private void LoadConnectionString()
        {
            df.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection db = new SqlConnection(df.connectionString))
                {
                    db.Open();
                    lbl_connection.Text = "Connection to Server Successful";
                    lbl_connection.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                lbl_connection.Text = "No connection to server.\nCheck App.Config \nConnection String";
                lbl_connection.ForeColor = Color.Red;
                btn_store.Enabled = false;
            }
        }
    }
}
