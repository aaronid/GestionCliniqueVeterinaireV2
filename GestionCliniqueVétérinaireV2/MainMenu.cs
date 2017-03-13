using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCliniqueVétérinaireV2
{
    public partial class MainMenu : Form
    {
        // Déclaration sans instance des différents écrans
        RendezVousForm ecranRdv;
        ClientsForm ecranClients;
        VaccinsForm ecranVaccins;
        VeterinairesForm ecranVeterinaires;
        AnimauxForm ecranAnimaux;
        DossiersForm ecranDossiers;
        FacturesForm ecranFactures;
        AgendaForm ecranAgenda;
        RelancesForm ecranRelances;
        
        public MainMenu()
        {
            InitializeComponent();

            // Définition des toolTips des boutons de menu
            toolTip1.SetToolTip(btnRdv, "Prise de rendez-vous");
            toolTip1.SetToolTip(btnSortie, "Quitter l'application");
            toolTip1.SetToolTip(btnClients, "Gérer les clients");
            toolTip1.SetToolTip(btnAnimaux, "Gérer les animaux");
            toolTip1.SetToolTip(btnDossiersMedicaux, "Dossiers médicaux");

        }


        #region Gestion des fenêtres

        /// <summary>
        /// Ouverture unique de la fenêtre Rendez-vous
        /// au clic sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRdv_Click(object sender, EventArgs e)
        {
            if(ecranRdv == null)
            {
                ecranRdv = new RendezVousForm();
                ecranRdv.MdiParent = this;
                ecranRdv.Show();
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Clients
        /// au clic sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClients_Click(object sender, EventArgs e)
        {
            if (ecranClients == null)
            {
                ecranClients = new ClientsForm();
                ecranClients.MdiParent = this;
                ecranClients.Show(); 
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Animaux
        /// au clic sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimaux_Click(object sender, EventArgs e)
        {
            if (ecranAnimaux == null)
            {
                ecranAnimaux = new AnimauxForm();
                ecranAnimaux.MdiParent = this;
                ecranAnimaux.Show(); 
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Dossiers médicaux
        /// au clic sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDossiersMedicaux_Click(object sender, EventArgs e)
        {
            if (ecranDossiers == null)
            {
                ecranDossiers = new DossiersForm();
                ecranDossiers.MdiParent = this;
                ecranDossiers.Show(); 
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Factures
        /// au clic sur le bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactures_Click(object sender, EventArgs e)
        {
            if (ecranFactures == null)
            {
                ecranFactures = new FacturesForm();
                ecranFactures.MdiParent = this;
                ecranFactures.Show(); 
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Rendez-vous
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priseDeRendezvousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRdv_Click(sender, e);
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Vaccins
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockDeVaccinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ecranVaccins == null)
            {
                ecranVaccins = new VaccinsForm();
                ecranVaccins.MdiParent = this;
                ecranVaccins.Show();
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Agenda
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ecranAgenda == null)
            {
                ecranAgenda = new AgendaForm();
                ecranAgenda.MdiParent = this;
                ecranAgenda.Show();
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Mot de passe
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changerMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ecranVeterinaires == null)
            {
                ecranVeterinaires = new VeterinairesForm();
                ecranVeterinaires.MdiParent = this;
                ecranVeterinaires.Show();
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Clients
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClients_Click(sender, e);
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Animaux
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ecranAnimaux == null)
            {
                ecranAnimaux = new AnimauxForm();
                ecranAnimaux.MdiParent = this;
                ecranAnimaux.Show();
            }
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Factures
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFactures_Click(sender, e);
        }

        /// <summary>
        /// Ouverture unique de la fenêtre Relances
        /// au clic sur le menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void relancesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ecranRelances == null)
            {
                ecranRelances = new RelancesForm();
                ecranRelances.MdiParent = this;
                ecranRelances.Show();
            }
        }

        #endregion


        //private void FenetreSuperieure(Form form)
        //{
        //    if (form.Equals(ecranRdv))
        //    {
        //        ecranRdv.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranAgenda))
        //    {
        //        ecranAgenda.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranAnimaux))
        //    {
        //        ecranAnimaux.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranClients))
        //    {
        //        ecranClients.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranFactures))
        //    {

        //        ecranFactures.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranDossiers))
        //    {
        //        ecranDossiers.TopMost = true;
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranClients); 
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);             
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranVeterinaires))
        //    {
        //        ecranVeterinaires.TopMost = true;
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranVaccins))
        //    {
        //        ecranVaccins.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //        VerificationFormNull(ecranRelances);
        //    }
        //    if (form.Equals(ecranRelances))
        //    {
        //        ecranRelances.TopMost = true;
        //        VerificationFormNull(ecranDossiers);
        //        VerificationFormNull(ecranRdv);
        //        VerificationFormNull(ecranClients);
        //        VerificationFormNull(ecranVaccins);
        //        VerificationFormNull(ecranVeterinaires);
        //        VerificationFormNull(ecranAnimaux);
        //        VerificationFormNull(ecranFactures);
        //        VerificationFormNull(ecranAgenda);
        //    }
        //}

        //private void VerificationFormNull(Form form)
        //{
        //    bool estNull = false;

        //    if(form == null)
        //    {
        //        estNull = true;
        //    }
        //    else
        //    {
        //        form.TopMost = false;
        //    }


        //}
    }
}
