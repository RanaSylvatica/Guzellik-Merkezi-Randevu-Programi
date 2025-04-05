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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndpproje
{
    public partial class musteriGirisi : Form

    {
        Yonetim yonetim;
        public musteriGirisi(Yonetim yonetim)
        {
            InitializeComponent();                  //girisin kurucu fonksiyonuna parametre gönderik ki buradaki bilgileri de tutsun
            this.yonetim = yonetim;
        }
       

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            


            if (isimText.Text == null || soyisimText.Text == null || numaraText.Text == null || hizmetCombo.SelectedItem == null || guzellikUzmaniCombo.SelectedItem == null || fiyatCombo.SelectedItem == null || gunCombo.SelectedItem == null || saatCombo.SelectedItem == null)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string dataIsim = isimText.Text;
                string dataSoyisim = soyisimText.Text;
                string dataNumara = numaraText.Text;
                string dataHizmet = hizmetCombo.SelectedItem.ToString();
                string dataFiyat = fiyatCombo.SelectedItem.ToString();
                string dataGun = gunCombo.SelectedItem.ToString();
                string dataSaat = saatCombo.SelectedItem.ToString();
                string dataGuzellikUzmani = guzellikUzmaniCombo.SelectedItem.ToString();


                foreach (Musteri item in yonetim.hepsiniGoruntule())
                {
                     if (item.gun == dataGun && item.saat == dataSaat && item.numara == dataNumara)
                    {
                        MessageBox.Show("Bu kişinin seçilen günde ve saatte zaten bir randevusu bulunmaktadır.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                foreach (Musteri item in yonetim.hepsiniGoruntule())
                {
                    if (item.hizmet == dataHizmet && item.saat == dataSaat && item.gun == dataGun && item.guzellikUzmani == dataGuzellikUzmani)
                    {
                        MessageBox.Show("Bu randevu doludur.");
                        return;

                    }
                }

           
                personelGirisi PersonelGirisi = new personelGirisi(yonetim);
                yonetim = PersonelGirisi.SetData(dataIsim, dataSoyisim, dataNumara, dataHizmet, dataGuzellikUzmani, dataGun, dataSaat, dataFiyat);
            }
            //burada önce girilen bilgileri personel classına gönderdik ve dataBase de yeni müşteri oluşturuldu
            //return ile döndürdüğümüz yonetim değerini burdaki yonetime eşitledik

            

            isimText.Text = null;
            soyisimText.Text = null;
            numaraText.Text = null;
            saatCombo.SelectedItem = null;
            hizmetCombo.SelectedItem = null;
            gunCombo.SelectedItem = null;
            guzellikUzmaniCombo.SelectedItem = null;
            fiyatCombo.SelectedItem = null;

        }

        private void donButton_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris(yonetim);           //geriye dönmek içib yeni giriş sayfası tanımladık
            giris.Show();
            this.Hide();

        }

        private void musteriGirisi_Load(object sender, EventArgs e)
        {
            hizmetCombo.Items.Add("Cilt Bakımı");
            hizmetCombo.Items.Add("Manikür/Pedikür");
            hizmetCombo.Items.Add("Makyaj");
            hizmetCombo.Items.Add("İpek Kirpik");
            hizmetCombo.Items.Add("Kalıcı Oje");
            hizmetCombo.Items.Add("Epilasyon");

            saatCombo.Items.Add("10.00 - 11.00");
            saatCombo.Items.Add("11.00 - 12.00");
            saatCombo.Items.Add("12.00 - 13.00");
            saatCombo.Items.Add("14.00 - 15.00");
            saatCombo.Items.Add("15.00 - 16.00");
            saatCombo.Items.Add("16.00 - 17.00");
            saatCombo.Items.Add("17.00 - 18.00");
            saatCombo.Items.Add("18.00 - 19.00");
            saatCombo.Items.Add("19.00 - 20.00");

            gunCombo.Items.Add("Pazartesi");
            gunCombo.Items.Add("Salı");
            gunCombo.Items.Add("Çarşamba");
            gunCombo.Items.Add("Perşembe");
            gunCombo.Items.Add("Cuma");
            gunCombo.Items.Add("Cumartesi");
        }

        private void hizmetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            guzellikUzmaniCombo.SelectedItem = null;        //seçilen hizmete göre fiyatlar değişiklik göstermektedir
            if (hizmetCombo.Text == "Epilasyon")
            {
                fiyatCombo.Items.Clear();
                fiyatCombo.Items.Add("1500 TL");
                fiyatCombo.Items.Add("2200 TL");

            }
            else if (hizmetCombo.Text == "Cilt Bakımı")
            {
                fiyatCombo.Items.Clear();
                fiyatCombo.Items.Add("100 TL");
                fiyatCombo.Items.Add("300 TL");

            }
            else if (hizmetCombo.Text == "Manikür/Pedikür")
            {
                fiyatCombo.Items.Clear();
                fiyatCombo.Items.Add("200 TL");
                fiyatCombo.Items.Add("300 TL");

            }
            else if (hizmetCombo.Text == "İpek Kirpik")
            {
                fiyatCombo.Items.Clear();
                fiyatCombo.Items.Add("500 TL");
                fiyatCombo.Items.Add("700 TL");

            }
            else if (hizmetCombo.Text == "Kalıcı Oje")
            {
                fiyatCombo.Items.Clear();
                fiyatCombo.Items.Add("700 TL");
                fiyatCombo.Items.Add("1000 TL");

            }
            else if (hizmetCombo.Text == "Makyaj")
            {
                fiyatCombo.Items.Clear();
                fiyatCombo.Items.Add("200 TL");
                fiyatCombo.Items.Add("400 TL");

            }




            if (hizmetCombo.SelectedItem == "Epilasyon")
            {
                guzellikUzmaniCombo.Items.Clear();
                guzellikUzmaniCombo.Items.Add("Serra Hanım");
                guzellikUzmaniCombo.Items.Add("Feyyaz Bey");

            }
            else if (hizmetCombo.SelectedItem == "Cilt Bakımı")
            {
                guzellikUzmaniCombo.Items.Clear();
                guzellikUzmaniCombo.Items.Add("Betül Hanım");
                guzellikUzmaniCombo.Items.Add("Yiğit Bey");
                guzellikUzmaniCombo.Items.Add("Yıldız Hanım");


            }
            else if (hizmetCombo.SelectedItem == "Makyaj")
            {
                guzellikUzmaniCombo.Items.Clear();
                guzellikUzmaniCombo.Items.Add("Şila Hanım");
                guzellikUzmaniCombo.Items.Add("Mert Bey");
                guzellikUzmaniCombo.Items.Add("Melis Hanım");


            }
            else if (hizmetCombo.SelectedItem == "Manikür/Pedikür")
            {
                guzellikUzmaniCombo.Items.Clear();
                guzellikUzmaniCombo.Items.Add("Elif Hanım");
                guzellikUzmaniCombo.Items.Add("Şükran Hanım");
                guzellikUzmaniCombo.Items.Add("Melek Hanım");
                guzellikUzmaniCombo.Items.Add("Pelin Hanım");
            }
            else if (hizmetCombo.SelectedItem == "İpek Kirpik")
            {
                guzellikUzmaniCombo.Items.Clear();
                guzellikUzmaniCombo.Items.Add("Tülay Hanım");
                guzellikUzmaniCombo.Items.Add("Kemal Bey");
                guzellikUzmaniCombo.Items.Add("Tuna Bey");
                guzellikUzmaniCombo.Items.Add("Kerim Bey");


            }
            else if (hizmetCombo.SelectedItem == "Kalıcı Oje")
            {
                guzellikUzmaniCombo.Items.Clear();
                guzellikUzmaniCombo.Items.Add("Rana Hanım");
                guzellikUzmaniCombo.Items.Add("Abdullah Bey");
                guzellikUzmaniCombo.Items.Add("Mete Bey");
                guzellikUzmaniCombo.Items.Add("Yıldız Hanım");


            }
        }

        private void fiyatCombo_SelectedIndexChanged(object sender, EventArgs e) //seçilen fiyatlara göre verilen hizmetlerin bilgilendirmesini yapar
        {
             if (hizmetCombo.SelectedItem == "Epilasyon")
            {
                if (fiyatCombo.SelectedItem == "1500 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\nYüz, kol ve bacak epilasyonu.", "Bilgilendirme", MessageBoxButtons.OK);

                }
                else if (fiyatCombo.SelectedItem == "2200 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\nTüm vücut epilasyon, dilediğiniz bölgeler içerikten çıkarılır.", "Bilgilendirme.", MessageBoxButtons.OK);
                }

            }
            if (hizmetCombo.SelectedItem == "Cilt Bakımı")
            {
                if (fiyatCombo.SelectedItem == "100 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n1. Yağ terapisi.\n2. Leke giderme.\n3. Nemlendirme.", "Bilgilendirme", MessageBoxButtons.OK);

                }
                else if (fiyatCombo.SelectedItem == "300 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n 1. Yağ terapisi.\n2. Yüz masajı.\n3. Leke giderme operasyonu.\n4. Göz altı aydınlatma.\n5. Yoğun nemlendirme.", "Bilgilendirme.", MessageBoxButtons.OK);
                }


            }
            if (hizmetCombo.SelectedItem == "Manikür / Pedikür")
            {
                if (fiyatCombo.SelectedItem == "200 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n1. El/ayak tırnak şekillendirme ve parlatma.\n2. Nemlendirme.", "Bilgilendirme", MessageBoxButtons.OK);

                }
                else if (fiyatCombo.SelectedItem == "300 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n1. El/ayak tırnak şekillendirme, bakım ve parlatma.\n2. El/ayak masajı.\n3. Yoğun nemlendirme. ", "Bilgilendirme.", MessageBoxButtons.OK);
                }

            }
            if (hizmetCombo.SelectedItem == "İpek Kirpik")
            {
                if (fiyatCombo.SelectedItem == "500 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\nİpek kirpik yapımı.", "Bilgilendirme", MessageBoxButtons.OK);

                }
                else if (fiyatCombo.SelectedItem == "700 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n İpek kirpik yapımının yanı sıra kirpik dolgunlaştırma işlemimiz mevcuttur.", "Bilgilendirme.", MessageBoxButtons.OK);
                }

            }
            if (hizmetCombo.SelectedItem == "Kalıcı Oje")
            {
                if (fiyatCombo.SelectedItem == "700 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n1. Tırnak şekillendirme\n 2. Kalıcı oje yapımı (Yalnızca renk seçimi yapılabilir.)", "Bilgilendirme", MessageBoxButtons.OK);

                }
                else if (fiyatCombo.SelectedItem == "1000 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n 1. Tırnak şekillendirme.\n 2. Kalıcı oje ve istediğiniz desen, taş, parlatma.", "Bilgilendirme.", MessageBoxButtons.OK);
                }

            }
            if (hizmetCombo.SelectedItem == "Makyaj")
            {
                if (fiyatCombo.SelectedItem == "200 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\nNormal günlük makyaj yapılır.", "Bilgilendirme", MessageBoxButtons.OK);

                }
                else if (fiyatCombo.SelectedItem == "400 TL")
                {
                    MessageBox.Show("Seçtiğiniz fiyatın içeriği şu şekildedir:\n1. Düğün/özel gün makyajı yapılır.\n2. Glitter pakete dahildir.", "Bilgilendirme.", MessageBoxButtons.OK);
                }

            }
        }
    }
}
