using Alex.Bdd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDetente
{
    partial class Genre
    {
        private static String _connectionSring = Properties.Settings.Default.ConnectionString;























        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere DataTable de tous les genres
        /// </summary>
        /// <returns></returns>
        private static DataTable GetDTGenres()
        {
            String sqlQuery = "SELECT " +
                                            "* " +
                                "FROM " +
                                            "genre";
            return SQLClient.GetDataTable(_connectionSring, sqlQuery);
        }






















        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere DataRow avec un ID Genre
        /// </summary>
        /// <param name="idGenre">ID du genre</param>
        /// <returns></returns>
        private static DataRow GetDRGenre(Int32 idGenre)
        {
            String sqlQuery = "SELECT " + 
                                            "* " + 
                                "FROM " + 
                                            "genre " + 
                                "WHERE " + 
                                            "id_genre = " + idGenre;
            return SQLClient.GetUniqueDataRow(_connectionSring, sqlQuery);
        }
    }
}
