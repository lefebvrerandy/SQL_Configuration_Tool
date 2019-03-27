using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Configuration_Tool
{
    class SQL
    {
        string connectionString;

        public SQL(string newConnString)
        {
            connectionString = newConnString;
        }

        public bool LoadConfigFiles(DataFields df)
        {
            bool isValid = false;

            using (SqlConnection db = new SqlConnection(df.connectionString))
            {
                // Create the query string
                string query = "SELECT @Select FROM @Table";

                SqlCommand cmd = new SqlCommand(query, db);
                cmd.Parameters.AddWithValue("@Select", "*");
                cmd.Parameters.AddWithValue("@Table", "Configuration_Table");

                db.Open();
                cmd.Connection = db;
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    reader.Read();
                    DataFields dataField = new DataFields();
                    PropertyInfo[] properties = dataField.GetType().GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.Name == reader[0].ToString())
                        {
                            var x = 0;
                        }
                    }
                }

                cmd.Dispose();
            }

            return isValid;
        }

        public bool InsertInto(DataFields df)
        {
            bool isValid = false;

            using (SqlConnection db = new SqlConnection(df.connectionString))
            {
                // Create the query string
                string query = "INSERT INTO dbo.Configuration_Table (Time_Scale, Bin_capacity, Refill_rate, Defect_rate, Build_rate)";
                query += " VALUES (@Time_Scale, @Bin_capacity, @Refill_rate, @Defect_rate, @Build_rate)";

                SqlCommand cmd = new SqlCommand(query, db);
                //cmd.Parameters.AddWithValue("@Time_Scale", df.TimeScale);
                //cmd.Parameters.AddWithValue("@Bin_capacity", df.BinCapacity);
                //cmd.Parameters.AddWithValue("@Refill_rate", df.RefillRate);
                //cmd.Parameters.AddWithValue("@Defect_rate", df.defectRate);
                //cmd.Parameters.AddWithValue("@Build_rate", df.buildRate);
                
                //cmd.Parameters.AddWithValue("@Description", df.); Need a description?

                db.Open();
                cmd.Connection = db;
                cmd.ExecuteNonQuery();

                cmd.Dispose();
            }

            return isValid;
        }
    }
}
