
namespace sistemaAcademico
{
    partial class FormUser
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
            this.lb_title_users = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.checkAdm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title_users
            // 
            this.lb_title_users.AutoSize = true;
            this.lb_title_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_users.Location = new System.Drawing.Point(12, 9);
            this.lb_title_users.Name = "lb_title_users";
            this.lb_title_users.Size = new System.Drawing.Size(97, 25);
            this.lb_title_users.TabIndex = 7;
            this.lb_title_users.Text = "Usuarios";
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.Silver;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(17, 37);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(338, 239);
            this.dg.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.checkAdm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.bt_salvar);
            this.panel1.Location = new System.Drawing.Point(362, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 209);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dados Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(67, 67);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(138, 20);
            this.txt_nome.TabIndex = 7;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(67, 41);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(138, 20);
            this.txt_Id.TabIndex = 6;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(130, 171);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 1;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(510, 253);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 18;
            this.bt_delete.Text = "Excluir";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(429, 253);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 17;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // checkAdm
            // 
            this.checkAdm.AutoSize = true;
            this.checkAdm.Location = new System.Drawing.Point(13, 110);
            this.checkAdm.Name = "checkAdm";
            this.checkAdm.Size = new System.Drawing.Size(89, 17);
            this.checkAdm.TabIndex = 14;
            this.checkAdm.Text = "Administrador";
            this.checkAdm.UseVisualStyleBackColor = true;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 301);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lb_title_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title_users;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.CheckBox checkAdm;
    }
}