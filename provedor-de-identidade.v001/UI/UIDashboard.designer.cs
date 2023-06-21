namespace provedor_de_identidade.v001.UI
{
    partial class UIDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.lblAplicacao = new System.Windows.Forms.Panel();
            this.lblNumAplicacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUtilizadores = new System.Windows.Forms.Panel();
            this.lblNumUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGerarGrafico = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvUsApp = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.lblAplicacao.SuspendLayout();
            this.lblUtilizadores.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Controls.Add(this.lblAplicacao);
            this.panel1.Controls.Add(this.lblUtilizadores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 211);
            this.panel1.TabIndex = 0;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.Location = new System.Drawing.Point(1026, 0);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(43, 43);
            this.BtnFechar.TabIndex = 24;
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblAplicacao
            // 
            this.lblAplicacao.BackColor = System.Drawing.Color.White;
            this.lblAplicacao.Controls.Add(this.lblNumAplicacao);
            this.lblAplicacao.Controls.Add(this.label2);
            this.lblAplicacao.Location = new System.Drawing.Point(50, 80);
            this.lblAplicacao.Margin = new System.Windows.Forms.Padding(5);
            this.lblAplicacao.Name = "lblAplicacao";
            this.lblAplicacao.Size = new System.Drawing.Size(405, 73);
            this.lblAplicacao.TabIndex = 22;
            // 
            // lblNumAplicacao
            // 
            this.lblNumAplicacao.AutoSize = true;
            this.lblNumAplicacao.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAplicacao.Location = new System.Drawing.Point(160, 38);
            this.lblNumAplicacao.Name = "lblNumAplicacao";
            this.lblNumAplicacao.Size = new System.Drawing.Size(76, 23);
            this.lblNumAplicacao.TabIndex = 1;
            this.lblNumAplicacao.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(68, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de aplicações registadas";
            // 
            // lblUtilizadores
            // 
            this.lblUtilizadores.BackColor = System.Drawing.Color.White;
            this.lblUtilizadores.Controls.Add(this.lblNumUsuario);
            this.lblUtilizadores.Controls.Add(this.label4);
            this.lblUtilizadores.Location = new System.Drawing.Point(544, 80);
            this.lblUtilizadores.Margin = new System.Windows.Forms.Padding(5);
            this.lblUtilizadores.Name = "lblUtilizadores";
            this.lblUtilizadores.Size = new System.Drawing.Size(443, 73);
            this.lblUtilizadores.TabIndex = 22;
            // 
            // lblNumUsuario
            // 
            this.lblNumUsuario.AutoSize = true;
            this.lblNumUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUsuario.Location = new System.Drawing.Point(197, 38);
            this.lblNumUsuario.Name = "lblNumUsuario";
            this.lblNumUsuario.Size = new System.Drawing.Size(76, 23);
            this.lblNumUsuario.TabIndex = 1;
            this.lblNumUsuario.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(101, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total de utilizadores registados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.btnGerarGrafico);
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1072, 401);
            this.panel5.TabIndex = 1;
            // 
            // btnGerarGrafico
            // 
            this.btnGerarGrafico.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGerarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarGrafico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarGrafico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnGerarGrafico.Location = new System.Drawing.Point(24, 8);
            this.btnGerarGrafico.Margin = new System.Windows.Forms.Padding(5);
            this.btnGerarGrafico.Name = "btnGerarGrafico";
            this.btnGerarGrafico.Size = new System.Drawing.Size(433, 35);
            this.btnGerarGrafico.TabIndex = 20;
            this.btnGerarGrafico.Text = "Aplicações mais utilizadas";
            this.btnGerarGrafico.UseVisualStyleBackColor = true;
            this.btnGerarGrafico.Click += new System.EventHandler(this.btnGerarGrafico_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(24, 51);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(433, 213);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "Aplicações mais utilizadas";
            title2.Name = "Aplicações mais utilizadas/Mês";
            this.chart1.Titles.Add(title2);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dgvUsApp);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(467, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(550, 256);
            this.panel6.TabIndex = 13;
            // 
            // dgvUsApp
            // 
            this.dgvUsApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsApp.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsApp.Location = new System.Drawing.Point(10, 45);
            this.dgvUsApp.Name = "dgvUsApp";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsApp.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsApp.RowHeadersWidth = 51;
            this.dgvUsApp.Size = new System.Drawing.Size(531, 197);
            this.dgvUsApp.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label13.Location = new System.Drawing.Point(19, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Utilizadores/Aplicações";
            // 
            // UIDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 612);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIDashboard";
            this.Text = "UIDashboard";
            this.panel1.ResumeLayout(false);
            this.lblAplicacao.ResumeLayout(false);
            this.lblAplicacao.PerformLayout();
            this.lblUtilizadores.ResumeLayout(false);
            this.lblUtilizadores.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lblAplicacao;
        private System.Windows.Forms.Label lblNumAplicacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel lblUtilizadores;
        private System.Windows.Forms.Label lblNumUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvUsApp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGerarGrafico;
    }
}