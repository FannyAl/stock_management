using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Stock_class
{

    //*********************************************************
    //**************   La classe Professionnel   **************
    //*********************************************************

    public class Professionnel
    {
        // Déclaration des attributs
        #region Attributs de la class PROFESSIONNEL

        private string m_strID_professionnel;
        private string m_strNom_professionnel;
        private string m_strMDP_Professionnel;
        private string m_strStatut_professionnel;
        private string m_strInfo_professionnel;

        #endregion
   
         //PRORPIETES de la classe Professionnel
        #region Propriétés de la class Professionnel

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
        /// PROPRIETE Nom professionnel accompagnant
        /// </summary>
        [DisplayName("Nom pro")]
        public string NomPro
        {
            get { return m_strNom_professionnel; }
            set { m_strNom_professionnel = value; }
        }

        /// <summary>
        /// PROPRIETE Mot de Passe Professionnel
        /// </summary>
        [DisplayName("Mot de passe")]
        public string MdpPro
        {
            get { return m_strMDP_Professionnel; }
            set { m_strMDP_Professionnel = value; }
        }

        /// <summary>
        /// PROPRIETE Statut professionnel
        /// </summary>
        [DisplayName("Statut")]
        public string StatutPro
        {
            get { return m_strStatut_professionnel; }
            set { m_strStatut_professionnel = value; }
        }

        /// <summary>
        /// PROPRIETE Informations complémentaires
        /// </summary>
        [DisplayName("Informations")]
        public string CommentairePro
        {
            get { return m_strInfo_professionnel; }
            set { m_strInfo_professionnel = value; }
        }

        #endregion


        // Les CONSTRUCTEUR de la classe Professionnel
        #region Constructeurs/Destructeur de la class Professionnel

        // CONSTRUCTEUR d'initialisation
        public Professionnel(string Id, string Nom, string Mdp, string Statut, string Commentaire)
        {
            m_strID_professionnel = Id;
            m_strNom_professionnel = Nom;
            m_strMDP_Professionnel = Mdp;
            m_strStatut_professionnel = Statut;
            m_strInfo_professionnel = Commentaire;
        }

        // CONSTRUCTEUR par défault
        public Professionnel()
        {
            m_strID_professionnel = "";
            m_strNom_professionnel = "";
            m_strMDP_Professionnel = "";
            m_strStatut_professionnel = "";
            m_strInfo_professionnel = "";
        }

        #endregion


        // Les METHODES de la classe Professionnel
        #region METHODES de la classe Professionnel

        //*********************************************************
        //***************  AFFICHAGE infos Pro ********************
        //*********************************************************
        public string affiche()
        {
            return this.m_strID_professionnel + " " + this.m_strNom_professionnel + " " + this.m_strMDP_Professionnel +
            " " + this.m_strStatut_professionnel + " " + this.m_strInfo_professionnel;
        }


        //*********************************************************
        //**********************  MAJ Pro    **********************
        //*********************************************************
        public void MAJ(Professionnel p)
        {
            // MAJ de toutes les données du compte professionnel
            this.m_strID_professionnel = p.m_strID_professionnel;
            this.m_strNom_professionnel = p.m_strNom_professionnel;
            this.m_strMDP_Professionnel = p.m_strMDP_Professionnel;
            this.m_strStatut_professionnel = p.m_strStatut_professionnel;
            this.m_strInfo_professionnel = p.m_strInfo_professionnel;

            DAO_Professionnel.MAJ_Professionnel(p);
        }

        #endregion

    }
}
