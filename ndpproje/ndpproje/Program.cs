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

//giri�,personel, m��teri sayfalar� her �al��t���nda yeni bir arraylist olu�maktad�r. bilgi kayb�n� engellemek i�in hepsindeki bilgileri
//program ba�lat�ld���nda olu�turacak program.cs deki arrayliste g�nderiyor.