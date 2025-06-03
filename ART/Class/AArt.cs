using System;

namespace ART.Class
{
    internal class AArt
    {
        // Private fields
        private int clinicID;
        private string art;
        private string daart;

        // Public properties
        public int ClinicID
        {
            get { return clinicID; }
            set { clinicID = value; }
        }

        public string Art
        {
            get { return art; }
            set { art = value; }
        }

        public string Daart
        {
            get { return daart; }
            set { daart = value; }
        }

        // Constructors
        public AArt()
        {
            clinicID = 0;
            art = string.Empty;
            daart = string.Empty;
        }

        public AArt(int clinicID, string art, string daart)
        {
            this.clinicID = clinicID;
            this.art = art;
            this.daart = daart;
        }

        // Override ToString for display
        public override string ToString()
        {
            return $"ClinicID: {clinicID}, ART: {art}, DAART: {daart}";
        }
    }
}
