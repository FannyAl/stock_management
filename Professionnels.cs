using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //***********   La collection PROFESSIONNELS   ************
    //*********************************************************

    /// <summary>
    /// La classe PROFESSIONNELS
    /// </summary>
    public class Professionnels : List<Professionnel>
    {

        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //**************     Les PROFESSIONNELS   *****************
        int nb_pro = 0;
        int no_pro_courant = 0;

        //*********************************************************
        //**** Initialisation de la liste des Bibliotheques *******
        //*********************************************************
        #region CONSTRUCTEUR Professionnels

        /// <summary>
        /// CONSTRUCTEUR par défault de la collection Professionnels
        /// </summary>
        public Professionnels()
        {
            //Fonction d'initialisation de la Collection
            DAO_Professionnel.Init_Professionnels(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Professionnels


        #region Méthodes Liste de tous les Professionnels

        //*********************************************************
        //*** Les ID de toutes les Professionnels de la liste  ****
        //*********************************************************
        /// <summary>
        /// Les ID de tous les Professionnels de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Professionnel()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Professionnel p in this)
            {
                liste[i] = p.IdPro;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //****   Tous les professionnels de la liste        ******
        //*********************************************************
        /// <summary>
        /// Tous les professionnels  de la liste
        /// </summary>
        /// <returns>Liste de Noms des Bibliotheques</returns>
        public List<Professionnel> Liste_Professionnel()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID, info

        //*********************************************************
        //**********  RECHERCHE de professionnel par ID ***********
        //*********************************************************
        /// <summary>
        /// RECHERCHE de professionnel par ID
        /// </summary>
        /// <param name="id">ID professionnel</param>
        /// <returns>liste des comptes pro</returns>
        public Professionnels Recherche_parID(string id)
        {
            // Recupération des infos selon un ID
            Professionnels liste = new Professionnels();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Professionnel p in this)
            {
                if (p.IdPro == id)
                {
                    liste.Add(p);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //********  RECHERCHE d'un professionnel par INFOS ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un professionnel par INFO
        /// </summary>
        /// <param name="info">info professionnel</param>
        /// <returns>liste des comptes pro</returns>
        public Professionnels Recherche_parINFO(string info)
        {
            // Recupération des infos selon le LIBELLE
            Professionnels liste = new Professionnels();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Professionnel p in this)
            {
                if (p.CommentairePro == info)
                {
                    liste.Add(p);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'un professionnel      ****
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un professionnel
        /// </summary>
        /// <param name="pro">Professionnel</param>
        public void MAJ_liste_pro(Professionnel pro)
        { 
            //Recherche du compte professionnel à modifier dans la base de données
            foreach (Professionnel p in this)
            {
                if (p.IdPro == pro.IdPro)
                {
                    p.MAJ(pro);
                    break;
                }
            }
        }


        //*********************************************************
        //***  AJOUT d'un nouveau professionel dans la liste  *****
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="p">Professionnel</param>
        public void AJOUT_new(Professionnel p)
        {
            // Ajout d'un nouveau professionnel
            this.Add(p);
            DAO_Professionnel.AJOUT_Professionnel(p);
            nb_pro += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER un professionnel dans la liste   ******
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="p">Professionnel</param>
        public void SUPPRIMER(Professionnel p)
        {
            // Suppression de la bibliothèque courante
            this.Remove(p);
            DAO_Professionnel.SUPPR_Professionnel(p);
            nb_pro--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// pro_PRECEDENT()
        /// </summary>
        /// <returns>Professionnel précédente</returns>
        public Professionnel pro_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_pro_courant -= 1;
                return (this[no_pro_courant]);
            }
            catch (Exception e)
            {
                no_pro_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// pro_SUIVANT()
        /// </summary>
        /// <returns>Professionnel suivant</returns>
        public Professionnel pro_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_pro_courant += 1;
                return (this[no_pro_courant]);

            }
            catch (Exception e)
            {
                no_pro_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion

    }
}
