using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //*************   La collection ASSOCIATIONS  **************
    //*********************************************************

    /// <summary>
    /// La classe ASSOCIATIONS
    /// </summary>
    public class Associations : List<Association>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //**************     Les ASSOCIATIONS    *****************
        int nb_asso = 0;
        int no_asso_courant = 0;

        //*********************************************************
        //***** Initialisation de la liste des ASSOCIATIONS *******
        //*********************************************************
        #region CONSTRUCTEUR Associations

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe ASSOCIATIONS
        /// </summary>
        public Associations()
        {
            //Fonction d'initialisation de la Collection
            //DAO_Association.Init_Associations(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe ASSOCIATIONS


        #region Méthodes Liste de toutes les ASSOCIATIONS

        //*********************************************************
        //*** Les noms de toutes les ASSOCIATIONS de la liste *****
        //*********************************************************
        /// <summary>
        /// Les noms de toutes les ASSOCIATIONS de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Accompagnement_Association()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Association a in this)
            {
                liste[i] = a.IDAccompagnement;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //****   Toutes les Associations de la liste        ******
        //*********************************************************
        /// <summary>
        /// Toutes les Associations de la liste
        /// </summary>
        /// <returns>Liste de IDAccompagnement</returns>
        public List<Association> Liste_Associations()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID_usager, ID_pro

        //*********************************************************
        //*******  RECHERCHE de l'association par ID_usager *******
        //*********************************************************
        /// <summary>
        /// RECHERCHE de l'association par ID_usager
        /// </summary>
        /// <param name="code">ID_usager</param>
        /// <returns></returns>
        public Associations Recherche_parUSAGER(string usager)
        {
            // Recupération des infos selon un ID
            Associations liste = new Associations();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Association a in this)
            {
                if (a.IdUsager == usager)
                {
                    liste.Add(a);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*********  RECHERCHE de l'Association par ID_pro ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE de l'association par ID_pro
        /// </summary>
        /// <param name="libelle">ID_professionnel accompagnant</param>
        /// <returns>liste bibliothèque</returns>
        public Associations Recherche_parPRO(string pro)
        {
            // Recupération des infos selon le LIBELLE
            Associations liste = new Associations();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Association a in this)
            {
                if (a.IdPro == pro)
                {
                    liste.Add(a);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'une Association  *********
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'une Association
        /// </summary>
        /// <param name="bib">Association</param>
        public void MAJ_liste_asso(Association asso)
        { 
            foreach (Association a in this)
            {
                if (a.IDAccompagnement == asso.IDAccompagnement)
                {
                    a.MAJ(asso);
                    break;
                }
            }
        }


        //*********************************************************
        //***  AJOUT d'une nouvelle association dans la liste  ****
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="b">Association</param>
        public void AJOUT_new(Association a)
        {
            // Ajout d'une nouvelle association
            this.Add(a);
            //DAO_Association.AJOUT_Asso(a);
            nb_asso += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER une association dans la liste   *******
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Association</param>
        public void SUPPRIMER(Association a)
        {
            // Suppression de l'association courante
            this.Remove(a);
            //DAO_Association.SUPPR_Asso(a);
            nb_asso--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// asso_PRECEDENT()
        /// </summary>
        /// <returns>Association précédente</returns>
        public Association asso_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_asso_courant -= 1;
                return (this[no_asso_courant]);
            }
            catch (Exception e)
            {
                no_asso_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// asso_SUIVANT()
        /// </summary>
        /// <returns>Association suivante</returns>
        public Association asso_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_asso_courant += 1;
                return (this[no_asso_courant]);

            }
            catch (Exception e)
            {
                no_asso_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion
    }
}
