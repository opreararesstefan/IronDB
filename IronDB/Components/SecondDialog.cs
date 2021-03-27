using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronDB.Components
{
    public partial class SecondDialog : Form
    {
        #region C'tor

        /// <summary>
        /// SecondDialog
        /// </summary>
        public SecondDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public static bool FlagSecondDialog { get; set; } = false;

        private static string UserTxt { get; set; }

        private static string PassTxt { get; set; }

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

        /// <summary>
        /// LoginBtn_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var connect = Controller.ConnectDB();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Users WHERE Username= '" + UserTxt + "' AND Passwort ='" + PassTxt +"'", connect);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Success", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Logging.ReportLogsInfo("Succeded => SELECT " + UserTxt + ", " + PassTxt + " FROM Users");
            }
            else
            {
                Logging.ReportLogsInfo("Failed  => SELECT " + UserTxt + ", " + PassTxt + " FROM Users");
                MessageBox.Show("Failed", " Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Controller.CloseConnectionDb(connect);
        }

        /// <summary>
        /// SecondDialog_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            FlagSecondDialog = false;
            Logging.ReportLogsInfo("Second Dialog Closed!!");
        }

        /// <summary>
        /// UsernameTextBox_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UserTxt = UsernameTextBox.Text;
        }

        /// <summary>
        /// PasswortTextBox_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswortTextBox_TextChanged(object sender, EventArgs e)
        {
            PassTxt = PasswortTextBox.Text;
        }
    }
}
