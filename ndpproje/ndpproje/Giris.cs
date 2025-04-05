/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........:3
**				ÖÐRENCÝ ADI............:Elif Ranagül Akyol
**				ÖÐRENCÝ NUMARASI.......:B231210092
**              DERSÝN ALINDIÐI GRUP...:A
****************************************************************************/


using System.Diagnostics.Eventing.Reader;

namespace ndpproje
{
    public partial class Giris : Form
    {
        Yonetim yonetim;
        public Giris(Yonetim yonetim)       //program.cs de oluþturduðumuz yonetim nesnesini buraya aktardýk
            //müþteri ve personelin girdiði bilgileri bir arada tutmak için yaptýk
        {
            InitializeComponent();
            this.yonetim = yonetim;
        }

        public void girisButton_Click(object sender, EventArgs e)
        {
            string isim = isimText.Text.ToString();
            string soyisim = soyisimText.Text.ToString();
            string numara = numaraText.Text.ToString();

            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(numara))
            {
                if (isimText.Text == "Elif Ranagül" && soyisimText.Text == "Akyol" && numaraText.Text == "05061901370")
                {
                    personelGirisi personelGirisi = new personelGirisi(yonetim);        //yönetici iççin özel isim numara verdik gerekli kontrollerden
                                                                                        //sonra yeni bir personel sayfasý açtýk ve arraylist için
                                                                                        //yonetim nesnesini parametre olarak verdik
                    personelGirisi.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Girdiðiniz bilgiler bir personele ait deðildir","Uyarý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                return;
            }
            else
            {
                MessageBox.Show("Lütfen boþ alanlarý doldurunuz", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void musteriGiris_Click(object sender, EventArgs e)
        {
            
            string isim=isimText.Text.ToString();
            string soyisim = soyisimText.Text.ToString();
            string numara = numaraText.Text.ToString();

            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(numara) )
            {
                
                musteriGirisi musteriGirisi = new musteriGirisi(yonetim);           //yeni müþteri sayfasý açýlacak
                musteriGirisi.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Lütfen boþ alanlarý doldurunuz.", "Uyarý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               

            }
           
            
            
        }
        

    }
}
