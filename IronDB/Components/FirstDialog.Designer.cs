
namespace IronDB
{
    partial class FirstDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVUsername = new System.Windows.Forms.DataGridView();
            this.DGVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passwort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVRoles = new System.Windows.Forms.DataGridView();
            this.DGVRolesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUsername
            // 
            this.DGVUsername.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsername.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVID,
            this.Username,
            this.Passwort});
            this.DGVUsername.Location = new System.Drawing.Point(34, 56);
            this.DGVUsername.Name = "DGVUsername";
            this.DGVUsername.Size = new System.Drawing.Size(245, 48);
            this.DGVUsername.TabIndex = 0;
            this.DGVUsername.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsername_CellValueChanged);
            this.DGVUsername.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGVUsername_RowPostPaint);
            this.DGVUsername.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DGVUsername_UserDeletingRow);
            // 
            // DGVID
            // 
            this.DGVID.DataPropertyName = "id";
            this.DGVID.HeaderText = "DGVID";
            this.DGVID.Name = "DGVID";
            this.DGVID.Visible = false;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Passwort
            // 
            this.Passwort.DataPropertyName = "Passwort";
            this.Passwort.HeaderText = "Passwort";
            this.Passwort.Name = "Passwort";
            // 
            // DGVRoles
            // 
            this.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVRolesID,
            this.Roles});
            this.DGVRoles.Location = new System.Drawing.Point(447, 56);
            this.DGVRoles.Name = "DGVRoles";
            this.DGVRoles.Size = new System.Drawing.Size(149, 48);
            this.DGVRoles.TabIndex = 1;
            this.DGVRoles.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DGVRoles_RowPostPaint);
            // 
            // DGVRolesID
            // 
            this.DGVRolesID.DataPropertyName = "RolesId";
            this.DGVRolesID.HeaderText = "id";
            this.DGVRolesID.Name = "DGVRolesID";
            this.DGVRolesID.Visible = false;
            // 
            // Roles
            // 
            this.Roles.DataPropertyName = "Roles";
            this.Roles.HeaderText = "Roles";
            this.Roles.Name = "Roles";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(70, 358);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // FirstDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.DGVRoles);
            this.Controls.Add(this.DGVUsername);
            this.Name = "FirstDialog";
            this.Text = "FirstDialog";
            this.Load += new System.EventHandler(this.FirstDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVUsername;
        private System.Windows.Forms.DataGridView DGVRoles;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passwort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVRolesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roles;
    }
}

