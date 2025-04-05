
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
namespace ndpproje
{
    partial class personelGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            isimText = new TextBox();
            soyisimText = new TextBox();
            numaraText = new TextBox();
            musteriLabel = new Label();
            isimLabel = new Label();
            soyisimLabel = new Label();
            numaraLabel = new Label();
            label4 = new Label();
            guzellikUzmaniLabel = new Label();
            gunLabel = new Label();
            saatLabel = new Label();
            fiyatLabel = new Label();
            kaydetButton = new Button();
            guncelleButton = new Button();
            silButton = new Button();
            goruntuleButton = new Button();
            goruntuleList = new ListBox();
            fiyatCombo = new ComboBox();
            saatCombo = new ComboBox();
            gunCombo = new ComboBox();
            guzellikUzmaniCombo = new ComboBox();
            hizmetCombo = new ComboBox();
            donButton = new Button();
            SuspendLayout();
            // 
            // isimText
            // 
            isimText.Location = new Point(135, 51);
            isimText.Name = "isimText";
            isimText.Size = new Size(164, 27);
            isimText.TabIndex = 0;
            isimText.TextChanged += isimText_TextChanged;
            // 
            // soyisimText
            // 
            soyisimText.Location = new Point(135, 120);
            soyisimText.Name = "soyisimText";
            soyisimText.Size = new Size(164, 27);
            soyisimText.TabIndex = 1;
            // 
            // numaraText
            // 
            numaraText.Location = new Point(135, 202);
            numaraText.Name = "numaraText";
            numaraText.Size = new Size(164, 27);
            numaraText.TabIndex = 2;
            // 
            // musteriLabel
            // 
            musteriLabel.AutoSize = true;
            musteriLabel.Location = new Point(343, 9);
            musteriLabel.Name = "musteriLabel";
            musteriLabel.Size = new Size(135, 20);
            musteriLabel.TabIndex = 8;
            musteriLabel.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Location = new Point(61, 54);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new Size(39, 20);
            isimLabel.TabIndex = 9;
            isimLabel.Text = "İsim:";
            // 
            // soyisimLabel
            // 
            soyisimLabel.AutoSize = true;
            soyisimLabel.Location = new Point(37, 123);
            soyisimLabel.Name = "soyisimLabel";
            soyisimLabel.Size = new Size(63, 20);
            soyisimLabel.TabIndex = 10;
            soyisimLabel.Text = "Soyisim:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.Location = new Point(35, 205);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new Size(65, 20);
            numaraLabel.TabIndex = 11;
            numaraLabel.Text = "Numara:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 289);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 12;
            label4.Text = "Hizmet:";
            // 
            // guzellikUzmaniLabel
            // 
            guzellikUzmaniLabel.AutoSize = true;
            guzellikUzmaniLabel.Location = new Point(419, 49);
            guzellikUzmaniLabel.Name = "guzellikUzmaniLabel";
            guzellikUzmaniLabel.Size = new Size(118, 20);
            guzellikUzmaniLabel.TabIndex = 13;
            guzellikUzmaniLabel.Text = "Güzellik Uzmanı:";
            // 
            // gunLabel
            // 
            gunLabel.AutoSize = true;
            gunLabel.Location = new Point(499, 123);
            gunLabel.Name = "gunLabel";
            gunLabel.Size = new Size(38, 20);
            gunLabel.TabIndex = 14;
            gunLabel.Text = "Gün:";
            // 
            // saatLabel
            // 
            saatLabel.AutoSize = true;
            saatLabel.Location = new Point(496, 205);
            saatLabel.Name = "saatLabel";
            saatLabel.Size = new Size(41, 20);
            saatLabel.TabIndex = 15;
            saatLabel.Text = "Saat:";
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new Point(494, 289);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new Size(43, 20);
            fiyatLabel.TabIndex = 16;
            fiyatLabel.Text = "Fiyat:";
            // 
            // kaydetButton
            // 
            kaydetButton.Location = new Point(12, 350);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(125, 29);
            kaydetButton.TabIndex = 8;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // guncelleButton
            // 
            guncelleButton.Location = new Point(165, 350);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(116, 29);
            guncelleButton.TabIndex = 9;
            guncelleButton.Text = "Güncelle";
            guncelleButton.UseVisualStyleBackColor = true;
            guncelleButton.Click += guncelleButton_Click;
            // 
            // silButton
            // 
            silButton.Location = new Point(431, 350);
            silButton.Name = "silButton";
            silButton.Size = new Size(106, 29);
            silButton.TabIndex = 11;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = true;
            silButton.Click += silButton_Click;
            // 
            // goruntuleButton
            // 
            goruntuleButton.Location = new Point(309, 350);
            goruntuleButton.Name = "goruntuleButton";
            goruntuleButton.Size = new Size(94, 29);
            goruntuleButton.TabIndex = 10;
            goruntuleButton.Text = "Görüntüle";
            goruntuleButton.UseVisualStyleBackColor = true;
            goruntuleButton.Click += goruntuleButton_Click;
            // 
            // goruntuleList
            // 
            goruntuleList.FormattingEnabled = true;
            goruntuleList.Location = new Point(12, 400);
            goruntuleList.Name = "goruntuleList";
            goruntuleList.Size = new Size(733, 284);
            goruntuleList.TabIndex = 21;
            // 
            // fiyatCombo
            // 
            fiyatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            fiyatCombo.FormattingEnabled = true;
            fiyatCombo.Location = new Point(581, 286);
            fiyatCombo.Name = "fiyatCombo";
            fiyatCombo.Size = new Size(164, 28);
            fiyatCombo.TabIndex = 7;
            fiyatCombo.SelectedIndexChanged += fiyatCombo_SelectedIndexChanged;
            // 
            // saatCombo
            // 
            saatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            saatCombo.FormattingEnabled = true;
            saatCombo.Location = new Point(581, 202);
            saatCombo.Name = "saatCombo";
            saatCombo.Size = new Size(164, 28);
            saatCombo.TabIndex = 6;
            // 
            // gunCombo
            // 
            gunCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gunCombo.FormattingEnabled = true;
            gunCombo.Location = new Point(581, 120);
            gunCombo.Name = "gunCombo";
            gunCombo.Size = new Size(164, 28);
            gunCombo.TabIndex = 5;
            // 
            // guzellikUzmaniCombo
            // 
            guzellikUzmaniCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            guzellikUzmaniCombo.FormattingEnabled = true;
            guzellikUzmaniCombo.Location = new Point(918, 498);
            guzellikUzmaniCombo.Name = "guzellikUzmaniCombo";
            guzellikUzmaniCombo.Size = new Size(164, 28);
            guzellikUzmaniCombo.TabIndex = 4;
            guzellikUzmaniCombo.SelectedIndexChanged += guzellikUzmaniCombo_SelectedIndexChanged;
            // 
            // hizmetCombo
            // 
            hizmetCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            hizmetCombo.FormattingEnabled = true;
            hizmetCombo.Location = new Point(135, 286);
            hizmetCombo.Name = "hizmetCombo";
            hizmetCombo.Size = new Size(164, 28);
            hizmetCombo.TabIndex = 3;
            hizmetCombo.SelectedIndexChanged += hizmetCombo_SelectedIndexChanged;
            // 
            // donButton
            // 
            donButton.Location = new Point(590, 350);
            donButton.Name = "donButton";
            donButton.Size = new Size(155, 29);
            donButton.TabIndex = 12;
            donButton.Text = "Giriş Sayfasına Dön";
            donButton.UseVisualStyleBackColor = true;
            donButton.Click += donButton_Click;
            // 
            // personelGirisi
            // 
            AcceptButton = kaydetButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 696);
            Controls.Add(donButton);
            Controls.Add(hizmetCombo);
            Controls.Add(guzellikUzmaniCombo);
            Controls.Add(gunCombo);
            Controls.Add(saatCombo);
            Controls.Add(fiyatCombo);
            Controls.Add(goruntuleList);
            Controls.Add(goruntuleButton);
            Controls.Add(silButton);
            Controls.Add(guncelleButton);
            Controls.Add(kaydetButton);
            Controls.Add(fiyatLabel);
            Controls.Add(saatLabel);
            Controls.Add(gunLabel);
            Controls.Add(guzellikUzmaniLabel);
            Controls.Add(label4);
            Controls.Add(numaraLabel);
            Controls.Add(soyisimLabel);
            Controls.Add(isimLabel);
            Controls.Add(musteriLabel);
            Controls.Add(numaraText);
            Controls.Add(soyisimText);
            Controls.Add(isimText);
            Name = "personelGirisi";
            Text = "Personel Girişi";
            Load += personelGirisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isimText;
        private TextBox soyisimText;
        private TextBox numaraText;
        private Label musteriLabel;
        private Label isimLabel;
        private Label soyisimLabel;
        private Label numaraLabel;
        private Label label4;
        private Label guzellikUzmaniLabel;
        private Label gunLabel;
        private Label saatLabel;
        private Label fiyatLabel;
        private Button kaydetButton;
        private Button guncelleButton;
        private Button silButton;
        private Button goruntuleButton;
        private ListBox goruntuleList;
        private ComboBox fiyatCombo;
        private ComboBox saatCombo;
        private ComboBox gunCombo;
        private ComboBox guzellikUzmaniCombo;
        private ComboBox hizmetCombo;
        private Button donButton;
    }
}