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
    public partial class frm_transfert_stock : Form
    {
        public frm_transfert_stock()
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

        // Bouton RETRAIT MATERIEL
        private void BTN_ajout_materiel_Click(object sender, EventArgs e)
        {
            frm_retrait_usager f = new frm_retrait_usager();
            f.Show();
            this.Hide();
        }

        // Bouton PANIER
        private void BTN_panier_Click(object sender, EventArgs e)
        {
            frm_panier_usager f = new frm_panier_usager();
            f.Show();
            this.Hide();
        }

        // Bouton COMPTE USAGER
        private void BTN_compte_usager_Click(object sender, EventArgs e)
        {
            frm_compte_usager f = new frm_compte_usager();
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
        //******************************Affichage Recherche****************************
        //*****************************************************************************
        #region Recherche

        // Bouton A
        private void RADIO_A_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par la lettre A
        }

        // Bouton BCDE
        private void RADIO_BCDE_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres BCDE
        }

        // Bouton GHIJK
        private void RADIO_GHIJK_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres GHIJK
        }

        // Bouton LMN
        private void RADIO_LMN_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres LMN
        }

        // Bouton OPQ
        private void RADIO_OPQ_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres OPQ
        }

        // Bouton R
        private void RADIO_R_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres R
        }

        // Bouton S
        private void RADIO_S_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres S
        }

        // Bouton TUV...
        private void RADIO_TUV_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres TUVWXYZ
        }

        // Si déselection d'un bouton : suppression de la recherche en cours ou ajouter bouton annuler/retour

        #endregion


        //*****************************************************************************
        //******************************Sélection matériel*****************************
        //*****************************************************************************
        #region Sélection matériel

        private void BTN_materiel_Click(object sender, EventArgs e)
        {
            // Si sélection
            if (PNL_info_materiel.Visible == false)
            {
                // Affichage détail et pavé numéric
                #region Visibilité détails matériel / pavé numéric
                PNL_info_materiel.Visible = true;
                PNL_pave_numeric.Visible = true;
                TXTBX_qte_retrait.Text = "";
                BTN_valider.Enabled = false;
                #endregion

                #region Gestion affichage détails
                // Affichage du titre
                LBL_titre_materiel.Text = BTN_materiel.Text;
                // Affichage du type si existe
                if (true)
                {
                    // Génération et affichage des boutons radios
                    RADIO_type_materiel1.Visible = true;
                }
                // Affichage de la quantité en stock
                //TXTBX_qte_courant_stock.Text = qte;
                #endregion
            }

            // Si déselection
            else
            {
                // Dissimile détail et pavé numéric
                #region Visibilité détails matériel / pavé numéric
                PNL_info_materiel.Visible = false;
                PNL_pave_numeric.Visible = false;
                #endregion
            }
        }

        #endregion


        //*****************************************************************************
        //**************************** Fonctions pavé numéric *************************
        //*****************************************************************************
        #region Pavé numérique

        // Bouton 7
        private void BTN_pavenum_7_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_7.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 8
        private void BTN_pavenum_8_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_8.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 9
        private void BTN_pavenum_9_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_9.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 4
        private void BTN_pavenum_4_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_4.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 5
        private void BTN_pavenum_5_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_5.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 6
        private void BTN_pavenum_6_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_6.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 1
        private void BTN_pavenum_1_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_1.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 2
        private void BTN_pavenum_2_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_2.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 3
        private void BTN_pavenum_3_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_3.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // Bouton 0
        private void BTN_pavenum_0_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text += BTN_pavenum_0.Text;
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        // EFFACER 
        private void BTN_pavenum_clear_Click(object sender, EventArgs e)
        {
            TXTBX_qte_retrait.Text = "";
            // Réactivation bouton valider
            BTN_valider.Enabled = true;
        }

        #endregion


        //*****************************************************************************
        //****************************** Validation sélection *************************
        //*****************************************************************************
        #region Validation

        // Bouton Valider
        private void BTN_valider_Click(object sender, EventArgs e)
        {
            // Valider ok ///////////////////////////

            // Affichage messsage de validation envoie panier
            MessageBox.Show("Envoie vers le panier du stock Validé");

            // Dissimile détail et pavé numéric
            #region Visibilité détails matériel / pavé numéric
            PNL_info_materiel.Visible = false;
            PNL_pave_numeric.Visible = false;
            // Désactive le bouton valider
            BTN_valider.Enabled = false;
            #endregion

            // Redirection page panier
            frm_panier_stock_transfert f = new frm_panier_stock_transfert();
            f.Show();
            this.Hide();
        }

        #endregion
    }
}
