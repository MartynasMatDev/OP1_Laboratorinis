namespace OP1_Laboratorinis
{
    /// <summary>
    /// Klasė skirta lentynos duomenims aprašyti 
    /// </summary>
    class Lentyna
    {
        private double aukstis; // lentynos aukštis(milimetrais)
        private double ilgis;   // lentynos ilgis(milimetrais)

        /// <summary>
        /// Konstruktorius su parametrais
        /// </summary>
        /// <param name="aukstis">lentynos aukštis(milimetrais)</param>
        /// <param name="ilgis">lentynos ilgis(milimetrais)</param>
        public Lentyna(double aukstis, double ilgis)
        {
            this.aukstis = aukstis;
            this.ilgis = ilgis;
        }

        /// <summary>
        /// Priskiria lentynos aukštį
        /// </summary>
        /// <param name="aukstis">lentynos aukštis(milimetrais)</param>
        public void DetiAuksti(double aukstis)
        {
            this.aukstis = aukstis;
        }

        /// <summary>
        /// Grąžina lentynos aukštį
        /// </summary>
        /// <returns>lentynos aukštį</returns>
        public double ImtiAuksti()
        {
            return this.aukstis;
        }

        /// <summary>
        /// Priskiria lentynos ilgį
        /// </summary>
        /// <param name="ilgis">lentynos ilgis(milimetrais)</param>
        public void DetiIlgi(double ilgis)
        {
            this.ilgis = ilgis;
        }

        /// <summary>
        /// Grąžina lentynos ilgį
        /// </summary>
        /// <returns>lentynos ilgį</returns>
        public double ImtiIlgi()
        {
            return this.ilgis;
        }

        /// <summary>
        /// Metodas, skirtas patikrinti ar sąsiuviniai telpa, padėti horizontaliai
        /// </summary>
        /// <param name="sasiuvinys1">Pirmojo sąsiuvinio objektas</param>
        /// <param name="sasiuvinys2">Antrojo sąsiuvinio objektas</param>
        /// <param name="sasiuvinys3">Trečiojo sąsiuvinio objektas</param>
        /// <returns>ar tilps</returns>
        public bool ArSasviuniaiTelpaHorizontaliai(Sasiuvinys sasiuvinys1, Sasiuvinys sasiuvinys2, Sasiuvinys sasiuvinys3)
        {
            if (sasiuvinys1.ImtiSasiuvinioAuksti() > this.aukstis && sasiuvinys2.ImtiSasiuvinioAuksti() > this.aukstis && sasiuvinys3.ImtiSasiuvinioAuksti() > this.aukstis)
            {
                return false;
            }

            double sasiuviniuUzimamasIlgis = sasiuvinys1.ImtiSasiuvinioStori() + sasiuvinys2.ImtiSasiuvinioStori() + sasiuvinys3.ImtiSasiuvinioStori();

            if (sasiuviniuUzimamasIlgis > this.ilgis)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Metodas, skirtas patikrinti ar sąsiuviniai telpa, padėti vertikaliai
        /// </summary>
        /// <param name="sasiuvinys1">Pirmojo sąsiuvinio objektas</param>
        /// <param name="sasiuvinys2">Antrojo sąsiuvinio objektas</param>
        /// <param name="sasiuvinys3">Trečiojo sąsiuvinio objektas</param>
        /// <returns>ar tilps</returns>
        public bool ArSasviuniaiTelpaVertikaliai(Sasiuvinys sasiuvinys1, Sasiuvinys sasiuvinys2, Sasiuvinys sasiuvinys3)
        {
            if (sasiuvinys1.ImtiSasiuvinioStori() > this.aukstis && sasiuvinys2.ImtiSasiuvinioStori() > this.aukstis && sasiuvinys3.ImtiSasiuvinioStori() > this.aukstis)
            {
                return false;
            }

            double sasiuviniuUzimamasIlgis = sasiuvinys1.ImtiSasiuvinioAuksti() + sasiuvinys2.ImtiSasiuvinioAuksti() + sasiuvinys3.ImtiSasiuvinioAuksti();

            if (sasiuviniuUzimamasIlgis > this.ilgis)
            {
                return false;
            }
            return true;
        }

        public string DuomenysSpausdinimui()
        {
            return $"Lentyna: {aukstis}mm aukščio, {ilgis}mm ilgio.";
        }
    }
}
