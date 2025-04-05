/****************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2023-2024 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........:3
**				��RENC� ADI............:Elif Ranag�l Akyol
**				��RENC� NUMARASI.......:B231210092
**              DERS�N ALINDI�I GRUP...:A
****************************************************************************/


using System.Diagnostics.Eventing.Reader;

namespace ndpproje
{
    public partial class Giris : Form
    {
        Yonetim yonetim;
        public Giris(Yonetim yonetim)       //program.cs de olu�turdu�umuz yonetim nesnesini buraya aktard�k
            //m��teri ve personelin girdi�i bilgileri bir arada tutmak i�in yapt�k
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
                if (isimText.Text == "Elif Ranag�l" && soyisimText.Text == "Akyol" && numaraText.Text == "05061901370")
                {
                    personelGirisi personelGirisi = new personelGirisi(yonetim);        //y�netici i��in �zel isim numara verdik gerekli kontrollerden
                                                                                        //sonra yeni bir personel sayfas� a�t�k ve arraylist i�in
                                                                                        //yonetim nesnesini parametre olarak verdik
                    personelGirisi.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Girdi�iniz bilgiler bir personele ait de�ildir","Uyar�",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                return;
            }
            else
            {
                MessageBox.Show("L�tfen bo� alanlar� doldurunuz", "Uyar�!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void musteriGiris_Click(object sender, EventArgs e)
        {
            
            string isim=isimText.Text.ToString();
            string soyisim = soyisimText.Text.ToString();
            string numara = numaraText.Text.ToString();

            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) && !string.IsNullOrEmpty(numara) )
            {
                
                musteriGirisi musteriGirisi = new musteriGirisi(yonetim);           //yeni m��teri sayfas� a��lacak
                musteriGirisi.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("L�tfen bo� alanlar� doldurunuz.", "Uyar�!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               

            }
           
            
            
        }
        

    }
}
