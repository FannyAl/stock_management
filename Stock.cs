using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //******************   La classe Stock  *******************
    //*********************************************************

    public class Stock
    {
        // Déclaration des attributs
        #region Attributs de la classe STOCK

        private string m_strID_stock;
        private string m_strNom_stock;
        private string m_strAdresse_stock;
        private string m_strInfos_stock;

        #endregion
   
         //PRORPIETES de la classe Stock
        #region Propriétés de la classe Stock

        /// <summary>
        /// PROPRIETE Code Stock
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("ID Stock")]
        public string IDStock
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strID_stock; }
            set { m_strID_stock = value; } 
        }

        /// <summary>
        /// PROPRIETE Nom Stock
        /// </summary>
        [DisplayName("Nom Stock")]
        public string NomStock
        {
            get { return m_strNom_stock; }
            set { m_strNom_stock = value; }
        }

        /// <summary>
        /// PROPRIETE Adresse Stock
        /// </summary>
        [DisplayName("Adresse Stock")]
        public string AdressStock
        {
            get { return m_strAdresse_stock; }
            set { m_strAdresse_stock = value; }
        }

        /// <summary>
        /// PROPRIETE Informations complémentaires
        /// </summary>
        [DisplayName("Informations")]
        public string InfoStock
        {
            get { return m_strInfos_stock; }
            set { m_strInfos_stock = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Stock
        #region Constructeurs/Destructeur de la classe Stock

        // CONSTRUCTEUR d'initialisation
        public Stock(string ID, string Nom, string Adress, string Commentaire)
        {
            m_strID_stock = ID;
            m_strNom_stock = Nom;
            m_strAdresse_stock = Adress;
            m_strInfos_stock = Commentaire;
        }

        // CONSTRUCTEUR par défault
        public Stock()
        {
            m_strID_stock = "";
            m_strNom_stock = "";
            m_strAdresse_stock = "";
            m_strInfos_stock = "";
        }

        #endregion


        // Les METHODES de la classe Stock
        #region METHODES de la classe Stock

        //*********************************************************
        //***************  AFFICHAGE infos Stock ******************
        //*********************************************************
        public string affiche()
        {
            return m_strID_stock + " " + this.m_strNom_stock + " " + this.m_strAdresse_stock + " " + this.m_strInfos_stock;
        }


        //*********************************************************
        //**********************  MAJ Stock    ********************
        //*********************************************************
        public void MAJ(Stock s)
        {
            // MAJ de toutes les données
            this.m_strID_stock = s.m_strID_stock;
            this.m_strNom_stock = s.m_strNom_stock;
            this.m_strAdresse_stock = s.m_strAdresse_stock;
            this.m_strInfos_stock = s.m_strInfos_stock;

            DAO_Stock.MAJ_Stock(s);
        }

        #endregion

    }
}
