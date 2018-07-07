using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_menu
{
    public partial class frm_login_ajout_materiel : Form
    {
        //*****************************************************************************
        //************************* Déclaration des variables *************************
        //*****************************************************************************
        String Action = "";

        public frm_login_ajout_materiel()
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
        //*******************************Traitements Pro*******************************
        //*****************************************************************************
        #region Professionnel
        // Textbox ID PRO
        private void TXTBX_id_pro_MouseClick(object sender, MouseEventArgs e)
        {

            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            // Focus ID PRO
            TXTBX_id_pro.Focus();
            // Action identifiant professionnel accompagnant
            Action = "IDPRO";
        }

        private void TXTBX_id_pro_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 8 caractères
            if (TXTBX_id_pro.Text.Length >= 8)
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
            frm_ajout_materiel f = new frm_ajout_materiel();
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_a.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_z.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_e.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_r.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_t.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_y.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_u.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_i.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_o.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_p.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_q.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_s.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_d.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_f.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_g.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_h.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_j.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_k.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_l.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_m.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_w.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_x.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_c.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_v.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_b.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_n.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_virgule.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_point.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_2points.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_clavier_pointexclamation.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_7.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_8.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_9.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_4.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_5.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_6.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_1.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_2.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_3.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text += BTN_pavenum_0.Text;
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
            // Si le focus est sur le textbox id professionnel
            if (Action == "IDPRO")
            {
                TXTBX_id_pro.Text = "";
            }
            // Si le focus est sur le textbox mdp professionel
            else if (Action == "MDPPRO")
            {
                TXTBX_mdp_pro.Text = "";
            }
        }

        #endregion

    }
}
