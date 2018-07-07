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
    /// La classe Binome
    /// </summary>
    public class Binomes : List<Binome>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //******************     Les Binömes    *******************
        int nb_binome = 0;
        int no_binome_courant = 0;

        //*********************************************************
        //******   Initialisation de la liste des Binomes   *******
        //*********************************************************
        #region CONSTRUCTEUR Binome

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe Binome
        /// </summary>
        public Binomes()
        {
            //Fonction d'initialisation de la Collection
            DAO_Binome.Init_Binomes(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe Binomes

        #region Méthodes Liste de tous les Binomes

        //*********************************************************
        //************** Liste de tous les Binomes ****************
        //*********************************************************
        /// <summary>
        /// Liste de tous les Binomes
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_Accompagnement()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Binome b in this)
            {
                liste[i] = b.IdAccomp;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //********   Tous les Binomes de la liste        **********
        //*********************************************************
        /// <summary>
        /// Tous les Binomes de la liste
        /// </summary>
        /// <returns>Liste ID Accompagnement</returns>
        public List<Binome> Liste_Binome()
        {
            return this;
        }

        #endregion

        #region Méthodes RECHERCHE par ID / Date

        //*********************************************************
        //***************  RECHERCHE du binome par ID *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE du binome par ID
        /// </summary>
        /// <param name="IDAcc">ID Accompagnement</param>
        /// <returns></returns>
        public Binomes Recherche_parID(string IDAcc)
        {
            // Recupération des infos selon un ID
            Binomes liste = new Binomes();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Binome b in this)
            {
                if (b.IdAccomp == IDAcc)
                {
                    // Recherche ID usager et pro

                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*************  RECHERCHE du binome par Date *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE du binome par DATE
        /// </summary>
        /// <param name="date">DATE</param>
        /// <returns></returns>
        public Binomes Recherche_parDATE(string date)
        {
            // Recupération des infos selon une DATE
            Binomes liste = new Binomes();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Binome b in this)
            {
                if (b.Date_Heure == date)
                {
                    liste.Add(b);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*************  RECHERCHE du binome par Heure ************
        //*********************************************************
        /// <summary>
        /// RECHERCHE du binome par HEURE
        /// </summary>
        /// <param name="heure">HEURE</param>
        /// <returns></returns>
        public Binomes Recherche_parHEURE(string heure)
        {
            // Recupération des infos selon une Heure
            Binomes liste = new Binomes();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Binome b in this)
            {
                if (b.Date_Heure == heure)
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
        public void MAJ_liste_binome(Binome bi)
        { 
            //Recherche de l'adhérent à modifier dans la base de données
            foreach (Binome b in this)
            {
                if (b.IdAccomp == bi.IdAccomp)
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
        /// <param name="b">Binome</param>
        public void AJOUT_new(Binome b)
        {
            // Ajout d'un nouveau binôme
            this.Add(b);
            DAO_Binome.AJOUT_Binome(b);
            nb_binome += 1;
        }


        //*********************************************************
        //*********   SUPPRIMER un binôme dans la liste   *********
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Binôme</param>
        public void SUPPRIMER(Binome b)
        {
            // Suppression de la bibliothèque courante
            this.Remove(b);
            DAO_Binome.SUPPR_Binome(b);
            nb_binome--;
        }

        #endregion

        #endregion

    }
}
