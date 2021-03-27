using IronDB.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronDB
{
    public partial class FirstDialog : Form
    {
        #region Properties

        public static bool FlagFirstDialog { get; set; } = false;

        private static string Log = @"C:\temp\Logs.txt";

        /// <summary>
        /// Controller
        /// </summary>
        public Controllers Controller
        {
            get
            {
                Controllers controllers = new Controllers();
                return controllers;
            }
        }

        #endregion

        #region C'tor

        /// <summary>
        /// FirstDialog
        /// </summary>
        public FirstDialog()
        {
            InitializeComponent();
            if (File.Exists(Log))
                File.Delete(Log);
            Logging.StartLogs();
            Logging.ReportLogsInfo("App Loaded!");
        }

        #endregion

        #region Methods

        /// <summary>
        /// LoginBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SecondDialog form = new SecondDialog();
            if (!SecondDialog.FlagSecondDialog)
            {
                form.Show();
                SecondDialog.FlagSecondDialog = true;
                Logging.ReportLogsInfo("SecondDialog Loaded!!");
            }
            else
                form.Activate();
        }

        /// <summary>
        /// FirstDialog_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstDialog_Load(object sender, EventArgs e)
        {
            var connect = Controller.ConnectDB();
            DGVUsername.DataSource = Controller.PopulateDataGridView(connect, "Users");
            DGVRoles.DataSource = Controller.PopulateDataGridView(connect, "Roles");
            Controller.CloseConnectionDb(connect);
            Controller.ResizeColumns(DGVUsername);
            Controller.ResizeColumns(DGVRoles);
        }

        /// <summary>
        /// DGVUsername_RowPostPaint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVUsername_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Controller.PaintIdColumn(DGVUsername, sender, e);
        }

        /// <summary>
        /// DGVRoles_RowPostPaint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVRoles_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Controller.PaintIdColumn(DGVRoles, sender, e);
        }

        /// <summary>
        /// DGVUsername_CellValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVUsername_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int actual = 0;
            var connect = Controller.ConnectDB();
            DataGridViewRow dgv = DGVUsername.CurrentRow;
            //var newCellValue = this.DGVUsername.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
            if (dgv != null)
            {
                SqlCommand sqlcmd = new SqlCommand("UsersAddOrEdit", connect);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                var user = new Users(this.DGVUsername.Rows[e.RowIndex].Cells[1].Value.ToString(), this.DGVUsername.Rows[e.RowIndex].Cells[2].Value.ToString(), this.DGVRoles.Rows[actual].Cells[1].Value.ToString());
                if (dgv.Cells[0].Value == DBNull.Value)
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                else
                {
                    actual = Convert.ToInt32(dgv.Cells[0].Value);
                    sqlcmd.Parameters.AddWithValue("@ID", actual);
                }
                sqlcmd.Parameters.AddWithValue("@Username", user.Username);
                sqlcmd.Parameters.AddWithValue("@Passwort", user.Passwort);
                sqlcmd.ExecuteNonQuery();
                Controller.CloseConnectionDb(connect);
                Controller.ResizeColumns(DGVUsername);

            }
        }

        /// <summary>
        /// DGVUsername_UserDeletingRow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVUsername_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Controller.UserDeletingRow(DGVUsername, "Users", e);
            Controller.ResizeColumns(DGVUsername);
        }

        #endregion
    }
}
