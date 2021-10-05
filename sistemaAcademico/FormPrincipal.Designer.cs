
namespace sistemaAcademico
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_menu = new System.Windows.Forms.Panel();
            this.bt_disciplina = new System.Windows.Forms.Button();
            this.bt_cursos = new System.Windows.Forms.Button();
            this.bt_periodo = new System.Windows.Forms.Button();
            this.pn_header = new System.Windows.Forms.Panel();
            this.lb_statusServer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_status = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pn_menu.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.DimGray;
            this.pn_menu.Controls.Add(this.bt_disciplina);
            this.pn_menu.Controls.Add(this.bt_cursos);
            this.pn_menu.Controls.Add(this.bt_periodo);
            this.pn_menu.Location = new System.Drawing.Point(0, 50);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(189, 451);
            this.pn_menu.TabIndex = 1;
            this.pn_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_menu_Paint);
            // 
            // bt_disciplina
            // 
            this.bt_disciplina.BackColor = System.Drawing.Color.DarkGray;
            this.bt_disciplina.FlatAppearance.BorderSize = 0;
            this.bt_disciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_disciplina.Font = new System.Drawing.Font("Eurostile", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_disciplina.ForeColor = System.Drawing.Color.White;
            this.bt_disciplina.Location = new System.Drawing.Point(-1, 127);
            this.bt_disciplina.Name = "bt_disciplina";
            this.bt_disciplina.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bt_disciplina.Size = new System.Drawing.Size(189, 39);
            this.bt_disciplina.TabIndex = 2;
            this.bt_disciplina.Text = "Disciplina";
            this.bt_disciplina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_disciplina.UseVisualStyleBackColor = false;
            // 
            // bt_cursos
            // 
            this.bt_cursos.BackColor = System.Drawing.Color.DarkGray;
            this.bt_cursos.FlatAppearance.BorderSize = 0;
            this.bt_cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cursos.Font = new System.Drawing.Font("Eurostile", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cursos.ForeColor = System.Drawing.Color.White;
            this.bt_cursos.Location = new System.Drawing.Point(-1, 82);
            this.bt_cursos.Name = "bt_cursos";
            this.bt_cursos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bt_cursos.Size = new System.Drawing.Size(189, 39);
            this.bt_cursos.TabIndex = 1;
            this.bt_cursos.Text = "Cursos";
            this.bt_cursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cursos.UseVisualStyleBackColor = false;
            this.bt_cursos.Click += new System.EventHandler(this.bt_cursos_Click);
            // 
            // bt_periodo
            // 
            this.bt_periodo.BackColor = System.Drawing.Color.DarkGray;
            this.bt_periodo.FlatAppearance.BorderSize = 0;
            this.bt_periodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_periodo.Font = new System.Drawing.Font("Eurostile", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_periodo.ForeColor = System.Drawing.Color.White;
            this.bt_periodo.Location = new System.Drawing.Point(0, 37);
            this.bt_periodo.Name = "bt_periodo";
            this.bt_periodo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bt_periodo.Size = new System.Drawing.Size(189, 39);
            this.bt_periodo.TabIndex = 0;
            this.bt_periodo.Text = "Periodos";
            this.bt_periodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_periodo.UseVisualStyleBackColor = false;
            // 
            // pn_header
            // 
            this.pn_header.BackColor = System.Drawing.Color.Tan;
            this.pn_header.Controls.Add(this.lb_statusServer);
            this.pn_header.Controls.Add(this.button1);
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Margin = new System.Windows.Forms.Padding(0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(800, 50);
            this.pn_header.TabIndex = 0;
            this.pn_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_statusServer
            // 
            this.lb_statusServer.AutoSize = true;
            this.lb_statusServer.BackColor = System.Drawing.Color.Transparent;
            this.lb_statusServer.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_statusServer.Location = new System.Drawing.Point(750, 34);
            this.lb_statusServer.Name = "lb_statusServer";
            this.lb_statusServer.Size = new System.Drawing.Size(37, 13);
            this.lb_statusServer.TabIndex = 1;
            this.lb_statusServer.Text = "Offline";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(753, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_status
            // 
            this.pn_status.BackColor = System.Drawing.Color.GhostWhite;
            this.pn_status.ForeColor = System.Drawing.Color.Transparent;
            this.pn_status.Location = new System.Drawing.Point(189, 393);
            this.pn_status.Name = "pn_status";
            this.pn_status.Size = new System.Drawing.Size(611, 107);
            this.pn_status.TabIndex = 2;
            // 
            // panelChild
            // 
            this.panelChild.Location = new System.Drawing.Point(189, 50);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(611, 340);
            this.panelChild.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.pn_menu);
            this.Controls.Add(this.pn_status);
            this.Controls.Add(this.pn_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pn_menu.ResumeLayout(false);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Button bt_periodo;
        private System.Windows.Forms.Panel pn_header;
        private System.Windows.Forms.Button bt_disciplina;
        private System.Windows.Forms.Button bt_cursos;
        private System.Windows.Forms.Label lb_statusServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_status;
        private System.Windows.Forms.Panel panelChild;
    }
}

