using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDetente
{
    partial class Document
    {
        private Int32 _idDocument;
        private String _cote;
        private String _typeDocument;
        private DateTime _dateAchat;
        private Boolean _disponible;
        private String _titre;
        private Auteur _auteur;
        private Genre _genre;
        private Int32 _nombrePages;
        private Decimal _caution;

        #region Get-Set

        public int IdDocument
        {
            get
            {
                return _idDocument;
            }

            set
            {
                _idDocument = value;
            }
        }

        public string Cote
        {
            get
            {
                return _cote;
            }

            set
            {
                _cote = value;
            }
        }

        public string TypeDocument
        {
            get
            {
                return _typeDocument;
            }

            set
            {
                _typeDocument = value;
            }
        }

        public DateTime DateAchat
        {
            get
            {
                return _dateAchat;
            }

            set
            {
                _dateAchat = value;
            }
        }

        public bool Disponible
        {
            get
            {
                return _disponible;
            }

            set
            {
                _disponible = value;
            }
        }

        public string Titre
        {
            get
            {
                return _titre;
            }

            set
            {
                _titre = value;
            }
        }

        public Auteur Auteur
        {
            get
            {
                return _auteur;
            }

            set
            {
                _auteur = value;
            }
        }

        public Genre Genre
        {
            get
            {
                return _genre;
            }

            set
            {
                _genre = value;
            }
        }

        public int NombrePages
        {
            get
            {
                return _nombrePages;
            }

            set
            {
                _nombrePages = value;
            }
        }

        public decimal Caution
        {
            get
            {
                return _caution;
            }

            set
            {
                _caution = value;
            }
        }
        #endregion








        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recuperation d'une liste de documents (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Document> GetDocuments()
        {
            DataTable dtDocuments = GetDTDocuments();
            return GetDocuments(dtDocuments);
        }



























        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recuperation d'une liste de documents a partir d'un idAuteur(OBJET)
        /// </summary>
        /// <param name="idAuteur">Id de l'auteur</param>
        /// <returns></returns>
        public static List<Document> GetDocuments_IdAuteur(Int32 idAuteur)
        {
            DataTable dtDocuments = GetDTDocuments_idAuteur(idAuteur);
            return GetDocuments(dtDocuments);
        }
































        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recuperation d'une liste de documents avec un idTitre(OBJET)
        /// </summary>
        /// <param name="idTitre">Id du titre</param>
        /// <returns></returns>
        public static List<Document> GetDocuments_IdTitre(Int32 idTitre)
        {
            DataTable dtDocuments = GetDTDocuments_idTitre(idTitre);
            return GetDocuments(dtDocuments);
        }


























        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recuperation d'une liste de documents (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Document> GetDocuments_IdAuteur_IdTitre(Int32 idAuteur, Int32 idTitre)
        {
            DataTable dtDocuments = GetDTDocuments_idAuteur_idTitre(idAuteur, idTitre);
            return GetDocuments(dtDocuments);
        }
































        //---------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une liste de documents
        /// </summary>
        /// <param name="dtDocuments">DataTable à traiter</param>
        /// <returns></returns>
        private static List<Document> GetDocuments(DataTable dtDocuments)
        {
            List<Document> documents = new List<Document>();

            foreach (DataRow drDocument in dtDocuments.Rows)
            {
                Document document = new Document();
                document._idDocument = (Int32)drDocument[(Int32)EnumDocument.IdDocument];
                document._cote = drDocument[(Int32)EnumDocument.Cote].ToString();
                document._typeDocument = drDocument[(Int32)EnumDocument.TypeDoc].ToString();
                document._dateAchat = (DateTime)drDocument[(Int32)EnumDocument.DateAchat];
                document._disponible = (Boolean)drDocument[(Int32)EnumDocument.Disponible];
                document._titre = drDocument[(Int32)EnumDocument.Titre].ToString();
                document._auteur = Auteur.GetAuteur(Int32.Parse(drDocument[(Int32)EnumDocument.IdAuteur].ToString()));
                document._genre = Genre.GetGenre(Int32.Parse(drDocument[(Int32)EnumDocument.IdGenre].ToString()));
                document._nombrePages = (String.IsNullOrEmpty(drDocument[(Int32)EnumDocument.NombrePages].ToString()) ? 0 : (Int32)drDocument[(Int32)EnumDocument.NombrePages]);
                document._caution = (String.IsNullOrEmpty(drDocument[(Int32)EnumDocument.Caution].ToString()) ? 0 : Decimal.Parse(drDocument[(Int32)EnumDocument.Caution].ToString()));

                documents.Add(document);
            }

            return documents;
        }

    }
}
