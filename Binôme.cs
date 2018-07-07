using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //***********   La classe ACCOMPAGNEMENT   ****************
    //*********************************************************

    class Binôme
    {
        // Déclaration des attributs
        #region Attributs de la class ACCOMPAGNEMENT

        private string m_strIDAccompag;
        private string m_strNomPro;
        private string m_strDate_heure;
    
        #endregion


        //PRORPIETES de la classe Bînome
        #region Propriétés de la class Bînome

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

        /// <summary>
        /// PROPRIETE Nom Professionnel
        /// </summary>
        [DisplayName("Nom")]
        public string NomPro
        {
            get { return m_strNomPro; }
            set { m_strNomPro = value; }
        }

        /// <summary>
        /// PROPRIETE Date & heure
        /// </summary>
        [DisplayName("Date & heure")]
        public string DateHeure
        {
            get { return m_strDate_heure; }
            set { m_strDate_heure = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Bînome
        #region Constructeurs/Destructeur de la class Accompagnement

        // CONSTRUCTEUR d'initialisation
        public Binôme(string IDAcc, string Nom, string DateHeure)
        {
            m_strIDAccompag = IDAcc;
            m_strNomPro = Nom;
            m_strDate_heure = DateHeure;
        }

        // CONSTRUCTEUR par défault
        public Binôme()
        {
            m_strIDAccompag = "";
            m_strNomPro = "";
            m_strDate_heure = "";
        }

        #endregion


        // Les METHODES de la classe Bînome
        #region METHODES de la class Accompagnement

        //*********************************************************
        //********  AFFICHE les infos Bînome *************
        //*********************************************************
        public string affiche()
        {
            return this.m_strIDAccompag + " " + this.m_strNomPro + " "+ this.m_strDate_heure;
        }


        //*********************************************************
        //**************  MAJ de la classe Bînome   ***************
        //*********************************************************
        public void MAJ(Binôme b)
        {
            // MAJ de toutes les données
            this.m_strIDAccompag = b.m_strIDAccompag;
            this.m_strNomPro = b.m_strNomPro;
            this.m_strDate_heure = b.m_strDate_heure;

            //DAO_Accompagnement.MAJ_Accompagnement(a);
        }

        #endregion
    }
}
