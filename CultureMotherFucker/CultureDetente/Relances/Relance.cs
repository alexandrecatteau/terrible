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
        private Int32 _idRelance;
        private DateTime _dateRelance;
        private String _libelleRelance;

        #region Get-Set
            public int IdRelance
            {
                get
                {
                    return _idRelance;
                }

                set
                {
                    _idRelance = value;
                }
            }

            public DateTime DateRelance
            {
                get
                {
                    return _dateRelance;
                }

                set
                {
                    _dateRelance = value;
                }
            }

            public string LibelleRelance
            {
                get
                {
                    return _libelleRelance;
                }

                set
                {
                    _libelleRelance = value;
                }
            }
        #endregion























        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Recupere une liste avec toutes les relances (OBJET)
        /// </summary>
        /// <returns></returns>
        public static List<Relance> GetRelances()
        {
            DataTable dtRelances = GetDTRelances();
            List<Relance> relances = new List<Relance>();
            foreach (DataRow drRelance in dtRelances.Rows)
            {
                Relance relance = new Relance();
                relance.IdRelance = (Int32)drRelance[(Int32)EnumRelance.Id];
                relance.DateRelance = (DateTime)drRelance[(Int32)EnumRelance.DateRelance];
                relance.LibelleRelance = drRelance[(Int32)EnumRelance.LibelleCourrier].ToString();

                relances.Add(relance);
            }

            return relances;
        }


























        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retourne une Relance (OBJET)
        /// </summary>
        /// <param name="idRelance">ID de la relance</param>
        /// <returns></returns>
        public static Relance GetRelance(Int32 idRelance)
        {
            DataRow drRelance = GetDRRelance(idRelance);
            Relance relance = new Relance();
            relance.IdRelance = (Int32)drRelance[(Int32)EnumRelance.Id];
            relance.DateRelance = (DateTime)drRelance[(Int32)EnumRelance.DateRelance];
            relance.LibelleRelance = drRelance[(Int32)EnumRelance.LibelleCourrier].ToString();

            return relance;
        }
    }
}
