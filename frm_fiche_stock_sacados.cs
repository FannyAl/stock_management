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
    public partial class frm_fiche_stock_sacados : Form
    {
        //*****************************************************************************
        //************************* Déclaration des variables *************************
        //*****************************************************************************
        String Action = "";

        public frm_fiche_stock_sacados()
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
            // Message d'alerte avant déconnexion du compte
            MessageBox.Show("Etes-vous sûr de vouloir retourner au menu ? Votre compte va être déconnecté", "Confirmation", MessageBoxButtons.YesNo);

            // Re-direction du formulaire Menu
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

        // Bouton GESTION compte USAGER
        private void BTN_gestion_compte_usager_Click(object sender, EventArgs e)
        {
            frm_gestion_compte_usager f = new frm_gestion_compte_usager();
            f.Show();
            this.Hide();
        }

        // Bouton GESTION compte STOCK
        private void BTN_gestion_compte_stock_Click(object sender, EventArgs e)
        {
            frm_gestion_stock f = new frm_gestion_stock();
            f.Show();
            this.Hide();
        }

        // Bouton GESTION compte PRO
        private void BTN_gestion_compte_pro_Click(object sender, EventArgs e)
        {
            frm_gestion_compte_pro f = new frm_gestion_compte_pro();
            f.Show();
            this.Hide();
        }

        #endregion


        //*****************************************************************************
        //******************************Données du compte******************************
        //*****************************************************************************
        #region Actions

        // Clique sur bouton corbeille => supprimer
        private void BTN_trash_Click(object sender, EventArgs e)
        {
            // Ouverture messageBox de confirmation
            MessageBox.Show("Etes-vous sûr de vouloir supprimer ce compte usager ?", "Confirmation", MessageBoxButtons.YesNo);

            // Suppression du compte
        }

        // Clique sur bouton modifier
        private void BTN_edit_Click(object sender, EventArgs e)
        {
            #region Activation modification de données
            TXTBX_nom_stock.Enabled = true;
            TXTBX_adress.Enabled = true;
            TXTBX_info.Enabled = true;
            #endregion

            //Focus sur le textbox
            TXTBX_nom_stock.Focus();
            Action = "MAJ";

            #region visibilité valider / annuler
            BTN_delete.Visible = true;
            BTN_validate.Visible = true;
            #endregion
        }

        // Clique sur bouton NOUVEAU
        private void BTN_nouveau_Click(object sender, EventArgs e)
        {
            // Textbox vides
            TXTBX_nom_stock.Text = "";
            TXTBX_adress.Text = "";
            TXTBX_info.Text = "";

            //Focus sur le textbox
            TXTBX_nom_stock.Focus();
            Action = "AJOUT";

            #region visibilité valider / annuler
            BTN_delete.Visible = true;
            BTN_validate.Visible = true;
            #endregion
        }

        #endregion


        #region Gestion textbox

        // Evenement MouseClick
        private void TXTBX_nom_MouseClick(object sender, MouseEventArgs e)
        {
            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            // Focus Nom de stock
            TXTBX_nom_stock.Focus();
            // Action identifiant professionnel accompagnant
            Action = "NOM";
        }

        private void TXTBX_adress_MouseClick(object sender, MouseEventArgs e)
        {
            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            // Focus adresse
            TXTBX_adress.Focus();
            // Action identifiant professionnel accompagnant
            Action = "ADRESSE";
        }

        private void TXTBX_info_MouseClick(object sender, MouseEventArgs e)
        {
            #region Visibilité claviers
            PNL_clavier.Visible = true;
            PNL_pave_numeric.Visible = true;
            #endregion

            // Focus Infos
            TXTBX_info.Focus();
            // Action identifiant professionnel accompagnant
            Action = "INFO";
        }

        // Evenement textchanged
        private void TXTBX_nom_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 8 caractères
            if (TXTBX_nom_stock.Text.Length >= 8)
            {
                //Gestion des contôles
                BTN_validate.Enabled = true;
            }
        }

        private void TXTBX_adress_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 4 caractères
            if (TXTBX_adress.Text.Length >= 4)
            {
                //Gestion des contôles
                BTN_validate.Enabled = true;
            }
        }

        private void TXTBX_info_TextChanged(object sender, EventArgs e)
        {
            //Si saisie minimale d'au moins 1 caractère
            if (TXTBX_info.Text.Length >= 1)
            {
                //Gestion des contôles
                BTN_validate.Enabled = true;
            }
        }
        #endregion


        #region Valider ou annuler manipulation

        // Bouton Valider
        private void BTN_validate_Click(object sender, EventArgs e)
        {

        }

        // Bouton Annuler
        private void BTN_delete_Click(object sender, EventArgs e)
        {
            //Message d'alerte avant de rétablir les anciennes saisies
            MessageBox.Show("Etes-vous sûr de vouloir réinitialiser les informations de cette bibliothèque ?", "Confirmation", MessageBoxButtons.YesNo);

            // Réinitialisation de la page avant les modifications
            //Affiche_txtbox();

            //Désactivation des boutons Enregistrer et Effacer
            BTN_validate.Visible = false;
            BTN_validate.Visible = false;
        }

        #endregion


        //*****************************************************************************
        //************************Bouton Retour gestion stock**************************
        //*****************************************************************************


        //*****************************************************************************
        //**********************Clavier alphabétique / numérique***********************
        //*****************************************************************************
        #region Clavier alphabétique

        // A
        private void BTN_clavier_a_Click(object sender, EventArgs e)
        {
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_a.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_a.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_a.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_z.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_z.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_z.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_e.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_e.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_e.Text;
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
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_r.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_r.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_r.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_t.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_t.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_t.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_y.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_y.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_y.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_u.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_u.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_u.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_i.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_i.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_i.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_o.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_o.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_o.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_p.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_p.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_p.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_q.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_q.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_q.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_s.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_s.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_s.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_d.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_d.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_d.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_f.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_f.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_f.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_g.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_g.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_g.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_h.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_h.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_h.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_j.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_j.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_j.Text;
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
           
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_k.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_k.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_k.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_l.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_l.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_l.Text;
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
           
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_m.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_m.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_m.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_w.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_w.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_w.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_x.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_x.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_x.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_c.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_c.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_c.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_v.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_v.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_v.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_b.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_b.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_b.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_n.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_n.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_n.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_virgule.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_virgule.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_virgule.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_point.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_point.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_point.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_2points.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_2points.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_2points.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_clavier_pointexclamation.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_clavier_pointexclamation.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_clavier_pointexclamation.Text;
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
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_7.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_7.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_7.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_8.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_8.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_8.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_9.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_9.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_9.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_4.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_4.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_4.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_5.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_5.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_5.Text;
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
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_6.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_6.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_6.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_1.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_1.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_1.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_2.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_2.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_2.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_3.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_3.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_3.Text;
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
            
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text += BTN_pavenum_0.Text;
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text += BTN_pavenum_0.Text;
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text += BTN_pavenum_0.Text;
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
            // Si le focus est sur le textbox Nom du stock
            if (Action == "NOM")
            {
                TXTBX_nom_stock.Text = "";
            }
            // Si le focus est sur le textbox adresse
            else if (Action == "ADRESSE")
            {
                TXTBX_adress.Text = "";
            }
            // Si le focus est sur le textbox mdp
            else if (Action == "INFO")
            {
                TXTBX_info.Text = "";
            }
        }

        #endregion

    }
}
