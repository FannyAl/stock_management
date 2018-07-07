using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //****************   La collection USAGERS   **************
    //*********************************************************

    /// <summary>
    /// La classe USAGERS
    /// </summary>
    public class Usagers : List<Usager>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //******************     Les USAGERS   ********************
        int nb_usager = 0;
        int no_usager_courant = 0;

        //*********************************************************
        //******** Initialisation de la liste des USAGERS *********
        //*********************************************************
        #region CONSTRUCTEUR Usagers

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Usagers
        /// </summary>
        public Usagers()
        {
            //Fonction d'initialisation de la Collection
            DAO_Usager.Init_Usagers(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Usgaers


        #region Méthodes Liste de tous les Usagers

        //*********************************************************
        //******* Les noms de tous les usagers de la liste ********
        //*********************************************************
        /// <summary>
        /// Les noms de tous les usagers de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Usager()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Usager u in this)
            {
                liste[i] = u.IdUsager;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //**********   Tous les usgaers de la liste        ********
        //*********************************************************
        /// <summary>
        /// Tous les usagers de la liste
        /// </summary>
        /// <returns>Liste de Id de tous les Usagers</returns>
        public List<Usager> Liste_Usager()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID, Pseudo, mail, adresse

        //*********************************************************
        //***********  RECHERCHE d'un usager par ID *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un usager par ID
        /// </summary>
        /// <param name="Id">ID Usager</param>
        /// <returns></returns>
        public Usagers Recherche_parID(string Id)
        {
            // Recupération des infos selon un ID
            Usagers liste = new Usagers();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Usager u in this)
            {
                if (u.IdUsager == Id)
                {
                    liste.Add(u);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //**********  RECHERCHE d'un usager par PSEUDO ************
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un usager par PSEUDO
        /// </summary>
        /// <param name="pseudo">Pseudo de l'usager</param>
        /// <returns>liste des usagers</returns>
        public Usagers Recherche_parPSEUDO(string pseudo)
        {
            // Recupération des infos selon le LIBELLE
            Usagers liste = new Usagers();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Usager u in this)
            {
                if (u.PseudoUsager == pseudo)
                {
                    liste.Add(u);
                    break;
                }
            }
            return liste;
        }


        //*********************************************************
        //*********  RECHERCHE d'un usager par ADRESSE ************
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un usager par ADRESSE
        /// </summary>
        /// <param name="adresse">Adresse de l'usager</param>
        /// <returns>liste usagers</returns>
        public Usagers Recherche_parADRESSE(string adresse)
        {
            // Recupération des infos selon un l'ADRESSE
            Usagers liste = new Usagers();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Usager u in this)
            {
                if (u.PostAdress == adresse)
                {
                    liste.Add(u);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //************  RECHERCHE d'un usager par MAIL ************
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un usager par MAIL
        /// </summary>
        /// <param name="mail">Mail de l'usager</param>
        /// <returns>liste usagers</returns>
        public Usagers Recherche_parMAIL(string mail)
        {
            // Recupération des infos selon un l'ADRESSE
            Usagers liste = new Usagers();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Usager u in this)
            {
                if (u.MailAdress == mail)
                {
                    liste.Add(u);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //******   MISE A JOUR des infos d'un usager      *********
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un usager
        /// </summary>
        /// <param name="usa">Usager</param>
        public void MAJ_liste_usager(Usager usa)
        { 
            //Recherche de l'usager à modifier dans la base de données
            foreach (Usager u in this)
            {
                if (u.IdUsager == usa.IdUsager)
                {
                    u.MAJ(usa);
                    break;
                }
            }
        }


        //*********************************************************
        //********  AJOUT d'un nouvel usager dans la liste  *******
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="u">Usager</param>
        public void AJOUT_new(Usager u)
        {
            // Ajout d'un nouvel usager
            this.Add(u);
            DAO_Usager.AJOUT_Usager(u);
            nb_usager += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER un nouvel usager dans la liste   ******
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="u">Usager</param>
        public void SUPPRIMER(Usager u)
        {
            // Suppression de l'usager courant
            this.Remove(u);
            DAO_Usager.SUPPR_Usager(u);
            nb_usager--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// usager_PRECEDENT()
        /// </summary>
        /// <returns>Usager préscédent</returns>
        public Usager usager_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_usager_courant -= 1;
                return (this[no_usager_courant]);
            }
            catch (Exception e)
            {
                no_usager_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// usager_SUIVANT()
        /// </summary>
        /// <returns>Usager suivant</returns>
        public Usager usager_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_usager_courant += 1;
                return (this[no_usager_courant]);

            }
            catch (Exception e)
            {
                no_usager_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion

    }
}
