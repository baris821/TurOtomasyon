using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace massTurSqlite.forms
{
    public partial class anaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        classes.Forms forms = new classes.Forms();

        public static int UserID = -1;
        public static int Aktarma = -1;

        public anaForm()
        {
            InitializeComponent();
        }

        private void barBtnMusEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.MusteriEkle();
        }

        private void barBtnMusLis_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.MusteriListesi();
        }

        private void barBtnSeyahat_ItemClick(object sender, ItemClickEventArgs e)
        {
            forms.SeyahatKarti();
        }
    }
}