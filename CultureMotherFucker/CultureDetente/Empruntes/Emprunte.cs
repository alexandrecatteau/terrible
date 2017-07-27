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
        private Int32 _id;
        private DateTime _dateEmprunt;
        private Lecteur _lecteur;
        private String _cote;
        private Relance _relance;

        #region Get-Set
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public DateTime DateEmprunt
        {
            get
            {
                return _dateEmprunt;
            }

            set
            {
                _dateEmprunt = value;
            }
        }

        internal Lecteur Lecteur
        {
            get
            {
                return _lecteur;
            }

            set
            {
                _lecteur = value;
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

        internal Relance Relance
        {
            get
            {
                return _relance;
            }

            set
            {
                _relance = value;
            }
        }
        #endregion


























        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une liste des Empruntés (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Emprunte> GetEmpruntes()
        {
            DataTable dtEmpruntes = GetDTEmpruntes();
            List<Emprunte> empruntes = new List<Emprunte>();
            foreach (DataRow drEmprunte in dtEmpruntes.Rows)
            {
                Emprunte emprunte = new Emprunte();
                emprunte._id = (Int32)drEmprunte[(Int32)EnumEmprunte.IdEmprunt];
                emprunte._dateEmprunt = (DateTime)drEmprunte[(Int32)EnumEmprunte.DateEmprunt];
                emprunte._lecteur = Lecteur.GetLecteur((Int32)drEmprunte[(Int32)EnumEmprunte.IdLecteur]);
                emprunte._cote = drEmprunte[(Int32)EnumEmprunte.Cote].ToString();
                emprunte._relance = Relance.GetRelance((Int32)drEmprunte[(Int32)EnumEmprunte.IdRelance]);
                empruntes.Add(emprunte);
            }

            return empruntes;
        }
    }
}
