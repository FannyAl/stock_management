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
    class DAO_Accompagnement
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //**** Initialisation de la liste des Accompagnements *****
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Accompagnements
        /// </summary>
        /// <param name="acc">Liste des Accompagnements</param>
        public static void Init_Accompagnements(Accompagnements acc)
        {
            //Connexion avec base de données
            try
            {
                acc.Clear();
                String[] result = new String[5];

                // Requête Sql
                String strSql = "Select * from ACCOMPAGNEMENT";

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

                    if (!sqlRdr.IsDBNull(2))
                        result[2] = sqlRdr.GetString(2);
                    else result[2] = "<nc>";

                    if (!sqlRdr.IsDBNull(3))
                        result[3] = sqlRdr.GetString(3);
                    else result[3] = "<nc>";

                    if (!sqlRdr.IsDBNull(4))
                        result[4] = sqlRdr.GetString(4);
                    else result[4] = "<nc>";

                    // Ajout d'un accompagnement dans la liste
                    acc.Add(new Accompagnement(result[0], result[1], result[2], result[3], result[4]));
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
        //******   Mise a jour des infos d'un accompagnement ******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un accompagnement
        /// </summary>
        /// <param name="acc">Accompagnement</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Accompagnement(Accompagnement acc)
        {
            //Requête Sql
            String strSql = "Update ACCOMPAGNEMENT set ID_usager ='" + acc.IdUsager + "' , ID_professionnel= '" + acc.IdPro +
                "' , Nom_professionnel= '" + acc.NomPro + "' , Date_heure= '" + acc.Date_heure +
                "' where ID_accompagnement='" + acc.IdAccomp + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////*** Ajout d'un nouvel accompagnement dans la liste    ***
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouvel accompagnement dans la liste
        /// </summary>
        /// <param name="acc">Accompagnement</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Accomp(Accompagnement acc)
        {
            // Requête sql
            String strSql = "Insert into ACCOMPAGNEMENT values('" +
                acc.IdUsager + "' , '" +
                acc.IdPro + "' , '" +
                acc.NomPro + "' , '" +
                acc.IdAccomp + "' , '" +
                acc.Date_heure + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //**** Suppression d'un accompagnement dans la liste  *****
        //*********************************************************
        /// <summary>
        /// Suppression d'un accompagnement dans la liste
        /// </summary>
        /// <param name="acc">Accompagnement</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_Accomp(Accompagnement acc)
        {
            // Requête Sql
            String strSql = "Delete from ACCOMPAGNEMENT where ID_accompagnement='" + acc.IdAccomp.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
