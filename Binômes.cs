using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //*************   La collection Binomes   ******************
    //*********************************************************

    /// <summary>
    /// La classe Binomôme
    /// </summary>
    public class Binômes : List<Binôme>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //******************     Les Binömes    *******************
        int nb_binome = 0;
        int no_binome_courant = 0;

        //*********************************************************
        //**** Initialisation de la liste des Binomes *******
        //*********************************************************
        #region CONSTRUCTEUR Binome

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Binome
        /// </summary>
        public Binômes()
        {
            //Fonction d'initialisation de la Collection
            //DAO_Binome.Init_Binomes(this);//////////////////////////////////////////////
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Binomes

        #region Méthodes Liste de toutes les Binomes

        //*********************************************************
        //******* Les noms de tous les binomes de la liste*********
        //*********************************************************
        /// <summary>
        /// Les noms de tous les binomes de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Binome()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Binôme b in this)
            {
                liste[i] = b.IDAccompagnement;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //********   Toutes les Binomes de la liste        ********
        //*********************************************************
        /// <summary>
        /// Toutes les Binomes de la liste
        /// </summary>
        /// <returns>Liste de ID des Binomes</returns>
        public List<Binôme> Liste_Binome()
        {
            return this;
        }

        #endregion
        // AFFICHAGE NOM ACCOMPAGNANT USAGER PLUS PERTINENT

        #region Méthodes RECHERCHE par ID / Nom d'accompagnateur / Date

        //*********************************************************
        //***************  RECHERCHE du binome par ID *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE du binome par CODE
        /// </summary>
        /// <param name="code">Code Binome</param>
        /// <returns></returns>
        public Binômes Recherche_parID(string IDAcc)
        {
            // Recupération des infos selon un ID
            Binômes liste = new Binômes();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Binôme b in this)
            {
                if (b.IDAccompagnement == IDAcc)
                {
                    // Recherche ID usager et pro

                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*****  RECHERCHE du binome par Nom d'accompagnateur *****
        //*********************************************************
        /// <summary>
        /// RECHERCHE du binome par NOM accompagnateur
        /// </summary>
        /// <param name="code">Nom Accompagnateur</param>
        /// <returns></returns>
        public Binômes Recherche_parNOMPRO(string Nom)
        {
            // Recupération des infos selon le Nom d'un professionnel accompagnant
            Binômes liste = new Binômes();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Binôme b in this)
            {
                if (b.NomPro == Nom)
                {
                    // Recherche ID usager et pro

                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*********  RECHERCHE du binome par Date & Heure *********
        //*********************************************************
        /// <summary>
        /// RECHERCHE du binome par DATE
        /// </summary>
        /// <param name="code">DATE</param>
        /// <returns></returns>
        public Binômes Recherche_parDATE(string date)
        {
            // Recupération des infos selon une DATE
            Binômes liste = new Binômes();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Binôme b in this)
            {
                if (b.DateHeure == date)
                {
                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'un binôme       **********
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un binôme
        /// </summary>
        /// <param name="bib">Binôme</param>
        public void MAJ_liste_binome(Binôme bi)
        { 
            //Recherche de l'adhérent à modifier dans la base de données
            foreach (Binôme b in this)
            {
                if (b.IDAccompagnement == bi.IDAccompagnement)
                {
                    b.MAJ(bi);
                    break;
                }
            }
        }


        //*********************************************************
        //*******  AJOUT d'un nouveau binôme dans la liste  *******
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="b">Bibliothèque</param>
        public void AJOUT_new(Binôme b)
        {
            // Ajout d'un nouveau binôme
            this.Add(b);
            //DAO_Binome.AJOUT_Binome(b);
            nb_binome += 1;
        }


        //*********************************************************
        //*********   SUPPRIMER un binôme dans la liste   *********
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Binôme</param>
        public void SUPPRIMER(Binôme b)
        {
            // Suppression de la bibliothèque courante
            this.Remove(b);
            //DAO_Binome.SUPPR_Binome(b);
            nb_binome--;
        }

        #endregion

        #endregion

    }
}
