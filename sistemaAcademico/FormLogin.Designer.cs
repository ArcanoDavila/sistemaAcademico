
namespace sistemaAcademico
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_login = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_errorLogin = new System.Windows.Forms.Label();
            this.bt_closeLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 451);
            this.panel1.TabIndex = 0;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(461, 293);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(183, 31);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "Acceder";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.Control;
            this.txt_user.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.DimGray;
            this.txt_user.Location = new System.Drawing.Point(461, 190);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(183, 26);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "User";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.Font = new System.Drawing.Font("Consolas", 12F);
            this.txt_password.ForeColor = System.Drawing.Color.DimGray;
            this.txt_password.Location = new System.Drawing.Point(461, 222);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(183, 26);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eurostile", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Sys Academy";
            // 
            // lb_errorLogin
            // 
            this.lb_errorLogin.AutoSize = true;
            this.lb_errorLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lb_errorLogin.Location = new System.Drawing.Point(458, 260);
            this.lb_errorLogin.Name = "lb_errorLogin";
            this.lb_errorLogin.Size = new System.Drawing.Size(58, 13);
            this.lb_errorLogin.TabIndex = 5;
            this.lb_errorLogin.Text = "Error Login";
            this.lb_errorLogin.Visible = false;
            // 
            // bt_closeLogin
            // 
            this.bt_closeLogin.BackColor = System.Drawing.SystemColors.Control;
            this.bt_closeLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.bt_closeLogin.FlatAppearance.BorderSize = 0;
            this.bt_closeLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.bt_closeLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.bt_closeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_closeLogin.Location = new System.Drawing.Point(754, 12);
            this.bt_closeLogin.Name = "bt_closeLogin";
            this.bt_closeLogin.Size = new System.Drawing.Size(34, 23);
            this.bt_closeLogin.TabIndex = 4;
            this.bt_closeLogin.Text = "X";
            this.bt_closeLogin.UseVisualStyleBackColor = false;
            this.bt_closeLogin.Click += new System.EventHandler(this.bt_closeLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_closeLogin);
            this.Controls.Add(this.lb_errorLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_errorLogin;
        private System.Windows.Forms.Button bt_closeLogin;
    }
}