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
using System.Data.Entity.Validation;

namespace massTurSqlite.forms
{
    public partial class musteriEkleForm : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        classes.Messages mesaj = new classes.Messages();
        public musteriEkleForm()
        {
            InitializeComponent();
        }
        
        void yeniMusteri()
        {
            data.Musteri m = new data.Musteri();

            try
            {
                m.TCMusteriNo = txtTC.Text.ToString();
                m.ad = txtAd.Text.ToString();
                m.soyad = txtSoyad.Text.ToString();
                m.dogumYer = txtDogumYeri.Text.ToString();
                m.dogumTarih = dateEditDogumTarihi.DateTime;
                m.anneAd = txtAnneAd.Text.ToString();
                m.babaAd = txtBabaAd.Text.ToString();
                m.cinsiyet = comboBoxCinsiyet.SelectedItem.ToString();

                if (comboBoxVatandas.SelectedItem.ToString() == "Türk") m.vatandas = true;
                else m.vatandas = false;

                m.medeniDurum = comboBoxMedeni.SelectedItem.ToString();
                m.turu = comboBoxMusteriTuru.SelectedItem.ToString();
                m.basvuruTipi = comboBoxBasvuruTipi.SelectedItem.ToString();
                m.grup = txtGrup.Text.ToString();
                m.ogrenci = (bool)(radioOgr.EditValue);
                m.ogrenciBelge = (bool)(radioOgrBelge.EditValue);
                m.cepTel = txtCepTel.Text.ToString();
                m.adres = txtAdres.Text.ToString();
                m.acilAd = txtAcilAd.Text.ToString();
                m.acilYakinlik = txtAcilYakinlik.Text.ToString();
                m.acilNo = txtAcilNo.Text.ToString();
                m.faturaAdres = txtFaturaAdres.Text.ToString();
                m.passID = 0;
                m.aktif = true;

                using (data.massTurEntities db = new data.massTurEntities())
                {
                    db.Musteri.Add(m);
                    db.SaveChanges();
                }
                mesaj.YeniKayit("Yeni müşteri kaydı oluşturuldu");
                Temizle();

            }
            catch (Exception e)
            {
                mesaj.Hata(e);
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            yeniMusteri();
        }
        void Temizle()
        {
            txtAcilAd.Text = "";
            txtAcilNo.Text = "";
            txtAcilYakinlik.Text = "";
            txtAd.Text = "";
            txtAdres.Text = "";
            txtAnneAd.Text = "";
            txtBabaAd.Text = "";
            txtCepTel.Text = "";
            txtDogumYeri.Text = "";
            txtFaturaAdres.Text = "";
            txtGrup.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            comboBoxBasvuruTipi.Text = "Seçiniz";
            comboBoxCinsiyet.Text = "Seçiniz";
            comboBoxMedeni.Text = "Seçiniz";
            comboBoxMusteriTuru.Text = "Seçiniz";
            comboBoxVatandas.Text = "Seçiniz";
            dateEditDogumTarihi.Text = "";

        }
    }
}