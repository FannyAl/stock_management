using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //************   La collection ACCOMPAGNEMENTS  ***********
    //*********************************************************

    /// <summary>
    /// La classe ASSOCIATIONS
    /// </summary>
    public class Accompagnements : List<Accompagnement>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //**************     Les ACCOMPAGNEMENTS    ***************
        int nb_acc = 0;
        int no_acc_courant = 0;

        //*********************************************************
        //**** Initialisation de la liste des ACCOMPAGNEMENTS *****
        //*********************************************************
        #region CONSTRUCTEUR Accompagnements

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe ACCOMPAGNEMENTS
        /// </summary>
        public Accompagnements()
        {
            //Fonction d'initialisation de la Collection
            DAO_Accompagnement.Init_Accompagnements(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe ACCOMPAGNEMENTS


        #region Méthodes Liste de toutes les ACCOMPAGNEMENTS

        //*********************************************************
        //********* La liste de tous les ACCOMPAGNEMENTS **********
        //*********************************************************
        /// <summary>
        /// La liste de tous les ACCOMPAGNEMENTS
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Accompagnement()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Accompagnement a in this)
            {
                liste[i] = a.IdAccomp;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //********  Tous les accompagnements de la liste   ********
        //*********************************************************
        /// <summary>
        /// Tous les accompagnements de la liste
        /// </summary>
        /// <returns>Liste de IdAccompagnement</returns>
        public List<Accompagnement> Liste_Associations()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID_usager, ID_pro, Nom_pro, date & heure

        //*********************************************************
        //****** RECHERCHE des accompagnements par ID_usager ******
        //*********************************************************
        /// <summary>
        /// RECHERCHE des accompagnements par ID_usager
        /// </summary>
        /// <param name="usager">ID_usager</param>
        /// <returns></returns>
        public Accompagnements Recherche_parUSAGER(string usager)
        {
            // Recupération des infos selon un ID
            Accompagnements liste = new Accompagnements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Accompagnement a in this)
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
        /// <param name="pro">ID_professionnel accompagnant</param>
        /// <returns>liste accompagnement</returns>
        public Accompagnements Recherche_parPRO(string pro)
        {
            // Recupération des infos selon le LIBELLE
            Accompagnements liste = new Accompagnements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Accompagnement a in this)
            {
                if (a.IdPro == pro)
                {
                    liste.Add(a);
                    break;
                }
            }
            return liste;
        }


        //*********************************************************
        //****** RECHERCHE des accompagnements par Nom_pro ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE des accompagnements par Nom_pro
        /// </summary>
        /// <param name="nom">Nom_pro</param>
        /// <returns></returns>
        public Accompagnements Recherche_parNOMPRO(string Nom)
        {
            // Recupération des infos selon un ID
            Accompagnements liste = new Accompagnements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Accompagnement a in this)
            {
                if (a.NomPro == Nom)
                {
                    liste.Add(a);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //******  RECHERCHE de l'Association par Date *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de l'association par Date
        /// </summary>
        /// <param name="date">ID_professionnel accompagnant</param>
        /// <returns>liste accompagnement</returns>
        public Accompagnements Recherche_parDATE(string date)
        {
            // Recupération des infos selon le LIBELLE
            Accompagnements liste = new Accompagnements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Accompagnement a in this)
            {
                if (a.Date_heure == date)
                {
                    liste.Add(a);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //******  RECHERCHE de l'Association par Heure ************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de l'association par Heure
        /// </summary>
        /// <param name="heure">ID_professionnel accompagnant</param>
        /// <returns>liste accompagnement</returns>
        public Accompagnements Recherche_parHEURE(string heure)
        {
            // Recupération des infos selon le LIBELLE
            Accompagnements liste = new Accompagnements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Accompagnement a in this)
            {
                if (a.Date_heure == heure)
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
        //****   MISE A JOUR des infos d'un accompagnement  *******
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un accompagnement
        /// </summary>
        /// <param name="acc">Accompagnement</param>
        public void MAJ_liste_asso(Accompagnement acc)
        { 
            foreach (Accompagnement a in this)
            {
                if (a.IdAccomp == acc.IdAccomp)
                {
                    a.MAJ(acc);
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
        /// <param name="a">Accompagnement</param>
        public void AJOUT_new(Accompagnement a)
        {
            // Ajout d'un nouvel accompagnement
            this.Add(a);
            DAO_Accompagnement.AJOUT_Accomp(a);
            nb_acc += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER une association dans la liste   *******
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="a">Accompagnement</param>
        public void SUPPRIMER(Accompagnement a)
        {
            // Suppression de l'accompagnement courante
            this.Remove(a);
            DAO_Accompagnement.SUPPR_Accomp(a);
            nb_acc--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// accomp_PRECEDENT()
        /// </summary>
        /// <returns>Accompagnement précédent</returns>
        public Accompagnement accomp_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_acc_courant -= 1;
                return (this[no_acc_courant]);
            }
            catch (Exception e)
            {
                no_acc_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// accomp_SUIVANT()
        /// </summary>
        /// <returns>Accompagnement suivant</returns>
        public Accompagnement accomp_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_acc_courant += 1;
                return (this[no_acc_courant]);

            }
            catch (Exception e)
            {
                no_acc_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion
    }
}
