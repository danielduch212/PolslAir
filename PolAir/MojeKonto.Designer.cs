
namespace PolAir
{
    partial class MojeKonto
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
            this.usunKonto = new System.Windows.Forms.Button();
            this.zmienHaslo = new System.Windows.Forms.Button();
            this.NIE = new System.Windows.Forms.Button();
            this.TAK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.Label();
            this.textImie = new System.Windows.Forms.Label();
            this.textNazwisko = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.Label();
            this.sHasloLabel = new System.Windows.Forms.Label();
            this.nhasloLabel = new System.Windows.Forms.Label();
            this.pnhasloLabel = new System.Windows.Forms.Label();
            this.textBoxStareHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHasloP = new System.Windows.Forms.TextBox();
            this.zmienhaslo2 = new System.Windows.Forms.Button();
            this.anulujZmianeHasla = new System.Windows.Forms.Button();
            this.CzyUsunac = new System.Windows.Forms.Label();
            this.ErrorZleStare = new System.Windows.Forms.Label();
            this.errorZleNowe = new System.Windows.Forms.Label();
            this.errorliczbaznakow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usunKonto
            // 
            this.usunKonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.usunKonto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usunKonto.Location = new System.Drawing.Point(714, 691);
            this.usunKonto.Name = "usunKonto";
            this.usunKonto.Size = new System.Drawing.Size(210, 29);
            this.usunKonto.TabIndex = 7;
            this.usunKonto.Text = "usuń konto";
            this.usunKonto.UseVisualStyleBackColor = false;
            this.usunKonto.Click += new System.EventHandler(this.button1_Click);
            // 
            // zmienHaslo
            // 
            this.zmienHaslo.BackColor = System.Drawing.Color.Silver;
            this.zmienHaslo.Location = new System.Drawing.Point(714, 433);
            this.zmienHaslo.Name = "zmienHaslo";
            this.zmienHaslo.Size = new System.Drawing.Size(210, 29);
            this.zmienHaslo.TabIndex = 8;
            this.zmienHaslo.Text = "Zmień hasło";
            this.zmienHaslo.UseVisualStyleBackColor = false;
            this.zmienHaslo.Click += new System.EventHandler(this.button2_Click);
            // 
            // NIE
            // 
            this.NIE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NIE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NIE.Location = new System.Drawing.Point(361, 588);
            this.NIE.Name = "NIE";
            this.NIE.Size = new System.Drawing.Size(94, 41);
            this.NIE.TabIndex = 10;
            this.NIE.Text = "NIE";
            this.NIE.UseVisualStyleBackColor = false;
            this.NIE.Visible = false;
            this.NIE.Click += new System.EventHandler(this.NIE_Click);
            // 
            // TAK
            // 
            this.TAK.BackColor = System.Drawing.Color.Red;
            this.TAK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TAK.Location = new System.Drawing.Point(765, 588);
            this.TAK.Name = "TAK";
            this.TAK.Size = new System.Drawing.Size(94, 41);
            this.TAK.TabIndex = 11;
            this.TAK.Text = "TAK";
            this.TAK.UseVisualStyleBackColor = false;
            this.TAK.Visible = false;
            this.TAK.Click += new System.EventHandler(this.TAK_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(514, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 41);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Moje Konto";
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = true;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(361, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 31);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Imie:";
            // 
            // textBox4
            // 
            this.textBox4.AutoSize = true;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(361, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 31);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Nazwisko:";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox6
            // 
            this.textBox6.AutoSize = true;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(361, 204);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 31);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Adres email:";
            // 
            // textImie
            // 
            this.textImie.AutoSize = true;
            this.textImie.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textImie.Location = new System.Drawing.Point(668, 142);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(67, 31);
            this.textImie.TabIndex = 16;
            this.textImie.Text = "Imie:";
            this.textImie.Click += new System.EventHandler(this.textImie_Click);
            // 
            // textNazwisko
            // 
            this.textNazwisko.AutoSize = true;
            this.textNazwisko.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textNazwisko.Location = new System.Drawing.Point(668, 173);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(67, 31);
            this.textNazwisko.TabIndex = 17;
            this.textNazwisko.Text = "Imie:";
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(668, 202);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(67, 31);
            this.textEmail.TabIndex = 18;
            this.textEmail.Text = "Imie:";
            // 
            // sHasloLabel
            // 
            this.sHasloLabel.AutoSize = true;
            this.sHasloLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sHasloLabel.Location = new System.Drawing.Point(361, 299);
            this.sHasloLabel.Name = "sHasloLabel";
            this.sHasloLabel.Size = new System.Drawing.Size(122, 28);
            this.sHasloLabel.TabIndex = 19;
            this.sHasloLabel.Text = "Stare hasło:";
            this.sHasloLabel.Visible = false;
            // 
            // nhasloLabel
            // 
            this.nhasloLabel.AutoSize = true;
            this.nhasloLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nhasloLabel.Location = new System.Drawing.Point(361, 338);
            this.nhasloLabel.Name = "nhasloLabel";
            this.nhasloLabel.Size = new System.Drawing.Size(128, 28);
            this.nhasloLabel.TabIndex = 20;
            this.nhasloLabel.Text = "Nowe haslo:";
            this.nhasloLabel.Visible = false;
            // 
            // pnhasloLabel
            // 
            this.pnhasloLabel.AutoSize = true;
            this.pnhasloLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnhasloLabel.Location = new System.Drawing.Point(361, 380);
            this.pnhasloLabel.Name = "pnhasloLabel";
            this.pnhasloLabel.Size = new System.Drawing.Size(207, 28);
            this.pnhasloLabel.TabIndex = 21;
            this.pnhasloLabel.Text = "Powtórz nowe hasło:";
            this.pnhasloLabel.Visible = false;
            // 
            // textBoxStareHaslo
            // 
            this.textBoxStareHaslo.Location = new System.Drawing.Point(668, 299);
            this.textBoxStareHaslo.Name = "textBoxStareHaslo";
            this.textBoxStareHaslo.Size = new System.Drawing.Size(309, 27);
            this.textBoxStareHaslo.TabIndex = 22;
            this.textBoxStareHaslo.TextChanged += new System.EventHandler(this.textBoxStareHaslo_TextChanged);
            // 
            // textBoxNoweHaslo
            // 
            this.textBoxNoweHaslo.Location = new System.Drawing.Point(668, 342);
            this.textBoxNoweHaslo.Name = "textBoxNoweHaslo";
            this.textBoxNoweHaslo.Size = new System.Drawing.Size(309, 27);
            this.textBoxNoweHaslo.TabIndex = 23;
            this.textBoxNoweHaslo.TextChanged += new System.EventHandler(this.textBoxNoweHaslo_TextChanged);
            // 
            // textBoxNoweHasloP
            // 
            this.textBoxNoweHasloP.Location = new System.Drawing.Point(668, 384);
            this.textBoxNoweHasloP.Name = "textBoxNoweHasloP";
            this.textBoxNoweHasloP.Size = new System.Drawing.Size(309, 27);
            this.textBoxNoweHasloP.TabIndex = 24;
            this.textBoxNoweHasloP.TextChanged += new System.EventHandler(this.textBoxNoweHasloP_TextChanged);
            // 
            // zmienhaslo2
            // 
            this.zmienhaslo2.BackColor = System.Drawing.Color.White;
            this.zmienhaslo2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zmienhaslo2.Location = new System.Drawing.Point(714, 433);
            this.zmienhaslo2.Name = "zmienhaslo2";
            this.zmienhaslo2.Size = new System.Drawing.Size(210, 29);
            this.zmienhaslo2.TabIndex = 25;
            this.zmienhaslo2.Text = "Zmień hasło";
            this.zmienhaslo2.UseVisualStyleBackColor = false;
            this.zmienhaslo2.Click += new System.EventHandler(this.zmienhaslo2_Click);
            // 
            // anulujZmianeHasla
            // 
            this.anulujZmianeHasla.BackColor = System.Drawing.Color.White;
            this.anulujZmianeHasla.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anulujZmianeHasla.Location = new System.Drawing.Point(942, 433);
            this.anulujZmianeHasla.Name = "anulujZmianeHasla";
            this.anulujZmianeHasla.Size = new System.Drawing.Size(210, 29);
            this.anulujZmianeHasla.TabIndex = 26;
            this.anulujZmianeHasla.Text = "Anuluj";
            this.anulujZmianeHasla.UseVisualStyleBackColor = false;
            this.anulujZmianeHasla.Click += new System.EventHandler(this.anulujZmianeHasla_Click);
            // 
            // CzyUsunac
            // 
            this.CzyUsunac.AutoSize = true;
            this.CzyUsunac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CzyUsunac.ForeColor = System.Drawing.Color.Red;
            this.CzyUsunac.Location = new System.Drawing.Point(448, 543);
            this.CzyUsunac.Name = "CzyUsunac";
            this.CzyUsunac.Size = new System.Drawing.Size(353, 28);
            this.CzyUsunac.TabIndex = 27;
            this.CzyUsunac.Text = "Czy na pewno chcesz usunąć konto?";
            this.CzyUsunac.Visible = false;
            // 
            // ErrorZleStare
            // 
            this.ErrorZleStare.AutoSize = true;
            this.ErrorZleStare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorZleStare.ForeColor = System.Drawing.Color.Red;
            this.ErrorZleStare.Location = new System.Drawing.Point(514, 255);
            this.ErrorZleStare.Name = "ErrorZleStare";
            this.ErrorZleStare.Size = new System.Drawing.Size(157, 28);
            this.ErrorZleStare.TabIndex = 28;
            this.ErrorZleStare.Text = "Złe stare hasło!";
            this.ErrorZleStare.Visible = false;
            // 
            // errorZleNowe
            // 
            this.errorZleNowe.AutoSize = true;
            this.errorZleNowe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorZleNowe.ForeColor = System.Drawing.Color.Red;
            this.errorZleNowe.Location = new System.Drawing.Point(463, 255);
            this.errorZleNowe.Name = "errorZleNowe";
            this.errorZleNowe.Size = new System.Drawing.Size(285, 28);
            this.errorZleNowe.TabIndex = 29;
            this.errorZleNowe.Text = "Nowe hasła nie zgadzają się!";
            this.errorZleNowe.Visible = false;
            // 
            // errorliczbaznakow
            // 
            this.errorliczbaznakow.AutoSize = true;
            this.errorliczbaznakow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorliczbaznakow.ForeColor = System.Drawing.Color.Red;
            this.errorliczbaznakow.Location = new System.Drawing.Point(441, 255);
            this.errorliczbaznakow.Name = "errorliczbaznakow";
            this.errorliczbaznakow.Size = new System.Drawing.Size(360, 28);
            this.errorliczbaznakow.TabIndex = 30;
            this.errorliczbaznakow.Text = "Hasło musi mieć od 7 do 15 znaków!";
            this.errorliczbaznakow.Visible = false;
            this.errorliczbaznakow.Click += new System.EventHandler(this.errorliczbaznakow_Click);
            // 
            // MojeKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 785);
            this.Controls.Add(this.errorliczbaznakow);
            this.Controls.Add(this.errorZleNowe);
            this.Controls.Add(this.ErrorZleStare);
            this.Controls.Add(this.CzyUsunac);
            this.Controls.Add(this.anulujZmianeHasla);
            this.Controls.Add(this.zmienhaslo2);
            this.Controls.Add(this.textBoxNoweHasloP);
            this.Controls.Add(this.textBoxNoweHaslo);
            this.Controls.Add(this.textBoxStareHaslo);
            this.Controls.Add(this.pnhasloLabel);
            this.Controls.Add(this.nhasloLabel);
            this.Controls.Add(this.sHasloLabel);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TAK);
            this.Controls.Add(this.NIE);
            this.Controls.Add(this.zmienHaslo);
            this.Controls.Add(this.usunKonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MojeKonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MojeKonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button usunKonto;
        private System.Windows.Forms.Button zmienHaslo;
        private System.Windows.Forms.Button NIE;
        private System.Windows.Forms.Button TAK;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Label textBox2;
        private System.Windows.Forms.Label textBox4;
        private System.Windows.Forms.Label textBox6;
        private System.Windows.Forms.Label textImie;
        private System.Windows.Forms.Label textNazwisko;
        private System.Windows.Forms.Label textEmail;
        private System.Windows.Forms.Label sHasloLabel;
        private System.Windows.Forms.Label nhasloLabel;
        private System.Windows.Forms.Label pnhasloLabel;
       
        private System.Windows.Forms.TextBox noweHaslo;
        private System.Windows.Forms.TextBox pNoweHaslo;
        private System.Windows.Forms.TextBox textBoxStareHaslo;
        private System.Windows.Forms.TextBox textBoxNoweHaslo;
        private System.Windows.Forms.TextBox textBoxNoweHasloP;
        private System.Windows.Forms.Button zmienhaslo2;
        private System.Windows.Forms.Button anulujZmianeHasla;
        private System.Windows.Forms.Label CzyUsunac;
        private System.Windows.Forms.Label ErrorZleStare;
        private System.Windows.Forms.Label errorZleNowe;
        private System.Windows.Forms.Label errorliczbaznakow;
    }
}