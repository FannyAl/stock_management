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
    class DAO_Emplacement
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //***** Initialisation de la liste des EMPLACEMENTS *******
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des EMPLACEMENTS
        /// </summary>
        /// <param name="empl">Liste des Emplacements</param>
        public static void Init_Emplacements(Emplacements empl)
        {
            //Connexion avec la base de données
            try
            {
                empl.Clear();
                String[] result = new String[4];

                // Requête Sql
                String strSql = "Select * from EMPLACEMENT";

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


                    // Ajout d'un emplacement dans la liste
                    empl.Add(new Emplacement(result[0], result[1], result[2], result[3]));
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
        //******   Mise a jour des infos d'un emplacement   *******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un emplacement
        /// </summary>
        /// <param name="empl">Emplacement</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Emplacement(Emplacement empl)
        {
            //Requête Sql
            String strSql = "Update EMPLACEMENT set ID_stock ='" +
                empl.IdStock + "' , ID_transit= '" + empl.IdTransit + "' , ID_materiel= '" + empl.IdMateriel +
                "' where ID_emplacement='" + empl.IdEmplacement + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////****** Ajout d'un nouvel emplacement dans la liste ******
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouvel emplacement dans la liste
        /// </summary>
        /// <param name="empl">Emplacement</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Emplacement(Emplacement empl)
        {
            // Requête sql
            String strSql = "Insert into EMPLACEMENT values('"
              + empl.IdEmplacement + "' , '" +
                empl.IdStock + "' , '" +
                empl.IdTransit + "' , '" +
                empl.IdMateriel + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****   Suppression d'un emplacement dans la liste  ******
        //*********************************************************
        /// <summary>
        /// Suppression d'un emplacement dans la liste
        /// </summary>
        /// <param name="empl">Emplacement</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_Emplacement(Emplacement empl)
        {
            // Requête Sql
            String strSql = "Delete from EMPLACEMENT where ID_emplacement='" + empl.IdStock.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
