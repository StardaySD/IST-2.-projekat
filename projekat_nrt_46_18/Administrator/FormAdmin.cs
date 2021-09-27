using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace Administrator
{
    public partial class FormAdmin : Form
    {
        WcfService.Korisnik ovajKorisnik;
        Korisnik[] korisnici;
        ServiceReference1.AdminClient adminClient = new ServiceReference1.AdminClient();
        List<GrupaKorisnici> praznaLista = new List<GrupaKorisnici>();
        int idPrimalac;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(WcfService.Korisnik korisnik) : this()
        {
            ovajKorisnik = korisnik;
        }

        private void btnZahtev_Click(object sender, EventArgs e)
        {
            int id = (int)lbGrupe.SelectedValue;
            if (rbUlaz.Checked)
            {
                if (adminClient.vecUgrupi(ovajKorisnik))
                {
                    MessageBox.Show("Vec ste u grupi.");
                }
                else
                {
                    adminClient.zahtevZaPristupGrupi(new GrupaKorisnici(id, ovajKorisnik.Id_korisnika));
                    tmrOsveziKorisnike.Enabled = true;
                }

            }
            else if (rbIzlaz.Checked)
            {
                if (adminClient.izlazakIzGrupe(ovajKorisnik, id))
                {
                    tmrOsveziKorisnike.Enabled = false; //sluzi da ocisti celu listu ako se klikne na kraj
                    lbOnlineKorisnici.DataSource = praznaLista;
                    txtChat.Text = "";
                    MessageBox.Show("Uspesno ste napustili grupu.");
                }
                else
                {
                    MessageBox.Show("Niste bili clan te grupe.");
                }
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            idPrimalac = ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Id_korisnika;
            string poruka = txtPoruka.Text;
            adminClient.slanjePoruka(new Poruke(ovajKorisnik.Id_korisnika, idPrimalac, poruka, DateTime.Now)); //posalje se poruka koja se zatim snima u listi poruka
            txtChat.Text += ovajKorisnik.Korisnicko_ime + " " + DateTime.Now + ": " + Environment.NewLine + poruka + Environment.NewLine;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Grupa[] grupe = adminClient.prikazGrupa();
            lbGrupe.Items.Clear();
            lbGrupe.DataSource = grupe;
            lbGrupe.DisplayMember = "Naziv";
            lbGrupe.ValueMember = "Id_grupa";

            korisnici = adminClient.prikaziSveKorisnike();
            lbKorisnici.Items.Clear();
            lbKorisnici.DataSource = korisnici;
            lbKorisnici.DisplayMember = "Korisnicko_ime";
            lbKorisnici.ValueMember = "Id_korisnika";

            cmbTip.Items.Add(Tip.Admin);
            cmbTip.Items.Add(Tip.User);
            cmbTip.SelectedIndex = 0;
        }
        
        private void tmrOsveziZahteve_Tick(object sender, EventArgs e)
        {
            GrupaKorisnici[] zahtevi = adminClient.prikazZahteva();
            if (zahtevi.Length > 0) 
            {
                lbZahtevi.DataSource = zahtevi;
                lbZahtevi.DisplayMember = zahtevi.ToString(); 
                lbZahtevi.ValueMember = "";
            }
            else
            {
                lbZahtevi.DataSource = praznaLista;
            }
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            string tekst = lbZahtevi.GetItemText(lbZahtevi.SelectedItem);
            string[] delovi = tekst.Split(' ');
            int idKorisnik = Int32.Parse(delovi[1]);
            int idGrupa = Int32.Parse(delovi[4]);
            adminClient.OdobriUlazakUGrupu(new GrupaKorisnici(idGrupa, idKorisnik));
        }

        private void btnOdbij_Click(object sender, EventArgs e)
        {
            string tekst = lbZahtevi.GetItemText(lbZahtevi.SelectedItem);
            string[] delovi = tekst.Split(' ');
            int idKorisnik = Int32.Parse(delovi[1]);
            int idGrupa = Int32.Parse(delovi[4]);
            adminClient.PonistiUlazakUGrupu(new GrupaKorisnici(idGrupa, idKorisnik));
        }

        private void tmrOsveziKorisnike_Tick(object sender, EventArgs e)
        {
            WcfService.Korisnik[] onlineKorisnici = adminClient.onlineKorisnici(ovajKorisnik);
            if (onlineKorisnici.Length > 0) //ukoliko ima jos neki korisnik koji je online
            {
                lbOnlineKorisnici.DataSource = onlineKorisnici;
                lbOnlineKorisnici.DisplayMember = onlineKorisnici.ToString();
                lbOnlineKorisnici.ValueMember = "";
                idPrimalac = ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Id_korisnika;
                Poruke poruka = adminClient.citanjePoruka(ovajKorisnik, idPrimalac);
                if (poruka != null)
                {
                    txtChat.Text += ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Korisnicko_ime + " " + poruka.Vreme + ": " + Environment.NewLine + poruka.Tekst + Environment.NewLine;
                }
            }
            else
            {
                lbOnlineKorisnici.DataSource = praznaLista;
            }
        }

        private void lbOnlineKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPrimalac = ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Id_korisnika;
        }

        private void gbUser_Enter(object sender, EventArgs e)
        {

        }

        private void rbIzmeni_CheckedChanged(object sender, EventArgs e)
        {
            int idKorisnika = (int)lbKorisnici.SelectedValue;
            Korisnik k=korisnici.First(x => x.Id_korisnika == idKorisnika);
            txtIme.Text = k.Korisnicko_ime;
            txtNadimak.Text = k.Nadimak;
            txtLozinka.Text = k.Lozinka;
            cmbTip.SelectedItem = k.Tip;
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            if (rbIzmeni.Checked)
            {
                Korisnik k = (Korisnik)lbKorisnici.SelectedItem;
                if (k != null)
                {
                    k.Korisnicko_ime = txtIme.Text;
                    k.Nadimak = txtNadimak.Text;
                    k.Lozinka = txtLozinka.Text;
                    k.Tip = (Tip)cmbTip.SelectedItem;
                    adminClient.IzmeniKorisnika(k);
                    MessageBox.Show("Uspesno izmenjen korisnik.");
                    txtIme.Text = "";
                    txtLozinka.Text = "";
                    txtNadimak.Text = "";
                    cmbTip.SelectedIndex = 0;
                }
            }
            else if (rbDodaj.Checked)
            {
                if (txtIme.Text != "" && txtLozinka.Text != "" && txtNadimak.Text != "") 
                { 
                    Korisnik k = new Korisnik(txtIme.Text, txtLozinka.Text, txtNadimak.Text, (Tip)cmbTip.SelectedItem);
                    adminClient.DodajKorisnika(k);
                    MessageBox.Show("Uspesno dodat korisnik.");
                    txtIme.Text = "";
                    txtLozinka.Text = "";
                    txtNadimak.Text = "";
                    cmbTip.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Popunite sva polja!");
                }
            }
        }

        private void rbDodaj_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tmrOsveziSveKorisnike_Tick(object sender, EventArgs e)
        {
            lbKorisnici.DataSource = null;
            korisnici = adminClient.prikaziSveKorisnike();
            lbKorisnici.Items.Clear();
            lbKorisnici.DataSource = korisnici;
            lbKorisnici.DisplayMember = "Korisnicko_ime";
            lbKorisnici.ValueMember = "Id_korisnika";

            cmbTip.Items.Clear();
            cmbTip.Items.Add(Tip.Admin);
            cmbTip.Items.Add(Tip.User);
            cmbTip.SelectedIndex = 0;
        }

        private void lbKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
