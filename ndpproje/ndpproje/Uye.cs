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
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ndpproje
{
    public class Uye        //müşterilerin classıdır
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string numara { get; set; }
        public string hizmet { get; set; }
        public string gun { get; set; }
        public string saat { get; set; }
        public string guzellikUzmani { get; set; }
        public string fiyat { get; set; }

        

    }

    public interface IYetki         //bazı yetki metodları
    {
        public void guncelle();
        public void sil();
        public void goruntule();
    }
}
