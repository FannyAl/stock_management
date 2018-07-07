using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{

    //*********************************************************
    //***************** La classe EMPLACEMENT *****************
    //*********************************************************

    public class Emplacement
    {
        // Déclaration des attributs
        #region Attributs de la class EMPLACEMENT

        private string m_strID_emplacement;
        private string m_strID_stock;
        private string m_strID_transit;
        private string m_strID_materiel;


        #endregion
   
         //PRORPIETES de la classe Emplacement
        #region Propriétés de la classe Emplacement

        /// <summary>
        /// PROPRIETE ID_emplacement
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Emplacement")]
        public string IdEmplacement
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_emplacement; }
            set { m_strID_emplacement = value; } 
        }

        /// <summary>
        /// PROPRIETE ID_stock
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Stock")]
        public string IdStock
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_stock; }
            set { m_strID_stock = value; }
        }

        /// <summary>
        /// PROPRIETE ID_transit
        /// </summary>
        [DisplayName("ID transit")]
        public string IdTransit
        {
            get { return m_strID_transit; }
            set { m_strID_transit = value; }
        }

        /// <summary>
        /// PROPRIETE ID_materiel
        /// </summary>
        [DisplayName("ID materiel")]
        public string IdMateriel
        {
            get { return m_strID_materiel; }
            set { m_strID_materiel = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe EMPLACEMENT
        #region Constructeurs/Destructeur de la classe EMPLACEMENT

        // CONSTRUCTEUR d'initialisation
        public Emplacement(string empl, string stock, string transit, string materiel)
        {
            m_strID_emplacement = empl;
            m_strID_stock = stock;
            m_strID_transit = transit;
            m_strID_materiel = materiel;
        }

        // CONSTRUCTEUR par défault
        public Emplacement()
        {
            m_strID_emplacement = "";
            m_strID_stock = "";
            m_strID_transit = "";
            m_strID_materiel = "";
        }

        #endregion


        // Les METHODES de la classe Emplacement
        #region METHODES de la classe Emplacement

        //*********************************************************
        //************* AFFICHAGE infos Emplacement ***************
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_emplacement + " " + this.m_strID_stock + " " + this.m_strID_transit + " " + this.m_strID_materiel + " ";
        }


        //*********************************************************
        //*******************  MAJ EMPLACEMENT  *******************
        //*********************************************************
        public void MAJ(Emplacement emp)
        {
            // MAJ de toutes les données d'un usager
            this.m_strID_emplacement = emp.m_strID_emplacement;
            this.m_strID_stock = emp.m_strID_stock;
            this.m_strID_transit = emp.m_strID_transit;
            this.m_strID_materiel = emp.m_strID_materiel;

            DAO_Emplacement.MAJ_Emplacement(emp);
        }

        #endregion
    }
}
