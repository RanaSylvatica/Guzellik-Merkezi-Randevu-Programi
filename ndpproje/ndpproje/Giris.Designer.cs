namespace ndpproje
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            girisButton = new Button();
            numaraText = new TextBox();
            soyisimText = new TextBox();
            isimText = new TextBox();
            isimLabel = new Label();
            soyisimLabel = new Label();
            numaraLabel = new Label();
            musteriGiris = new Button();
            SuspendLayout();
            // 
            // girisButton
            // 
            girisButton.Location = new Point(268, 314);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(105, 54);
            girisButton.TabIndex = 4;
            girisButton.Text = "Personel Girişi";
            girisButton.UseVisualStyleBackColor = true;
            girisButton.Click += girisButton_Click;
            // 
            // numaraText
            // 
            numaraText.Location = new Point(349, 225);
            numaraText.Name = "numaraText";
            numaraText.Size = new Size(162, 27);
            numaraText.TabIndex = 3;
            // 
            // soyisimText
            // 
            soyisimText.Location = new Point(349, 153);
            soyisimText.Name = "soyisimText";
            soyisimText.Size = new Size(162, 27);
            soyisimText.TabIndex = 2;
            // 
            // isimText
            // 
            isimText.Location = new Point(347, 80);
            isimText.Name = "isimText";
            isimText.Size = new Size(164, 27);
            isimText.TabIndex = 1;
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Location = new Point(294, 83);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new Size(39, 20);
            isimLabel.TabIndex = 4;
            isimLabel.Text = "İsim:";
            // 
            // soyisimLabel
            // 
            soyisimLabel.AutoSize = true;
            soyisimLabel.Location = new Point(270, 156);
            soyisimLabel.Name = "soyisimLabel";
            soyisimLabel.Size = new Size(63, 20);
            soyisimLabel.TabIndex = 5;
            soyisimLabel.Text = "Soyisim:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.Location = new Point(268, 228);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new Size(65, 20);
            numaraLabel.TabIndex = 6;
            numaraLabel.Text = "Numara:";
            // 
            // musteriGiris
            // 
            musteriGiris.Location = new Point(406, 314);
            musteriGiris.Name = "musteriGiris";
            musteriGiris.Size = new Size(105, 54);
            musteriGiris.TabIndex = 5;
            musteriGiris.Text = "   Müşteri   Girişi";
            musteriGiris.UseVisualStyleBackColor = true;
            musteriGiris.Click += musteriGiris_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(musteriGiris);
            Controls.Add(numaraLabel);
            Controls.Add(soyisimLabel);
            Controls.Add(isimLabel);
            Controls.Add(isimText);
            Controls.Add(soyisimText);
            Controls.Add(numaraText);
            Controls.Add(girisButton);
            Name = "Giris";
            Text = "Giriş ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisButton;
        private TextBox numaraText;
        private TextBox soyisimText;
        private TextBox isimText;
        private Label isimLabel;
        private Label soyisimLabel;
        private Label numaraLabel;
        private Button musteriGiris;
    }
}
