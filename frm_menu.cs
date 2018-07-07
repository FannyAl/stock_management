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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }


        /// <summary>
        /// App fonctionnalities 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        // Clique bouton retrait
        private void BTN_retrait_Click(object sender, EventArgs e)
        {
            frm_login_retrait_usager f = new frm_login_retrait_usager();
            f.Show();
            this.Hide();
        }

        // Clique bouton transfert
        private void BTN_tranfert_Click(object sender, EventArgs e)
        {
            frm_login_transfert_materiel f = new frm_login_transfert_materiel();
            f.Show();
            this.Hide();
        }

        // Clique bouton ajout
        private void BTN_ajout_Click(object sender, EventArgs e)
        {
            frm_login_ajout_materiel f = new frm_login_ajout_materiel();
            f.Show();
            this.Hide();
        }

        // Clique bouton paramètre => dirige vers la fenêtre d'administration
        private void BTN_Parametres_Click(object sender, EventArgs e)
        {
            frm_login_admin f = new frm_login_admin();
            f.Show();
            this.Hide();
        }

    }
}
