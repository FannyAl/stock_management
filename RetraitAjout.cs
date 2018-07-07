using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //*************   La classe RETRAIT/AJOUT   ***************
    //*********************************************************

    public class RetraitAjout
    {
        // Déclaration des attributs
        #region Attributs de la classe RETRAIT/AJOUT

        private string m_strID_transit;
        private string m_strID_materiel;
        private string m_strID_professionnel;
        private string m_strID_accompagnement;
        private string m_strNom_professionnel;
        private string m_strDate_heure;
        private string m_strType_transit;
        private int m_intQte_materiel_transit;
    
        #endregion


        //PRORPIETES de la classe RETRAIT/AJOUT
        #region Propriétés de la classe RETRAIT/AJOUT

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
        /// PROPRIETE ID Pro
        /// </summary>
        [DisplayName("ID professionnel")]
        public string IdProfessionnel
        {
            get { return m_strID_professionnel; }
            set { m_strID_professionnel = value; }
        }

        /// <summary>
        /// PROPRIETE ID accompagnement
        /// </summary>
        [DisplayName("ID accompagnement")]
        public string IdAccompagnement
        {
            get { return m_strID_accompagnement; }
            set { m_strID_accompagnement = value; }
        }

        /// <summary>
        /// PROPRIETE NOM professionnel
        /// </summary>
        [DisplayName("ID professionnel")]
        public string NomProfessionnel
        {
            get { return m_strNom_professionnel; }
            set { m_strNom_professionnel = value; }
        }

        /// <summary>
        /// PROPRIETE Date & heure
        /// </summary>
        [DisplayName(" Date & heure")]
        public string Date_heure
        {
            get { return m_strDate_heure; }
            set { m_strDate_heure = value; }
        }

        /// <summary>
        /// PROPRIETE Type transit
        /// </summary>
        [DisplayName(" Type Transit")]
        public string Type_transit
        {
            get { return m_strType_transit; }
            set { m_strType_transit = value; }
        }

        /// <summary>
        /// PROPRIETE Qte materiel transit
        /// </summary>
        [DisplayName(" Qte materiel")]
        public int QteMateriel
        {
            get { return m_intQte_materiel_transit; }
            set { m_intQte_materiel_transit = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe INTERACTION
        #region Constructeurs/Destructeur de la class INTERACTION

        // CONSTRUCTEUR d'initialisation
        public RetraitAjout(string IDtrans, string IDmat, string IDpro, string IDacc, string NOMpro, string DateHeure, string TYPEtrans, int QTmat)
        {
            m_strID_transit = IDtrans;
            m_strID_materiel = IDmat;
            m_strID_professionnel = IDpro;
            m_strID_accompagnement = IDacc;
            m_strNom_professionnel = NOMpro;
            m_strDate_heure = DateHeure;
            m_strType_transit = TYPEtrans;
            m_intQte_materiel_transit = QTmat;
        }

        // CONSTRUCTEUR par défault
        public RetraitAjout()
        {
            m_strID_transit = "";
            m_strID_materiel = "";
            m_strID_professionnel = "";
            m_strID_accompagnement = "";
            m_strNom_professionnel = "";
            m_strDate_heure = "";
            m_strType_transit = "";
            m_intQte_materiel_transit = 0;
        }

        #endregion


        // Les METHODES de la classe RETRAIT/AJOUT
        #region METHODES de la classe RETRAIT/AJOUT

        //*********************************************************
        //********  AFFICHE les infos INTERACTION  ****************
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_transit + " " + this.m_strID_materiel + " " + this.m_strID_professionnel + " " + this.m_strID_accompagnement + " " +
            this.m_strNom_professionnel + " " + this.m_strDate_heure + " " + this.m_strType_transit + " " + this.m_intQte_materiel_transit;
        }


        //*********************************************************
        //************  MAJ de la classe INTERACTION   ************
        //*********************************************************
        public void MAJ(RetraitAjout ra)
        {
            // MAJ de toutes les données
            this.m_strID_transit = ra.m_strID_transit;
            this.m_strID_materiel = ra.m_strID_materiel;
            this.m_strID_professionnel = ra.m_strID_professionnel;
            this.m_strID_accompagnement = ra.m_strID_accompagnement;
            this.m_strNom_professionnel = ra.m_strNom_professionnel;
            this.m_strDate_heure = ra.m_strDate_heure;
            this.m_strType_transit = ra.m_strType_transit;
            this.m_intQte_materiel_transit = ra.m_intQte_materiel_transit;

            DAO_RetraitAjout.MAJ_RA(ra);
        }

        #endregion
    }
}
