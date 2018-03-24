using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GHAR_2_Class_Library
{
    public class GharDataManager
    {
        #region Fields

        List<Reservation> masterReservations;

        #endregion

        #region Constructors

        public GharDataManager()
        {
            masterReservations = new List<Reservation>();
        }

        #endregion

        #region Properties



        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Clears all stored reservations.
        /// </summary>
        public void ClearMasterReservations()
        {
            masterReservations = new List<Reservation>();
        }

        #endregion

        #region Protected Methods



        #endregion

        #region Private Methods



        #endregion

        #endregion
    }
}