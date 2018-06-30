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

namespace massTurSqlite.Modul_Cari
{
    public partial class frmCariGrup : DevExpress.XtraEditors.XtraForm
    {
        classes.Messages mesajlar = new classes.Messages();


        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public frmCariGrup()
        {
            InitializeComponent();
        }

        void Sec()
        {
            try
            {

            }
            catch (Exception e)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void YeniKaydet()
        {
            try
            {

            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {

            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
    }
}