
namespace Administrator
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.lbOnlineKorisnici = new System.Windows.Forms.ListBox();
            this.lblKorisnici = new System.Windows.Forms.Label();
            this.rbIzlaz = new System.Windows.Forms.RadioButton();
            this.rbUlaz = new System.Windows.Forms.RadioButton();
            this.btnZahtev = new System.Windows.Forms.Button();
            this.lbGrupe = new System.Windows.Forms.ListBox();
            this.lblGrupe = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblZahtevi = new System.Windows.Forms.Label();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.lbZahtevi = new System.Windows.Forms.ListBox();
            this.gbKorisnici = new System.Windows.Forms.GroupBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.txtNadimak = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lbKorisnici = new System.Windows.Forms.ListBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblNadimak = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.rbDodaj = new System.Windows.Forms.RadioButton();
            this.rbIzmeni = new System.Windows.Forms.RadioButton();
            this.tmrOsveziZahteve = new System.Windows.Forms.Timer(this.components);
            this.tmrOsveziKorisnike = new System.Windows.Forms.Timer(this.components);
            this.tmrOsveziSveKorisnike = new System.Windows.Forms.Timer(this.components);
            this.gbChat.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbKorisnici.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.txtChat);
            this.gbChat.Controls.Add(this.btnPosalji);
            this.gbChat.Controls.Add(this.lblPoruka);
            this.gbChat.Controls.Add(this.txtPoruka);
            this.gbChat.Controls.Add(this.lbOnlineKorisnici);
            this.gbChat.Controls.Add(this.lblKorisnici);
            this.gbChat.Location = new System.Drawing.Point(9, 17);
            this.gbChat.Margin = new System.Windows.Forms.Padding(2);
            this.gbChat.Name = "gbChat";
            this.gbChat.Padding = new System.Windows.Forms.Padding(2);
            this.gbChat.Size = new System.Drawing.Size(424, 290);
            this.gbChat.TabIndex = 14;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(158, 33);
            this.txtChat.Margin = new System.Windows.Forms.Padding(2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(251, 154);
            this.txtChat.TabIndex = 14;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(241, 261);
            this.btnPosalji.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(89, 23);
            this.btnPosalji.TabIndex = 12;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(156, 189);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(82, 13);
            this.lblPoruka.TabIndex = 13;
            this.lblPoruka.Text = "Unesite poruku:";
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(158, 206);
            this.txtPoruka.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(251, 51);
            this.txtPoruka.TabIndex = 11;
            // 
            // lbOnlineKorisnici
            // 
            this.lbOnlineKorisnici.FormattingEnabled = true;
            this.lbOnlineKorisnici.Location = new System.Drawing.Point(16, 33);
            this.lbOnlineKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.lbOnlineKorisnici.Name = "lbOnlineKorisnici";
            this.lbOnlineKorisnici.Size = new System.Drawing.Size(135, 251);
            this.lbOnlineKorisnici.TabIndex = 3;
            this.lbOnlineKorisnici.SelectedIndexChanged += new System.EventHandler(this.lbOnlineKorisnici_SelectedIndexChanged);
            // 
            // lblKorisnici
            // 
            this.lblKorisnici.AutoSize = true;
            this.lblKorisnici.Location = new System.Drawing.Point(14, 15);
            this.lblKorisnici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorisnici.Name = "lblKorisnici";
            this.lblKorisnici.Size = new System.Drawing.Size(81, 13);
            this.lblKorisnici.TabIndex = 1;
            this.lblKorisnici.Text = "Online korisnici:";
            // 
            // rbIzlaz
            // 
            this.rbIzlaz.AutoSize = true;
            this.rbIzlaz.Location = new System.Drawing.Point(521, 256);
            this.rbIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.rbIzlaz.Name = "rbIzlaz";
            this.rbIzlaz.Size = new System.Drawing.Size(86, 17);
            this.rbIzlaz.TabIndex = 13;
            this.rbIzlaz.TabStop = true;
            this.rbIzlaz.Text = "Izlaz iz grupe";
            this.rbIzlaz.UseVisualStyleBackColor = true;
            // 
            // rbUlaz
            // 
            this.rbUlaz.AutoSize = true;
            this.rbUlaz.Location = new System.Drawing.Point(438, 256);
            this.rbUlaz.Margin = new System.Windows.Forms.Padding(2);
            this.rbUlaz.Name = "rbUlaz";
            this.rbUlaz.Size = new System.Drawing.Size(85, 17);
            this.rbUlaz.TabIndex = 12;
            this.rbUlaz.TabStop = true;
            this.rbUlaz.Text = "Ulaz u grupu";
            this.rbUlaz.UseVisualStyleBackColor = true;
            // 
            // btnZahtev
            // 
            this.btnZahtev.Location = new System.Drawing.Point(437, 277);
            this.btnZahtev.Margin = new System.Windows.Forms.Padding(2);
            this.btnZahtev.Name = "btnZahtev";
            this.btnZahtev.Size = new System.Drawing.Size(161, 23);
            this.btnZahtev.TabIndex = 11;
            this.btnZahtev.Text = "Posalji zahtev";
            this.btnZahtev.UseVisualStyleBackColor = true;
            this.btnZahtev.Click += new System.EventHandler(this.btnZahtev_Click);
            // 
            // lbGrupe
            // 
            this.lbGrupe.FormattingEnabled = true;
            this.lbGrupe.Location = new System.Drawing.Point(437, 42);
            this.lbGrupe.Margin = new System.Windows.Forms.Padding(2);
            this.lbGrupe.Name = "lbGrupe";
            this.lbGrupe.Size = new System.Drawing.Size(162, 212);
            this.lbGrupe.TabIndex = 10;
            // 
            // lblGrupe
            // 
            this.lblGrupe.AutoSize = true;
            this.lblGrupe.Location = new System.Drawing.Point(437, 17);
            this.lblGrupe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupe.Name = "lblGrupe";
            this.lblGrupe.Size = new System.Drawing.Size(86, 13);
            this.lblGrupe.TabIndex = 9;
            this.lblGrupe.Text = "Dostupne grupe:";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.lbGrupe);
            this.gbUser.Controls.Add(this.gbChat);
            this.gbUser.Controls.Add(this.lblGrupe);
            this.gbUser.Controls.Add(this.rbIzlaz);
            this.gbUser.Controls.Add(this.btnZahtev);
            this.gbUser.Controls.Add(this.rbUlaz);
            this.gbUser.Location = new System.Drawing.Point(14, 243);
            this.gbUser.Margin = new System.Windows.Forms.Padding(2);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(2);
            this.gbUser.Size = new System.Drawing.Size(607, 319);
            this.gbUser.TabIndex = 15;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "USER";
            this.gbUser.Enter += new System.EventHandler(this.gbUser_Enter);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.pictureBox1);
            this.gbAdmin.Controls.Add(this.lblZahtevi);
            this.gbAdmin.Controls.Add(this.btnOdbij);
            this.gbAdmin.Controls.Add(this.btnOdobri);
            this.gbAdmin.Controls.Add(this.lbZahtevi);
            this.gbAdmin.Controls.Add(this.gbKorisnici);
            this.gbAdmin.Location = new System.Drawing.Point(14, 10);
            this.gbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.gbAdmin.Size = new System.Drawing.Size(607, 220);
            this.gbAdmin.TabIndex = 16;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 128);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblZahtevi
            // 
            this.lblZahtevi.AutoSize = true;
            this.lblZahtevi.Location = new System.Drawing.Point(437, 15);
            this.lblZahtevi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZahtevi.Name = "lblZahtevi";
            this.lblZahtevi.Size = new System.Drawing.Size(46, 13);
            this.lblZahtevi.TabIndex = 15;
            this.lblZahtevi.Text = "Zahtevi:";
            // 
            // btnOdbij
            // 
            this.btnOdbij.Location = new System.Drawing.Point(523, 180);
            this.btnOdbij.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(80, 27);
            this.btnOdbij.TabIndex = 24;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = true;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(439, 180);
            this.btnOdobri.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(80, 27);
            this.btnOdobri.TabIndex = 23;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // lbZahtevi
            // 
            this.lbZahtevi.FormattingEnabled = true;
            this.lbZahtevi.Location = new System.Drawing.Point(439, 34);
            this.lbZahtevi.Margin = new System.Windows.Forms.Padding(2);
            this.lbZahtevi.Name = "lbZahtevi";
            this.lbZahtevi.Size = new System.Drawing.Size(164, 134);
            this.lbZahtevi.TabIndex = 10;
            // 
            // gbKorisnici
            // 
            this.gbKorisnici.Controls.Add(this.cmbTip);
            this.gbKorisnici.Controls.Add(this.txtNadimak);
            this.gbKorisnici.Controls.Add(this.txtLozinka);
            this.gbKorisnici.Controls.Add(this.txtIme);
            this.gbKorisnici.Controls.Add(this.lblTip);
            this.gbKorisnici.Controls.Add(this.lbKorisnici);
            this.gbKorisnici.Controls.Add(this.lblLozinka);
            this.gbKorisnici.Controls.Add(this.lblNadimak);
            this.gbKorisnici.Controls.Add(this.lblIme);
            this.gbKorisnici.Controls.Add(this.btnSnimi);
            this.gbKorisnici.Controls.Add(this.rbDodaj);
            this.gbKorisnici.Controls.Add(this.rbIzmeni);
            this.gbKorisnici.Location = new System.Drawing.Point(143, 15);
            this.gbKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.gbKorisnici.Name = "gbKorisnici";
            this.gbKorisnici.Padding = new System.Windows.Forms.Padding(2);
            this.gbKorisnici.Size = new System.Drawing.Size(290, 200);
            this.gbKorisnici.TabIndex = 0;
            this.gbKorisnici.TabStop = false;
            this.gbKorisnici.Text = "Korisnici";
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(190, 122);
            this.cmbTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(76, 21);
            this.cmbTip.TabIndex = 22;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(190, 99);
            this.txtNadimak.Margin = new System.Windows.Forms.Padding(2);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(76, 20);
            this.txtNadimak.TabIndex = 21;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(190, 76);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(76, 20);
            this.txtLozinka.TabIndex = 20;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(190, 53);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(76, 20);
            this.txtIme.TabIndex = 19;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(126, 124);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(25, 13);
            this.lblTip.TabIndex = 18;
            this.lblTip.Text = "Tip:";
            // 
            // lbKorisnici
            // 
            this.lbKorisnici.FormattingEnabled = true;
            this.lbKorisnici.Location = new System.Drawing.Point(15, 19);
            this.lbKorisnici.Margin = new System.Windows.Forms.Padding(2);
            this.lbKorisnici.Name = "lbKorisnici";
            this.lbKorisnici.Size = new System.Drawing.Size(106, 173);
            this.lbKorisnici.TabIndex = 10;
            this.lbKorisnici.SelectedIndexChanged += new System.EventHandler(this.lbKorisnici_SelectedIndexChanged);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(126, 78);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 17;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblNadimak
            // 
            this.lblNadimak.AutoSize = true;
            this.lblNadimak.Location = new System.Drawing.Point(126, 101);
            this.lblNadimak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNadimak.Name = "lblNadimak";
            this.lblNadimak.Size = new System.Drawing.Size(52, 13);
            this.lblNadimak.TabIndex = 16;
            this.lblNadimak.Text = "Nadimak:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(126, 56);
            this.lblIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 15;
            this.lblIme.Text = "Ime:";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(125, 165);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(140, 23);
            this.btnSnimi.TabIndex = 15;
            this.btnSnimi.Text = "Snimi korisnika";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // rbDodaj
            // 
            this.rbDodaj.AutoSize = true;
            this.rbDodaj.Location = new System.Drawing.Point(181, 15);
            this.rbDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(98, 17);
            this.rbDodaj.TabIndex = 15;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "Dodaj korisnika";
            this.rbDodaj.UseVisualStyleBackColor = true;
            this.rbDodaj.CheckedChanged += new System.EventHandler(this.rbDodaj_CheckedChanged);
            // 
            // rbIzmeni
            // 
            this.rbIzmeni.AutoSize = true;
            this.rbIzmeni.Location = new System.Drawing.Point(125, 15);
            this.rbIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.rbIzmeni.Name = "rbIzmeni";
            this.rbIzmeni.Size = new System.Drawing.Size(55, 17);
            this.rbIzmeni.TabIndex = 13;
            this.rbIzmeni.TabStop = true;
            this.rbIzmeni.Text = "Izmeni";
            this.rbIzmeni.UseVisualStyleBackColor = true;
            this.rbIzmeni.CheckedChanged += new System.EventHandler(this.rbIzmeni_CheckedChanged);
            // 
            // tmrOsveziZahteve
            // 
            this.tmrOsveziZahteve.Enabled = true;
            this.tmrOsveziZahteve.Interval = 4000;
            this.tmrOsveziZahteve.Tick += new System.EventHandler(this.tmrOsveziZahteve_Tick);
            // 
            // tmrOsveziKorisnike
            // 
            this.tmrOsveziKorisnike.Interval = 3000;
            this.tmrOsveziKorisnike.Tick += new System.EventHandler(this.tmrOsveziKorisnike_Tick);
            // 
            // tmrOsveziSveKorisnike
            // 
            this.tmrOsveziSveKorisnike.Enabled = true;
            this.tmrOsveziSveKorisnike.Interval = 10000;
            this.tmrOsveziSveKorisnike.Tick += new System.EventHandler(this.tmrOsveziSveKorisnike_Tick);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 578);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.gbUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbKorisnici.ResumeLayout(false);
            this.gbKorisnici.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.ListBox lbOnlineKorisnici;
        private System.Windows.Forms.Label lblKorisnici;
        private System.Windows.Forms.RadioButton rbIzlaz;
        private System.Windows.Forms.RadioButton rbUlaz;
        private System.Windows.Forms.Button btnZahtev;
        private System.Windows.Forms.ListBox lbGrupe;
        private System.Windows.Forms.Label lblGrupe;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.GroupBox gbKorisnici;
        private System.Windows.Forms.ListBox lbKorisnici;
        private System.Windows.Forms.Label lblZahtevi;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.ListBox lbZahtevi;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.TextBox txtNadimak;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblNadimak;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.RadioButton rbIzmeni;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.Timer tmrOsveziZahteve;
        private System.Windows.Forms.Timer tmrOsveziKorisnike;
        private System.Windows.Forms.Timer tmrOsveziSveKorisnike;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}