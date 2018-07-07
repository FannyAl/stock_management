using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //*************   La collection EMPLACEMENTS  *************
    //*********************************************************

    /// <summary>
    /// La classe EMPLACEMENTS
    /// </summary>
    public class Emplacements : List<Emplacement>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //*****************   Les EMPLACEMENTS   ******************
        int nb_empl = 0;
        int no_empl_courant = 0;

        //*********************************************************
        //***** Initialisation de la liste des EMPLACEMENTS *******
        //*********************************************************
        #region CONSTRUCTEUR Emplacements

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Emplacements
        /// </summary>
        public Emplacements()
        {
            //Fonction d'initialisation de la Collection
            DAO_Emplacement.Init_Emplacements(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Emplacements


        #region Méthodes Liste de tous les Emplacements

        //*********************************************************
        //*********** Liste de tous les ID Emplacements ***********
        //*********************************************************
        /// <summary>
        /// Liste de tous les ID Emplacements
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Empl()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Emplacement empl in this)
            {
                liste[i] = empl.IdEmplacement;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //**************   Liste des emplacements   ***************
        //*********************************************************
        /// <summary>
        /// Tous les emplacements de la liste
        /// </summary>
        /// <returns>Liste de Id de tous les Emplacements</returns>
        public List<Emplacement> Liste_Emplacement()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID_emplacement, ID_stock

        //*********************************************************
        //**** RECHERCHE d'un emplacement par ID_emplacement ******
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un emplacement par ID
        /// </summary>
        /// <param name="Id_empl">ID Emplacement</param>
        /// <returns></returns>
        public Emplacements Recherche_parID_EMPL(string Id_empl)
        {
            // Recupération des infos selon un ID
            Emplacements liste = new Emplacements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Emplacement empl in this)
            {
                if (empl.IdEmplacement == Id_empl)
                {
                    liste.Add(empl);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //******** RECHERCHE d'un emplacement par ID_stock ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE d'un usager par ID_stock
        /// </summary>
        /// <param name="ID_stock">ID_stock</param>
        /// <returns>liste des ID_stock</returns>
        public Emplacements Recherche_parID_STOCK(string Id_stock)
        {
            // Recupération des infos selon l'ID stock
            Emplacements liste = new Emplacements();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Emplacement empl in this)
            {
                if (empl.IdStock == Id_stock)
                {
                    liste.Add(empl);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //******  MISE A JOUR des infos d'un emplacement  *********
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un emplacement
        /// </summary>
        /// <param name="empl">Emplacement</param>
        public void MAJ_liste_emplacement(Emplacement empl)
        { 
            //Recherche de l'usager à modifier dans la base de données
            foreach (Emplacement e in this)
            {
                if (e.IdEmplacement == empl.IdEmplacement)
                {
                    e.MAJ(empl);
                    break;
                }
            }
        }


        //*********************************************************
        //****** AJOUT d'un nouvel emplacement dans la liste ******
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="e">Emplacement</param>
        public void AJOUT_new(Emplacement e)
        {
            // Ajout d'un nouvel emplacement
            this.Add(e);
            DAO_Emplacement.AJOUT_Emplacement(e);
            nb_empl += 1;
        }


        //*********************************************************
        //***** SUPPRIMER un nouvel emplacement dans la liste *****
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="u">Usager</param>
        public void SUPPRIMER(Emplacement e)
        {
            // Suppression de l'emplacement courant
            this.Remove(e);
            DAO_Emplacement.SUPPR_Emplacement(e);
            nb_empl--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// empl_PRECEDENT()
        /// </summary>
        /// <returns>Emplacement préscédent</returns>
        public Emplacement empl_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_empl_courant -= 1;
                return (this[no_empl_courant]);
            }
            catch (Exception e)
            {
                no_empl_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// empl_SUIVANT()
        /// </summary>
        /// <returns>Emplacement suivant</returns>
        public Emplacement empl_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_empl_courant += 1;
                return (this[no_empl_courant]);

            }
            catch (Exception e)
            {
                no_empl_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion
    }
}
