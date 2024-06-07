using System;

namespace Ispit.Model
{
    public class Ucenik
    {
        private string _ime;
        private string _prezime;
        int _starost;

        public string Ime { get; set; }

        public string Prezime { get; set; }
       
        public DateTime DatumRodjenja { get; set; }

        public double Prosjek { get; set; }

        public string VratiPunoIme()
        {
            return $"{_ime} {_prezime}";
        }

        public string ProsjekRijecima(double prosjek)
        {
            if (prosjek >= 1.0 && prosjek <= 1.49)
                return "nedovoljan";
            else if (prosjek >= 1.5 && prosjek <= 2.49)
                return "dovoljan";
            else if (prosjek >= 2.5 && prosjek <= 3.49)
                return "dobar";
            else if (prosjek >= 3.5 && prosjek <= 4.49)
                return "vrlo dobar";
            else if (prosjek >= 4.5 && prosjek <= 5.0)
                return "odličan";
            else
                return "Niste upisali ispravan prosjek, prosjek treba biti broj između 1 i 5";
        }

        public int VratiStarost()
        {
            DateTime trenutniDatum = DateTime.Now;
            _starost = trenutniDatum.Year - DatumRodjenja.Year;
            return _starost;
        }
    }
}
