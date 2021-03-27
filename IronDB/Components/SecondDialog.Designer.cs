
namespace IronDB.Components
{
    partial class SecondDialog
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswortLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(167, 143);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(55, 13);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Username";
            // 
            // PasswortLabel
            // 
            this.PasswortLabel.AutoSize = true;
            this.PasswortLabel.Location = new System.Drawing.Point(167, 182);
            this.PasswortLabel.Name = "PasswortLabel";
            this.PasswortLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswortLabel.TabIndex = 1;
            this.PasswortLabel.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(258, 256);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(165, 21);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(258, 136);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(191, 20);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PasswortTextBox
            // 
            this.PasswortTextBox.Location = new System.Drawing.Point(258, 175);
            this.PasswortTextBox.Name = "PasswortTextBox";
            this.PasswortTextBox.Size = new System.Drawing.Size(191, 20);
            this.PasswortTextBox.TabIndex = 4;
            this.PasswortTextBox.TextChanged += new System.EventHandler(this.PasswortTextBox_TextChanged);
            // 
            // SecondDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswortTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswortLabel);
            this.Controls.Add(this.UserLabel);
            this.Name = "SecondDialog";
            this.Text = "SecondDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswortLabel;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswortTextBox;
    }
}