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
        private Int32 _id;
        private String _nom;
        private String _prenom;
        private String _adresse;
        private String _mail;
        private DateTime _dateInscription;
        private Decimal _cotisation;
        private Int32 _nombrePrets;

        #region GET-SET
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

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return _adresse;
            }

            set
            {
                _adresse = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }

        public DateTime DateInscription
        {
            get
            {
                return _dateInscription;
            }

            set
            {
                _dateInscription = value;
            }
        }

        public decimal Cotisation
        {
            get
            {
                return _cotisation;
            }

            set
            {
                _cotisation = value;
            }
        }

        public int NombrePrets
        {
            get
            {
                return _nombrePrets;
            }

            set
            {
                _nombrePrets = value;
            }
        }
        #endregion










        //--------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une liste de lecteur (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Lecteur> GetLecteurs()
        {
            DataTable dtLecteurs = GetDTLecteurs();
            List<Lecteur> lecteurs = new List<Lecteur>();

            foreach (DataRow drLecteur in dtLecteurs.Rows)
            {
                Lecteur lecteur = new Lecteur();
                lecteur._id = (Int32)drLecteur[(Int32)EnumLecteur.Id];
                lecteur._nom = drLecteur[(Int32)EnumLecteur.Nom].ToString();
                lecteur._prenom = drLecteur[(Int32)EnumLecteur.Prenom].ToString();
                lecteur._adresse = drLecteur[(Int32)EnumLecteur.Adresse].ToString();
                lecteur._mail = drLecteur[(Int32)EnumLecteur.Mail].ToString();
                lecteur._dateInscription = (DateTime)drLecteur[(Int32)EnumLecteur.DateInscription];
                lecteur._cotisation = (String.IsNullOrEmpty(drLecteur[(Int32)EnumLecteur.Cotisation].ToString()) ? 0 : Decimal.Parse(drLecteur[(Int32)EnumLecteur.Cotisation].ToString()));
                lecteur._nombrePrets = (String.IsNullOrEmpty(drLecteur[(Int32)EnumLecteur.NombrePrets].ToString()) ? 0 : Int32.Parse(drLecteur[(Int32)EnumLecteur.NombrePrets].ToString()));

                lecteurs.Add(lecteur);
            }

            return lecteurs;
        }


















        //---------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere un Lecteur (OBJET)
        /// </summary>
        /// <param name="idLecteur">ID du lecteur</param>
        /// <returns></returns>
        public static Lecteur GetLecteur(Int32 idLecteur)
        {
            DataRow drLecteur = GetDRLecteur(idLecteur);
            Lecteur lecteur = new Lecteur();
            lecteur._id = (Int32)drLecteur[(Int32)EnumLecteur.Id];
            lecteur._nom = drLecteur[(Int32)EnumLecteur.Nom].ToString();
            lecteur._prenom = drLecteur[(Int32)EnumLecteur.Prenom].ToString();
            lecteur._adresse = drLecteur[(Int32)EnumLecteur.Adresse].ToString();
            lecteur._mail = drLecteur[(Int32)EnumLecteur.Mail].ToString();
            lecteur._dateInscription = (DateTime)drLecteur[(Int32)EnumLecteur.DateInscription];
            lecteur._cotisation = (String.IsNullOrEmpty(drLecteur[(Int32)EnumLecteur.Cotisation].ToString()) ? 0 : Decimal.Parse(drLecteur[(Int32)EnumLecteur.Cotisation].ToString()));
            lecteur._nombrePrets = (String.IsNullOrEmpty(drLecteur[(Int32)EnumLecteur.NombrePrets].ToString()) ? 0 : Int32.Parse(drLecteur[(Int32)EnumLecteur.NombrePrets].ToString()));

            return lecteur;
        }
    }
}
