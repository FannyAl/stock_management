using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_class
{
    //*********************************************************
    //*********  La collection RETRAITS AJOUTS  ***************
    //*********************************************************

    /// <summary>
    /// La classe RETRAITSAJOUTS
    /// </summary>
    public class RetraitsAjouts : List<RetraitAjout>
    {
        //*********************************************************
        //**********      Les Objets                ***************
        //*********************************************************

        //****************** Les RETRAITS AJOUTS ******************
        int nb_retraitajout = 0;
        int no_retraitajout_courant = 0;

        //*********************************************************
        //***** Initialisation de la liste des RETRAITS AJOUTS ****
        //*********************************************************
        #region CONSTRUCTEUR RETRAITS AJOUTS

        /// <summary>
        /// CONSTRUCTEUR par défault de la classe RETRAITS AJOUTS
        /// </summary>
        public RetraitsAjouts()
        {
            //Fonction d'initialisation de la Collection
            DAO_RetraitAjout.Init_RetraitsAjouts(this);
        }

        #endregion


        //*********************************************************
        //************      Les Méthodes            ***************
        //*********************************************************
        #region METHODES de la classe RETRAITS AJOUTS


        #region Méthodes Liste de toutes les RETRAITS AJOUTS

        //*********************************************************
        //*********  Liste de tous les RETRAITS AJOUTS  ***********
        //*********************************************************
        /// <summary>
        /// Liste de tous les RETRAITS AJOUTS
        /// </summary>
        /// <returns>liste</returns>
        public String[] Liste_ID_transit_retraitajout()
        {
            //****     Version avec LISTE   ***
            String[] liste = new String[this.Count]; //nb d'éléments dans la liste

            int i = 0;
            foreach (RetraitAjout ra in this)
            {
                liste[i] = ra.IDTransit;
                i++;
            }
            return liste;
        }


        //*********************************************************
        //************  Tous les retraits ajouts      *************
        //*********************************************************
        /// <summary>
        /// Tous les retraits ajouts de la liste
        /// </summary>
        /// <returns>Liste des retraits ajouts</returns>
        public List<RetraitAjout> Liste_RetraitAjout()
        {
            return this;
        }

        #endregion


        #region Méthodes RECHERCHE par ID_transit, ID_materiel, ID_professionnel, ID_accompagement, Nom_professionnel, Date, Heure, TypeTransit 

        //*********************************************************
        //*******  RECHERCHE RetraitAjout par ID_transit **********
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par ID_transit
        /// </summary>
        /// <param name="idtrans">ID_transit</param>
        /// <returns></returns>
        public RetraitsAjouts Recherche_parID_TRANSIT(string idtrans)
        {
            // Recupération des infos selon un ID_transit
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.IDTransit == idtrans)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*******  RECHERCHE RetraitAjout par ID_materiel *********
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par ID_materiel
        /// </summary>
        /// <param name="idmat">ID_materiel</param>
        /// <returns>liste RetraitAjout</returns>
        public RetraitsAjouts Recherche_parID_MATERIEL(string idmat)
        {
            // Recupération des infos selon l'ID_Materiel
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.IDMateriel == idmat)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //**** RECHERCHE RetraitAjout par ID_PROFESSIONNEL ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par ID_PROFESSIONNEL
        /// </summary>
        /// <param name="idpro">ID_PROFESSIONNEL</param>
        /// <returns>liste RetraitAjout</returns>
        public RetraitsAjouts Recherche_parID_PRO(string idpro)
        {
            // Recupération des infos selon l'ID_professionnel
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.IdProfessionnel == idpro)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }


        //*********************************************************
        //**** RECHERCHE RetraitAjout par ID_ACCOMPAGNEMENT *******
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par ID_ACCOMPAGNEMENT
        /// </summary>
        /// <param name="idaccomp">ID_ACCOMPAGNEMENT</param>
        /// <returns>liste RetraitAjout</returns>
        public RetraitsAjouts Recherche_parID_ACCOMP(string idaccomp)
        {
            // Recupération des infos selon l'ID_accompagnement
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.IdAccompagnement == idaccomp)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }


        //*********************************************************
        //**** RECHERCHE RetraitAjout par NOM_PROFESSIONNEL *******
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par NOM_PROFESSIONNEL
        /// </summary>
        /// <param name="nompro">NOM_PROFESSIONNEL</param>
        /// <returns>liste RetraitAjout</returns>
        public RetraitsAjouts Recherche_parNOM_PRO(string nompro)
        {
            // Recupération des infos selon le nom du professionnel accompagnant
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.NomProfessionnel == nompro)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //*********** RECHERCHE RetraitAjout par DATE *************
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par DATE
        /// </summary>
        /// <param name="date">DATE</param>
        /// <returns>liste RetraitAjout</returns>
        public RetraitsAjouts Recherche_parDATE(string date)
        {
            // Recupération des infos selon la date
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.Date_heure == date)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }

        //*********************************************************
        //***** RECHERCHE RetraitAjout par TYPE DE TRANSIT ********
        //*********************************************************
        /// <summary>
        /// RECHERCHE RetraitAjout par TYPE DE TRANSIT
        /// </summary>
        /// <param name="typetrans">TYPE DE TRANSIT</param>
        /// <returns>liste RetraitAjout</returns>
        public RetraitsAjouts Recherche_parTYPE_TRANS(string typetrans)
        {
            // Recupération des infos selon le type de transit de matériel : retrait, transfert, approvisionnement
            RetraitsAjouts liste = new RetraitsAjouts();
            liste.Clear();

            //****    Recherche Collection   ***
            foreach (RetraitAjout ra in this)
            {
                if (ra.Type_transit == typetrans)
                {
                    liste.Add(ra);
                    break;
                }
            }
            return liste;
        }

        #endregion


        #region Méthodes MAJ / AJOUT / SUPPRIMER
        
        //*********************************************************
        //****   MISE A JOUR des infos d'un RetraitAjout       ****
        //*********************************************************
        /// <summary>
        /// MISE A JOUR des infos d'un RetraitAjout 
        /// </summary>
        /// <param name="reaj">RetraitAjout</param>
        public void MAJ_liste_retraitajout(RetraitAjout reaj)
        { 
            //Recherche du retraitajout à modifier dans la base de données
            foreach (RetraitAjout ra in this)
            {
                if (ra.IDTransit == reaj.IDTransit)
                {
                    ra.MAJ(reaj);
                    break;
                }
            }
        }


        //*********************************************************
        //****  AJOUT d'un nouveau RetraitAjout dans la liste  ****
        //*********************************************************
        /// <summary>
        /// AJOUT_new()
        /// </summary>
        /// <param name="ra">RetraitAjout</param>
        public void AJOUT_new(RetraitAjout ra)
        {
            // Ajout d'un nouveau retrait Ajout
            this.Add(ra);
            DAO_RetraitAjout.AJOUT_RA(ra);
            nb_retraitajout += 1;
        }


        //*********************************************************
        //*****   SUPPRIMER un retraitajout dans la liste   *******
        //*********************************************************
        /// <summary>
        /// SUPPR_RA()
        /// </summary>
        /// <param name="ra">retraitajout</param>
        public void SUPPR_RA(RetraitAjout ra)
        {
            // Suppression du RetraitAjout courant
            this.Remove(ra);
            DAO_RetraitAjout.SUPPR_RA(ra);
            nb_retraitajout--;
        }

        #endregion


        #region Méthodes PRECEDENT / SUIVANT
        
        //*******************************************************************
        //******* Recuperation de l'element PRECEDENT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// ra_PRECEDENT()
        /// </summary>
        /// <returns>ra précédent</returns>
        public RetraitAjout ra_PRECEDENT()
        {   
            // Fonction permettant de recuperer l'element precedent de la liste
            try
            {
                no_retraitajout_courant -= 1;
                return (this[no_retraitajout_courant]);
            }
            catch (Exception e)
            {
                no_retraitajout_courant += 1;
                throw e;
            }
        }


        //*******************************************************************
        //********  Recuperation de l'element SUIVANT de la liste  **********
        //*******************************************************************
        /// <summary>
        /// ra_SUIVANT()
        /// </summary>
        /// <returns>Ra suivant</returns>
        public RetraitAjout ra_SUIVANT()
        {
            // Fonction permettant de recuperer l'element suivant de la liste
            try
            {
                no_retraitajout_courant += 1;
                return (this[no_retraitajout_courant]);

            }
            catch (Exception e)
            {
                no_retraitajout_courant -= 1;
                throw e;
            }
        }

        #endregion 

        #endregion
    }
}
