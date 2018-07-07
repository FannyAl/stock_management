using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //***********  La collection INTERACTIONS  ****************
    //*********************************************************

    /// <summary>
    /// La classe INTERACTIONS
    /// </summary>
    public class Interactions : List<Interaction>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //****************** Les INTERACTIONS   *******************
        int nb_interaction = 0;
        int no_interaction_courant = 0;

        //*********************************************************
        //***** Initialisation de la liste des INTERACTIONS *******
        //*********************************************************
        #region CONSTRUCTEUR Interactions

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Interactions
        /// </summary>
        public Interactions()
        {
            //Fonction d'initialisation de la Collection
            //DAO_Interaction.Init_Interactions(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe INTERACTIONS


        #region Méthodes Liste de toutes les INTERACTIONS

        //*********************************************************
        //********* Liste de toutes les interactions  *************
        //*********************************************************
        /// <summary>
        /// Liste de toutes les interactions
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Accomp_Interaction()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Interaction inte in this)
            {
                liste[i] = inte.IdBinome;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //************   Toutes les Interactions        ***********
        //*********************************************************
        /// <summary>
        /// Toutes les Interactions de la liste
        /// </summary>
        /// <returns>Liste des Interactions</returns>
        public List<Interaction> Liste_Interaction()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par Id_Binome, ID_pro, ID_materiel 

        //*********************************************************
        //*******  RECHERCHE d'interaction par Id_Binome **********
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'interaction par Id_Binome
        /// </summary>
        /// <param name="code">Id_Binome</param>
        /// <returns></returns>
        public Interactions Recherche_parIdBinome(string Binome)
        {
            // Recupération des infos selon un ID
            Interactions liste = new Interactions();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Interaction i in this)
            {
                if (i.IdBinome == Binome)
                {
                    liste.Add(i);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*********  RECHERCHE d'interaction par Id_pro ***********
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'interaction par Id_pro
        /// </summary>
        /// <param name="libelle">Id_pro</param>
        /// <returns>liste interactions</returns>
        public Interactions Recherche_parIdPro(string professionnel)
        {
            // Recupération des infos selon le LIBELLE
            Interactions liste = new Interactions();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Interaction i in this)
            {
                if (i.IdPro == professionnel)
                {
                    liste.Add(i);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //******  RECHERCHE d'interaction par ID_materiel *********
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'interaction par ID_materiel
        /// </summary>
        /// <param name="adresse">ID_materiel</param>
        /// <returns>liste interactions</returns>
        public Interactions Recherche_parMATERIEL(string materiel)
        {
            // Recupération des infos selon l'ID du materiel
            Interactions liste = new Interactions();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Interaction i in this)
            {
                if (i.IDMateriel == materiel)
                {
                    liste.Add(i);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'une interaction       ****
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'une interaction
        /// </summary>
        /// <param name="bib">Interaction</param>
        public void MAJ_liste_interaction(Interaction inte)
        { 
            //Recherche de l'interaction à modifier dans la base de données
            foreach (Interaction i in this)
            {
                if ((i.IdBinome == inte.IdBinome) || (i.IdPro == inte.IdPro))
                {
                    i.MAJ(inte);
                    break;
                }
            }
        }


        //*********************************************************
        //***  AJOUT d'une nouvelle interaction dans la liste  ****
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="i">Interaction</param>
        public void AJOUT_new(Interaction i)
        {
            // Ajout d'une nouvelle interaction
            this.Add(i);
            //DAO_Interaction.AJOUT_Interaction(i);
            nb_interaction += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER une interaction dans la liste   *******
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Interaction</param>
        public void SUPPRIMER(Interaction i)
        {
            // Suppression de l'interaction courante
            this.Remove(i);
            //DAO_Interaction.SUPPR_Interaction(i);
            nb_interaction--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// interaction_PRECEDENT()
        /// </summary>
        /// <returns>Interaction précédente</returns>
        public Interaction Interaction_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_interaction_courant -= 1;
                return (this[no_interaction_courant]);
            }
            catch (Exception e)
            {
                no_interaction_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// interaction_SUIVANT()
        /// </summary>
        /// <returns>Bibliothèque suivante</returns>
        public Interaction interaction_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_interaction_courant += 1;
                return (this[no_interaction_courant]);

            }
            catch (Exception e)
            {
                no_interaction_courant -= 1;
                throw e;
            }
        }

        #endregion 

        #endregion
    }
}
