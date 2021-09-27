using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    public enum Tip { Admin, User }
   
    [ServiceContract]
    public interface IAdmin:IUser
    {

        [OperationContract]
        void DodajKorisnika(Korisnik korisnik); //unos podataka i dodavanje novog korisnika

        [OperationContract]
        void IzmeniKorisnika(Korisnik korisnik); //unos podataka i izmena vec postojeceg korisnika
        
        [OperationContract]
        List<Korisnik> prikaziSveKorisnike(); //prikaz svih postojecih korisnika

        //odobravanje zahteva korisnika da udje u grupu - stavlja korisnika u grupu
        [OperationContract]
        void OdobriUlazakUGrupu(GrupaKorisnici grupaKorisnici);
        [OperationContract]
        void PonistiUlazakUGrupu(GrupaKorisnici grupaKorisnici);
        [OperationContract]
        List<GrupaKorisnici> prikazZahteva();
        
    }

    [ServiceContract]
    public interface IUser
    {
        
        [OperationContract]
        Korisnik Login(string ime, string lozinka); //prijava na sistem

        [OperationContract]
        List<Korisnik> onlineKorisnici(Korisnik korisnik); //provera i prikaz svih online korisnika
        
        [OperationContract]
        List<Grupa> prikazGrupa(); //korisniku se prikazuju sve grupe

        [OperationContract]
        void zahtevZaPristupGrupi(GrupaKorisnici grupaKorisnici); //slanje zahteva za pristup grupi
        
        [OperationContract]
        bool vecUgrupi(Korisnik korisnik); //Provera da li je korisnik vec clan grupe

        [OperationContract]
        bool izlazakIzGrupe(Korisnik korisnik, int idGrupe); //izlazak iz zeljene grupe
        
        [OperationContract]
        void slanjePoruka(Poruke poruke); //slanje poruka u istoj grupi
        
        [OperationContract]
        Poruke citanjePoruka(Korisnik korisnik, int idKorisnika); //citanje poruka u istoj grupi
      
    }

    [DataContract]
    public class Korisnik
    {
        [DataMember]
        static int ID = 0;
        [DataMember]
        int id_korisnika = ID++;    //ID korisnika
        [DataMember]
        string korisnicko_ime;      //ime korisceno za login kao username
        [DataMember]
        string lozinka;             //password za ulazak
        [DataMember]
        string nadimak;             //sta drugi korisnici vide kao ime korisnika
        [DataMember]
        Tip tip;                    //tip naloga (admin ili user)

        public Korisnik(string korisnicko_ime, string lozinka, string nadimak, Tip tip)
        {
            this.Korisnicko_ime = korisnicko_ime;
            this.Lozinka = lozinka;
            this.Nadimak = nadimak;
            this.Tip = tip;
        }

        public int Id_korisnika { get => id_korisnika; set => id_korisnika = value; }
        public string Korisnicko_ime { get => korisnicko_ime; set => korisnicko_ime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Nadimak { get => nadimak; set => nadimak = value; }
        public Tip Tip { get => tip; set => tip = value; }
        public override string ToString()
        {
            return Korisnicko_ime;
        }

    }

    [DataContract]
    public class Poruke
    {
        [DataMember]
        static int ID = 0;
        [DataMember]
        int id_poruke = ID++;   //ID poruke
        [DataMember]
        int id_posiljalac;      //id korisnika koji salje poruku
        [DataMember]
        int id_primalac;        //id grupe u koju se salje poruka
        [DataMember]    
        string tekst;           //sadrzaj poruke
        [DataMember]
        DateTime vreme;         //vreme kada je poruka poslata 

        public Poruke()
        {
        }

        public Poruke(int id_posiljalac, int id_primalac, string tekst, DateTime vreme)
        {
            this.id_posiljalac = id_posiljalac;
            this.id_primalac = id_primalac;
            this.tekst = tekst;
            this.vreme = vreme;
        }

        public int Id_poruke { get => id_poruke; set => id_poruke = value; }
        public int Id_posiljalac { get => id_posiljalac; set => id_posiljalac = value; }
        public int Id_primalac { get => id_primalac; set => id_primalac = value; }
        public string Tekst { get => tekst; set => tekst = value; }
        public DateTime Vreme { get => vreme; set => vreme = value; }

    }

    [DataContract]
    public class Grupa
    {
        [DataMember]
        static int ID = 0;
        [DataMember]
        int id_grupa = ID++;    //ID grupe 
        [DataMember]
        string naziv;           //ime grupe koju svi korisnici vide
        [DataMember]
        int max_broj_clanova;   //Maksimalan broj clanova (oba tipa korisnika)

        public Grupa(string naziv, int max_broj_clanova)
        {
            this.naziv = naziv;
            this.max_broj_clanova = max_broj_clanova;
        }

        public int Id_grupa { get => id_grupa; set => id_grupa = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Max_broj_clanova { get => max_broj_clanova; set => max_broj_clanova = value; }
    }

    [DataContract]
    public class GrupaKorisnici
    {
        [DataMember]
        int id_grupa;
        [DataMember]
        int id_korisnik;

        public GrupaKorisnici(int id_grupa, int id_korisnik)
        {
            this.id_grupa = id_grupa;
            this.id_korisnik = id_korisnik;
        }

        public int Id_grupa { get => id_grupa; set => id_grupa = value; }
        public int Id_korisnik { get => id_korisnik; set => id_korisnik = value; }
        public override string ToString()
        {
            //ID korisnika koji se nalazi u grupi tog ID-a, primer Korisnik: 16 -> grupa: 6
            return "Korisnik: " + this.id_korisnik + " -> grupa: " + this.id_grupa;
        }
    }
}
