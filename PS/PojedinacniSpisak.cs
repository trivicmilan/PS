﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.dto;
using PS.dao;
using PS.controlers;

namespace PS
{
    public partial class PojedinacniSpisak : Form
    {
        int kartaZakljuckaId;
        List<string> vreceOIdLista = new List<string>();

        public PojedinacniSpisak(string otprema, string od, string za, string datum, int kartaZakljucka)
        {
            InitializeComponent();
            tbOtprema.Text = otprema;
            tbOtprema.Enabled = false;
            tbOd.Text = od;
            tbOd.Enabled = false;
            tbZa.Text = za;
            tbZa.Enabled = false;
            tbDatum.Text = datum;
            tbDatum.Enabled = false;
            this.kartaZakljuckaId = kartaZakljucka;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string v = tbIdentifikator.Text.Trim();
            bool b = true;
            foreach (string vr in vreceOIdLista)
            {
                if (vr.Equals(v)) b = false;
            }
            if (b)
            { 
            vreceOIdLista.Add(tbIdentifikator.Text.Trim());
            dgvVrece.Rows.Add(tbIdentifikator.Text.Trim());
            tbIdentifikator.Text = "";
            btnKreirajSpisak.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vreća sa unijetim identifikatorom je već unijeta. Molimo unesite ispravan identifikator!");
                tbIdentifikator.Text = "";
            }

        }

        private void btnKreirajSpisak_Click(object sender, EventArgs e)
        {
            VrecaDAO vdao = DAOFactory.getDAOFactory().getVrecaDAO();
            foreach (string vreca in vreceOIdLista)
            {
                KartaZakljuckaDTO karta = new KartaZakljuckaDTO();
                karta.KartaID = kartaZakljuckaId;
                vdao.insert(new VrecaDTO(karta, 0, vreca));
            }

            //kreiranje stringa za upis u fajl
            string text = "Datum: " + tbDatum.Text + "\r\n" +
                          "                                                             Spisak razmjene                                                  Otprema: " + tbOtprema.Text.Trim() + 
                          "\r\n\r\n" + "Od: " + tbOd.Text + "\r\nZa: " + tbZa.Text + "\r\n" + "\r\nIdentifikator\r\n---------------------\r\n";
            foreach (string vreca in vreceOIdLista)
            {
                text += vreca + "\r\n";
            }
            Printer p = new Printer();
            p.Text = text;
            p.PrintToPDF();
            MessageBox.Show("Spisak razmjene kreiran!");
            this.Close();
        }

        private void tbIdentifikator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDodaj_Click(this, new EventArgs());
            }
        }

        private void PojedinacniSpisak_Load(object sender, EventArgs e)
        {
            btnKreirajSpisak.Enabled = false;
        }
    }
}

