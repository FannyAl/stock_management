using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //**************   La classe INTERACTION   ****************
    //*********************************************************

    class Interaction
    {
        // Déclaration des attributs
        #region Attributs de la class INTERACTION

        private string m_strIDMateriel;
        private string m_strIdPro;
        private string m_strMdpPro;
        private string m_strIDAccompag;
        private string m_strNomPro;
    
        #endregion


        //PRORPIETES de la classe INTERACTION
        #region Propriétés de la class INTERACTION

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
        /// PROPRIETE Nom Professionnel Accompagnant
        /// </summary>
        [DisplayName("Nom Accompagnant")]
        public string NomProAcc
        {
            get { return m_strNomPro; }
            set { m_strNomPro = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe INTERACTION
        #region Constructeurs/Destructeur de la class INTERACTION

        // CONSTRUCTEUR d'initialisation
        public Interaction(string IdMateriel, string IdPro, string MdpPro, string IdBinome, string DateHeure)
        {
            m_strIDMateriel = IdMateriel;
            m_strIdPro = IdPro;
            m_strMdpPro = MdpPro;
            m_strIDAccompag = IdBinome;
            m_strNomPro = DateHeure;
        }

        // CONSTRUCTEUR par défault
        public Interaction()
        {
            m_strIDMateriel = "";
            m_strIdPro = "";
            m_strMdpPro = "";
            m_strIDAccompag = "";
            m_strNomPro = "";
        }

        #endregion


        // Les METHODES de la classe INTERACTION
        #region METHODES de la class INTERACTION

        //*********************************************************
        //********  AFFICHE les infos INTERACTION  ****************
        //*********************************************************
        public string affiche()
        {
            return this.m_strIDMateriel + " " + this.m_strIdPro + " " + this.m_strMdpPro + " " + this.m_strIDAccompag + " " + this.m_strNomPro;
        }


        //*********************************************************
        //************  MAJ de la classe INTERACTION   ************
        //*********************************************************
        public void MAJ(Interaction i)
        {
            // MAJ de toutes les données
            this.m_strIDMateriel = i.m_strIDMateriel;
            this.m_strIdPro = i.m_strIdPro;
            this.m_strMdpPro = i.m_strMdpPro;
            this.m_strIDAccompag = i.m_strIDAccompag;
            this.m_strNomPro = i.m_strNomPro;

            //DAO_Interaction.MAJ_Interaction(i);
        }

        #endregion
    }
}
