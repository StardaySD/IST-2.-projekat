using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)] //visestruki pristup
    public class WcfService : IAdmin, IUser
    {
        private static List<Korisnik> korisnici = ListaKorisnika();
        private static List<Grupa> grupe = ListaGrupa();
        private static List<GrupaKorisnici> grupaKor = ListaGrupaKorisnika();
        private static List<Poruke> listaPoruka = ListaPoruka();
        private static List<Poruke> listaProcitanih = ListaProcitanih();
        private static List<GrupaKorisnici> listaZahteva = ListaZahteva();
        
        //Svi korisnici unutar chat servisa (Admini i obiscni korisnici) su ovde definisani
        private static List<Korisnik> ListaKorisnika()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            korisnici.Add(new Korisnik("AdminM", "Mmitar", "Realizen", Tip.Admin));
            korisnici.Add(new Korisnik("AdminA", "Maleksandar", "Aca", Tip.Admin));
            korisnici.Add(new Korisnik("Marko", "borak", "Borak", Tip.Admin));
            korisnici.Add(new Korisnik("Petar", "milicevic", "Cope", Tip.User));
            korisnici.Add(new Korisnik("Zvezdan", "pmgb9788", "Kizve", Tip.User));
            korisnici.Add(new Korisnik("Peric", "pepe", "Petar", Tip.User));
            korisnici.Add(new Korisnik("IMG", "LMG88", "LMG", Tip.User));
            return korisnici;
        }
        //Sve grupe koje postoje unutar chat servisa su ovde definisane
        private static List<Grupa> ListaGrupa()
        {
            List<Grupa> grupe = new List<Grupa>();
            grupe.Add(new Grupa("GrupaNRT", 20));
            grupe.Add(new Grupa("GrupaRT", 30));
            grupe.Add(new Grupa("GrupaAVT", 20));
            grupe.Add(new Grupa("GrupaUSERS", 70));
            grupe.Add(new Grupa("GrupaADMIN", 10));
            return grupe;
        }
        private static List<GrupaKorisnici> ListaGrupaKorisnika()
        {
            List<GrupaKorisnici> grupaKor = new List<GrupaKorisnici>();
            return grupaKor;
        }
        private static List<GrupaKorisnici> ListaZahteva()
        {
            List<GrupaKorisnici> listaZahteva = new List<GrupaKorisnici>();
            return listaZahteva;
        }
        private static List<Poruke> ListaPoruka()
        {
            List<Poruke> listaPoruka = new List<Poruke>();
            return listaPoruka;
        }
        private static List<Poruke> ListaProcitanih()
        {
            List<Poruke> listaProcitanih = new List<Poruke>();
            return listaProcitanih;
        }
        public Korisnik Login(string ime, string lozinka)
        {
            try
            {
                Korisnik korisnik = korisnici.Where(x => x.Korisnicko_ime == ime && x.Lozinka == lozinka).First();
                return korisnik;
            }
            catch
            {
                return null;
            }
        }

        public void slanjePoruka(Poruke poruke) 
        {
            listaPoruka.Add(new Poruke(poruke.Id_posiljalac, poruke.Id_primalac, poruke.Tekst, poruke.Vreme));
        }

        public Poruke citanjePoruka(Korisnik korisnik, int idKorisnika)
        {
            int imaPoruka = listaPoruka.FindIndex(x => x.Id_primalac == korisnik.Id_korisnika && x.Id_posiljalac == idKorisnika); //da li uopste ima poruka
            if (imaPoruka == -1) //Ako nema poruka vraca null, tj ne vraca nijedan podatak (poruku)
            {
                return null;
            }
            else //u suprotnom ide se dalje sa proverama
            {  //da li je u listi procitanih
                Poruke poruka=listaPoruka.FindLast(x => x.Id_primalac == korisnik.Id_korisnika && x.Id_posiljalac == idKorisnika);
                int vecProcitana = listaProcitanih.FindIndex(x => x.Id_poruke == poruka.Id_poruke);
                if (vecProcitana == -1) 
                {
                    listaProcitanih.Add(poruka);
                    return poruka;
                }
                else
                {
                    return null;
                }
            }
        }
        public void DodajKorisnika(Korisnik korisnik)
        {
            Korisnik k = new Korisnik(korisnik.Korisnicko_ime, korisnik.Lozinka, korisnik.Nadimak, korisnik.Tip);
            korisnici.Add(k);
        }
        public void IzmeniKorisnika(Korisnik korisnik)
        {
            for (int i = 0; i < korisnici.Count; i++)
            {
                if (korisnici[i].Id_korisnika == korisnik.Id_korisnika)
                {
                    korisnici[i] = korisnik;
                    break;
                }
            }
        }
        public List<Grupa> prikazGrupa()
        {
            return grupe;
        }
        public List<GrupaKorisnici> prikazZahteva()
        {
            return listaZahteva;
        }
        public void OdobriUlazakUGrupu(GrupaKorisnici grupaKorisnici)
        {
            //da li ima isti u grupa korisnici
            if (grupaKor.Count == 0)
            {
                grupaKor.Add(new GrupaKorisnici(grupaKorisnici.Id_grupa, grupaKorisnici.Id_korisnik));
                GrupaKorisnici zahtev = listaZahteva.Find(x => x.Id_grupa == grupaKorisnici.Id_grupa && x.Id_korisnik == grupaKorisnici.Id_korisnik);
                listaZahteva.Remove(zahtev);
            }
            else
            {
                //da li je on vec u nekoj grupi
                int vecUgrupi = grupaKor.FindIndex(x => x.Id_korisnik == grupaKorisnici.Id_korisnik);
                if (vecUgrupi == -1) //ako nije
                {
                    //onda ako ima mesta dodaje ga
                    List<GrupaKorisnici> filtrirani = grupaKor.FindAll(x => x.Id_grupa == grupaKorisnici.Id_grupa);
                    int brojClanova = grupe.Find(x => x.Id_grupa == grupaKorisnici.Id_grupa).Max_broj_clanova;
                    if (brojClanova > filtrirani.Count)
                    {
                        grupaKor.Add(new GrupaKorisnici(grupaKorisnici.Id_grupa, grupaKorisnici.Id_korisnik));
                        GrupaKorisnici zahtev = listaZahteva.Find(x => x.Id_grupa == grupaKorisnici.Id_grupa && x.Id_korisnik == grupaKorisnici.Id_korisnik);
                        listaZahteva.Remove(zahtev);
                    }
                }
            }
        }
        public void PonistiUlazakUGrupu(GrupaKorisnici grupaKorisnici)
        {
            GrupaKorisnici zahtev = listaZahteva.Find(x => x.Id_grupa == grupaKorisnici.Id_grupa && x.Id_korisnik == grupaKorisnici.Id_korisnik);
            listaZahteva.Remove(zahtev);
        }
       
        public bool izlazakIzGrupe(Korisnik korisnik, int idGrupe) //provera da li je uopste bio u toj grupi
        {
            int bioUgrupi = grupaKor.FindIndex(x => x.Id_grupa == idGrupe && x.Id_korisnik == korisnik.Id_korisnika);
            if (bioUgrupi == -1) //ako nije bio u grupi
            {
                return false;
            }
            else 
            {
                GrupaKorisnici gr = grupaKor.Find(x => x.Id_grupa == idGrupe && x.Id_korisnik == korisnik.Id_korisnika);
                grupaKor.Remove(gr);
                return true;
            }
        }
        public void zahtevZaPristupGrupi(GrupaKorisnici grupaKorisnici)
        {
            int vecIma = listaZahteva.FindIndex(x => x.Id_grupa == grupaKorisnici.Id_grupa && x.Id_korisnik == grupaKorisnici.Id_korisnik);
            if (vecIma == -1)
            {
                listaZahteva.Add(new GrupaKorisnici(grupaKorisnici.Id_grupa, grupaKorisnici.Id_korisnik));
            }
        }

        public bool vecUgrupi(Korisnik korisnik)
        {
            int postoji = grupaKor.FindIndex(x => x.Id_korisnik == korisnik.Id_korisnika);
            if (postoji == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Korisnik> onlineKorisnici(Korisnik korisnik) 
        {
            int postoji = grupaKor.FindIndex(x => x.Id_korisnik == korisnik.Id_korisnika);
            List<Korisnik> onlineKorisnici = new List<Korisnik>();
            if (postoji == -1)
            {
                return onlineKorisnici;
            }
            else
            {
                int idGrupe = grupaKor.Find(x => x.Id_korisnik == korisnik.Id_korisnika).Id_grupa;
                List<GrupaKorisnici> sviSaIdGrupe = grupaKor.FindAll(x => x.Id_grupa == idGrupe && x.Id_korisnik != korisnik.Id_korisnika); //da ne prikazuje sebe
                foreach (GrupaKorisnici grupaKor in sviSaIdGrupe)
                {
                    onlineKorisnici.Add(korisnici.Find(x => x.Id_korisnika == grupaKor.Id_korisnik));
                }
                return onlineKorisnici;
            }
        }
        public List<Korisnik> prikaziSveKorisnike()
        {
            return korisnici;
        }
    }
}