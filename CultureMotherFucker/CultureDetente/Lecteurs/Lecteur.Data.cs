using Alex.Bdd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDetente
{
    partial class Lecteur
    {
        private static String _connectionString = Properties.Settings.Default.ConnectionString;



























        //--------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere DataTable de tous les lecteurs
        /// </summary>
        /// <returns></returns>
        private static DataTable GetDTLecteurs()
        {

            String sqlQuery = "SELECT " +
                                            "* " +
                                "FROM " +
                                            "lecteur";

            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }
















        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere un lecteur (OBJET)
        /// </summary>
        /// <param name="idLecteur">ID du lecteur</param>
        /// <returns></returns>
        private static DataRow GetDRLecteur(Int32 idLecteur)
        {
            String sqlQuery = "SELECT * FROM lecteur WHERE idLecteur = " + idLecteur;

            return SQLClient.GetUniqueDataRow(_connectionString, sqlQuery);
        }
    }
}
