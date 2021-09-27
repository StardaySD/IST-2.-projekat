using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace Administrator
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
            ServiceReference1.AdminClient adminClient = new ServiceReference1.AdminClient();
            Korisnik korisnik = adminClient.Login(ime, lozinka);
            if (korisnik != null)
            {
                if (korisnik.Tip.ToString()=="Admin")
                {
                    MessageBox.Show("Dobrodosli Administratore!");
                    this.Hide();
                    FormAdmin form = new FormAdmin(korisnik);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Uneti podatci su netacni.");
                }
            }
            else
            {
                MessageBox.Show("Uneti podatci su netacni.");
            }
        }
    }
}
