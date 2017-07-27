using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alex.Bdd;
using System.Data;

namespace CultureDetente
{
    partial class Auteur
    {
        private static String _connectionString = Properties.Settings.Default.ConnectionString;















        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere DataTable de tous les auteurs
        /// </summary>
        /// <returns></returns>
        private static DataTable GetDTAuteurs()
        {
            String sqlQuery = "SELECT " + 
                                            "* " + 
                                "FROM " + 
                                            "auteur";
            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }


















        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere DataRow d'un lecteur
        /// </summary>
        /// <returns></returns>
        private static DataRow GetDRAuteur(Int32 idAuteur)
        {
            String sqlQuery = "SELECT " +
                                            "* " +
                                "FROM " +
                                            "auteur " +
                                "WHERE " +
                                            "id_auteur = " + idAuteur;
            return SQLClient.GetUniqueDataRow(_connectionString, sqlQuery);
        }
    }
}
