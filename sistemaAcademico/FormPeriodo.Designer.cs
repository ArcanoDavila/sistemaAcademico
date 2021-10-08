
namespace sistemaAcademico
{
    partial class FormPeriodo
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
            this.button1 = new System.Windows.Forms.Button();
            this.bt_salvarPeriodo = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.dg_periodos = new System.Windows.Forms.DataGridView();
            this.lb_title_periodos = new System.Windows.Forms.Label();
            this.bt_deletePeriodo = new System.Windows.Forms.Button();
            this.txt_IdPeriodo = new System.Windows.Forms.TextBox();
            this.txt_pernome = new System.Windows.Forms.TextBox();
            this.txt_persigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_periodos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt_salvarPeriodo
            // 
            this.bt_salvarPeriodo.Location = new System.Drawing.Point(130, 133);
            this.bt_salvarPeriodo.Name = "bt_salvarPeriodo";
            this.bt_salvarPeriodo.Size = new System.Drawing.Size(75, 23);
            this.bt_salvarPeriodo.TabIndex = 1;
            this.bt_salvarPeriodo.Text = "Salvar";
            this.bt_salvarPeriodo.UseVisualStyleBackColor = true;
            this.bt_salvarPeriodo.Click += new System.EventHandler(this.bt_salvarPeriodo_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(426, 266);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 2;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // dg_periodos
            // 
            this.dg_periodos.BackgroundColor = System.Drawing.Color.Silver;
            this.dg_periodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_periodos.Location = new System.Drawing.Point(17, 50);
            this.dg_periodos.Name = "dg_periodos";
            this.dg_periodos.Size = new System.Drawing.Size(338, 239);
            this.dg_periodos.TabIndex = 4;
            // 
            // lb_title_periodos
            // 
            this.lb_title_periodos.AutoSize = true;
            this.lb_title_periodos.Font = new System.Drawing.Font("Eurostile", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_periodos.Location = new System.Drawing.Point(12, 12);
            this.lb_title_periodos.Name = "lb_title_periodos";
            this.lb_title_periodos.Size = new System.Drawing.Size(99, 25);
            this.lb_title_periodos.TabIndex = 5;
            this.lb_title_periodos.Text = "Periodos";
            // 
            // bt_deletePeriodo
            // 
            this.bt_deletePeriodo.Location = new System.Drawing.Point(507, 266);
            this.bt_deletePeriodo.Name = "bt_deletePeriodo";
            this.bt_deletePeriodo.Size = new System.Drawing.Size(75, 23);
            this.bt_deletePeriodo.TabIndex = 3;
            this.bt_deletePeriodo.Text = "Excluir";
            this.bt_deletePeriodo.UseVisualStyleBackColor = true;
            this.bt_deletePeriodo.Click += new System.EventHandler(this.bt_deletePeriodo_Click);
            // 
            // txt_IdPeriodo
            // 
            this.txt_IdPeriodo.Location = new System.Drawing.Point(67, 41);
            this.txt_IdPeriodo.Name = "txt_IdPeriodo";
            this.txt_IdPeriodo.Size = new System.Drawing.Size(138, 20);
            this.txt_IdPeriodo.TabIndex = 6;
            // 
            // txt_pernome
            // 
            this.txt_pernome.Location = new System.Drawing.Point(67, 67);
            this.txt_pernome.Name = "txt_pernome";
            this.txt_pernome.Size = new System.Drawing.Size(138, 20);
            this.txt_pernome.TabIndex = 7;
            // 
            // txt_persigla
            // 
            this.txt_persigla.Location = new System.Drawing.Point(67, 93);
            this.txt_persigla.Name = "txt_persigla";
            this.txt_persigla.Size = new System.Drawing.Size(138, 20);
            this.txt_persigla.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "IdPeriodo:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sigla:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adicionar Periodo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_persigla);
            this.panel1.Controls.Add(this.txt_pernome);
            this.panel1.Controls.Add(this.txt_IdPeriodo);
            this.panel1.Controls.Add(this.bt_salvarPeriodo);
            this.panel1.Location = new System.Drawing.Point(361, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 170);
            this.panel1.TabIndex = 14;
            // 
            // FormPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_title_periodos);
            this.Controls.Add(this.dg_periodos);
            this.Controls.Add(this.bt_deletePeriodo);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeriodo";
            this.Text = "FormPeriodo";
            this.Load += new System.EventHandler(this.FormPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_periodos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_salvarPeriodo;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.DataGridView dg_periodos;
        private System.Windows.Forms.Label lb_title_periodos;
        private System.Windows.Forms.Button bt_deletePeriodo;
        private System.Windows.Forms.TextBox txt_IdPeriodo;
        private System.Windows.Forms.TextBox txt_pernome;
        private System.Windows.Forms.TextBox txt_persigla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}