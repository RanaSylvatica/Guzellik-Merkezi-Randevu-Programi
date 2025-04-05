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

****************************************************************************/namespace ndpproje
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Yonetim yonetim=new Yonetim();      
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Giris(yonetim));        


        }
    }
}

//giriþ,personel, müþteri sayfalarý her çalýþtýðýnda yeni bir arraylist oluþmaktadýr. bilgi kaybýný engellemek için hepsindeki bilgileri
//program baþlatýldýðýnda oluþturacak program.cs deki arrayliste gönderiyor.