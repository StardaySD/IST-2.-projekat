using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WcfService;

namespace Klijent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string lozinka = txtLozinka.Text;
            ServiceReference1.UserClient userClient = new ServiceReference1.UserClient();
            Korisnik korisnik = userClient.Login(ime, lozinka);
            if (korisnik != null)
            {
                if (korisnik.Tip.ToString() == "User")
                {
                    MessageBox.Show("Uspesno ste se ulogovali!");
                    this.Hide();
                    FormKlijent form = new FormKlijent(korisnik);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Niste uneli ispravne podatke.");
                }
            }
            else
            {
                MessageBox.Show("Niste uneli ispravne podatke.");
            }
        }
    }
}
