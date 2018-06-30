using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace massTurSqlite.forms
{
    public partial class seyahatKartiForm : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        public string TCKN;
        public data.Musteri seciliMusteri = null;
        classes.Messages mesaj = new classes.Messages();
        public data.Tur seciliTur = null;

        public seyahatKartiForm()
        {
            InitializeComponent();
            
        }

        private void seyahatKartiForm_Load(object sender, EventArgs e)
        {
            comboBoxDoldur();
            turListe();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            TCKN = txtTC.Text.ToString();
            using (data.massTurEntities db = new data.massTurEntities())
            {
                seciliMusteri = db.Musteri.Where(m=>m.TCMusteriNo == TCKN).FirstOrDefault();
                if (seciliMusteri != null)
                {
                    groupKisiBilgi.Visible = true;
                    labelAd.Text = seciliMusteri.ad;
                    labelSoyad.Text = seciliMusteri.soyad;
                }
                else
                {
                    mesaj.MusteriBulunamadi();
                    txtTC.Text = "";
                }
            }
        }
        private void comboBoxDoldur()
        {
            comboSezon.Text = "Seçiniz";
            comboDonem.Text = "Seçiniz";
            comboTur.Text = "Seçiniz";

            comboDonem.Properties.Items.Clear();
            comboSezon.Properties.Items.Clear();

            using (data.massTurEntities db = new data.massTurEntities())
            {
                foreach (data.Sezon s in db.Sezon.Where(sez=>sez.aktif == true).ToList())
                {
                    comboSezon.Properties.Items.Add(s.ad);
                }
                foreach (data.Donem d in db.Donem.Where(don => don.aktif == true).ToList())
                {
                    comboDonem.Properties.Items.Add(d.ad);
                }
            }
        }
        private void comboSezon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sezon = Convert.ToString(comboSezon.SelectedItem);
            string donem = Convert.ToString(comboDonem.SelectedItem);

            comboTur.Properties.Items.Clear();
            using (data.massTurEntities db = new data.massTurEntities())
            {
                foreach (data.Tur tur in db.Tur.Where(t => t.Donem.ad.Contains(donem) && t.Sezon.ad.Contains(sezon)).ToList())
                {
                    comboTur.Properties.Items.Add(tur.ad);
                }
            }
        }
        private void comboDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sezon = comboSezon.SelectedItem.ToString();
            string donem = comboDonem.SelectedItem.ToString();

            comboTur.Properties.Items.Clear();
            using (data.massTurEntities db = new data.massTurEntities())
            {
                foreach (data.Tur tur in db.Tur.Where(t => t.Donem.ad.Contains(donem) && t.Sezon.ad.Contains(sezon)).ToList())
                {
                    comboTur.Properties.Items.Add(tur.ad);
                }
            }

        }
        private void turListe()
        {
            this.comboSezon.SelectedIndexChanged +=
                    new System.EventHandler(comboSezon_SelectedIndexChanged);
            this.comboDonem.SelectedIndexChanged +=
                    new System.EventHandler(comboDonem_SelectedIndexChanged);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            string turAd = Convert.ToString(comboTur.SelectedItem);

            if (turAd != null)
            {
                using (data.massTurEntities db = new data.massTurEntities())
                {
                    seciliTur = db.Tur.Where(t => t.ad == turAd).FirstOrDefault();
                    if (seciliTur != null)
                    {
                        if (seciliTur.bitTarih != null)
                        {
                            DateTime bitTarih = (DateTime)seciliTur.bitTarih;
                            labelBitTarih.Text = bitTarih.ToString("dd/MM/yyyy");
                        }
                        if (seciliTur.basTarih!=null)
                        {
                            DateTime basTarih = (DateTime)seciliTur.basTarih;
                            labelBasTarih.Text = basTarih.ToString("dd/MM/yyyy");
                        }
                        labelKod.Text = seciliTur.kod;
                        groupTurBilgi.Visible = true;

                        int padding = 0;
                        int y = 20;
                        foreach (data.Parkur p in seciliTur.Parkur.ToList())
                        {
                            GroupControl gc = new GroupControl();
                            ////gc.AutoSize = true;
                            gc.Width = 75;
                            gc.Height = 75;
                            gc.Location = new Point(padding,y);
                            PictureBox pic = new PictureBox();
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Dock = DockStyle.Fill;
                            gc.Text = p.sehir + "("+ p.sira +")";
                            if (p.ulasim == "Uçak")
                            {
                                pic.Image = Image.FromFile("../../data\\images\\AWT-Plane.png");
                            }
                            else if (p.ulasim == "Otobüs")
                            {
                                pic.Image = Image.FromFile("../../data/images/AWT-Bus.png");
                            }
                            gc.Controls.Add(pic);
                            groupParkur.Controls.Add(gc);
                            groupParkur.Visible = true;
                            padding += 75;
                            if (padding > 300)
                            {
                                padding = 0;
                                y += 75;
                            }
                           
                        }

                    }
                }
            }
        }

    }
}