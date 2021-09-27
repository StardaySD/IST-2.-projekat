using Klijent.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace Klijent
{
    public partial class FormKlijent : Form
    {
        WcfService.Korisnik ovajKorisnik;
        int idPrimalac;
        List<WcfService.Korisnik> praznaLista = new List<WcfService.Korisnik>();
        ServiceReference1.UserClient userClient = new ServiceReference1.UserClient();
        public FormKlijent()
        {
            InitializeComponent();

        }
        public FormKlijent(WcfService.Korisnik korisnik):this()
        {
            ovajKorisnik = korisnik;
        }
        private void FormKlijent_Load(object sender, EventArgs e)
        {
            Grupa[] grupe = userClient.prikazGrupa();
            lbGrupe.Items.Clear();
            lbGrupe.DataSource = grupe;
            lbGrupe.DisplayMember = "Naziv";
            lbGrupe.ValueMember = "Id_grupa";
        }

        private void btnZahtev_Click(object sender, EventArgs e)
        {
            //Ne smem imati pristup grupi kojoj nisam clan
            
            //Ne smem imati mogucnost napustanja grupe ako nisam njen clan
            int id = (int)lbGrupe.SelectedValue;
            if (rbUlaz.Checked)
            {//da li je korisnik vec u bilo kojoj grupi
                if (userClient.vecUgrupi(ovajKorisnik))
                {
                    MessageBox.Show("Vec ste clan u grupi.");
                }
                else
                {
                    userClient.zahtevZaPristupGrupi(new GrupaKorisnici(id, ovajKorisnik.Id_korisnika));
                    tmrOsveziKorisnike.Enabled = true;
                }
            } 
            else if (rbIzlaz.Checked)
            {
                if (userClient.izlazakIzGrupe(ovajKorisnik,id)) 
                {
                    tmrOsveziKorisnike.Enabled = false; //ako se klikne na kraj cela lista se ocisti
                    lbOnlineKorisnici.DataSource = praznaLista;
                    txtChat.Text = "";
                    MessageBox.Show("Uspesno ste napustili grupu.");
                }
                else
                {
                    MessageBox.Show("Niste ni clan u toj grupi.");
                }
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e) 
        {
            idPrimalac = ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Id_korisnika;
            string poruka = txtPoruka.Text;
            userClient.slanjePoruka(new Poruke(ovajKorisnik.Id_korisnika, idPrimalac, poruka, DateTime.Now)); //poruka se posalje i snima u listu poruka
            txtChat.Text+= ovajKorisnik.Korisnicko_ime + " " + DateTime.Now + ": " + Environment.NewLine + poruka + Environment.NewLine;
        }

        private void tmrOsveziKorisnike_Tick(object sender, EventArgs e)
        {
            //na tajmer koji se aktivira kada se udje u grupu
            WcfService.Korisnik[] onlineKorisnici = userClient.onlineKorisnici(ovajKorisnik);
            if (onlineKorisnici.Length > 0) //kad je jos neko online
            {
                lbOnlineKorisnici.DataSource = onlineKorisnici;
                lbOnlineKorisnici.DisplayMember = onlineKorisnici.ToString();
                lbOnlineKorisnici.ValueMember = "";
                idPrimalac = ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Id_korisnika;
                Poruke poruka = userClient.citanjePoruka(ovajKorisnik, idPrimalac);
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

        private void lbGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbOnlineKorisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPrimalac = ((WcfService.Korisnik)lbOnlineKorisnici.SelectedItem).Id_korisnika;
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPoruka_Click(object sender, EventArgs e)
        {

        }

        private void txtPoruka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
