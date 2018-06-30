using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massTurSqlite.classes
{
    class Forms
    {
        public void MusteriListesi(bool Secim = false)
        {
            forms.musteriListeForm frm = new forms.musteriListeForm();

            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = forms.anaForm.ActiveForm;
                frm.Show();
            }
        }

        public void MusteriEkle(bool Secim = false)
        {
            forms.musteriEkleForm frm = new forms.musteriEkleForm();

            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
        }
        public void SeyahatKarti(bool Secim = false)
        {
            forms.seyahatKartiForm frm = new forms.seyahatKartiForm();

            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = forms.anaForm.ActiveForm;
                frm.Show();
            }
        }


    }
}
