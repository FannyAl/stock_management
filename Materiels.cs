using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //*************   La collection MATERIEL   ****************
    //*********************************************************

    /// <summary>
    /// La classe MATERIEL
    /// </summary>
    public class Materiels : List<Materiel>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //******************     Les MATERIELS   ******************
        int nb_materiel = 0;
        int no_materiel_courant = 0;

        //*********************************************************
        //******* Initialisation de la liste des Materiels ********
        //*********************************************************
        #region CONSTRUCTEUR Materiels

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Bibliotheques
        /// </summary>
        public Materiels()
        {
            //Fonction d'initialisation de la Collection
            DAO_Materiel.Init_Materiels(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Materiels


        #region Méthodes Liste de tout le materiel

        //*********************************************************
        //******* Les titres de tout le materiel de la liste*******
        //*********************************************************
        /// <summary>
        /// Les noms de tout le materiel de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_Titre_Materiel()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Materiel m in this)
            {
                liste[i] = m.TitreMateriel;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //*********   Tout le materiel de la liste        *********
        //*********************************************************
        /// <summary>
        /// Tous les Bibliothèques de la liste
        /// </summary>
        /// <returns>Liste de Noms des Bibliotheques</returns>
        public List<Materiel> Liste_Materiel()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par Id, titre, type, famille

        //*********************************************************
        //************  RECHERCHE de materiel par ID **************
        //*********************************************************
        /// <summary>
        /// RECHERCHE du materiel par ID
        /// </summary>
        /// <param name="code">Code Bibliothèque</param>
        /// <returns></returns>
        public Materiels Recherche_parID(string id)
        {
            // Recupération des infos selon un ID
            Materiels liste = new Materiels();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Materiel m in this)
            {
                if (m.IDMateriel == id)
                {
                    liste.Add(m);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //***********  RECHERCHE de materiel par TITRE ************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de materiel par TITRE
        /// </summary>
        /// <param name="libelle">Titre du materiel</param>
        /// <returns>liste materiel</returns>
        public Materiels Recherche_parTITRE(string titre)
        {
            // Recupération des infos selon le LIBELLE
            Materiels liste = new Materiels();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Materiel m in this)
            {
                //Pour retourner l'alernative d'un materiel qui possède des informations similaires avant de le créer
                if (m.TitreMateriel == titre)
                {
                    liste.Add(m);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //***********  RECHERCHE de materiel par TYPE *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de materiel par TYPE
        /// </summary>
        /// <param name="type">Type de materiel</param>
        /// <returns>liste materiel</returns>
        public Materiels Recherche_parTYPE(string type)
        {
            // Recupération des infos selon un TYPE
            Materiels liste = new Materiels();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Materiel m in this)
            {
                if (m.TypeMateriel == type)
                {
                    liste.Add(m);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //**********  RECHERCHE de materiel par FAMILLE ***********
        //*********************************************************
        /// <summary>
        /// RECHERCHE de materiel par FAMILLE
        /// </summary>
        /// <param name="famille">Famille de materiel</param>
        /// <returns>liste materiel</returns>
        public Materiels Recherche_parFAMILLE(string famille)
        {
            // Recupération des infos selon une FAMILLE
            Materiels liste = new Materiels();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Materiel m in this)
            {
                if (m.FamilleMateriel == famille)
                {
                    liste.Add(m);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //*******   MISE A JOUR des infos d'un materiel      ******
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un materiel
        /// </summary>
        /// <param name="bib">Materiel</param>
        public void MAJ_liste_materiel(Materiel mat)
        { 
            //Recherche du materiel à modifier dans la base de données
            foreach (Materiel m in this)
            {
                if (m.IDMateriel == mat.IDMateriel)
                {
                    m.MAJ(mat);
                    break;
                }
            }
        }


        //*********************************************************
        //*****  AJOUT d'un nouveau materiel dans la liste  *******
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="b">Materiel</param>
        public void AJOUT_new(Materiel m)
        {
            // Ajout d'une nouvelle bibliothèque
            this.Add(m);
            //DAO_Materiel.AJOUT_Materiel(m);
            nb_materiel += 1;
        }


        //*********************************************************
        //*******   SUPPRIMER un materiel dans la liste   *********
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Materiel</param>
        public void SUPPRIMER(Materiel m)
        {
            // Suppression du materiel courante
            this.Remove(m);
            //DAO_Materiel.SUPPR_Materiel(m);
            nb_materiel--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// materiel_PRECEDENT()
        /// </summary>
        /// <returns>Materiel précédent</returns>
        public Materiel materiel_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_materiel_courant -= 1;
                return (this[no_materiel_courant]);
            }
            catch (Exception e)
            {
                no_materiel_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// materiel_SUIVANT()
        /// </summary>
        /// <returns>Materiel suivant</returns>
        public Materiel materiel_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_materiel_courant += 1;
                return (this[no_materiel_courant]);

            }
            catch (Exception e)
            {
                no_materiel_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion

    }
}
