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
    class DAO_Usager
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //******* Initialisation de la liste des Usagers **********
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Usagers
        /// </summary>
        /// <param name="us">Liste des Usagers</param>
        public static void Init_Usagers(Usagers us)
        {
            //Connexion avec la base de données
            try
            {
                us.Clear();
                String[] result = new String[5];

                // Requête Sql
                String strSql = "Select * from USAGER";

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


                    // Ajout de l'usager dans la liste
                    us.Add(new Usager(result[0], result[1], result[2], result[3], result[4])); 
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
        //******   Mise a jour des infos d'un usager         ******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un usager
        /// </summary>
        /// <param name="us">Usager</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Usager(Usager us)
        {
            //Requête Sql
            String strSql = "Update USAGER set Pseudo_usager ='" +
                us.PseudoUsager + "' , Mail_usager= '" + us.MailAdress + "' , Adresse_usager= '" + us.PostAdress +
                "' , Infos_usager= '" + us.Commentaire + "' where ID_usager='" + us.IdUsager + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////******   Ajout d'un nouvel usager dans la liste    ******
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouvel usager dans la liste
        /// </summary>
        /// <param name="us">Usager</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Usager(Usager us)
        {
            // Requête sql
            String strSql = "Insert into USAGER values('"
              + us.IdUsager + "' , '" +
                us.PseudoUsager + "' , '" +
                us.MailAdress + "' , '" +
                us.PostAdress + "' , '" +
                us.Commentaire + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****   Suppression d'un usager dans la liste     ********
        //*********************************************************
        /// <summary>
        /// Suppression de l'usager dans la liste
        /// </summary>
        /// <param name="us">Usager</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_Usager(Usager us)
        {
            // Requête Sql
            String strSql = "Delete from USAGER where ID_usager='" + us.IdUsager.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
