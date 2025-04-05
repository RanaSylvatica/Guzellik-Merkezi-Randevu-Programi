
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
    partial class musteriGirisi
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
            isimLabel = new Label();
            soyiyimLabel = new Label();
            numaraLabel = new Label();
            hizmetLabel = new Label();
            GuzellikUzmaniLabel = new Label();
            fiyatLabel = new Label();
            gunLabel = new Label();
            saatLabel = new Label();
            isimText = new TextBox();
            soyisimText = new TextBox();
            numaraText = new TextBox();
            hizmetCombo = new ComboBox();
            guzellikUzmaniCombo = new ComboBox();
            fiyatCombo = new ComboBox();
            gunCombo = new ComboBox();
            saatCombo = new ComboBox();
            kaydetButton = new Button();
            donButton = new Button();
            SuspendLayout();
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Location = new Point(63, 37);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new Size(39, 20);
            isimLabel.TabIndex = 0;
            isimLabel.Text = "İsim:";
            // 
            // soyiyimLabel
            // 
            soyiyimLabel.AutoSize = true;
            soyiyimLabel.Location = new Point(58, 90);
            soyiyimLabel.Name = "soyiyimLabel";
            soyiyimLabel.Size = new Size(63, 20);
            soyiyimLabel.TabIndex = 1;
            soyiyimLabel.Text = "Soyisim:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.Location = new Point(58, 149);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new Size(65, 20);
            numaraLabel.TabIndex = 2;
            numaraLabel.Text = "Numara:";
            // 
            // hizmetLabel
            // 
            hizmetLabel.AutoSize = true;
            hizmetLabel.Location = new Point(63, 209);
            hizmetLabel.Name = "hizmetLabel";
            hizmetLabel.Size = new Size(60, 20);
            hizmetLabel.TabIndex = 3;
            hizmetLabel.Text = "Hizmet:";
            // 
            // GuzellikUzmaniLabel
            // 
            GuzellikUzmaniLabel.AutoSize = true;
            GuzellikUzmaniLabel.Location = new Point(327, 40);
            GuzellikUzmaniLabel.Name = "GuzellikUzmaniLabel";
            GuzellikUzmaniLabel.Size = new Size(118, 20);
            GuzellikUzmaniLabel.TabIndex = 4;
            GuzellikUzmaniLabel.Text = "Güzellik Uzmanı:";
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new Point(402, 90);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new Size(43, 20);
            fiyatLabel.TabIndex = 5;
            fiyatLabel.Text = "Fiyat:";
            // 
            // gunLabel
            // 
            gunLabel.AutoSize = true;
            gunLabel.Location = new Point(407, 149);
            gunLabel.Name = "gunLabel";
            gunLabel.Size = new Size(38, 20);
            gunLabel.TabIndex = 6;
            gunLabel.Text = "Gün:";
            // 
            // saatLabel
            // 
            saatLabel.AutoSize = true;
            saatLabel.Location = new Point(404, 212);
            saatLabel.Name = "saatLabel";
            saatLabel.Size = new Size(41, 20);
            saatLabel.TabIndex = 7;
            saatLabel.Text = "Saat:";
            // 
            // isimText
            // 
            isimText.Location = new Point(146, 37);
            isimText.Name = "isimText";
            isimText.Size = new Size(151, 27);
            isimText.TabIndex = 1;
            // 
            // soyisimText
            // 
            soyisimText.Location = new Point(146, 87);
            soyisimText.Name = "soyisimText";
            soyisimText.Size = new Size(151, 27);
            soyisimText.TabIndex = 2;
            // 
            // numaraText
            // 
            numaraText.Location = new Point(146, 147);
            numaraText.Name = "numaraText";
            numaraText.Size = new Size(151, 27);
            numaraText.TabIndex = 3;
            // 
            // hizmetCombo
            // 
            hizmetCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            hizmetCombo.FormattingEnabled = true;
            hizmetCombo.Location = new Point(146, 209);
            hizmetCombo.Name = "hizmetCombo";
            hizmetCombo.Size = new Size(151, 28);
            hizmetCombo.TabIndex = 4;
            hizmetCombo.SelectedIndexChanged += hizmetCombo_SelectedIndexChanged;
            // 
            // guzellikUzmaniCombo
            // 
            guzellikUzmaniCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            guzellikUzmaniCombo.FormattingEnabled = true;
            guzellikUzmaniCombo.Location = new Point(477, 34);
            guzellikUzmaniCombo.Name = "guzellikUzmaniCombo";
            guzellikUzmaniCombo.Size = new Size(151, 28);
            guzellikUzmaniCombo.TabIndex = 5;
            // 
            // fiyatCombo
            // 
            fiyatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            fiyatCombo.FormattingEnabled = true;
            fiyatCombo.Location = new Point(477, 87);
            fiyatCombo.Name = "fiyatCombo";
            fiyatCombo.Size = new Size(151, 28);
            fiyatCombo.TabIndex = 6;
            fiyatCombo.SelectedIndexChanged += fiyatCombo_SelectedIndexChanged;
            // 
            // gunCombo
            // 
            gunCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            gunCombo.FormattingEnabled = true;
            gunCombo.Location = new Point(477, 146);
            gunCombo.Name = "gunCombo";
            gunCombo.Size = new Size(151, 28);
            gunCombo.TabIndex = 7;
            // 
            // saatCombo
            // 
            saatCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            saatCombo.FormattingEnabled = true;
            saatCombo.Location = new Point(477, 209);
            saatCombo.Name = "saatCombo";
            saatCombo.Size = new Size(151, 28);
            saatCombo.TabIndex = 8;
            // 
            // kaydetButton
            // 
            kaydetButton.Location = new Point(260, 282);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(216, 29);
            kaydetButton.TabIndex = 9;
            kaydetButton.Text = "Kaydet";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // donButton
            // 
            donButton.Location = new Point(260, 331);
            donButton.Name = "donButton";
            donButton.Size = new Size(216, 29);
            donButton.TabIndex = 20;
            donButton.Text = "Giriş Sayfasına Dön";
            donButton.UseVisualStyleBackColor = true;
            donButton.Click += donButton_Click;
            // 
            // musteriGirisi
            // 
            AcceptButton = kaydetButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 387);
            Controls.Add(donButton);
            Controls.Add(kaydetButton);
            Controls.Add(saatCombo);
            Controls.Add(gunCombo);
            Controls.Add(fiyatCombo);
            Controls.Add(guzellikUzmaniCombo);
            Controls.Add(hizmetCombo);
            Controls.Add(numaraText);
            Controls.Add(soyisimText);
            Controls.Add(isimText);
            Controls.Add(saatLabel);
            Controls.Add(gunLabel);
            Controls.Add(fiyatLabel);
            Controls.Add(GuzellikUzmaniLabel);
            Controls.Add(hizmetLabel);
            Controls.Add(numaraLabel);
            Controls.Add(soyiyimLabel);
            Controls.Add(isimLabel);
            Name = "musteriGirisi";
            Text = "Müşteri Girişi";
            Load += musteriGirisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label isimLabel;
        private Label soyiyimLabel;
        private Label numaraLabel;
        private Label hizmetLabel;
        private Label GuzellikUzmaniLabel;
        private Label fiyatLabel;
        private Label gunLabel;
        private Label saatLabel;
        private TextBox isimText;
        private TextBox soyisimText;
        private TextBox numaraText;
        private ComboBox hizmetCombo;
        private ComboBox guzellikUzmaniCombo;
        private ComboBox fiyatCombo;
        private ComboBox gunCombo;
        private ComboBox saatCombo;
        private Button kaydetButton;
        private Button donButton;
    }
}