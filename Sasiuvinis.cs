namespace OP1_Laboratorinis
{
    /// <summary>
    /// Klasė skirta sąsiuvinio duomenims aprašyti 
    /// </summary>
    class Sasiuvinys
    {
        private int puslapiuSkaicius; // sąsiuvinio puslapių skaičius
        private double puslapioStoris; // sąsiuvinio puslapio storis milimetrais
        private double sasiuvinioStoris; // sąsiuvinio storis milimetrais
        private double sasiuvinioAukstis; // sąsiuvinio aukštis milimetrais

        /// <summary>
        /// Konstruktorius su parametrais
        /// </summary>
        /// <param name="puslapiuSkaicius">sąsiuvinio puslapių skaičius</param>
        /// <param name="puslapioStoris">sąsiuvinio puslapio storis</param>
        public Sasiuvinys(int puslapiuSkaicius, double puslapioStoris)
        {
            this.puslapiuSkaicius = puslapiuSkaicius;
            this.puslapioStoris = puslapioStoris;
            this.sasiuvinioStoris = puslapiuSkaicius * puslapioStoris;
        }

        /// <summary>
        /// Grąžina sąsiuvinio puslapių skaičių
        /// </summary>
        /// <returns>puslapių skaičių</returns>
        public int ImtiPuslapiuSkaiciu()
        {
            return this.puslapiuSkaicius;
        }

        /// <summary>
        /// Grąžina sąsiuvinio puslapio storį
        /// </summary>
        /// <returns>puslapio storį</returns>
        public double ImtiPuslapioStori()
        {
            return this.puslapioStoris;
        }

        /// <summary>
        ///  Grąžina sąsiuvinio storį
        /// </summary>
        /// <returns>sąsiuvinio storį</returns>
        public double ImtiSasiuvinioStori()
        {
            return this.sasiuvinioStoris;
        }

        /// <summary>
        /// Grąžina sąsiuvinio aukštį
        /// </summary>
        /// <returns>sąsiuvinio aukštį</returns>
        public double ImtiSasiuvinioAuksti()
        {
            return this.sasiuvinioAukstis;
        }

        /// <summary>
        /// Priskiria sąsiuvinio aukštį
        /// </summary>
        /// <param name="aukstis">sąsiuvinio aukštis milimetrais</param>
        public void DetiSasiuvinioAuksti(double aukstis)
        {
            this.sasiuvinioAukstis = aukstis;
        }

        public string DuomenysSpausdinimui(string numeracija)
        {
            return $"{numeracija} sąsiuvinis: {puslapioStoris}mm puslapio storio, {sasiuvinioAukstis}mm aukščio ir turi {puslapiuSkaicius} psl. ";
        }
    }
}
