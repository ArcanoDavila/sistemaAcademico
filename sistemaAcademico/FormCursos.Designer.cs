
namespace sistemaAcademico
{
    partial class FormCursos
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
            this.bt_close = new System.Windows.Forms.Button();
            this.lb_title_periodos = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.lb_obs = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_perid = new System.Windows.Forms.TextBox();
            this.lb_perid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(536, 12);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(47, 23);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "X";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_title_periodos
            // 
            this.lb_title_periodos.AutoSize = true;
            this.lb_title_periodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_periodos.Location = new System.Drawing.Point(12, 12);
            this.lb_title_periodos.Name = "lb_title_periodos";
            this.lb_title_periodos.Size = new System.Drawing.Size(80, 25);
            this.lb_title_periodos.TabIndex = 6;
            this.lb_title_periodos.Text = "Cursos";
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.Silver;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(17, 40);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(338, 239);
            this.dg.TabIndex = 7;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(492, 256);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 9;
            this.bt_delete.Text = "Excluir";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(411, 256);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 8;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lb_perid);
            this.panel1.Controls.Add(this.txt_perid);
            this.panel1.Controls.Add(this.txt_obs);
            this.panel1.Controls.Add(this.lb_obs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_sigla);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.bt_salvar);
            this.panel1.Location = new System.Drawing.Point(362, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 209);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adicionar Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sigla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IdCurso:";
            // 
            // txt_sigla
            // 
            this.txt_sigla.Location = new System.Drawing.Point(67, 93);
            this.txt_sigla.Name = "txt_sigla";
            this.txt_sigla.Size = new System.Drawing.Size(138, 20);
            this.txt_sigla.TabIndex = 8;
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
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // lb_obs
            // 
            this.lb_obs.AutoSize = true;
            this.lb_obs.Location = new System.Drawing.Point(10, 126);
            this.lb_obs.Name = "lb_obs";
            this.lb_obs.Size = new System.Drawing.Size(29, 13);
            this.lb_obs.TabIndex = 14;
            this.lb_obs.Text = "Obs:";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(67, 119);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(138, 20);
            this.txt_obs.TabIndex = 15;
            // 
            // txt_perid
            // 
            this.txt_perid.Location = new System.Drawing.Point(67, 145);
            this.txt_perid.Name = "txt_perid";
            this.txt_perid.Size = new System.Drawing.Size(138, 20);
            this.txt_perid.TabIndex = 16;
            // 
            // lb_perid
            // 
            this.lb_perid.AutoSize = true;
            this.lb_perid.Location = new System.Drawing.Point(10, 152);
            this.lb_perid.Name = "lb_perid";
            this.lb_perid.Size = new System.Drawing.Size(57, 13);
            this.lb_perid.TabIndex = 17;
            this.lb_perid.Text = "Periodo ID";
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(595, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lb_title_periodos);
            this.Controls.Add(this.bt_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_title_periodos;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_perid;
        private System.Windows.Forms.TextBox txt_perid;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.Label lb_obs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sigla;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button bt_salvar;
    }
}