using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //***********   La classe TRANSIT   ****************
    //*********************************************************

    class Transit
    {
        // Déclaration des attributs
        #region Attributs de la class TRANSIT

        private string m_strIDMateriel;
        private string m_strIdPro;
        private string m_strMdpPro;
        private string m_strIDAccompag;
        private string m_strDate_heure;
    
        #endregion


        //PRORPIETES de la classe Transit
        #region Propriétés de la class transit

        /// <summary>
        /// PROPRIETE ID Materiel
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Materiel")]
        public string IDMateriel
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strIDMateriel; }
            set { m_strIDMateriel = value; } 
        }

        /// <summary>
        /// PROPRIETE ID Pro
        /// </summary>
        [DisplayName("ID professionnel")]
        public string IdPro
        {
            get { return m_strIdPro; }
            set { m_strIdPro = value; }
        }

        /// <summary>
        /// PROPRIETE Mdp Pro
        /// </summary>
        [DisplayName("Mdp professionnel")]
        public string MdpPro
        {
            get { return m_strMdpPro; }
            set { m_strMdpPro = value; }
        }

        /// <summary>
        /// PROPRIETE ID Bînome
        /// </summary>
        [DisplayName("ID bînome")]
        public string IdBinome
        {
            get { return m_strIDAccompag; }
            set { m_strIDAccompag = value; }
        }

        /// <summary>
        /// PROPRIETE Date & heure
        /// </summary>
        [DisplayName("Date & Heure")]
        public string DateHeure
        {
            get { return m_strDate_heure; }
            set { m_strDate_heure = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Transit
        #region Constructeurs/Destructeur de la class Accompagnement

        // CONSTRUCTEUR d'initialisation
        public Transit(string IdMateriel, string IdPro, string MdpPro, string IdBinome, string DateHeure)
        {
            m_strIDMateriel = IdMateriel;
            m_strIdPro = IdPro;
            m_strMdpPro = MdpPro;
            m_strIDAccompag = IdBinome;
            m_strDate_heure = DateHeure;
        }

        // CONSTRUCTEUR par défault
        public Transit()
        {
            m_strIDMateriel = "";
            m_strIdPro = "";
            m_strMdpPro = "";
            m_strIDAccompag = "";
            m_strDate_heure = "";
        }

        #endregion


        // Les METHODES de la classe Transit
        #region METHODES de la class Transit

        //*********************************************************
        //********  AFFICHE les infos Transit  *************
        //*********************************************************
        public string affiche()
        {
            return this.m_strIDMateriel + " " + this.m_strIdPro + " " + this.m_strMdpPro + " " + this.m_strIDAccompag + " " + this.m_strDate_heure;
        }


        //*********************************************************
        //************  MAJ de la classe Transit   ****************
        //*********************************************************
        public void MAJ(Transit t)
        {
            // MAJ de toutes les données
            this.m_strIDMateriel = t.m_strIDMateriel;
            this.m_strIdPro = t.m_strIdPro;
            this.m_strMdpPro = t.m_strMdpPro;
            this.m_strIDAccompag = t.m_strIDAccompag;
            this.m_strDate_heure = t.m_strDate_heure;

            //DAO_Transit.MAJ_transit(t);
        }

        #endregion
    }
}
