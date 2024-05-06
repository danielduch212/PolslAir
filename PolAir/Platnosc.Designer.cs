
namespace PolAir
{
    partial class Platnosc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.glownyText = new System.Windows.Forms.Label();
            this.TAK = new System.Windows.Forms.Button();
            this.NIE = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nrBlik = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NIE2 = new System.Windows.Forms.Button();
            this.TAK2 = new System.Windows.Forms.Button();
            this.OdrzucZakup = new System.Windows.Forms.Button();
            this.nieprawidlowyBlik = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textImie = new System.Windows.Forms.Label();
            this.textNazwisko = new System.Windows.Forms.Label();
            this.textSkad = new System.Windows.Forms.Label();
            this.textDokad = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.Label();
            this.textOdleglosc = new System.Windows.Forms.Label();
            this.textKoszt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.Label();
            this.akceptujBlik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(506, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(263, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(263, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(265, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skąd:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(263, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dokąd:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(263, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data:";
            // 
            // glownyText
            // 
            this.glownyText.AutoSize = true;
            this.glownyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.glownyText.Location = new System.Drawing.Point(528, 625);
            this.glownyText.Name = "glownyText";
            this.glownyText.Size = new System.Drawing.Size(308, 28);
            this.glownyText.TabIndex = 11;
            this.glownyText.Text = "Czy potwierdzasz zakup biletu?";
            // 
            // TAK
            // 
            this.TAK.Location = new System.Drawing.Point(476, 681);
            this.TAK.Name = "TAK";
            this.TAK.Size = new System.Drawing.Size(94, 29);
            this.TAK.TabIndex = 12;
            this.TAK.Text = "TAK";
            this.TAK.UseVisualStyleBackColor = true;
            this.TAK.Click += new System.EventHandler(this.TAK_Click);
            // 
            // NIE
            // 
            this.NIE.Location = new System.Drawing.Point(764, 681);
            this.NIE.Name = "NIE";
            this.NIE.Size = new System.Drawing.Size(94, 29);
            this.NIE.TabIndex = 13;
            this.NIE.Text = "NIE";
            this.NIE.UseVisualStyleBackColor = true;
            this.NIE.Click += new System.EventHandler(this.NIE_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(265, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Całkowity koszt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(146, 579);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 28);
            this.label9.TabIndex = 16;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nrBlik
            // 
            this.nrBlik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nrBlik.Location = new System.Drawing.Point(570, 681);
            this.nrBlik.Name = "nrBlik";
            this.nrBlik.Size = new System.Drawing.Size(188, 30);
            this.nrBlik.TabIndex = 17;
            this.nrBlik.Visible = false;
            this.nrBlik.TextChanged += new System.EventHandler(this.nrBlik_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(265, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Całkowita Odległość:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(265, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Czas odlotu:";
            // 
            // NIE2
            // 
            this.NIE2.BackColor = System.Drawing.Color.White;
            this.NIE2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NIE2.Location = new System.Drawing.Point(764, 681);
            this.NIE2.Name = "NIE2";
            this.NIE2.Size = new System.Drawing.Size(94, 29);
            this.NIE2.TabIndex = 22;
            this.NIE2.Text = "NIE";
            this.NIE2.UseVisualStyleBackColor = false;
            this.NIE2.Visible = false;
            this.NIE2.Click += new System.EventHandler(this.NIE2_Click);
            // 
            // TAK2
            // 
            this.TAK2.BackColor = System.Drawing.Color.White;
            this.TAK2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TAK2.Location = new System.Drawing.Point(470, 682);
            this.TAK2.Name = "TAK2";
            this.TAK2.Size = new System.Drawing.Size(94, 29);
            this.TAK2.TabIndex = 23;
            this.TAK2.Text = "TAK";
            this.TAK2.UseVisualStyleBackColor = false;
            this.TAK2.Visible = false;
            this.TAK2.Click += new System.EventHandler(this.TAK2_Click);
            // 
            // OdrzucZakup
            // 
            this.OdrzucZakup.BackColor = System.Drawing.Color.White;
            this.OdrzucZakup.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OdrzucZakup.Location = new System.Drawing.Point(857, 728);
            this.OdrzucZakup.Name = "OdrzucZakup";
            this.OdrzucZakup.Size = new System.Drawing.Size(169, 29);
            this.OdrzucZakup.TabIndex = 24;
            this.OdrzucZakup.Text = "Odrzuć zakup";
            this.OdrzucZakup.UseVisualStyleBackColor = false;
            this.OdrzucZakup.Visible = false;
            this.OdrzucZakup.Click += new System.EventHandler(this.OdrzucZakup_Click);
            // 
            // nieprawidlowyBlik
            // 
            this.nieprawidlowyBlik.AutoSize = true;
            this.nieprawidlowyBlik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nieprawidlowyBlik.ForeColor = System.Drawing.Color.Red;
            this.nieprawidlowyBlik.Location = new System.Drawing.Point(540, 597);
            this.nieprawidlowyBlik.Name = "nieprawidlowyBlik";
            this.nieprawidlowyBlik.Size = new System.Drawing.Size(275, 28);
            this.nieprawidlowyBlik.TabIndex = 25;
            this.nieprawidlowyBlik.Text = "Nieprawidłowy Numer Blik!";
            this.nieprawidlowyBlik.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(99, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 38);
            this.label11.TabIndex = 28;
            this.label11.Text = "Secure";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(52, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 62);
            this.label12.TabIndex = 27;
            this.label12.Text = "PolslAIR";
            // 
            // textImie
            // 
            this.textImie.AutoSize = true;
            this.textImie.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textImie.Location = new System.Drawing.Point(528, 201);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(67, 31);
            this.textImie.TabIndex = 29;
            this.textImie.Text = "Imie:";
            // 
            // textNazwisko
            // 
            this.textNazwisko.AutoSize = true;
            this.textNazwisko.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNazwisko.Location = new System.Drawing.Point(528, 253);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(67, 31);
            this.textNazwisko.TabIndex = 30;
            this.textNazwisko.Text = "Imie:";
            // 
            // textSkad
            // 
            this.textSkad.AutoSize = true;
            this.textSkad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textSkad.Location = new System.Drawing.Point(528, 304);
            this.textSkad.Name = "textSkad";
            this.textSkad.Size = new System.Drawing.Size(72, 31);
            this.textSkad.TabIndex = 31;
            this.textSkad.Text = "Skąd:";
            // 
            // textDokad
            // 
            this.textDokad.AutoSize = true;
            this.textDokad.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textDokad.Location = new System.Drawing.Point(528, 360);
            this.textDokad.Name = "textDokad";
            this.textDokad.Size = new System.Drawing.Size(90, 31);
            this.textDokad.TabIndex = 32;
            this.textDokad.Text = "Dokąd:";
            // 
            // textData
            // 
            this.textData.AutoSize = true;
            this.textData.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textData.Location = new System.Drawing.Point(528, 406);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(90, 31);
            this.textData.TabIndex = 33;
            this.textData.Text = "Dokąd:";
            // 
            // textOdleglosc
            // 
            this.textOdleglosc.AutoSize = true;
            this.textOdleglosc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textOdleglosc.Location = new System.Drawing.Point(528, 450);
            this.textOdleglosc.Name = "textOdleglosc";
            this.textOdleglosc.Size = new System.Drawing.Size(238, 31);
            this.textOdleglosc.TabIndex = 34;
            this.textOdleglosc.Text = "Całkowita Odległość:";
            this.textOdleglosc.Click += new System.EventHandler(this.textOdleglosc_Click);
            // 
            // textKoszt
            // 
            this.textKoszt.AutoSize = true;
            this.textKoszt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textKoszt.Location = new System.Drawing.Point(528, 494);
            this.textKoszt.Name = "textKoszt";
            this.textKoszt.Size = new System.Drawing.Size(238, 31);
            this.textKoszt.TabIndex = 35;
            this.textKoszt.Text = "Całkowita Odległość:";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(528, 541);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 31);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "12:00";
            // 
            // akceptujBlik
            // 
            this.akceptujBlik.BackColor = System.Drawing.Color.White;
            this.akceptujBlik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.akceptujBlik.Location = new System.Drawing.Point(586, 728);
            this.akceptujBlik.Name = "akceptujBlik";
            this.akceptujBlik.Size = new System.Drawing.Size(169, 29);
            this.akceptujBlik.TabIndex = 37;
            this.akceptujBlik.Text = "Akceptuj";
            this.akceptujBlik.UseVisualStyleBackColor = false;
            this.akceptujBlik.Visible = false;
            this.akceptujBlik.Click += new System.EventHandler(this.akceptujBlik_Click);
            // 
            // Platnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 785);
            this.Controls.Add(this.akceptujBlik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textKoszt);
            this.Controls.Add(this.textOdleglosc);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textDokad);
            this.Controls.Add(this.textSkad);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nieprawidlowyBlik);
            this.Controls.Add(this.OdrzucZakup);
            this.Controls.Add(this.TAK2);
            this.Controls.Add(this.NIE2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nrBlik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NIE);
            this.Controls.Add(this.TAK);
            this.Controls.Add(this.glownyText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Platnosc";
            this.Text = "Platnosc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label glownyText;
        private System.Windows.Forms.Button TAK;
        private System.Windows.Forms.Button NIE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nrBlik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NIE2;
        private System.Windows.Forms.Button TAK2;
        private System.Windows.Forms.Button OdrzucZakup;
        private System.Windows.Forms.Label nieprawidlowyBlik;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label textImie;
        private System.Windows.Forms.Label textNazwisko;
        private System.Windows.Forms.Label textSkad;
        private System.Windows.Forms.Label textDokad;
        private System.Windows.Forms.Label textData;
        private System.Windows.Forms.Label textOdleglosc;
        private System.Windows.Forms.Label textKoszt;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Button akceptujBlik;
    }
}