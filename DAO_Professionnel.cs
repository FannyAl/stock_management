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
    class DAO_Professionnel
    {

        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //*** Initialisation de la liste des Professionnels *******
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Professionnels
        /// </summary>
        /// <param name="pro">Liste des Professionnels</param>
        public static void Init_Professionnels(Professionnels pro)
        {
            //Connexion avec base de données
            try
            {
                pro.Clear();
                String[] result = new String[5];

                // Requête Sql
                String strSql = "Select * from PROFESSIONNEL";

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


                    // Ajout d'un professionnel dans la liste
                    pro.Add(new Professionnel(result[0], result[1], result[2], result[3], result[4]));
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
        //******   Mise a jour des infos d'un professionnel  ******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un professionnel
        /// </summary>
        /// <param name="pro">Professionnel</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Professionnel(Professionnel pro)
        {
            //Requête Sql
            String strSql = "Update PROFESSIONNEL set Nom_professionnel ='" + pro.NomPro + "' , MDP_professionnel= '" +
                pro.MdpPro + "' , Statut_professionnel= '" + pro.StatutPro + "' , Infos_professionnel= '" + pro.CommentairePro +
                "' where ID_professionnel='" + pro.IdPro + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////**** Ajout d'un nouveau professionnel dans la liste *****
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouveau professionnel dans la liste
        /// </summary>
        /// <param name="pro">Professionnel</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Professionnel(Professionnel pro)
        {
            // Requête sql
            String strSql = "Insert into PROFESSIONNEL values('"
              + pro.IdPro + "' , '" +
                pro.NomPro + "' , '" +
                pro.MdpPro + "' , '" +
                pro.StatutPro + "' , '" +
                pro.CommentairePro + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //**** Suppression d'un professionnel dans la liste *******
        //*********************************************************
        /// <summary>
        /// Suppression d'un professionnel dans la liste
        /// </summary>
        /// <param name="pro">Professionnel</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_Professionnel(Professionnel pro)
        {
            // Requête Sql
            String strSql = "Delete from PROFESSIONNEL where ID_professionnel='" + pro.IdPro.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
