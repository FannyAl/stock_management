using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //****************   La classe ASSOCIE   ******************
    //*********************************************************

    class Associe
    {
        // Déclaration des attributs
        #region Attributs de la class ASSOCIE

        private string m_strIdUsager;
        private string m_strIdPro;
        private string m_strMdpPro;
        private string m_strIDAccompag;
    
        #endregion


        //PRORPIETES de la classe Associe
        #region Propriétés de la class Associe

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


        // Les CONSTRUCTEUR de la classe Accompagnement
        #region Constructeurs/Destructeur de la class Accompagnement

        // CONSTRUCTEUR d'initialisation
        public Associe(string IdUsager, string IdProfessionnel, string MdpProfessionnel, string IdAccompagnement)
        {
            m_strIdUsager = IdUsager;
            m_strIdPro = IdProfessionnel;
            m_strMdpPro = MdpProfessionnel;
            m_strIDAccompag = IdAccompagnement;
        }

        // CONSTRUCTEUR par défault
        public Associe()
        {
            m_strIdUsager = "";
            m_strIdPro = "";
            m_strMdpPro = "";
            m_strIDAccompag = "";
        }

        #endregion


        // Les METHODES de la classe Associe
        #region METHODES de la class Associe

        //*********************************************************
        //************  AFFICHE les infos Associe  ****************
        //*********************************************************
        public string affiche()
        {
            return this.m_strIdUsager + " " + this.m_strIdPro + " " + this.m_strMdpPro + " " + this.m_strIDAccompag;
        }


        //*********************************************************
        //************  MAJ de la classe Associe    ***************
        //*********************************************************
        public void MAJ(Associe ass)
        {
            // MAJ de toutes les données
            this.m_strIdUsager = ass.m_strIdUsager;
            this.m_strIdPro = ass.m_strIdPro;
            this.m_strMdpPro = ass.m_strMdpPro;
            this.m_strIDAccompag = ass.m_strIDAccompag;

            //DAO_Accompagnement.MAJ_Accompagnement(a);
        }

        #endregion
    }
}
