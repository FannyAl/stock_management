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
    class DAO_Materiel
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //******* Initialisation de la liste du materiel **********
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste du materiel
        /// </summary>
        /// <param name="mat">Liste du Materiel</param>
        public static void Init_Materiels(Materiels mat)
        {
            //Connexion avec base de données
            try
            {
                mat.Clear();
                String[] result = new String[8];

                // Requête Sql
                String strSql = "Select * from MATERIEL";

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

                    if (!sqlRdr.IsDBNull(6))
                        result[6] = sqlRdr.GetString(7);
                    else result[6] = "<nc>";

                    // Ajout d'un materiel dans la liste
                    mat.Add(new Materiel(result[0], result[1], result[2], result[3], result[4], Convert.ToInt32(result[5]), Convert.ToBoolean(result[6]), Convert.ToInt32(result[7]))); 
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
        //******   Mise a jour des infos d'un materiel       ******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un materiel
        /// </summary>
        /// <param name="mat">Materiel</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Materiel(Materiel mat)
        {
            //Requête Sql
            String strSql = "Update MATERIEL set ID_transit ='" +
                mat.IDTransit + "' , Titre_materiel= '" + mat.TitreMateriel + "' , Type_materiel= '" + mat.TypeMateriel +
                "' , Famille_materiel= '" + mat.FamilleMateriel + "' , Qte_materiel_stock= '" + mat.Quantité + "' , Disponibilite= '" + mat.DispoMateriel +
                "' , Seuil_alerte= '" + mat.Seuil_alert + "' where ID_materiel='" + mat.IDMateriel + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////******   Ajout d'un nouveau materiel dans la liste ******
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouveau materiel dans la liste
        /// </summary>
        /// <param name="mat">Materiel</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Materiel(Materiel mat)
        {
            // Requête sql
            String strSql = "Insert into MATERIEL values('"
              + mat.IDMateriel + "' , '" +
                mat.IDTransit + "' , '" +
                mat.TitreMateriel + "' , '" +
                mat.TypeMateriel + "' , '" +
                mat.FamilleMateriel + "' , '" +
                mat.Quantité + "' , '" +
                mat.DispoMateriel + "' , '" +
                mat.Seuil_alert + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****   Suppression d'un materiel dans la liste    *******
        //*********************************************************
        /// <summary>
        /// Suppression d'un materiel dans la liste
        /// </summary>
        /// <param name="mat">Materiel</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPR_Materiel(Materiel mat)
        {
            // Requête Sql
            String strSql = "Delete from MATERIEL where ID_materiel='" + mat.IDMateriel.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
