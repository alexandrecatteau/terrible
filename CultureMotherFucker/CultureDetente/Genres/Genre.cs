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
        private Int32 _idGenre;
        private String _nomGenre;

        public int IdGenre
        {
            get
            {
                return _idGenre;
            }

            set
            {
                _idGenre = value;
            }
        }
        public string NomGenre
        {
            get
            {
                return _nomGenre;
            }

            set
            {
                _nomGenre = value;
            }
        }




















        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une liste des Genres (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Genre> GetGenres()
        {
            DataTable dtGenres = GetDTGenres();
            List<Genre> genres = new List<Genre>();
            foreach (DataRow drGenre in dtGenres.Rows)
            {
                Genre genre = new Genre();
                genre._idGenre = (Int32)drGenre[(Int32)EnumGenre.IdGenre];
                genre._nomGenre = drGenre[(Int32)EnumGenre.NomGenre].ToString();

                genres.Add(genre);
            }

            return genres;
        }



















        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        public static Genre GetGenre(Int32 idGenre)
        {
            DataRow drGenre = GetDRGenre(idGenre);
            Genre genre = new Genre();

            genre._idGenre = (Int32)drGenre[(Int32)EnumGenre.IdGenre];
            genre._nomGenre = drGenre[(Int32)EnumGenre.NomGenre].ToString();

            return genre;
        }
    }
}
