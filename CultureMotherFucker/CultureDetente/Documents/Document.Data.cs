using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alex.Bdd;

namespace CultureDetente
{
    partial class Document
    {
        private static String _connectionString = Properties.Settings.Default.ConnectionString;












        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere DataTable avec tous les documents
        /// </summary>
        /// <returns></returns>
        private static DataTable GetDTDocuments()
        {
            String sqlQuery = "SELECT " +
                                        "* " +
                                "FROM " +
                                        "document";
            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }
























        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere un DataTable des documents a partir d'un idAuteur et d'un idTitre
        /// </summary>
        /// <param name="idAuteur">Id de l'auteur</param>
        /// <param name="idTitre">Id du titre</param>
        /// <returns></returns>
        private static DataTable GetDTDocuments_idAuteur_idTitre(Int32 idAuteur, Int32 idTitre)
        {
            String sqlQuery = "SELECT " +
                                        "* " +
                                "FROM " +
                                        "document " +
                                "WHERE " +
                                        "id_auteur = " + idAuteur + " AND id_genre = " + idTitre;
            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }






















        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere un DataTable des document a partir d'un idAuteur
        /// </summary>
        /// <param name="idAuteur">Id de l'auteur</param>
        /// <returns></returns>
        private static DataTable GetDTDocuments_idAuteur(Int32 idAuteur)
        {
            String sqlQuery = "SELECT " +
                                            "* " +
                                "FROM " +
                                            "document " +
                                "WHERE " +
                                            "id_auteur = " + idAuteur;
            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }





































        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere un DataTable des documents avec un idTitre
        /// </summary>
        /// <param name="idTitre">Id du titre</param>
        /// <returns></returns>
        private static DataTable GetDTDocuments_idTitre(Int32 idTitre)
        {
            String sqlQuery = "SELECT " + 
                                            "* " + 
                                "FROM " + 
                                            "document " + 
                                "WHERE " + 
                                            "id_document = " + idTitre;
            return SQLClient.GetDataTable(_connectionString, sqlQuery);
        }
    }
}
