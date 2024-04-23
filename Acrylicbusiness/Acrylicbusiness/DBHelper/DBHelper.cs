using Acrylicbusiness.connection;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acrylicbusiness.DBHelper
{
    internal class DBHelper
    {
        public static string gen = "";
        public static OleDbConnection conn;
        public static OleDbCommand command;
        public static OleDbDataReader reader;
        public static void fill(string q, DataGridView dgv)
        {
            
        try
            {
                connection.connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                OleDbCommand command = new OleDbCommand(q,
                connection.connection.conn);
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;
                connection.connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.connection.conn.Close();
                MessageBox.Show(ex.Message, "ErrorFillDataGridView",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void ModifyRecord(string updates)
        {
            try
            {
                connection.connection.DB();
                OleDbCommand command = new OleDbCommand(updates,
                connection.connection.conn);
                command.ExecuteNonQuery();
                connection.connection.conn.Close();
            }
            catch (Exception ex)
            {
                connection.connection.conn.Close();
                MessageBox.Show("Error ---->" + updates + ex.Message);
            }
        }

    }
}
