using Alex.Bdd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDetente
{
    partial class Relance
    {
        private static String _connectionString = Properties.Settings.Default.ConnectionString;






















        //--------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une DataTable de toutes les relances
        /// </summary>
        /// <returns></returns>
        private static DataTable GetDTRelances()
        {
            String sqlQuery = "SELECT " +
                                            "* " +
                                "FROM " +
                                            "relance";
            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }




























        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recuperation d'une DataRow avec les données d'une relance 
        /// </summary>
        /// <param name="idRelance">ID de la relance</param>
        /// <returns></returns>
        private static DataRow GetDRRelance(Int32 idRelance)
        {
            String sqlQuery = "SELECT " + 
                                            "* " + 
                                "FROM " + 
                                            "relance " + 
                                "WHERE " + 
                                            "idRelance = " + idRelance;

            return SQLClient.GetUniqueDataRow(_connectionString, sqlQuery);
        }
    }
}