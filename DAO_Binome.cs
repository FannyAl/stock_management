using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Stock_class;
using System.Configuration;
using System.Data.Common;
using couche_DAO;

namespace Stock_class
{
    class DAO_Binome
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //******* Initialisation de la liste des Binômes **********
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Binômes
        /// </summary>
        /// <param name="bi">Liste des Binômes</param>
        public static void Init_Binomes(Binomes bi)
        {
            //Connexion avec base de données
            try
            {
                bi.Clear();
                String[] result = new String[2];

                // Requête Sql
                String strSql = "Select * from BINOME";

                //// Execution de la requete
                IDataReader sqlRdr = DAO.Execute_Query(strSql);
                while (sqlRdr.Read())
                {
                    if (!sqlRdr.IsDBNull(0))
                        result[0] = sqlRdr.GetString(0);
                    else result[0] = "<nc>";

                    if (!sqlRdr.IsDBNull(1))
                        result[1] = sqlRdr.GetString(1);
                    else result[1] = "<nc>";


                    // Ajout d'un binôme dans la liste
                    bi.Add(new Binome(result[0], result[1]));
                }

                //Fermeture de la requête
                sqlRdr.Close();
                sqlRdr = null;

            }
            catch (Exception ex)
            {
                // ==> Si erreur, la LISTE est vide
            }

        }


        //*********************************************************
        //********   Mise a jour des infos d'un binôme     ********
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un binôme
        /// </summary>
        /// <param name="bi">Binome</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Binome(Binome bi)
        {
            //Requête Sql
            String strSql = "Update BINOME set Date_heure ='" +
                bi.Date_Heure + "' where ID_accompagnement='" + bi.IdAccomp + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////******   Ajout d'un nouveau binome dans la liste   ******
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouveau binome dans la liste
        /// </summary>
        /// <param name="bi">Binome</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Binome(Binome bi)
        {
            // Requête sql
            String strSql = "Insert into BINOME values('"
              + bi.IdAccomp + "' , '" +
                bi.Date_Heure + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //*****   Suppression d'un binome dans la liste     *******
        //*********************************************************
        /// <summary>
        /// Suppression d'un binome dans la liste
        /// </summary>
        /// <param name="bi">Binome</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_Binome(Binome bi)
        {
            // Requête Sql
            String strSql = "Delete from BINOME where ID_accompagnement='" + bi.IdAccomp.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
