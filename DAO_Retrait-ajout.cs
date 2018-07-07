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
    class DAO_Interaction
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //***** Initialisation de la liste des Interactions *******
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Interactions
        /// </summary>
        /// <param name="emp">Liste des Interactions</param>
        public static void Init_Interactions(Interactions inte)
        {
            //Connexion avec base de données
            try
            {
                inte.Clear();
                String[] result = new String[7];

                // Requête Sql
                String strSql = "Select * from INTERACTION";

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


                    // Décomposition des ID
                    string[] temp = result[3].Split('-');
                    string s0 = temp[0].Trim();
                    string s1 = temp[1].Trim();
                    string s2 = temp[2].Trim();
                    // Conversion des ID en entier
                    int etage = Convert.ToInt32(s0.Substring(s0.Length - 1, 1));
                    int allee = Convert.ToInt32(s1.Substring(s1.Length - 1, 1));
                    int rayon = Convert.ToInt32(s2.Substring(s2.Length - 1, 1));


                    // Ajout d'une interaction dans la liste
                    //us.Add(new Interaction(result[0], result[1], result[2], etage, allee, rayon)); /////////////////////////////////////////
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
        //******   Mise a jour des infos d'une interaction   ******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'une interaction
        /// </summary>
        /// <param name="emp">Interaction</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Interaction(Interaction inte)
        {
            //Requête Sql
            String strSql = "Update INTERACTION set ID_professionnel ='" +
                inte.IdPro + "' , MDP_professionnel= '" + inte.MdpPro + "' , ID_accompagnement= '" + inte.IdBinome + 
                "' , NOM_professionnel= '" + inte.NomProAcc + "' where ID_materiel='" + inte.IDMateriel + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////**** Ajout d'une nouvelle interaction dans la liste *****
        ////*********************************************************
        /// <summary>
        /// Ajout d'une nouvelle interaction dans la liste
        /// </summary>
        /// <param name="emp">Interaction</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Interaction(Interaction inte)
        {
            // Requête sql
            String strSql = "Insert into INTERACTION values('"
              + inte.IDMateriel + "' , '" +
                inte.IdPro + "' , '" +
                inte.MdpPro + "' , '" +
                inte.IdBinome + "' , '" +
                inte.NomProAcc + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //****   Suppression d'une interaction dans la liste ******
        //*********************************************************
        /// <summary>
        /// Suppression d'une interaction dans la liste
        /// </summary>
        /// <param name="emp">Interaction</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPR_Interaction(Interaction inte)
        {
            // Requête Sql
            String strSql = "Delete from INTERACTION where ID_materiel='" + inte.IDMateriel.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
