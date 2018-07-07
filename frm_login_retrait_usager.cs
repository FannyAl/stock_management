using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace frm_menu
{
    public partial class frm_login_retrait_usager : Form
    {
        //*****************************************************************************
        //************************* Déclaration des variables *************************
        //*****************************************************************************
        String Action = "";

        public frm_login_retrait_usager()
        {
            InitializeComponent();
        }

        //*****************************************************************************
        //******************************Barre de navigation****************************
        //*****************************************************************************
        #region Barre de navigation

        // Bouton MENU
        private void BTN_return_menu_Click(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            f.Show();
            this.Hide();
        }

        // Bouton ADMIN => dirige vers la fenêtre d'administration
        private void BTN_Parametres_Click(object sender, EventArgs e)
        {
            frm_login_admin f = new frm_login_admin();
            f.Show();
            this.Hide();
        }
        
        #endregion


        //*****************************************************************************
        //******************************Traitements Usager*****************************
        //*****************************************************************************
        #region Usager

        // Clique Textbox ID USAGER
        private void TXTBX_id_usager_Click(object sender, EventArgs e)
        {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion

                #region Visibilité images textbox
                    PIC_id_usager.Visible = true ;
                    PIC_search_ico.Visible = false;
                    PIC_ajout_usager.Visible = false;
                    BTN_identification_usager.Visible = false; 
                #endregion

                // Changement text label usager
                LBL_usager.Text = "Identification usager";
                // Focus ID USAGER
                TXTBX_id_usager.Focus();
                // Action identifiant usager
                Action = "USAGER";
        }

        // Bouton RECHERCHE id usager => affichage liste Auto_complet
        private void BTN_search_Click(object sender, EventArgs e)
        {
            // Déclencher fonction nouvel id usager
            TXTBX_id_usager.Text = "";

            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            #region Visibilité images textbox
            PIC_id_usager.Visible = false;
            PIC_search_ico.Visible = true;
            PIC_ajout_usager.Visible = false;
            BTN_identification_usager.Visible = true; 
            #endregion

            // Changement text label usager
            LBL_usager.Text = "Rechercher un usager";
            // Focus ID USAGER
            TXTBX_id_usager.Focus();
            // Action rechercher un usager dans une liste
            Action = "RECHERCHE";

            // Activation option auto-complete
            //TXTBX_id_usager.AutoCompleteCustomSource = Collection;
            //TXTBX_id_usager.AutoCompleteMode = SuggestAppend;
            //TXTBX_id_usager.AutoCompleteSource = 

        }

        //Bouton NOUVEAU usager
        private void BTN_nouveau_usager_Click(object sender, EventArgs e)
        {
            // Déclencher fonction nouvel id usager
            TXTBX_id_usager.Text = "";

            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            #region Visibilité images textbox
            PIC_id_usager.Visible = false;
            PIC_search_ico.Visible = false;
            PIC_ajout_usager.Visible = true;
            BTN_identification_usager.Visible = true; 
            #endregion

            // Changement text label usager
            LBL_usager.Text = "Nouvel usager (NP00/00M)";
            // Focus ID USAGER
            TXTBX_id_usager.Focus();
            TXTBX_id_usager.Text = "";
            // Action créer un nouvel usager
            Action = "NOUVEAU";
        }

        // Clique Bouton identification Usager 
        private void BTN_identification_usager_Click(object sender, EventArgs e)
        {
            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            #region Visibilité images textbox
            PIC_id_usager.Visible = true;
            PIC_search_ico.Visible = false;
            PIC_ajout_usager.Visible = false;
            BTN_identification_usager.Visible = false;
            #endregion

            // Changement text label usager
            LBL_usager.Text = "Identification usager";
            // Focus ID USAGER
            TXTBX_id_usager.Focus();
            // Action identifiant usager
            Action = "USAGER";
        }

        //Contrôle de saisie Textbox ID USAGER
        private void TXTBX_id_usager_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 3 caractères
            if (TXTBX_id_usager.Text.Length >= 3)
            {
                //Gestion des contôles
                BTN_valider.Enabled = true;
            }
        }

        #endregion


        //*****************************************************************************
        //*******************************Traitements Pro*******************************
        //*****************************************************************************
        #region Professionnel accompagnant
        // Textbox ID PRO
        private void TXTBX_id_pro_MouseClick(object sender, MouseEventArgs e)
        {

            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            // Focus ID PRO
            TXTBX_nom_pro.Focus();
            // Action identifiant professionnel accompagnant
            Action = "IDPRO";
        }
        private void TXTBX_id_pro_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 8 caractères
            if (TXTBX_nom_pro.Text.Length >= 8)
            {
                //Gestion des contôles
                BTN_valider.Enabled = true;
            }
        }


        // Textbox MDP PRO
        private void TXTBX_mdp_pro_MouseClick(object sender, MouseEventArgs e)
        {

            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            // Focus MDP PRO
            TXTBX_mdp_pro.Focus();
            // Action mot de passe professionnel accompagnant
            Action = "MDPPRO";
        }
        private void TXTBX_mdp_pro_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 1 caractères
            if (TXTBX_mdp_pro.Text.Length >= 1)
            {
                //Gestion des contôles
                BTN_valider.Enabled = true;
            }
        }
        #endregion


        //*****************************************************************************
        //*****************************Modalité de retrait*****************************
        //*****************************************************************************
        #region Modalités de retrait

        // Radio button RETRAIT DIRECT
        private void RADIO_retrait_direct_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Radio button cas LIVRAISON
        private void RADIO_livraison_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        #endregion


        //*****************************************************************************
        //***************************** Bouton valider ********************************
        //*****************************************************************************
        private void BTN_valider_Click(object sender, EventArgs e)
        {
            // Si identification valide ouvrir le formulaire de retrait
            //if (Action == "NOUVEAU")
            //{
                // Validation saisie nouvel ID usager 
                //if (idUsager_Valide(TXTBX_id_usager.Text))
                //{
                //    errorProvider.SetError(TXTBX_id_usager, ""); // Efface le symbole erreur
                //}
                //else
                //{
                    //errorProvider.SetError(TXTBX_id_usager, "Saisie d'identifiant usager invalide."); // Affiche le symbole erreur avec affichage infobulle
                    //TXTBX_id_usager.Focus();
                    //return;
                //}

                //Génère nouveau CODE BIBLIOTHEQUE
                //NOUVEAU_Code_Biblio();
                //Ajout de cette bibliothèque dans la base de données
                //ListeBibliothèques.AJOUT_new(TRANSFERT_données_saisies());
                //Message d'information enregistrement réussit
                //MessageBox.Show("Ajout dans la base de donnée réussit.");

                // Si identification valide ouvrir le formulaire de RETRAIT pour les usagers
                //frm_gestion_compte_usager f = new frm_gestion_compte_usager();
                //f.Show();
                //this.Hide();
            //}

            // Si saisie de donnée traditionnelle 
            //else
            //{
                // Contrôle de saisie dans chaque textbox
                // Validation saisie nouvel ID usager 
                //if (idUsager_Valide(TXTBX_id_usager.Text))
                //{
                //    errorProvider.SetError(TXTBX_id_usager, ""); // Efface le symbole erreur
                //}
                //else
                //{
                //    errorProvider.SetError(TXTBX_id_usager, "Saisie d'identifiant usager invalide."); // Affiche le symbole erreur avec affichage infobulle
                //    TXTBX_id_usager.Focus();
                //    return;
                //}

                //Modification des données de cette bibliothèque dans la base de données
                //ListeBibliothèques.MAJ_liste_biblio(TRANSFERT_données_saisies());
                //Message d'information enregistrement réussit
                //MessageBox.Show("Enregitrement des modifications réussit.");

                // Si identification valide ouvrir le formulaire de RETRAIT pour les usagers
                frm_retrait_usager f = new frm_retrait_usager();
                f.Show();
                this.Hide();
            //}
        }


        //*****************************************************************************
        //**********************Clavier alphabétique / numérique***********************
        //*****************************************************************************
        #region Clavier alphabétique

        // A
        private void BTN_clavier_a_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_a.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_a.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_a.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Z
        private void BTN_clavier_z_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_z.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_z.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_z.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // E
        private void BTN_clavier_e_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_e.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_e.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_e.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // R
        private void BTN_clavier_r_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_r.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_r.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_r.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //T
        private void BTN_clavier_t_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_t.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_t.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_t.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //Y
        private void BTN_clavier_y_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_y.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_y.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_y.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // U
        private void BTN_clavier_u_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_u.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_u.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_u.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //I
        private void BTN_clavier_i_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_i.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_i.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_i.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //O
        private void BTN_clavier_o_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_o.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_o.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_o.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //P
        private void BTN_clavier_p_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_p.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_p.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_p.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //Q
        private void BTN_clavier_q_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_q.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_q.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_q.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        //S
        private void BTN_clavier_s_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_s.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_s.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_s.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_d_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_d.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_d.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_d.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_f_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_f.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_f.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_f.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_g_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_g.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_g.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_g.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_h_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_h.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_h.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_h.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_j_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_j.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_j.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_j.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_k_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_k.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_k.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_k.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_l_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_l.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_l.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_l.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_m_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_m.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_m.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_m.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_w_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_w.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_w.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_w.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_x_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_x.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_x.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_x.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_c_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_c.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_c.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_c.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_v_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_v.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_v.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_v.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_b_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_b.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_b.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_b.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        private void BTN_clavier_n_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_n.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_n.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_n.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Virgule
        private void BTN_clavier_virgule_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_virgule.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_virgule.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_virgule.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }
        
        // Point
        private void BTN_clavier_point_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_point.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_point.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_point.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // 2 points
        private void BTN_clavier_2points_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_2points.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_2points.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_2points.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Point d'exclamation !
        private void BTN_clavier_pointexclamation_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_clavier_pointexclamation.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_clavier_pointexclamation.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_clavier_pointexclamation.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }
        #endregion

        
        #region Pavé numérique

        // Bouton 7
        private void BTN_pavenum_7_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_7.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_7.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_7.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 8
        private void BTN_pavenum_8_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_8.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_8.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_8.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 9
        private void BTN_pavenum_9_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_9.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_9.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_9.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 4
        private void BTN_pavenum_4_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_4.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_4.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_4.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 5
        private void BTN_pavenum_5_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_5.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_5.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_5.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 6
        private void BTN_pavenum_6_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_6.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_6.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_6.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 1
        private void BTN_pavenum_1_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_1.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_1.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_1.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 2
        private void BTN_pavenum_2_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_2.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_2.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_2.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 3
        private void BTN_pavenum_3_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_3.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_3.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_3.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }

        // Bouton 0
        private void BTN_pavenum_0_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text += BTN_pavenum_0.Text;
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text += BTN_pavenum_0.Text;
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text += BTN_pavenum_0.Text;
            }
            // Si pas de focus 
            else
            {
                #region Visibilité claviers
                PNL_clavier.Visible = true;
                PNL_pave_numeric.Visible = true;
                #endregion
            }
        }
        
        #endregion


        #region Actions clavier spécifiques 

        // EFFACER 
        private void BTN_pavenum_clear_Click(object sender, EventArgs e)
        {
            // Si le focus est sur le textbox id usager
            if ((Action == "USAGER") || (Action == "RECHERCHE") || (Action == "NOUVEAU"))
            {
                TXTBX_id_usager.Text = "";
            }
            // Si le focus est sur le textbox id professionnel
            else if (Action == "IDPRO")
            {
                TXTBX_nom_pro.Text = "";
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text = "";
            }
        }

        #endregion


        //*****************************************************************************
        //**************************Contrôle de saisie ********************************
        //*****************************************************************************

        //static bool idUsager_Valide(string idusager)
        //{
        //    // De forme 2 lettres(Nom et Prénom) 4 chiffres (Mois et Année de naissance) et lettre (genre M ou F)
        //    return Regex.IsMatch(idusager,  @"^[A-Za-z]{2}+[0-9]{4}+[A-Za-z]");
        //}

    }
}
