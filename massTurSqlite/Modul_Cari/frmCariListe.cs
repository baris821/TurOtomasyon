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
    public partial class frmCariListe : DevExpress.XtraEditors.XtraForm
    {

        public bool Secim = false;
        int SecimID = -1;

        public frmCariListe()
        {
            InitializeComponent();
        }

        private void frmCariListe_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {

        }
    }
}