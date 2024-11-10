using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class DBContext
    {
        string connecting = "server=DESKTOP-2E25VUI\\LUNA_TEST;Database=testing; Trusted_Connection=True;";
        public void InsertLogsIntoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    string query = @"Insert into Log_2 (LogTime, EventDescription) values (@Time,@Logs)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "Time");
                        adapter.InsertCommand.Parameters.Add("@Logs", SqlDbType.NVarChar, 255, "Events");
                        conn.Open();
                        adapter.Update(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving Log_2 to DB:" + ex.Message);
            }

        }

       

        public void loadLogsFormDB(DataTable dt, DataGridView dataGridViewLogs)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    string query = @"Select LogTime, EventDescription from Log_2 order by LogTime";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);
                        dataGridViewLogs.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();

                            dataGridViewLogs.Rows.Add(currentTime, events);


                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving Log_2 to DB:" + ex.Message);

            }
        }

     
        public void truncateLogsTable(DataGridView dataGridView1)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connecting))
                {
                    string query = @"TRUNCATE TABLE Log_2";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        dataGridView1.Rows.Clear();
                        MessageBox.Show("Log_2 table has been truncated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error truncating Log_2 table: " + ex.Message);
            }
        }
    }
}
