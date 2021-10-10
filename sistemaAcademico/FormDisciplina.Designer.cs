
namespace sistemaAcademico
{
    partial class FormDisciplina
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
            this.lb_curid = new System.Windows.Forms.Label();
            this.txt_curid = new System.Windows.Forms.TextBox();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.lb_obs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sigla = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lb_title = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lb_curid);
            this.panel1.Controls.Add(this.txt_curid);
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
            this.panel1.Location = new System.Drawing.Point(362, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 209);
            this.panel1.TabIndex = 19;
            // 
            // lb_curid
            // 
            this.lb_curid.AutoSize = true;
            this.lb_curid.Location = new System.Drawing.Point(10, 152);
            this.lb_curid.Name = "lb_curid";
            this.lb_curid.Size = new System.Drawing.Size(48, 13);
            this.lb_curid.TabIndex = 17;
            this.lb_curid.Text = "Curso ID";
            // 
            // txt_curid
            // 
            this.txt_curid.Location = new System.Drawing.Point(67, 145);
            this.txt_curid.Name = "txt_curid";
            this.txt_curid.Size = new System.Drawing.Size(138, 20);
            this.txt_curid.TabIndex = 16;
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(67, 119);
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(138, 20);
            this.txt_obs.TabIndex = 15;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adicionar Disciplina";
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
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(492, 263);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 18;
            this.bt_delete.Text = "Excluir";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(411, 263);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 17;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // dg
            // 
            this.dg.BackgroundColor = System.Drawing.Color.Silver;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(17, 47);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(338, 239);
            this.dg.TabIndex = 16;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(17, 19);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(105, 25);
            this.lb_title.TabIndex = 18;
            this.lb_title.Text = "Disciplina";
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(541, 9);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(47, 23);
            this.bt_close.TabIndex = 18;
            this.bt_close.Text = "X";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 301);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.dg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDisciplina";
            this.Text = "FormDisciplina";
            this.Load += new System.EventHandler(this.FormDisciplinas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_curid;
        private System.Windows.Forms.TextBox txt_curid;
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
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button bt_close;
    }
}