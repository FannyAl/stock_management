using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //****************   La classe MATERIEL   *****************
    //*********************************************************

    public class Materiel
    {
        // Déclaration des attributs
        #region Attributs de la classe MATERIEL

        private string m_strID_materiel;
        private string m_strID_transit;
        private string m_strTitre_materiel;
        private string m_strType_materiel;
        private string m_strFamille_materiel;
        private int m_intQte_materiel_stock;
        private bool m_boolDisponibilite;
        private int m_intSeuil_alerte;
    
        #endregion


        //PRORPIETES de la classe Matériel
        #region Propriétés de la classe materiel

        /// <summary>
        /// PROPRIETE ID Materiel
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Materiel")]
        public string IDMateriel
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_materiel; }
            set { m_strID_materiel = value; }
        }

        /// <summary>
        /// PROPRIETE ID transit
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID transit")]
        public string IDTransit
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_transit; }
            set { m_strID_transit = value; }
        }

        /// <summary>
        /// PROPRIETE Titre Materiel
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("Titre materiel")]
        public string TitreMateriel 
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strTitre_materiel; }
            set { m_strTitre_materiel = value; } 
        }

        /// <summary>
        /// PROPRIETE Type Materiel
        /// </summary>
        [DisplayName("Type materiel")]
        public string TypeMateriel
        {
            get { return m_strType_materiel; }
            set { m_strType_materiel = value; }
        }

        /// <summary>
        /// PROPRIETE Famille Materiel
        /// </summary>
        [DisplayName("Famille materiel")]
        public string FamilleMateriel
        {
            get { return m_strFamille_materiel; }
            set { m_strFamille_materiel = value; }
        }

        /// <summary>
        /// PROPRIETE Quantité stockée
        /// </summary>
        [DisplayName("Qte en stock")]
        public int Quantité
        {
            get { return m_intQte_materiel_stock; }
            set { m_intQte_materiel_stock = value; }
        }

        /// <summary>
        /// PROPRIETE Disponibilité
        /// </summary>
        [DisplayName("Dispo")]
        public bool DispoMateriel
        {
            get { return m_boolDisponibilite; }
            set { m_boolDisponibilite = value; }
        }

        /// <summary>
        /// PROPRIETE Seuil alerte
        /// </summary>
        [DisplayName("Alerte")]
        public int Seuil_alert
        {
            get { return m_intSeuil_alerte; }
            set { m_intSeuil_alerte = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Matériel
        #region Constructeurs/Destructeur de la classe Materiel

        // CONSTRUCTEUR d'initialisation
        public Materiel(string IDmat, string IDtran, string titre, string type, string famille, int Qte, bool dispo, int alert)
        {
            m_strID_materiel = IDmat;
            m_strID_transit = IDtran;
            m_strTitre_materiel = titre;
            m_strType_materiel = type;
            m_strFamille_materiel = famille;
            m_intQte_materiel_stock = Qte;
            m_boolDisponibilite = dispo;
            m_intSeuil_alerte = alert;
        }

        // CONSTRUCTEUR par défault
        public Materiel()
        {
            m_strID_materiel = "";
            m_strID_transit = "";
            m_strTitre_materiel = "";
            m_strType_materiel = "";
            m_strFamille_materiel = "";
            m_intQte_materiel_stock = 1;
            m_boolDisponibilite = true;
            m_intSeuil_alerte = 0;
        }

        #endregion


        // Les METHODES de la classe Materiel
        #region METHODES de la classe Materiel

        //*********************************************************
        //*************  AFFICHE les infos materiel  **************
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_materiel + " " + this.m_strID_transit + " " + this.m_strTitre_materiel + " " + this.m_strType_materiel + " " + this.m_strFamille_materiel + " " + Convert.ToInt32(this.m_intQte_materiel_stock) + this.m_boolDisponibilite + " " + Convert.ToInt32(this.m_intSeuil_alerte);
        }


        //*********************************************************
        //*******************  MAJ du Materiel    *****************
        //*********************************************************
        public void MAJ(Materiel m)
        {
            // MAJ de toutes les données
            this.m_strID_materiel = m.m_strID_materiel;
            this.m_strID_transit = m.m_strID_transit;
            this.m_strTitre_materiel = m.m_strTitre_materiel;
            this.m_strType_materiel = m.m_strType_materiel;
            this.m_strFamille_materiel = m.m_strFamille_materiel;
            this.m_intQte_materiel_stock = m.m_intQte_materiel_stock;
            this.m_boolDisponibilite = m.m_boolDisponibilite;
            this.m_intSeuil_alerte = m.m_intSeuil_alerte;

            DAO_Materiel.MAJ_Materiel(m);
        }

        #endregion
    }
}

