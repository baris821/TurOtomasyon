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
    public partial class musteriListeForm : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;

        DataTable list = new DataTable();
        classes.Messages mesajlar = new classes.Messages();


        public musteriListeForm()
        {
            list.Columns.Add("ID", typeof(int));
            list.Columns.Add("TCKN", typeof(string));
            list.Columns.Add("Ad", typeof(string));
            list.Columns.Add("Soyad", typeof(string));
            list.Columns.Add("Cinsiyet", typeof(string));
            list.Columns.Add("DogumYeri", typeof(string));
            list.Columns.Add("DogumTarih", typeof(string));
            list.Columns.Add("CepTel", typeof(string));
            InitializeComponent();
        }

        private void musteriListeForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            list.Rows.Clear();
            using (data.massTurEntities db = new data.massTurEntities())
            {
                foreach (data.Musteri m in db.Musteri.Where(mus => mus.aktif == true).ToList())
                {
                    string dogumTarih = Convert.ToString(m.dogumTarih);
                    list.Rows.Add(m.id , m.TCMusteriNo , m.ad,m.soyad,m.cinsiyet,m.dogumYer,dogumTarih,m.cepTel);
                }
            }

            gridMusteriList.DataSource = list;
        }

        void Ara()
        {
            using (data.massTurEntities db = new data.massTurEntities())
            {
                try
                {
                    var arama = db.Musteri.Where(m => m.TCMusteriNo.Contains(txtTC.Text.ToString()) || m.ad.Contains(txtAd.Text.ToString()) || m.soyad.Contains(txtSoyad.Text.ToString())).ToList();
                    list.Rows.Clear();
                    foreach (var m in arama.Where(a =>a.aktif == true).ToList())
                    {
                        string dogumTarih = Convert.ToString(m.dogumTarih);
                        list.Rows.Add(m.id, m.TCMusteriNo, m.ad, m.soyad, m.cinsiyet, m.dogumYer, dogumTarih, m.cepTel);
                    }
                }
                catch (Exception e)
                {
                    mesajlar.Hata(e);
                }
                
            }
            gridMusteriList.DataSource = list;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Ara();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}