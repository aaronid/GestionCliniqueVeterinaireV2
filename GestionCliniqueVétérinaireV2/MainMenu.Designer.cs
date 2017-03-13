namespace GestionCliniqueVétérinaireV2
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSortie = new System.Windows.Forms.Button();
            this.btnDossiersMedicaux = new System.Windows.Forms.Button();
            this.btnAnimaux = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnRdv = new System.Windows.Forms.Button();
            this.ultraTabbedMdiManager1 = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secrétariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priseDeRendezvousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDeVaccinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(191)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.btnSortie);
            this.panel2.Controls.Add(this.btnDossiersMedicaux);
            this.panel2.Controls.Add(this.btnAnimaux);
            this.panel2.Controls.Add(this.btnClients);
            this.panel2.Controls.Add(this.btnRdv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 751);
            this.panel2.TabIndex = 4;
            // 
            // btnSortie
            // 
            this.btnSortie.FlatAppearance.BorderSize = 0;
            this.btnSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnSortie.Image")));
            this.btnSortie.Location = new System.Drawing.Point(0, 596);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(169, 134);
            this.btnSortie.TabIndex = 4;
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.btnFactures_Click);
            // 
            // btnDossiersMedicaux
            // 
            this.btnDossiersMedicaux.FlatAppearance.BorderSize = 0;
            this.btnDossiersMedicaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDossiersMedicaux.Image = ((System.Drawing.Image)(resources.GetObject("btnDossiersMedicaux.Image")));
            this.btnDossiersMedicaux.Location = new System.Drawing.Point(3, 423);
            this.btnDossiersMedicaux.Name = "btnDossiersMedicaux";
            this.btnDossiersMedicaux.Size = new System.Drawing.Size(169, 134);
            this.btnDossiersMedicaux.TabIndex = 3;
            this.btnDossiersMedicaux.UseVisualStyleBackColor = true;
            this.btnDossiersMedicaux.Click += new System.EventHandler(this.btnDossiersMedicaux_Click);
            // 
            // btnAnimaux
            // 
            this.btnAnimaux.FlatAppearance.BorderSize = 0;
            this.btnAnimaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimaux.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimaux.Image")));
            this.btnAnimaux.Location = new System.Drawing.Point(6, 283);
            this.btnAnimaux.Name = "btnAnimaux";
            this.btnAnimaux.Size = new System.Drawing.Size(163, 134);
            this.btnAnimaux.TabIndex = 2;
            this.btnAnimaux.UseVisualStyleBackColor = true;
            this.btnAnimaux.Click += new System.EventHandler(this.btnAnimaux_Click);
            // 
            // btnClients
            // 
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.Location = new System.Drawing.Point(6, 143);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(163, 134);
            this.btnClients.TabIndex = 1;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnRdv
            // 
            this.btnRdv.FlatAppearance.BorderSize = 0;
            this.btnRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdv.Image = ((System.Drawing.Image)(resources.GetObject("btnRdv.Image")));
            this.btnRdv.Location = new System.Drawing.Point(6, 3);
            this.btnRdv.Name = "btnRdv";
            this.btnRdv.Size = new System.Drawing.Size(163, 134);
            this.btnRdv.TabIndex = 0;
            this.btnRdv.UseVisualStyleBackColor = true;
            this.btnRdv.Click += new System.EventHandler(this.btnRdv_Click);
            // 
            // ultraTabbedMdiManager1
            // 
            this.ultraTabbedMdiManager1.MdiParent = this;
            this.ultraTabbedMdiManager1.SettingsKey = "MainMenu.ultraTabbedMdiManager1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secrétariatToolStripMenuItem,
            this.vétérinairesToolStripMenuItem,
            this.dossiersToolStripMenuItem,
            this.facturationToolStripMenuItem,
            this.facturationToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // secrétariatToolStripMenuItem
            // 
            this.secrétariatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priseDeRendezvousToolStripMenuItem,
            this.stockDeVaccinsToolStripMenuItem});
            this.secrétariatToolStripMenuItem.Name = "secrétariatToolStripMenuItem";
            this.secrétariatToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.secrétariatToolStripMenuItem.Text = "Secrétariat";
            // 
            // priseDeRendezvousToolStripMenuItem
            // 
            this.priseDeRendezvousToolStripMenuItem.Name = "priseDeRendezvousToolStripMenuItem";
            this.priseDeRendezvousToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.priseDeRendezvousToolStripMenuItem.Text = "Prise de Rendez-vous";
            this.priseDeRendezvousToolStripMenuItem.Click += new System.EventHandler(this.priseDeRendezvousToolStripMenuItem_Click);
            // 
            // stockDeVaccinsToolStripMenuItem
            // 
            this.stockDeVaccinsToolStripMenuItem.Name = "stockDeVaccinsToolStripMenuItem";
            this.stockDeVaccinsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.stockDeVaccinsToolStripMenuItem.Text = "Stock de vaccins";
            this.stockDeVaccinsToolStripMenuItem.Click += new System.EventHandler(this.stockDeVaccinsToolStripMenuItem_Click);
            // 
            // vétérinairesToolStripMenuItem
            // 
            this.vétérinairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.changerMotDePasseToolStripMenuItem});
            this.vétérinairesToolStripMenuItem.Name = "vétérinairesToolStripMenuItem";
            this.vétérinairesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.vétérinairesToolStripMenuItem.Text = "Vétérinaires";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // changerMotDePasseToolStripMenuItem
            // 
            this.changerMotDePasseToolStripMenuItem.Name = "changerMotDePasseToolStripMenuItem";
            this.changerMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.changerMotDePasseToolStripMenuItem.Text = "Changer mot de passe";
            this.changerMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMotDePasseToolStripMenuItem_Click);
            // 
            // dossiersToolStripMenuItem
            // 
            this.dossiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.animauxToolStripMenuItem});
            this.dossiersToolStripMenuItem.Name = "dossiersToolStripMenuItem";
            this.dossiersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dossiersToolStripMenuItem.Text = "Dossiers";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // animauxToolStripMenuItem
            // 
            this.animauxToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("animauxToolStripMenuItem.Image")));
            this.animauxToolStripMenuItem.Name = "animauxToolStripMenuItem";
            this.animauxToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.animauxToolStripMenuItem.Text = "Animaux";
            this.animauxToolStripMenuItem.Click += new System.EventHandler(this.animauxToolStripMenuItem_Click);
            // 
            // facturationToolStripMenuItem
            // 
            this.facturationToolStripMenuItem.Name = "facturationToolStripMenuItem";
            this.facturationToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.facturationToolStripMenuItem.Text = "Dossiers médicaux";
            // 
            // facturationToolStripMenuItem1
            // 
            this.facturationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturesToolStripMenuItem,
            this.relancesClientsToolStripMenuItem});
            this.facturationToolStripMenuItem1.Name = "facturationToolStripMenuItem1";
            this.facturationToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.facturationToolStripMenuItem1.Text = "Facturation";
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.facturesToolStripMenuItem.Text = "Factures";
            this.facturesToolStripMenuItem.Click += new System.EventHandler(this.facturesToolStripMenuItem_Click);
            // 
            // relancesClientsToolStripMenuItem
            // 
            this.relancesClientsToolStripMenuItem.Name = "relancesClientsToolStripMenuItem";
            this.relancesClientsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.relancesClientsToolStripMenuItem.Text = "Relances clients";
            this.relancesClientsToolStripMenuItem.Click += new System.EventHandler(this.relancesClientsToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1192, 814);
            this.MinimumSize = new System.Drawing.Size(1192, 814);
            this.Name = "MainMenu";
            this.Text = "Clinique Vétérinaire";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager1;
        private System.Windows.Forms.Button btnRdv;
        private System.Windows.Forms.Button btnSortie;
        private System.Windows.Forms.Button btnDossiersMedicaux;
        private System.Windows.Forms.Button btnAnimaux;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secrétariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priseDeRendezvousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDeVaccinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMotDePasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}