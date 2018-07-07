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
    class DAO_RetraitAjout
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //**** Initialisation de la liste des retraits ajouts *****
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des retraits ajouts
        /// </summary>
        /// <param name="ras">Liste des retraits ajouts</param>
        public static void Init_RetraitsAjouts(RetraitsAjouts ras)
        {
            //Connexion avec base de données
            try
            {
                ras.Clear();
                String[] result = new String[8];

                // Requête Sql
                String strSql = "Select * from RETRAIT_AJOUT";

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

                    if (!sqlRdr.IsDBNull(5))
                        result[5] = sqlRdr.GetString(5);
                    else result[5] = "<nc>";

                    if (!sqlRdr.IsDBNull(6))
                        result[6] = sqlRdr.GetString(6);
                    else result[6] = "<nc>";

                    if (!sqlRdr.IsDBNull(7))
                        result[7] = sqlRdr.GetString(7);
                    else result[7] = "<nc>";


                    // Ajout d'une interaction dans la liste
                    ras.Add(new RetraitAjout(result[0], result[1], result[2], result[3], result[4], result[5], result[6], Convert.ToInt32(result[7])));
                    //nb_materiel += 1;
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
        //******   Mise a jour des infos d'un retrait ajout  ******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un retrait ajout
        /// </summary>
        /// <param name="ra">retrait ajout</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_RA(RetraitAjout ra)
        {
            //Requête Sql
            String strSql = "Update INTERACTION set ID_materiel ='" + ra.IDMateriel +
                "' , ID_professionnel= '" + ra.IdProfessionnel + "' , ID_accompagnement= '" + ra.IdAccompagnement +
                "' , NOM_professionnel= '" + ra.NomProfessionnel + "' , Date_heure= '" + ra.Date_heure +
                "' , Type_transit= '" + ra.Type_transit + "' , Qte_materiel_transit= '" + ra.QteMateriel + 
                "' where ID_transit='" + ra.IDTransit + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////**** Ajout d'un nouveau retrait ajout dans la liste *****
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouveau retrait ajout dans la liste
        /// </summary>
        /// <param name="ra">Retrait Ajout</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_RA(RetraitAjout ra)
        {
            // Requête sql
            String strSql = "Insert into RETRAIT_AJOUT values('"
              + ra.IDTransit + "' , '" +
                ra.IDMateriel + "' , '" +
                ra.IdProfessionnel + "' , '" +
                ra.IdAccompagnement + "' , '" +
                ra.NomProfessionnel + "' , '" +
                ra.Date_heure + "' , '" +
                ra.Type_transit + "' , '" +
                ra.QteMateriel + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****  Suppression d'un retrait ajout dans la liste ******
        //*********************************************************
        /// <summary>
        /// Suppression d'un retrait ajout dans la liste
        /// </summary>
        /// <param name="ra">retrait ajout</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_RA(RetraitAjout ra)
        {
            // Requête Sql
            String strSql = "Delete from RETRAIT_AJOUT where ID_transit='" + ra.IDTransit + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
