namespace GestionCliniqueVétérinaireV2
{
    partial class RendezVousForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RendezVousForm));
            this.gridRdv = new System.Windows.Forms.DataGridView();
            this.codeRdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veterinaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceAnimalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gpClientsRdv = new System.Windows.Forms.GroupBox();
            this.lblVeto = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnAjoutAnimal = new System.Windows.Forms.Button();
            this.btnAjoutClient = new System.Windows.Forms.Button();
            this.cbVeterinaire = new System.Windows.Forms.ComboBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.gpDateRdv = new System.Windows.Forms.GroupBox();
            this.btnUrgences = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblRdv = new System.Windows.Forms.Label();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbHeures = new System.Windows.Forms.ComboBox();
            this.calendarRdv = new System.Windows.Forms.MonthCalendar();
            this.btnSupprimerRdv = new System.Windows.Forms.Button();
            this.lblAjout = new System.Windows.Forms.Label();
            this.lblUrgences = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpClientsRdv.SuspendLayout();
            this.gpDateRdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRdv
            // 
            this.gridRdv.AllowUserToAddRows = false;
            this.gridRdv.AllowUserToDeleteRows = false;
            this.gridRdv.AllowUserToResizeColumns = false;
            this.gridRdv.AllowUserToResizeRows = false;
            this.gridRdv.AutoGenerateColumns = false;
            this.gridRdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRdv.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gridRdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeRdvDataGridViewTextBoxColumn,
            this.veterinaireDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn,
            this.nomAnimalDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.raceAnimalDataGridViewTextBoxColumn,
            this.dateRDVDataGridViewTextBoxColumn});
            this.gridRdv.DataSource = this.agendaBindingSource;
            this.gridRdv.Location = new System.Drawing.Point(27, 329);
            this.gridRdv.Name = "gridRdv";
            this.gridRdv.RowHeadersVisible = false;
            this.gridRdv.RowHeadersWidth = 60;
            this.gridRdv.Size = new System.Drawing.Size(893, 348);
            this.gridRdv.TabIndex = 6;
            // 
            // codeRdvDataGridViewTextBoxColumn
            // 
            this.codeRdvDataGridViewTextBoxColumn.DataPropertyName = "CodeRdv";
            this.codeRdvDataGridViewTextBoxColumn.HeaderText = "CodeRdv";
            this.codeRdvDataGridViewTextBoxColumn.Name = "codeRdvDataGridViewTextBoxColumn";
            // 
            // veterinaireDataGridViewTextBoxColumn
            // 
            this.veterinaireDataGridViewTextBoxColumn.DataPropertyName = "Veterinaire";
            this.veterinaireDataGridViewTextBoxColumn.HeaderText = "Veterinaire";
            this.veterinaireDataGridViewTextBoxColumn.Name = "veterinaireDataGridViewTextBoxColumn";
            // 
            // animalDataGridViewTextBoxColumn
            // 
            this.animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            this.animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            this.animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            // 
            // nomAnimalDataGridViewTextBoxColumn
            // 
            this.nomAnimalDataGridViewTextBoxColumn.DataPropertyName = "NomAnimal";
            this.nomAnimalDataGridViewTextBoxColumn.HeaderText = "NomAnimal";
            this.nomAnimalDataGridViewTextBoxColumn.Name = "nomAnimalDataGridViewTextBoxColumn";
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            // 
            // raceAnimalDataGridViewTextBoxColumn
            // 
            this.raceAnimalDataGridViewTextBoxColumn.DataPropertyName = "RaceAnimal";
            this.raceAnimalDataGridViewTextBoxColumn.HeaderText = "RaceAnimal";
            this.raceAnimalDataGridViewTextBoxColumn.Name = "raceAnimalDataGridViewTextBoxColumn";
            // 
            // dateRDVDataGridViewTextBoxColumn
            // 
            this.dateRDVDataGridViewTextBoxColumn.DataPropertyName = "DateRDV";
            this.dateRDVDataGridViewTextBoxColumn.HeaderText = "DateRDV";
            this.dateRDVDataGridViewTextBoxColumn.Name = "dateRDVDataGridViewTextBoxColumn";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataSource = typeof(BO.Agenda);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpClientsRdv
            // 
            this.gpClientsRdv.Controls.Add(this.lblVeto);
            this.gpClientsRdv.Controls.Add(this.lblAnimal);
            this.gpClientsRdv.Controls.Add(this.lblClient);
            this.gpClientsRdv.Controls.Add(this.btnAjoutAnimal);
            this.gpClientsRdv.Controls.Add(this.btnAjoutClient);
            this.gpClientsRdv.Controls.Add(this.cbVeterinaire);
            this.gpClientsRdv.Controls.Add(this.cbAnimal);
            this.gpClientsRdv.Controls.Add(this.cbClient);
            this.gpClientsRdv.Location = new System.Drawing.Point(27, 63);
            this.gpClientsRdv.Name = "gpClientsRdv";
            this.gpClientsRdv.Size = new System.Drawing.Size(506, 245);
            this.gpClientsRdv.TabIndex = 7;
            this.gpClientsRdv.TabStop = false;
            this.gpClientsRdv.Text = "Informations client";
            // 
            // lblVeto
            // 
            this.lblVeto.AutoSize = true;
            this.lblVeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeto.Location = new System.Drawing.Point(31, 139);
            this.lblVeto.Name = "lblVeto";
            this.lblVeto.Size = new System.Drawing.Size(77, 17);
            this.lblVeto.TabIndex = 7;
            this.lblVeto.Text = "Vétérinaire";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(31, 85);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(50, 17);
            this.lblAnimal.TabIndex = 6;
            this.lblAnimal.Text = "Animal";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(31, 58);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 17);
            this.lblClient.TabIndex = 5;
            this.lblClient.Text = "Client";
            // 
            // btnAjoutAnimal
            // 
            this.btnAjoutAnimal.BackColor = System.Drawing.Color.LightBlue;
            this.btnAjoutAnimal.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjoutAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutAnimal.Location = new System.Drawing.Point(389, 81);
            this.btnAjoutAnimal.Name = "btnAjoutAnimal";
            this.btnAjoutAnimal.Size = new System.Drawing.Size(96, 21);
            this.btnAjoutAnimal.TabIndex = 4;
            this.btnAjoutAnimal.Text = "Nouvel Animal";
            this.btnAjoutAnimal.UseVisualStyleBackColor = false;
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.BackColor = System.Drawing.Color.LightBlue;
            this.btnAjoutClient.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjoutClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutClient.Location = new System.Drawing.Point(389, 54);
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.Size = new System.Drawing.Size(96, 21);
            this.btnAjoutClient.TabIndex = 3;
            this.btnAjoutClient.Text = "Nouveau Client";
            this.btnAjoutClient.UseVisualStyleBackColor = false;
            // 
            // cbVeterinaire
            // 
            this.cbVeterinaire.FormattingEnabled = true;
            this.cbVeterinaire.Location = new System.Drawing.Point(119, 135);
            this.cbVeterinaire.Name = "cbVeterinaire";
            this.cbVeterinaire.Size = new System.Drawing.Size(264, 21);
            this.cbVeterinaire.TabIndex = 2;
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(119, 81);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(264, 21);
            this.cbAnimal.TabIndex = 1;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(119, 54);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(264, 21);
            this.cbClient.TabIndex = 0;
            // 
            // gpDateRdv
            // 
            this.gpDateRdv.Controls.Add(this.lblUrgences);
            this.gpDateRdv.Controls.Add(this.lblAjout);
            this.gpDateRdv.Controls.Add(this.btnUrgences);
            this.gpDateRdv.Controls.Add(this.btnAjout);
            this.gpDateRdv.Controls.Add(this.lblHeure);
            this.gpDateRdv.Controls.Add(this.lblRdv);
            this.gpDateRdv.Controls.Add(this.cbMinutes);
            this.gpDateRdv.Controls.Add(this.cbHeures);
            this.gpDateRdv.Controls.Add(this.calendarRdv);
            this.gpDateRdv.Location = new System.Drawing.Point(539, 63);
            this.gpDateRdv.Name = "gpDateRdv";
            this.gpDateRdv.Size = new System.Drawing.Size(424, 245);
            this.gpDateRdv.TabIndex = 8;
            this.gpDateRdv.TabStop = false;
            this.gpDateRdv.Text = "Date du rendez-vous";
            // 
            // btnUrgences
            // 
            this.btnUrgences.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUrgences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgences.Image = ((System.Drawing.Image)(resources.GetObject("btnUrgences.Image")));
            this.btnUrgences.Location = new System.Drawing.Point(309, 25);
            this.btnUrgences.Name = "btnUrgences";
            this.btnUrgences.Size = new System.Drawing.Size(81, 77);
            this.btnUrgences.TabIndex = 11;
            this.btnUrgences.UseVisualStyleBackColor = true;
            // 
            // btnAjout
            // 
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Image = ((System.Drawing.Image)(resources.GetObject("btnAjout.Image")));
            this.btnAjout.Location = new System.Drawing.Point(309, 135);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(81, 93);
            this.btnAjout.TabIndex = 10;
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.Location = new System.Drawing.Point(169, 204);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(18, 17);
            this.lblHeure.TabIndex = 9;
            this.lblHeure.Text = "H";
            // 
            // lblRdv
            // 
            this.lblRdv.AutoSize = true;
            this.lblRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdv.Location = new System.Drawing.Point(48, 204);
            this.lblRdv.Name = "lblRdv";
            this.lblRdv.Size = new System.Drawing.Size(47, 17);
            this.lblRdv.TabIndex = 8;
            this.lblRdv.Text = "Heure";
            // 
            // cbMinutes
            // 
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(192, 200);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(58, 21);
            this.cbMinutes.TabIndex = 2;
            // 
            // cbHeures
            // 
            this.cbHeures.FormattingEnabled = true;
            this.cbHeures.Location = new System.Drawing.Point(101, 200);
            this.cbHeures.Name = "cbHeures";
            this.cbHeures.Size = new System.Drawing.Size(62, 21);
            this.cbHeures.TabIndex = 1;
            // 
            // calendarRdv
            // 
            this.calendarRdv.Location = new System.Drawing.Point(23, 25);
            this.calendarRdv.Name = "calendarRdv";
            this.calendarRdv.TabIndex = 0;
            // 
            // btnSupprimerRdv
            // 
            this.btnSupprimerRdv.FlatAppearance.BorderSize = 0;
            this.btnSupprimerRdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerRdv.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerRdv.Image")));
            this.btnSupprimerRdv.Location = new System.Drawing.Point(925, 349);
            this.btnSupprimerRdv.Name = "btnSupprimerRdv";
            this.btnSupprimerRdv.Size = new System.Drawing.Size(38, 39);
            this.btnSupprimerRdv.TabIndex = 12;
            this.btnSupprimerRdv.UseVisualStyleBackColor = true;
            this.btnSupprimerRdv.Click += new System.EventHandler(this.btnSupprimerRdv_Click);
            // 
            // lblAjout
            // 
            this.lblAjout.AutoSize = true;
            this.lblAjout.Location = new System.Drawing.Point(330, 215);
            this.lblAjout.Name = "lblAjout";
            this.lblAjout.Size = new System.Drawing.Size(40, 13);
            this.lblAjout.TabIndex = 13;
            this.lblAjout.Text = "Ajouter";
            // 
            // lblUrgences
            // 
            this.lblUrgences.AutoSize = true;
            this.lblUrgences.Location = new System.Drawing.Point(319, 89);
            this.lblUrgences.Name = "lblUrgences";
            this.lblUrgences.Size = new System.Drawing.Size(62, 13);
            this.lblUrgences.TabIndex = 13;
            this.lblUrgences.Text = "Rdv Urgent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ajouter un rendez-vous au calendrier";
            // 
            // RendezVousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimerRdv);
            this.Controls.Add(this.gpDateRdv);
            this.Controls.Add(this.gpClientsRdv);
            this.Controls.Add(this.gridRdv);
            this.Name = "RendezVousForm";
            this.Text = "Prise de Rendez-vous";
            ((System.ComponentModel.ISupportInitialize)(this.gridRdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpClientsRdv.ResumeLayout(false);
            this.gpClientsRdv.PerformLayout();
            this.gpDateRdv.ResumeLayout(false);
            this.gpDateRdv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeRdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veterinaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceAnimalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gpDateRdv;
        private System.Windows.Forms.GroupBox gpClientsRdv;
        private System.Windows.Forms.Button btnSupprimerRdv;
        private System.Windows.Forms.Button btnUrgences;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblRdv;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbHeures;
        private System.Windows.Forms.MonthCalendar calendarRdv;
        private System.Windows.Forms.Label lblVeto;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnAjoutAnimal;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.ComboBox cbVeterinaire;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lblAjout;
        private System.Windows.Forms.Label lblUrgences;
        private System.Windows.Forms.Label label1;
    }
}