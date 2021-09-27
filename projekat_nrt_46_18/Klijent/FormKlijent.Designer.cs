
namespace Klijent
{
    partial class FormKlijent
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
            this.lbGrupe = new System.Windows.Forms.ListBox();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.lbOnlineKorisnici = new System.Windows.Forms.ListBox();
            this.lblKorisnici = new System.Windows.Forms.Label();
            this.lblGrupe = new System.Windows.Forms.Label();
            this.rbIzlaz = new System.Windows.Forms.RadioButton();
            this.btnZahtev = new System.Windows.Forms.Button();
            this.rbUlaz = new System.Windows.Forms.RadioButton();
            this.tmrOsveziKorisnike = new System.Windows.Forms.Timer(this.components);
            this.gbChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGrupe
            // 
            this.lbGrupe.FormattingEnabled = true;
            this.lbGrupe.Location = new System.Drawing.Point(439, 44);
            this.lbGrupe.Margin = new System.Windows.Forms.Padding(2);
            this.lbGrupe.Name = "lbGrupe";
            this.lbGrupe.Size = new System.Drawing.Size(162, 212);
            this.lbGrupe.TabIndex = 16;
            this.lbGrupe.SelectedIndexChanged += new System.EventHandler(this.lbGrupe_SelectedIndexChanged);
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.txtChat);
            this.gbChat.Controls.Add(this.btnPosalji);
            this.gbChat.Controls.Add(this.lblPoruka);
            this.gbChat.Controls.Add(this.txtPoruka);
            this.gbChat.Controls.Add(this.lbOnlineKorisnici);
            this.gbChat.Controls.Add(this.lblKorisnici);
            this.gbChat.Location = new System.Drawing.Point(11, 11);
            this.gbChat.Margin = new System.Windows.Forms.Padding(2);
            this.gbChat.Name = "gbChat";
            this.gbChat.Padding = new System.Windows.Forms.Padding(2);
            this.gbChat.Size = new System.Drawing.Size(424, 290);
            this.gbChat.TabIndex = 20;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(165, 33);
            this.txtChat.Margin = new System.Windows.Forms.Padding(2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(251, 154);
            this.txtChat.TabIndex = 10;
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(248, 261);
            this.btnPosalji.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(89, 23);
            this.btnPosalji.TabIndex = 9;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Location = new System.Drawing.Point(163, 189);
            this.lblPoruka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(82, 13);
            this.lblPoruka.TabIndex = 9;
            this.lblPoruka.Text = "Unesite poruku:";
            this.lblPoruka.Click += new System.EventHandler(this.lblPoruka_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(165, 206);
            this.txtPoruka.Margin = new System.Windows.Forms.Padding(2);
            this.txtPoruka.Multiline = true;
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(251, 51);
            this.txtPoruka.TabIndex = 8;
            this.txtPoruka.TextChanged += new System.EventHandler(this.txtPoruka_TextChanged);
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
            // lblGrupe
            // 
            this.lblGrupe.AutoSize = true;
            this.lblGrupe.Location = new System.Drawing.Point(439, 19);
            this.lblGrupe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupe.Name = "lblGrupe";
            this.lblGrupe.Size = new System.Drawing.Size(86, 13);
            this.lblGrupe.TabIndex = 15;
            this.lblGrupe.Text = "Dostupne grupe:";
            // 
            // rbIzlaz
            // 
            this.rbIzlaz.AutoSize = true;
            this.rbIzlaz.Location = new System.Drawing.Point(529, 258);
            this.rbIzlaz.Margin = new System.Windows.Forms.Padding(2);
            this.rbIzlaz.Name = "rbIzlaz";
            this.rbIzlaz.Size = new System.Drawing.Size(86, 17);
            this.rbIzlaz.TabIndex = 19;
            this.rbIzlaz.TabStop = true;
            this.rbIzlaz.Text = "Izlaz iz grupe";
            this.rbIzlaz.UseVisualStyleBackColor = true;
            // 
            // btnZahtev
            // 
            this.btnZahtev.Location = new System.Drawing.Point(439, 280);
            this.btnZahtev.Margin = new System.Windows.Forms.Padding(2);
            this.btnZahtev.Name = "btnZahtev";
            this.btnZahtev.Size = new System.Drawing.Size(161, 23);
            this.btnZahtev.TabIndex = 17;
            this.btnZahtev.Text = "Posalji zahtev";
            this.btnZahtev.UseVisualStyleBackColor = true;
            this.btnZahtev.Click += new System.EventHandler(this.btnZahtev_Click);
            // 
            // rbUlaz
            // 
            this.rbUlaz.AutoSize = true;
            this.rbUlaz.Location = new System.Drawing.Point(440, 258);
            this.rbUlaz.Margin = new System.Windows.Forms.Padding(2);
            this.rbUlaz.Name = "rbUlaz";
            this.rbUlaz.Size = new System.Drawing.Size(85, 17);
            this.rbUlaz.TabIndex = 18;
            this.rbUlaz.TabStop = true;
            this.rbUlaz.Text = "Ulaz u grupu";
            this.rbUlaz.UseVisualStyleBackColor = true;
            // 
            // tmrOsveziKorisnike
            // 
            this.tmrOsveziKorisnike.Interval = 3000;
            this.tmrOsveziKorisnike.Tick += new System.EventHandler(this.tmrOsveziKorisnike_Tick);
            // 
            // FormKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 325);
            this.Controls.Add(this.lbGrupe);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.lblGrupe);
            this.Controls.Add(this.rbUlaz);
            this.Controls.Add(this.btnZahtev);
            this.Controls.Add(this.rbIzlaz);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKlijent";
            this.Text = "Klijent";
            this.Load += new System.EventHandler(this.FormKlijent_Load);
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGrupe;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.TextBox txtPoruka;
        private System.Windows.Forms.ListBox lbOnlineKorisnici;
        private System.Windows.Forms.Label lblKorisnici;
        private System.Windows.Forms.Label lblGrupe;
        private System.Windows.Forms.RadioButton rbIzlaz;
        private System.Windows.Forms.Button btnZahtev;
        private System.Windows.Forms.RadioButton rbUlaz;
        private System.Windows.Forms.Timer tmrOsveziKorisnike;
        private System.Windows.Forms.TextBox txtChat;
    }
}