using MySql.Data;
using Stock_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_menu
{
    public partial class frm_retrait_usager : Form
    {

        //*****************************************************************************
        //************************* Déclaration des variables *************************
        //*****************************************************************************
        Materiels MaterielsList;
        Materiel DonnesMateriel;

        public frm_retrait_usager()
        {
            InitializeComponent();
        }

        //*****************************************************************************
        //****************************Chargement formulaire****************************
        //*****************************************************************************

        private void frm_retrait_usager_Load(object sender, EventArgs e)
        {
            //Création listView du materiel
            alimenter_ListView();

            //Chargement de la liste du materiel dans datagridview
            MaterielsList = new Materiels();
            alimenter_Datagrid();
        }

        #region Alimlentation ListView et Datagrid View

        private void alimenter_ListView()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Acide ascorbique", 0);
            LSTVW_materiel.Items.Add("Acide citrique", 1);
            LSTVW_materiel.Items.Add("Aiguilles", 2);
            LSTVW_materiel.Items.Add("Bouchons oreilles", 3);
            LSTVW_materiel.Items.Add("Crème Apaisante", 4);
            LSTVW_materiel.Items.Add("Eau de préparation pour injection", 5);
            LSTVW_materiel.Items.Add("Feuilles d'aluminium", 6); 
            LSTVW_materiel.Items.Add("Garrot", 7);
            LSTVW_materiel.Items.Add("Kit Base", 8);
            LSTVW_materiel.Items.Add("Lingette douceur", 9);
            LSTVW_materiel.Items.Add("Lubrifiant", 10);
            LSTVW_materiel.Items.Add("Maxicup", 11); 
            LSTVW_materiel.Items.Add("Maximix", 12); 
            LSTVW_materiel.Items.Add("Pipe à craque coudée", 13);
            LSTVW_materiel.Items.Add("Préservatif féminin", 14);
            LSTVW_materiel.Items.Add("Préservatif masculin", 15);
            LSTVW_materiel.Items.Add("Récupérateur", 16);
            LSTVW_materiel.Items.Add("Roule ta paille", 17);
            LSTVW_materiel.Items.Add("Seringue", 18);
            LSTVW_materiel.Items.Add("Seringue insuline", 19);
            LSTVW_materiel.Items.Add("Sérum physiologique", 20);
            LSTVW_materiel.Items.Add("Stericup", 21); 
            LSTVW_materiel.Items.Add("Steriflit", 22);
            LSTVW_materiel.Items.Add("Sterimix", 23);
            LSTVW_materiel.Items.Add("Tampon alcoolisé", 24);

            #endregion
        }

        private void alimenter_Datagrid()
        {
            // Association du DATAGRIDVIEW à la source de données
            DTGRG_materiel.DataSource = null;
            DTGRG_materiel.DataSource = MaterielsList.Liste_Materiel();
        }

        #endregion

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
            //LSTVW_materiel.SelectedItems[0].Text.StartsWith("A");
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewA();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewA()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Acide ascorbique", 0);
            LSTVW_materiel.Items.Add("Acide citrique", 1);
            LSTVW_materiel.Items.Add("Aiguilles", 2);

            #endregion
        }

        // Bouton BCDE
        private void RADIO_BCDE_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres BCDE
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewBCDE();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewBCDE()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Bouchons oreilles", 3);
            LSTVW_materiel.Items.Add("Crème Apaisante", 4);
            LSTVW_materiel.Items.Add("Eau de préparation pour injection", 5);

            #endregion
        }

        // Bouton GHIJK
        private void RADIO_GHIJK_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres GHIJK
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewGHIJK();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewGHIJK()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Garrot", 7);
            LSTVW_materiel.Items.Add("Kit Base", 8);

            #endregion
        }

        // Bouton LMN
        private void RADIO_LMN_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres LMN
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewLMN();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewLMN()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Lingette douceur", 9);
            LSTVW_materiel.Items.Add("Lubrifiant", 10);
            LSTVW_materiel.Items.Add("Maxicup", 11);
            LSTVW_materiel.Items.Add("Maximix", 12); 

            #endregion
        }

        // Bouton OPQ
        private void RADIO_OPQ_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres OPQ
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewOPQ();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewOPQ()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Pipe à craque coudée", 13);
            LSTVW_materiel.Items.Add("Préservatif féminin", 14);
            LSTVW_materiel.Items.Add("Préservatif masculin", 15);

            #endregion
        }

        // Bouton R
        private void RADIO_R_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres R
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewR();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewR()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Récupérateur", 16);
            LSTVW_materiel.Items.Add("Roule ta paille", 17);

            #endregion
        }

        // Bouton S
        private void RADIO_S_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres S
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewS();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewS()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Seringue", 18);
            LSTVW_materiel.Items.Add("Seringue insuline", 19);
            LSTVW_materiel.Items.Add("Sérum physiologique", 20);
            LSTVW_materiel.Items.Add("Stericup", 21);
            LSTVW_materiel.Items.Add("Steriflit", 22);
            LSTVW_materiel.Items.Add("Sterimix", 23);

            #endregion
        }

        // Bouton TUV...
        private void RADIO_TUV_CheckedChanged(object sender, EventArgs e)
        {
            // Recherche par les lettres TUVWXYZ
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListViewTUV();
            Delete_search.Visible = true;
        }

        private void alimenter_ListViewTUV()
        {
            #region ImageList

            // Importation des images de l'ImageList
            LSTVW_materiel.Items.Add("Tampon alcoolisé", 24);

            #endregion
        }

        // Suppression de la recherche en cours
        private void Delete_search_CheckedChanged(object sender, EventArgs e)
        {
            //Efface la liste du matériel
            LSTVW_materiel.Items.Clear();
            alimenter_ListView();
            Delete_search.Visible = false;
        }

        #endregion


        //*****************************************************************************
        //******************************Sélection matériel*****************************
        //*****************************************************************************
        #region Sélection matériel

        private void LSTVW_materiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si SELECTION : materiel existe dans la base de données
            if (LSTVW_materiel.SelectedIndices != null)
            {
                // Récupération de l'intitulé de l'image
                string famille = LSTVW_materiel.SelectedItems[0].Text;
                // Recherche dans la base de données des familles concernées
                Materiels Listefamille = new Materiels();
                Listefamille = MaterielsList.Recherche_parFAMILLE(famille);

                if (Listefamille != null)
                {
                    //Comptabilisation nombre de matériel appartenant à la même famille
                    int nb_type = Listefamille.Count;
                    //Import des informations liées aux matériels concernés pour l'affichage des données
                    //DonnesMateriel = (Materiel)LSTVW_materiel.SelectedItems[];

                    // Affichage détail et pavé numéric
                    #region Visibilité détails matériel / pavé numéric
                    PNL_info_materiel.Visible = true;
                    PNL_pave_numeric.Visible = true;
                    TXTBX_qte_retrait.Text = "";
                    BTN_valider.Enabled = false;
                    // Affichage titre du materiel
                    LBL_titre_materiel.Text = famille;
                    #endregion


                    // Si famille présente une fois alors affichage sans type
                    if (nb_type == 1)
                    {
                        MessageBox.Show("1 type de matériel");

                        //Affichage simple des données du matériel
                        #region Affichage quantité stock
                        TXTBX_qte_courant_stock.Text = DonnesMateriel.Quantité.ToString();
                        #endregion
                    }

                    // Si famille présente plusieurs fois
                    else if (nb_type > 1)
                    {
                        MessageBox.Show(nb_type.ToString());

                        // Affichage des boutons radios
                        #region Gestion des radios boutons
                        if (nb_type == 2)
	                    {
		                    RADIO_type_materiel1.Visible = true;
                            RADIO_type_materiel1.Text= DonnesMateriel.TypeMateriel;
                            RADIO_type_materiel2.Visible = true;
                            RADIO_type_materiel2.Text= DonnesMateriel.TypeMateriel;
                            
                            if(nb_type == 3)
	                        {
		                        RADIO_type_materiel3.Visible = true;
                                RADIO_type_materiel3.Text= DonnesMateriel.TypeMateriel;

                                if(nb_type == 4)
	                            {
		                            RADIO_type_materiel4.Visible = true;
                                    RADIO_type_materiel4.Text= DonnesMateriel.TypeMateriel;

                                    if(nb_type == 5)
	                                {
		                                RADIO_type_materiel5.Visible = true;
                                        RADIO_type_materiel5.Text= DonnesMateriel.TypeMateriel;
	                                }
	                            }
	                        }
	                    }
                        #endregion

                    }

                    // si pas de famille
                    else
                    {
                        MessageBox.Show("La base de données ne parvient pas à retrouver ce materiel");

                        //// Dissimile détail et pavé numéric
                        //#region Visibilité détails matériel / pavé numéric
                        //PNL_info_materiel.Visible = false;
                        //PNL_pave_numeric.Visible = false;
                        //#endregion
                    }
                }
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
            MessageBox.Show("Envoie panier Validé");

            // Dissimile détail et pavé numéric
            #region Visibilité détails matériel / pavé numéric
            PNL_info_materiel.Visible = false;
            PNL_pave_numeric.Visible = false;
            // Désactive le bouton valider
            BTN_valider.Enabled = false;
            #endregion

            // Redirection page panier
            frm_panier_usager f = new frm_panier_usager();
            f.Show();
            this.Hide();
        }

        #endregion

    }
}
