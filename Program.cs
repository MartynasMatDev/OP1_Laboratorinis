//----------------------------------------------------------------------------------------------------------
//  Užduotis:
//  1. Sukurkite klasę Sąsiuvinys, kuri turėtų kintamuosius sąsiuvinio puslapių skaičiui ir jo puslapio
//  storiui saugoti. Parduotuvėje pasirinkti trys sąsiuviniai. Rasti sąsiuvinį, kurios mažiausias puslapio
//  storis ir kiek puslapių turi ploniausias sąsiuvinys.
//  2. Papildykite klasę Sąsiuvinys kintamuoju, skirtu sąsiuvinio aukščiui saugoti. Sukurkite klasę
//  Lentyna, kuri turėtų kintamuosius lentynos aukščiui ir ilgiui saugoti. Ar tie trys sąsiuviniai tilps
//  lentynoje?
//  3. Papildykite klasę Lentyna metodu Dėti(), kurie leistų keisti lentynos aukštį ir ilgį. Ar tilps visi
//  sąsiuviniai lentynoje, jeigu lentynos aukštis bus padidintas du kartus? Jeigu lentynos ilgis bus
//  sumažintas du kartus? 
//----------------------------------------------------------------------------------------------------------


using System;

namespace OP1_Laboratorinis
{
    /// <summary>
    /// Klasė užduotyje nurodytiems skaičiavimams atlikti
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Užduoties variantas: U2-31\n");

            // Pirmo sąsiuvinio duomenų įvedimas:
            Console.Write("Įveskite pirmo sąsiuvinio puslapių skaičių: ");
            int pirmoSasiuvinioPslSk = int.Parse(Console.ReadLine()); // Sąsiuvinio puslapių skaičius
            Console.Write("Įveskite pirmo sąsiuvinio puslapio storį milimetrais: ");
            double pirmoSasiuvinioPslStoris = double.Parse(Console.ReadLine()); // Sąsiuvinio puslapio storis
            Sasiuvinys sasiuvinys1 = new Sasiuvinys(pirmoSasiuvinioPslSk, pirmoSasiuvinioPslStoris); // Sąsiuvinio objektas
            Console.Write("Įveskite pirmo sąsiuvinio aukštį: ");
            int pirmoSasiuvinioAukstis = int.Parse(Console.ReadLine()); // Sąsiuvinio aukštis  
            sasiuvinys1.DetiSasiuvinioAuksti(pirmoSasiuvinioAukstis);
            Console.WriteLine("");

            // Antro sąsiuvinio duomenų įvedimas:
            Console.Write("Įveskite antro sąsiuvinio puslapių skaičių: ");
            int antroSasiuvinioPslSk = int.Parse(Console.ReadLine()); // Sąsiuvinio puslapių skaičius
            Console.Write("Įveskite antro sąsiuvinio puslapio storį milimetrais: ");
            double antroSasiuvinioPslStoris = double.Parse(Console.ReadLine()); // Sąsiuvinio puslapio storis
            Sasiuvinys sasiuvinys2 = new Sasiuvinys(antroSasiuvinioPslSk, antroSasiuvinioPslStoris); // Sąsiuvinio objektas
            Console.Write("Įveskite antro sąsiuvinio aukštį: ");
            int antroSasiuvinioAukstis = int.Parse(Console.ReadLine()); // Sąsiuvinio aukštis  
            Console.WriteLine("");
            sasiuvinys2.DetiSasiuvinioAuksti(antroSasiuvinioAukstis);

            // Trečio sąsiuvinio duomenų įvedimas:
            Console.Write("Įveskite trečio sąsiuvinio puslapių skaičių: ");
            int trecioSasiuvinioPslSk = int.Parse(Console.ReadLine()); // Sąsiuvinio puslapių skaičius
            Console.Write("Įveskite trečio sąsiuvinio puslapio storį milimetrais: ");
            double trecioSasiuvinioPslStoris = double.Parse(Console.ReadLine()); // Sąsiuvinio puslapio storis
            Sasiuvinys sasiuvinys3 = new Sasiuvinys(trecioSasiuvinioPslSk, trecioSasiuvinioPslStoris);
            Console.Write("Įveskite trečio sąsiuvinio aukštį milimetrais: ");
            int trecioSasiuvinioAukstis = int.Parse(Console.ReadLine()); // Sąsiuvinio objektas
            Console.WriteLine("");
            sasiuvinys3.DetiSasiuvinioAuksti(trecioSasiuvinioAukstis);  // Sąsiuvinio aukštis  

            // Lentynos duomenų įvedimas:
            Console.Write("Įveskite lentynos aukštį milimetrais: ");
            int lentynosAukstis = int.Parse(Console.ReadLine()); // Lentynos aukštis
            Console.Write("Įveskite lentynos ilgį milimetrais: ");
            int lentynosIlgis = int.Parse(Console.ReadLine()); // Lentynos ilgis
            Console.WriteLine("");
            Lentyna lentyna = new Lentyna(lentynosAukstis, lentynosIlgis);  // Lentynos objektas

            // Atvaizduojame įvestus duomenis konsolės lange:
            SpausdintiIvestiesDuomenis(sasiuvinys1, sasiuvinys2, sasiuvinys3 , lentyna);

            // Atrenkame sąsiuvinį su ploniausiu puslapiu:
            Sasiuvinys sas_su_ploniausiu_psl = AtrinktiSasiuviniSuPloniausiuPuslapiu(sasiuvinys1, sasiuvinys2, sasiuvinys3);
            
            // Atvaizduojame sąsiuvinio su ploniausiu puslapiu duomenis konsolės lange:
            SpausdintiPloniausioPuslapioSasiuvini(sas_su_ploniausiu_psl);

            bool telpaGulsciai;  // Ar sąsiuviniai, telpa padėti horizontaliai
            bool telpaStatmenai; // Ar sąsiuviniai, telpa padėti vertikaliai

            telpaGulsciai = lentyna.ArSasviuniaiTelpaHorizontaliai(sasiuvinys1, sasiuvinys2, sasiuvinys3);
            telpaStatmenai = lentyna.ArSasviuniaiTelpaVertikaliai(sasiuvinys1, sasiuvinys2, sasiuvinys3);
            
            // Atvaizduojame ar tilps sąsiuviniai
            SpausdintiArTilpsSasiuviniai(telpaGulsciai, telpaStatmenai);

            // Padidiname lentynos aukštį dvigubai:
            lentyna.DetiAuksti(lentyna.ImtiAuksti() * 2);

            telpaGulsciai = lentyna.ArSasviuniaiTelpaHorizontaliai(sasiuvinys1, sasiuvinys2, sasiuvinys3);
            telpaStatmenai = lentyna.ArSasviuniaiTelpaVertikaliai(sasiuvinys1, sasiuvinys2, sasiuvinys3);

            // Atvaizduojame ar tilps sąsiuviniai
            SpausdintiArTilpsSasiuviniai(telpaGulsciai, telpaStatmenai);

            // Sumažiname lentynos ilgį dvigubai:
            lentyna.DetiIlgi(lentyna.ImtiIlgi() / 2);
            telpaGulsciai = lentyna.ArSasviuniaiTelpaHorizontaliai(sasiuvinys1, sasiuvinys2, sasiuvinys3);
            telpaStatmenai = lentyna.ArSasviuniaiTelpaVertikaliai(sasiuvinys1, sasiuvinys2, sasiuvinys3);

            // Atvaizduojame ar tilps sąsiuviniai
            SpausdintiArTilpsSasiuviniai(telpaGulsciai, telpaStatmenai);


        }

        /// <summary>
        /// Metodas, skirtas atspausdinti Įvesties duomenis konsolėje.
        /// </summary>
        /// <param name="sasiuvinys1">Pirmojo sąsiuvinio objektas</param>
        /// <param name="sasiuvinys2">Antrojo sąsiuvinio objektas</param>
        /// <param name="sasiuvinys3">Trečiojo sąsiuvinio objektas</param>
        /// <param name="lentyna">Lentynos objektas</param>
        static void SpausdintiIvestiesDuomenis(Sasiuvinys sasiuvinys1, Sasiuvinys sasiuvinys2, Sasiuvinys sasiuvinys3, Lentyna lentyna)
        {
            Console.WriteLine(sasiuvinys1.DuomenysSpausdinimui("Pirmas"));
            Console.WriteLine(sasiuvinys2.DuomenysSpausdinimui("Antras"));
            Console.WriteLine(sasiuvinys3.DuomenysSpausdinimui("Trecias"));
            Console.WriteLine(lentyna.DuomenysSpausdinimui());
        }

        /// <summary>
        /// Metodas, skirtas rasti sąsiuvinį, kuris turi ploniausią puslapį.
        /// </summary>
        /// <param name="sasiuvinys1"></param>
        /// <param name="sasiuvinys2"></param>
        /// <param name="sasiuvinys3"></param>
        /// <returns></returns>
        static Sasiuvinys AtrinktiSasiuviniSuPloniausiuPuslapiu(Sasiuvinys sasiuvinys1, Sasiuvinys sasiuvinys2, Sasiuvinys sasiuvinys3)
        {
            Sasiuvinys ploniausias_sasiuvinys = new Sasiuvinys(0, 0);
            if (sasiuvinys1.ImtiPuslapioStori() < sasiuvinys2.ImtiPuslapioStori() && sasiuvinys1.ImtiPuslapioStori() < sasiuvinys3.ImtiPuslapioStori())
            {
                ploniausias_sasiuvinys = sasiuvinys1;
            }

            if (sasiuvinys2.ImtiPuslapioStori() < sasiuvinys1.ImtiPuslapioStori() && sasiuvinys2.ImtiPuslapioStori() < sasiuvinys3.ImtiPuslapioStori())
            {
                ploniausias_sasiuvinys = sasiuvinys2;
            }

            if (sasiuvinys3.ImtiPuslapioStori() < sasiuvinys1.ImtiPuslapioStori() && sasiuvinys3.ImtiPuslapioStori() < sasiuvinys2.ImtiPuslapioStori())
            {
                ploniausias_sasiuvinys = sasiuvinys3;
            }

            return ploniausias_sasiuvinys;
        }

        /// <summary>
        /// Metodas, skirtas atspausdinti sąsiuvini su ploniausiu puslapiu.
        /// </summary>
        /// <param name="sasiuvinys">Sąsiuvinio objektas</param>
        static void SpausdintiPloniausioPuslapioSasiuvini(Sasiuvinys sasiuvinys)
        {
            Console.WriteLine($"Sąsiuvinis su ploniausiu puslapiu yra: {sasiuvinys.ImtiPuslapioStori():0.00}mm, turintis {sasiuvinys.ImtiPuslapiuSkaiciu()} vnt. puslapių.");
        }

        /// <summary>
        /// Metodas, skirtas atspausdinti ar tilps sąsiuviniai padėti horizontaliai arba/ir vertikaliai.
        /// </summary>
        /// <param name="telpaHorizontaliai"></param>
        /// <param name="telpaVertikaliai"></param>
        public static void SpausdintiArTilpsSasiuviniai(bool telpaHorizontaliai, bool telpaVertikaliai)
        {
            if (telpaHorizontaliai && telpaVertikaliai)
            {
                Console.WriteLine("Sąsiuviniai telpa lentynoje tiek padėti horizontaliai, tiek padėti vertikaliai.");
            }
            else if (telpaHorizontaliai && !telpaVertikaliai)
            {
                Console.WriteLine("Sąsiuviniai telpa lentynoje padėti horizontaliai, bet netelpa padėti vertikaliai.");
            }
            else if (!telpaHorizontaliai && telpaVertikaliai)
            {
                Console.WriteLine("Sąsiuviniai netelpa lentynoje padėti horizontaliai, bet telpa padėti vertikaliai.");
            }
            else
            {
                Console.WriteLine("Sąsiuviniai netelpa lentynoje tiek padėti horizontaliai, tiek padėti vertikaliai.");
            }
        }
    }
}
