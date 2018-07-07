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
    class DAO_Stock
    {
        ////*******************************************************
        ////**********      Les Fonctions             *************
        ////*******************************************************

        //*********************************************************
        //******* Initialisation de la liste des Stocks ***********
        //*********************************************************
        /// <summary>
        /// Initialisation de la liste des Stocks
        /// </summary>
        /// <param name="stk">Liste des Stocks</param>
        public static void Init_Stocks(Stocks stk)
        {
            //Connexion avec base de données
            try
            {
                stk.Clear();
                String[] result = new String[4];

                // Requête Sql
                String strSql = "Select * from STOCK";

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

                    // Ajout du stock dans la liste
                    stk.Add(new Stock(result[0], result[1], result[2], result[3]));
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
        //*******   Mise a jour des infos d'un stock        *******
        //*********************************************************
        /// <summary>
        /// Mise a jour des infos d'un stock
        /// </summary>
        /// <param name="stk">Stock</param>
        /// <returns>Requête SQL</returns>
        public static bool MAJ_Stock(Stock stk)
        {
            //Requête Sql
            String strSql = "Update STOCK set Nom_stock ='" +
                stk.NomStock + "' , Adresse_stock= '" + stk.AdressStock + "' , Infos_stock= '" + stk.InfoStock +
                "' where ID_stock='" + stk.IDStock + "'";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        ////*********************************************************
        ////******   Ajout d'un nouveau stock dans la liste    ******
        ////*********************************************************
        /// <summary>
        /// Ajout d'un nouveau stock dans la liste
        /// </summary>
        /// <param name="stk">Stock</param>
        /// <returns>Requête SQL</returns>
        public static bool AJOUT_Stock(Stock stk)
        {
            // Requête sql
            String strSql = "Insert into STOCK values('"
              + stk.IDStock + "' , '" +
                stk.NomStock + "' , '" +
                stk.AdressStock + "' , '" +
                stk.InfoStock + "')";

            return DAO.Execute_Ins_Upd_Delete(strSql);
        }

        //*********************************************************
        //******   Suppression d'un stock dans la liste     *******
        //*********************************************************
        /// <summary>
        /// Suppression du stock dans la liste
        /// </summary>
        /// <param name="stk">Stock</param>
        /// <returns>Requête SQL</returns>
        public static bool SUPPR_Stock(Stock stk)
        {
            // Requête Sql
            String strSql = "Delete from STOCK where ID_stock='" + stk.IDStock.ToString() + "'";
            return DAO.Execute_Ins_Upd_Delete(strSql);
        }
    }
}
