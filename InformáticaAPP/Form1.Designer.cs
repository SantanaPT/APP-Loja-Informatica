﻿namespace InformáticaAPP
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheirosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasMensaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparar_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAvariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_util = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sec = new System.Windows.Forms.Label();
            this.timerSeg = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheirosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.VendasToolStripMenuItem,
            this.reparar_ToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheirosToolStripMenuItem
            // 
            this.ficheirosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.ficheirosToolStripMenuItem.Enabled = false;
            this.ficheirosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ficheirosToolStripMenuItem.Image = global::InformáticaAPP.Properties.Resources.Folders_icon;
            this.ficheirosToolStripMenuItem.Name = "ficheirosToolStripMenuItem";
            this.ficheirosToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.ficheirosToolStripMenuItem.Text = "Ficheiros";
            this.ficheirosToolStripMenuItem.Click += new System.EventHandler(this.ficheirosToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemToolStripMenuItem,
            this.toolStripSeparator3,
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.toolStripSeparator4,
            this.categoriasToolStripMenuItem});
            this.produtosToolStripMenuItem.Enabled = false;
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.produtosToolStripMenuItem.Image = global::InformáticaAPP.Properties.Resources.Monitor_2_icon;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // listagemToolStripMenuItem
            // 
            this.listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            this.listagemToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.listagemToolStripMenuItem.Text = "Listagem";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.apagarToolStripMenuItem.Text = "Apagar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // VendasToolStripMenuItem
            // 
            this.VendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.vendasMensaisToolStripMenuItem});
            this.VendasToolStripMenuItem.Enabled = false;
            this.VendasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VendasToolStripMenuItem.Image = global::InformáticaAPP.Properties.Resources.Basket_Coins_icon;
            this.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem";
            this.VendasToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.VendasToolStripMenuItem.Text = "Vendas";
            // 
            // registarToolStripMenuItem
            // 
            this.registarToolStripMenuItem.Name = "registarToolStripMenuItem";
            this.registarToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.registarToolStripMenuItem.Text = "Registar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // vendasMensaisToolStripMenuItem
            // 
            this.vendasMensaisToolStripMenuItem.Name = "vendasMensaisToolStripMenuItem";
            this.vendasMensaisToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.vendasMensaisToolStripMenuItem.Text = "Vendas Mensais";
            // 
            // reparar_ToolStripMenuItem
            // 
            this.reparar_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeAvariasToolStripMenuItem});
            this.reparar_ToolStripMenuItem.Enabled = false;
            this.reparar_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reparar_ToolStripMenuItem.Image = global::InformáticaAPP.Properties.Resources.Gears_icon;
            this.reparar_ToolStripMenuItem.Name = "reparar_ToolStripMenuItem";
            this.reparar_ToolStripMenuItem.Size = new System.Drawing.Size(134, 36);
            this.reparar_ToolStripMenuItem.Text = "Reparações";
            this.reparar_ToolStripMenuItem.Click += new System.EventHandler(this.reparar_ToolStripMenuItem_Click);
            // 
            // registroDeAvariasToolStripMenuItem
            // 
            this.registroDeAvariasToolStripMenuItem.Name = "registroDeAvariasToolStripMenuItem";
            this.registroDeAvariasToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.registroDeAvariasToolStripMenuItem.Text = "Registo de Avarias";
            this.registroDeAvariasToolStripMenuItem.Click += new System.EventHandler(this.registroDeAvariasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Enabled = false;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShowShortcutKeys = false;
            this.toolStripMenuItem5.Size = new System.Drawing.Size(27, 36);
            this.toolStripMenuItem5.Text = "⠀";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(79, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItem7.Text = "⠀";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(27, 36);
            this.toolStripMenuItem6.Text = "⠀";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 36);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 36);
            this.toolStripMenuItem1.Text = "⠀";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(27, 36);
            this.toolStripMenuItem3.Text = "⠀";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginToolStripMenuItem.Image = global::InformáticaAPP.Properties.Resources.Lock_User_icon;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(44, 36);
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // lbl_util
            // 
            this.lbl_util.AutoSize = true;
            this.lbl_util.BackColor = System.Drawing.Color.Snow;
            this.lbl_util.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_util.Location = new System.Drawing.Point(644, 9);
            this.lbl_util.Name = "lbl_util";
            this.lbl_util.Size = new System.Drawing.Size(44, 18);
            this.lbl_util.TabIndex = 2;
            this.lbl_util.Text = "Login";
            this.lbl_util.Click += new System.EventHandler(this.lbl_util_Click);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.BackColor = System.Drawing.Color.Snow;
            this.label_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_min.Location = new System.Drawing.Point(807, 9);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(23, 16);
            this.label_min.TabIndex = 4;
            this.label_min.Text = "00";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.BackColor = System.Drawing.Color.Snow;
            this.label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.Location = new System.Drawing.Point(758, 9);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(23, 16);
            this.label_hora.TabIndex = 5;
            this.label_hora.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(787, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label_sec
            // 
            this.label_sec.AutoSize = true;
            this.label_sec.BackColor = System.Drawing.Color.Snow;
            this.label_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sec.Location = new System.Drawing.Point(841, 31);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(15, 9);
            this.label_sec.TabIndex = 7;
            this.label_sec.Text = "00";
            this.label_sec.Visible = false;
            // 
            // timerSeg
            // 
            this.timerSeg.Tick += new System.EventHandler(this.timerSeg_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "LOGIN PASSWORD: welcome_";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_sec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.lbl_util);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Loja Informática";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheirosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasMensaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAvariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lbl_util;
        private System.Windows.Forms.ToolStripMenuItem reparar_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sec;
        private System.Windows.Forms.Timer timerSeg;
        private System.Windows.Forms.Label label2;
    }
}

