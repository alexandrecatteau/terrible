using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureDetente
{
    partial class Auteur
    {
        private String _nomAuteur;
        private Int32 _idAuteur;

        public string NomAuteur
        {
            get
            {
                return _nomAuteur;
            }

            set
            {
                _nomAuteur = value;
            }
        }
        public int IdAuteur
        {
            get
            {
                return _idAuteur;
            }

            set
            {
                _idAuteur = value;
            }
        }























        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere tous les auteurs (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Auteur> GetAuteurs()
        {
            DataTable dtAuteurs = GetDTAuteurs();
            List<Auteur> auteurs = new List<Auteur>();
            foreach (DataRow drAuteur in dtAuteurs.Rows)
            {
                Auteur auteur = new Auteur();
                auteur._idAuteur = (Int32)drAuteur[(Int32)EnumAuteur.IdAuteur];
                auteur._nomAuteur = drAuteur[(Int32)EnumAuteur.NomAuteur].ToString();

                auteurs.Add(auteur);
            }

            return auteurs;
        }
























        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere un Auteur (OBJET)
        /// </summary>
        /// <param name="idAuteur">ID de l'auteur</param>
        /// <returns></returns>
        public static Auteur GetAuteur(Int32 idAuteur)
        {
            DataRow drAuteur = GetDRAuteur(idAuteur);
            Auteur auteur = new Auteur();

            auteur._idAuteur = (Int32)drAuteur[(Int32)EnumAuteur.IdAuteur];
            auteur._nomAuteur = drAuteur[(Int32)EnumAuteur.NomAuteur].ToString();

            return auteur;
        }
    }
}
