using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.Common;
using MySql.Data.MySqlClient;


namespace couche_DAO
{
    public static class DAO
    {
        //*********          Les Objets ADO.net   *************
        private static DbConnection MySqlConnection;
        private static DbCommand MysqlCmde;
        private static DbDataReader MysqlRdr;

        //*********************************************************
        //****   Pour l'accès a la base de donnees        *********
        //*********************************************************
        private static DbConnection Ouvrir_connexion_base()
        {

            if (MySqlConnection == null)
            {
                //************   Via APP.CONFIG    ****************
                //String connectionstring =
                //ConfigurationManager.ConnectionStrings["MonServeur"].ConnectionString;
                ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["MySql_Sacados"];

                DbProviderFactory fabrique = DbProviderFactories.GetFactory(cs.ProviderName);
                // à partir d'ici, le code est indépendant du SGBD
                MySqlConnection = fabrique.CreateConnection();
                MySqlConnection.ConnectionString = cs.ConnectionString;
                try
                {
                    MySqlConnection.Open();
                    MysqlCmde = MySqlConnection.CreateCommand();

                }
                catch (Exception)
                {
                    //Gestion de l'erreur
                }
            }

            return MySqlConnection;



        }


        public static bool Execute_Ins_Upd_Delete(string requete)
        {
            try
            {
                DbConnection cnn = Ouvrir_connexion_base();
                MysqlCmde.Connection = cnn;
                MysqlCmde.CommandType = CommandType.Text;
                MysqlCmde.CommandText = requete;

                // Execution de la commande
                int n = MysqlCmde.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {

                //throw e;   // L'erreur est envoyée au programme appelant
                return false;
            }
        }

        //public static DataTable Execute_Query(string requete)
        public static DbDataReader Execute_Query(string requete)
        {
            //****  Version AVEC acces base

            try
            {
                DbConnection cnn = Ouvrir_connexion_base();
                MysqlCmde.Connection = cnn;

                String strSql = requete;    // C'est la requete a executer
                MysqlCmde.CommandType = CommandType.Text;
                MysqlCmde.CommandText = strSql;
                // Execution de la commande
                //if (sqlRdr != null)
                //{
                //    sqlRdr = null;
                //}
                MysqlRdr = MysqlCmde.ExecuteReader();   // On execute la requete


            }
            catch (Exception ex)
            {
                // Pas de gestion d'une erreur d'accès à la base
                // ==> dans ce cas la LISTE est vide
                string s = ex.Message;
            }

            //DataTable dt = new DataTable();
            //dt.Load(sqlRdr);
            return MysqlRdr;

        }
    }
}

