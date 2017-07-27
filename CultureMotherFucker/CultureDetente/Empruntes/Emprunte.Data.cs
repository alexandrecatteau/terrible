using Alex.Bdd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDetente
{
    partial class Emprunte
    {
        private static String _connectionString = Properties.Settings.Default.ConnectionString;


















        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une DataTable avec tous les emprunts
        /// </summary>
        /// <returns></returns>
        private static DataTable GetDTEmpruntes()
        {
            String sqlQuery = "SELECT " + 
                                            "* " + 
                                "FROM " + 
                                            "emprunte";

            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }
    }
}
