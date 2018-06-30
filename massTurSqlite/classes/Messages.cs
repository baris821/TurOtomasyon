using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace massTurSqlite.classes
{
    class Messages
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj , "Yeni Kaıyt" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili öğe kalıcı olarak silinecektir!\n İşlemi onaylıyor musunuz?" , "Silme İşlemi" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
        }
        public void Silindi()
        {
            MessageBox.Show("Silme işlemi başarılı.","Silindi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Güncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncellendi()
        {
            MessageBox.Show("Güncelleme işlemi başarılı","Güncellendi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Hata(Exception e)
        {
            MessageBox.Show(e.Message , "Hata Oluştu" , MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void MusteriBulunamadi()
        {
            MessageBox.Show("Böyle bir müşteri bulunamadı!");
        }


    }
}
