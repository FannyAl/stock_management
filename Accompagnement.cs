using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //************** La classe ACCOMPAGNEMENT  ****************
    //*********************************************************

    public class Accompagnement
    {
        // Déclaration des attributs
        #region Attributs de la class ACCOMPAGNEMENT

        private string m_strID_usager;
        private string m_strID_professionnel;
        private string m_strNom_professionnel;
        private string m_strID_accompagnement;
        private string m_dttDate_heure;
    
        #endregion


        //PRORPIETES de la classe ACCOMPAGNEMENT
        #region Propriétés de la classe ACCOMPAGNEMENT

        /// <summary>
        /// PROPRIETE ID Usager
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Usager")]
        public string IdUsager 
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_usager; }
            set { m_strID_usager = value; } 
        }

        /// <summary>
        /// PROPRIETE ID Professionnel
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID pro")]
        public string IdPro
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_professionnel; }
            set { m_strID_professionnel = value; } 
        }

        /// <summary>
        /// PROPRIETE Nom Professionnel
        /// </summary>
        [DisplayName("Nom pro")]
        public string NomPro
        {
            get { return m_strNom_professionnel; }
            set { m_strNom_professionnel = value; }
        }

        /// <summary>
        /// PROPRIETE ID Accompagnement
        /// </summary>
        [DisplayName("ID accomp")]
        public string IdAccomp
        {
            get { return m_strID_accompagnement; }
            set { m_strID_accompagnement = value; }
        }

        /// <summary>
        /// PROPRIETE Date et heure
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("Date & heure")]
        public string Date_heure 
        {
            //Permet de sécuriser l'accès aux données
            get { return m_dttDate_heure; }
            set { m_dttDate_heure = value; } 
        }

        #endregion


        // Les CONSTRUCTEUR de la classe ACCOMPAGNEMENT
        #region Constructeurs/Destructeur de la classe ACCOMPAGNEMENT

        // CONSTRUCTEUR d'initialisation
        public Accompagnement(string IdUsager, string IdProfessionnel, string NomProfessionnel, string IdAccompagnement, string date_heure)
        {
            m_strID_usager = IdUsager;
            m_strID_professionnel = IdProfessionnel;
            m_strNom_professionnel = NomProfessionnel;
            m_strID_accompagnement = IdAccompagnement;
            m_dttDate_heure = date_heure;
        }

        // CONSTRUCTEUR par défault
        public Accompagnement()
        {
            m_strID_usager = "";
            m_strID_professionnel = "";
            m_strNom_professionnel = "";
            m_strID_accompagnement = "";
            m_dttDate_heure = "";
        }

        #endregion


        // Les METHODES de la classe ACCOMPAGNEMENT
        #region METHODES de la classe ACCOMPAGNEMENT

        //*********************************************************
        //***********  AFFICHE les infos ACCOMPAGNEMENT  **********
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_usager + " " + this.m_strID_professionnel + " " + this.m_strNom_professionnel + " " + this.m_strID_accompagnement + " " + this.m_dttDate_heure;
        }


        //*********************************************************
        //*********  MAJ de la classe ACCOMPAGNEMENT    ***********
        //*********************************************************
        public void MAJ(Accompagnement acc)
        {
            // MAJ de toutes les données
            this.m_strID_usager = acc.m_strID_usager;
            this.m_strID_professionnel = acc.m_strID_professionnel;
            this.m_strNom_professionnel = acc.m_strNom_professionnel;
            this.m_strID_accompagnement = acc.m_strID_accompagnement;
            this.m_dttDate_heure = acc.m_dttDate_heure;

            DAO_Accompagnement.MAJ_Accompagnement(acc);
        }

        #endregion
    }
}
