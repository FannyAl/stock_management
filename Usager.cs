using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Stock_class
{
    //*********************************************************
    //*****************   La classe USAGER   ******************
    //*********************************************************

    public class Usager
    {
        // Déclaration des attributs
        #region Attributs de la class USAGER

        private string m_strID_usager;
        private string m_strPseudo_usager;
        private string m_strMail_usager;
        private string m_strAdresse_usager;
        private string m_strInfos_usager;

        #endregion
   
         //PRORPIETES de la classe Usager
        #region Propriétés de la class usager

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
        /// PROPRIETE Pseudo Usager
        /// </summary>
        // Affichage dans le data-gridview
        [DisplayName("Pseudo Usager")]
        public string PseudoUsager
        {
            //Permet de sécuriser l'accès aux données
            get { return m_strPseudo_usager; }
            set { m_strPseudo_usager = value; }
        }

        /// <summary>
        /// PROPRIETE Adresse Mail
        /// </summary>
        [DisplayName("Mail")]
        public string MailAdress
        {
            get { return m_strMail_usager; }
            set { m_strMail_usager = value; }
        }

        /// <summary>
        /// PROPRIETE Adresse Postale
        /// </summary>
        [DisplayName("Adresse")]
        public string PostAdress
        {
            get { return m_strAdresse_usager; }
            set { m_strAdresse_usager = value; }
        }

        /// <summary>
        /// PROPRIETE Informations complémentaires
        /// </summary>
        [DisplayName("Infos complémentaires")]
        public string Commentaire
        {
            get { return m_strInfos_usager; }
            set { m_strInfos_usager = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Usager
        #region Constructeurs/Destructeur de la class Usager

        // CONSTRUCTEUR d'initialisation
        public Usager(string Id, string Pseudo, string Mail, string Adresse, string Commentaire)
        {
            m_strID_usager = Id;
            m_strPseudo_usager = Pseudo;
            m_strMail_usager = Mail;
            m_strAdresse_usager = Adresse;
            m_strInfos_usager = Commentaire;
        }

        // CONSTRUCTEUR par défault
        public Usager()
        {
            m_strID_usager = "";
            m_strPseudo_usager = "";
            m_strMail_usager = "";
            m_strAdresse_usager = "";
            m_strInfos_usager = "";
        }

        #endregion


        // Les METHODES de la classe Usager
        #region METHODES de la class Usager

        //*********************************************************
        //***************  AFFICHAGE infos usager *****************
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_usager + " " + this.m_strPseudo_usager + " " + this.m_strMail_usager + " " + this.m_strAdresse_usager + " " + this.m_strInfos_usager + " ";
        }


        //*********************************************************
        //********************  MAJ Usager    *********************
        //*********************************************************
        public void MAJ(Usager u)
        {
            // MAJ de toutes les données d'un usager
            this.m_strID_usager = u.m_strID_usager;
            this.m_strPseudo_usager = u.m_strPseudo_usager;
            this.m_strMail_usager = u.m_strMail_usager;
            this.m_strAdresse_usager = u.m_strAdresse_usager;
            this.m_strInfos_usager = u.m_strInfos_usager;

            DAO_Usager.MAJ_Usager(u);
        }

        #endregion
    }
}
