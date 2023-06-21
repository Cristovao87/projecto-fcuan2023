namespace provedor_de_identidade.v001.UI
{
    partial class UIPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnUserApp = new System.Windows.Forms.Button();
            this.btnAplicacao = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnMinimo);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 95);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(127, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "v.FCUAN - CC001/2023";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serviço de Gestão de Identidade";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.btnUserApp);
            this.panelMenu.Controls.Add(this.btnAplicacao);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 95);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 592);
            this.panelMenu.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.lbData);
            this.panel3.Controls.Add(this.lblHora);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(280, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 97);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.Black;
            this.lbData.Location = new System.Drawing.Point(780, 64);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(216, 21);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Luanda, 29 de Março 2023";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(821, 25);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(143, 39);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "21:49:45";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(280, 95);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1067, 495);
            this.panelPrincipal.TabIndex = 3;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // btnUserApp
            // 
            this.btnUserApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserApp.FlatAppearance.BorderSize = 0;
            this.btnUserApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUserApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnUserApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserApp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserApp.ForeColor = System.Drawing.Color.Black;
            this.btnUserApp.Image = ((System.Drawing.Image)(resources.GetObject("btnUserApp.Image")));
            this.btnUserApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserApp.Location = new System.Drawing.Point(4, 341);
            this.btnUserApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserApp.Name = "btnUserApp";
            this.btnUserApp.Size = new System.Drawing.Size(269, 75);
            this.btnUserApp.TabIndex = 6;
            this.btnUserApp.Text = " Utilizador/Aplicação";
            this.btnUserApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserApp.UseVisualStyleBackColor = true;
            this.btnUserApp.Click += new System.EventHandler(this.btnUserApp_Click);
            // 
            // btnAplicacao
            // 
            this.btnAplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicacao.FlatAppearance.BorderSize = 0;
            this.btnAplicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicacao.ForeColor = System.Drawing.Color.Black;
            this.btnAplicacao.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicacao.Image")));
            this.btnAplicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicacao.Location = new System.Drawing.Point(5, 258);
            this.btnAplicacao.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicacao.Name = "btnAplicacao";
            this.btnAplicacao.Size = new System.Drawing.Size(269, 75);
            this.btnAplicacao.TabIndex = 5;
            this.btnAplicacao.Text = "Aplicações";
            this.btnAplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAplicacao.UseVisualStyleBackColor = true;
            this.btnAplicacao.Click += new System.EventHandler(this.btnAplicacao_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(4, 175);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(269, 75);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = " Utilizadores";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(5, 90);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(269, 77);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.Image = global::provedor_de_identidade.v001.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(231, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 44);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimo
            // 
            this.btnMinimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimo.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMinimo.Image = global::provedor_de_identidade.v001.Properties.Resources.minimize;
            this.btnMinimo.Location = new System.Drawing.Point(1188, 22);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(43, 43);
            this.btnMinimo.TabIndex = 6;
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.btnMinimo_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMaximizar.Image = global::provedor_de_identidade.v001.Properties.Resources.maximize__1_;
            this.btnMaximizar.Location = new System.Drawing.Point(1237, 22);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(43, 44);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.bntMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFechar.Image = global::provedor_de_identidade.v001.Properties.Resources.close__2_;
            this.btnFechar.Location = new System.Drawing.Point(1286, 22);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 44);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::provedor_de_identidade.v001.Properties.Resources.logo_login;
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 687);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAplicacao;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUserApp;
    }
}