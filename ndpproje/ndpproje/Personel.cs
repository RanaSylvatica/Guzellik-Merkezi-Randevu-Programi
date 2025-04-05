/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3
**				ÖĞRENCİ ADI............:Elif Ranagül Akyol
**				ÖĞRENCİ NUMARASI.......:B231210092
**              DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    internal class Personel :Uye 
    {


       
    }

    public class Musteri : Uye
    {

        public Musteri(string isim, string soyisim, string numara, string hizmet, string guzellikUzmani, string gun, string fiyat, string saat)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.numara = numara;
            this.hizmet = hizmet;
            this.guzellikUzmani = guzellikUzmani;
            this.gun = gun;
            this.fiyat = fiyat;
            this.saat = saat;


        }

        public string toString()
        { 
            return this.isim+"\t"+this.soyisim+"\t"+this.numara+"\t" + this.hizmet + "\t" + this.guzellikUzmani + "\t" + this.gun + "\t" + this.fiyat + "\t" + this.saat+ "\t"; 
        }   

        //alınan değerleri alt alta yazdıracak değer döndürdük ki aşağıda silme metodunda kullanacağız
       
    }

    public class Yonetim: Iyetki
    {
        ArrayList musteriListesi = new ArrayList();


        public void ekle(Musteri musteri)
        {
            musteriListesi.Add(musteri);        //metod her çağrrıldığında bilgiler ile müşteri classından bir nesne oluşturur
        }

        public void guncelle(string isim, string soyisim, string numara, string hizmet, string guzellikUzmani, string gun, string fiyat, string saat)
        {
            foreach(Musteri item in musteriListesi)
            {
                
                if(numara == item.numara && isim == item.isim && soyisim == item.soyisim && hizmet == item.hizmet && guzellikUzmani == item.guzellikUzmani && gun == item.gun && saat == item.saat && fiyat == item.fiyat)
                {
                    MessageBox.Show("Bu bilgilerde değişiklik yapmadınız.", "Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (numara == item.numara && isim == item.isim && soyisim == item.soyisim)
                {
                    item.hizmet = hizmet;
                    item.guzellikUzmani = guzellikUzmani;
                    item.gun = gun;
                    item.fiyat = fiyat;
                    item.saat = saat;
                    MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK);

                    //var olan değerlerin eşitliğini kontrol ettikten sonra yeni yazılanlara eşitler.
                }
                else if (numara != item.numara)
                {
                    MessageBox.Show("Bu kişinin güncellenecek bir randevusu bulunmamaktadır.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }

        }
        
        public void sil(ListBox list)
        {
            if (list.SelectedItem != null) { 
            string[] veriler = list.SelectedItem.ToString().Split("\t"); //yukarıda alt alta yazdığımız değerleri split ile bir diziye atadı
                                                                         //sonra bu dizi içerisindeki 2 indeksli(numara) metodun parametresine
                                                                         //eşit bir değerse silmesini söyledik.

            Musteri silinecekMusteri = null;

            foreach (Musteri item in musteriListesi)
            {
                if (veriler[2] == item.numara)
                {
                    silinecekMusteri = item;
                }
            }

            musteriListesi.Remove(silinecekMusteri);
            }
            else
            {
                MessageBox.Show("Listeden bir eleman seçmediniz.","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        
        public ArrayList hepsiniGoruntule()
        {
            return musteriListesi;      //listeyi başka classta görmemiz için listeyi döndürür.
        }
    }
}
