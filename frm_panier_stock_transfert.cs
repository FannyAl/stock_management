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
    public partial class frm_panier_stock_transfert : Form
    {
        public frm_panier_stock_transfert()
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
        //************************Actions boutons par matériel*************************
        //*****************************************************************************
        #region Bouton matériel

        // Supprimer ce matériel
        private void BTN_trash_Click(object sender, EventArgs e)
        {
            PIC_materiel.Visible = false;
            LBL_titre_outil.Visible = false;
            LBL_type.Visible = false;
            LBL_X.Visible = false;
            LBL_qte_retrait.Visible = false;
            BTN_trash.Visible = false;
            BTN_less.Visible = false;
            BTN_plus.Visible = false;
        }

        // Moins de matériel
        private void BTN_less_Click(object sender, EventArgs e)
        {
            LBL_qte_retrait.Text = Convert.ToString(Convert.ToInt32(LBL_qte_retrait.Text) - 1);
        }

        // Plus de matériel
        private void BTN_plus_Click(object sender, EventArgs e)
        {
            LBL_qte_retrait.Text = Convert.ToString(Convert.ToInt32(LBL_qte_retrait.Text) + 1);
        }

        #endregion


        //*****************************************************************************
        //**********************Actions boutons valider/annuler************************
        //*****************************************************************************
        #region Valider
        private void BTN_validate_Click(object sender, EventArgs e)
        {
            // Calcul quantités stock, envoie données
            // Affichge message
            MessageBox.Show("Retrait Validé");

            // Redirection page accueil
            frm_menu f = new frm_menu();
            f.Show();
            this.Hide();
        }
        #endregion

        #region Annuler retrait
        private void BTN_delete_Click(object sender, EventArgs e)
        {
            // Affichge message d'alerte
            MessageBox.Show("Etes-vous sûr de vouloir annuler ce retrait ?", "Confirmation", MessageBoxButtons.YesNo);

            // Redirection menu
            frm_menu f = new frm_menu();
            f.Show();
            this.Hide();
        }
        #endregion

    }
}
