using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //**************   La classe ASSOCIATION   ****************
    //*********************************************************

    class Association
    {
        // Déclaration des attributs
        #region Attributs de la class ASSOCIATION

        private string m_strIdUsager;
        private string m_strIdPro;
        private string m_strMdpPro;
        private string m_strIDAccompag;
    
        #endregion


        //PRORPIETES de la classe ASSOCIATION
        #region Propriétés de la class ASSOCIATION

        /// <summary>
        /// PROPRIETE ID Usager
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Usager")]
        public string IdUsager 
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strIdUsager; } 
            set { m_strIdUsager = value; } 
        }

        /// <summary>
        /// PROPRIETE ID Professionnel
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID pro")]
        public string IdPro
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strIdPro; } 
            set { m_strIdPro = value; } 
        }

        /// <summary>
        /// PROPRIETE Mot de Passe Professionnel
        /// </summary>
        [DisplayName("Mot de passe")]
        public string MdpPro
        {
            get { return m_strMdpPro; }
            set { m_strMdpPro = value; }
        }
        /// <summary>
        /// PROPRIETE Id Bînome
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID bînome")]
        public string IDAccompagnement 
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strIDAccompag; }
            set { m_strIDAccompag = value; } 
        }

        #endregion


        // Les CONSTRUCTEUR de la classe ASSOCIATION
        #region Constructeurs/Destructeur de la class ASSOCIATION

        // CONSTRUCTEUR d'initialisation
        public Association(string IdUsager, string IdProfessionnel, string MdpProfessionnel, string IdAccompagnement)
        {
            m_strIdUsager = IdUsager;
            m_strIdPro = IdProfessionnel;
            m_strMdpPro = MdpProfessionnel;
            m_strIDAccompag = IdAccompagnement;
        }

        // CONSTRUCTEUR par défault
        public Association()
        {
            m_strIdUsager = "";
            m_strIdPro = "";
            m_strMdpPro = "";
            m_strIDAccompag = "";
        }

        #endregion


        // Les METHODES de la classe ASSOCIATION
        #region METHODES de la class ASSOCIATION

        //*********************************************************
        //************  AFFICHE les infos ASSOCIATION  ************
        //*********************************************************
        public string affiche()
        {
            return this.m_strIdUsager + " " + this.m_strIdPro + " " + this.m_strMdpPro + " " + this.m_strIDAccompag;
        }


        //*********************************************************
        //**********  MAJ de la classe ASSOCIATION    *************
        //*********************************************************
        public void MAJ(Association ass)
        {
            // MAJ de toutes les données
            this.m_strIdUsager = ass.m_strIdUsager;
            this.m_strIdPro = ass.m_strIdPro;
            this.m_strMdpPro = ass.m_strMdpPro;
            this.m_strIDAccompag = ass.m_strIDAccompag;

            //DAO_Association.MAJ_Association(ass);
        }

        #endregion
    }
}
