using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //***************   La classe BINOME   ********************
    //*********************************************************

    public class Binome
    {
        // Déclaration des attributs
        #region Attributs de la class BINOME

        private string m_strID_Accompagnement;
        private string m_strDate_heure;
    
        #endregion


        //PRORPIETES de la classe Binome
        #region Propriétés de la class Binome

        /// <summary>
        /// PROPRIETE Id Accomp
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Accomp")]
        public string IdAccomp
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_Accompagnement; }
            set { m_strID_Accompagnement = value; } 
        }

        /// <summary>
        /// PROPRIETE Date & heure
        /// </summary>
        [DisplayName("Date & heure")]
        public string Date_Heure
        {
            get { return m_strDate_heure; }
            set { m_strDate_heure = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Binome
        #region Constructeurs/Destructeur de la class Binome

        // CONSTRUCTEUR d'initialisation
        public Binome(string IDAcc, string DateHeure)
        {
            m_strID_Accompagnement = IDAcc;
            m_strDate_heure = DateHeure;
        }

        // CONSTRUCTEUR par défault
        public Binome()
        {
            m_strID_Accompagnement = "";
            m_strDate_heure = "";
        }

        #endregion


        // Les METHODES de la classe Binome
        #region METHODES de la class Binome

        //*********************************************************
        //**************  AFFICHE les infos Binome ****************
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_Accompagnement + " " + this.m_strDate_heure;
        }


        //*********************************************************
        //**************  MAJ de la classe Bînome   ***************
        //*********************************************************
        public void MAJ(Binome b)
        {
            // MAJ de toutes les données
            this.m_strID_Accompagnement = b.m_strID_Accompagnement;
            this.m_strDate_heure = b.m_strDate_heure;

            DAO_Binome.MAJ_Binome(b);
        }

        #endregion
    }
}
