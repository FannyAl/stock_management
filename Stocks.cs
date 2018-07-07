using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //**************   La collection STOCKS   *****************
    //*********************************************************

    public class Stocks : List<Stock>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //*****************     Les STOCKS    *********************
        int nb_stock = 0;
        int no_stock_courant = 0;

        //*********************************************************
        //******** Initialisation de la liste des Stocks **********
        //*********************************************************
        #region CONSTRUCTEUR Stock

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe STOCKS
        /// </summary>
        public Stocks()
        {
            //Fonction d'initialisation de la Collection
            DAO_Stock.Init_Stocks(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe STOCKS


        #region Méthodes Liste de tous les STOCKS

        //*********************************************************
        //******** Les noms de tous les stocks de la liste*********
        //*********************************************************
        /// <summary>
        /// Les noms de toutes les Stocks de la liste
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_Nom_Stock()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (Stock s in this)
            {
                liste[i] = s.NomStock;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //*********   Tous les stocks de la liste        **********
        //*********************************************************
        /// <summary>
        /// Tous les stocks de la liste
        /// </summary>
        /// <returns>Liste de Noms des Stocks</returns>
        public List<Stock> Liste_Stock()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID, nom, adresse, info

        //*********************************************************
        //*************  RECHERCHE des stocks par ID **************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de stock par ID
        /// </summary>
        /// <param name="id">Id Stock</param>
        /// <returns></returns>
        public Stocks Recherche_parID(string id)
        {
            // Recupération des infos selon un ID
            Stocks liste = new Stocks();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Stock s in this)
            {
                if (s.IDStock == id)
                {
                    liste.Add(s);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*************  RECHERCHE de stock par NOM ***************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de stock par NOM
        /// </summary>
        /// <param name="nom">Nom de stock</param>
        /// <returns>liste stock</returns>
        public Stocks Recherche_parNOM(string nom)
        {
            // Recupération des infos selon le NOM
            Stocks liste = new Stocks();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Stock s in this)
            {
                if (s.NomStock == nom)
                {
                    liste.Add(s);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //***********  RECHERCHE de stock par ADRESSE *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de stock par ADRESSE
        /// </summary>
        /// <param name="adresse">Adresse de stock</param>
        /// <returns>liste stocks</returns>
        public Stocks Recherche_parADRESSE(string adresse)
        {
            // Recupération des infos selon l'ADRESSE
            Stocks liste = new Stocks();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Stock s in this)
            {
                if (s.AdressStock == adresse)
                {
                    liste.Add(s);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*************  RECHERCHE de stock par INFO **************
        //*********************************************************
        /// <summary>
        /// RECHERCHE de stock par INFO
        /// </summary>
        /// <param name="infos">Info de stock</param>
        /// <returns>liste stock</returns>
        public Stocks Recherche_parINFO(string info)
        {
            // Recupération des infos selon le NOM
            Stocks liste = new Stocks();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (Stock s in this)
            {
                if (s.InfoStock == info)
                {
                    liste.Add(s);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'un stock       ***********
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un stock
        /// </summary>
        /// <param name="sto">Stock</param>
        public void MAJ_liste_stock(Stock sto)
        { 
            //Recherche du stock à modifier dans la base de données
            foreach (Stock s in this)
            {
                if (s.IDStock == sto.IDStock)
                {
                    s.MAJ(sto);
                    break;
                }
            }
        }


        //*********************************************************
        //*******  AJOUT d'un nouveau stock dans la liste  ********
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="s">Stock</param>
        public void AJOUT_new(Stock s)
        {
            // Ajout d'un nouveau stock
            this.Add(s);
            DAO_Stock.AJOUT_Stock(s);
            nb_stock += 1;
        }


        //*********************************************************
        //**********   SUPPRIMER un stock dans la liste   *********
        //*********************************************************
        /// <summary>
        /// SUPPRIMER()
        /// </summary>
        /// <param name="b">Stock</param>
        public void SUPPRIMER(Stock s)
        {
            // Suppression du stock courant
            this.Remove(s);
            DAO_Stock.SUPPR_Stock(s);
            nb_stock--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// stock_PRECEDENT()
        /// </summary>
        /// <returns>Stock précédent</returns>
        public Stock stock_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_stock_courant -= 1;
                return (this[no_stock_courant]);
            }
            catch (Exception e)
            {
                no_stock_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// stock_SUIVANT()
        /// </summary>
        /// <returns>Stock suivant</returns>
        public Stock stock_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_stock_courant += 1;
                return (this[no_stock_courant]);

            }
            catch (Exception e)
            {
                no_stock_courant -= 1;
                throw e;
            }
        }

        #endregion

        #endregion

    }
}
