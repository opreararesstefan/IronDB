using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronDB.Components
{
    public class Controllers
    {

        #region Properties

        /// <summary>
        /// Connection
        /// </summary>
        public const string Connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\IronDB.mdf;Integrated Security = True; Connect Timeout = 30";

        #endregion

        #region C'tor

        /// <summary>
        /// Controllers
        /// </summary>
        public Controllers()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// SqlConnection
        /// </summary>
        /// <returns></returns>
        public SqlConnection ConnectDB()
        {
            SqlConnection connection = new SqlConnection(Connection);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
                Console.WriteLine("DB connected succesfully!!");
            return connection;
        }

        /// <summary>
        /// CloseConnectionDb
        /// </summary>
        /// <param name="connection"></param>
        public void CloseConnectionDb(SqlConnection connection)
        {
            connection.Close();
            connection.Dispose();
            Console.WriteLine("DB Closed!!");
        }

        /// <summary>
        /// PopulateDataGridView
        /// </summary>
        /// <param name="connect"></param>
        public DataTable PopulateDataGridView(SqlConnection connect, string table)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM " + table, connect);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            if (table.Equals("Users"))
                GenerateListUser(dataTable);
            return dataTable;
        }

        private List<Users> GenerateListUser(DataTable dataTable)
        {
            var UserList = new List<Users>();
            foreach(DataRow element in dataTable.Rows)
            {
                UserList.Add(new Users(element.ItemArray[1].ToString(), element.ItemArray[2].ToString(), null));
            }
            return UserList;
        }

        /// <summary>
        /// UserDeletingRow
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="table"></param>
        /// <param name="e"></param>
        public void UserDeletingRow(DataGridView dgv, string table, DataGridViewRowCancelEventArgs e)
        {
            int actual;
            if (dgv.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure you want to Delete this record?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var connect = ConnectDB();
                    SqlCommand cmd = new SqlCommand("UsersDeleteByID", connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    actual = Convert.ToInt32(dgv.CurrentRow.Cells["DGVID"].Value);
                    cmd.Parameters.AddWithValue("@ID", actual);
                    cmd.ExecuteNonQuery();
                    CloseConnectionDb(connect);
                    Logging.ReportLogsInfo("Delete " + Convert.ToString(actual) + " From Table " + table);
                }
                else
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// ResizeColumns
        /// </summary>
        public void ResizeColumns(DataGridView dgv)
        {
            int index = 0;
            int colWidth = 0;
            foreach (var column in dgv.Columns)
            {
                dgv.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                colWidth += dgv.Columns[index].Width;
                index++;
            }
            dgv.Width = colWidth;
            dgv.Height = (dgv.RowCount + 1) * (dgv.Rows[0].Height + 1);
        }

        /// <summary>
        /// PaintIdColumn
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PaintIdColumn(DataGridView dgv, object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();
            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;
            SizeF size = e.Graphics.MeasureString(rowNumber, dgv.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 10)) dg.RowHeadersWidth = (int)(size.Width + 10);
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
            ResizeColumns(dgv);
        }

        /// <summary>
        /// DGVCEllVal
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public string DGVCEllVal(DataGridView dgv, DataGridViewRow row, string col)
        {
            var item = dgv.Columns.IndexOf(dgv.Columns[col]);
            if (string.IsNullOrEmpty(row.Cells[item].Value.ToString()) || string.IsNullOrWhiteSpace(row.Cells[item].Value.ToString()))
                return " ";
            else
                return row.Cells[item].Value.ToString();
        }

        #endregion
    }
}
