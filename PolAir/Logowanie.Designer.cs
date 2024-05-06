

namespace PolAir
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.wyjdzPrzycisk = new System.Windows.Forms.Button();
            this.errorNieEmailLubHaslo = new System.Windows.Forms.Label();
            this.PodajEmailiHaslo = new System.Windows.Forms.Label();
            this.errorZostaloUtworzone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "PolslAIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_2.Location = new System.Drawing.Point(169, 193);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(113, 38);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "E-Mail: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(169, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Haslo: ";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1.Location = new System.Drawing.Point(347, 350);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(118, 56);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Zaloguj";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 278);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(287, 38);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(525, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zaloz Konto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyjdzPrzycisk
            // 
            this.wyjdzPrzycisk.BackColor = System.Drawing.Color.White;
            this.wyjdzPrzycisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wyjdzPrzycisk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wyjdzPrzycisk.Location = new System.Drawing.Point(143, 350);
            this.wyjdzPrzycisk.Name = "wyjdzPrzycisk";
            this.wyjdzPrzycisk.Size = new System.Drawing.Size(118, 56);
            this.wyjdzPrzycisk.TabIndex = 20;
            this.wyjdzPrzycisk.Text = "Wyjdź";
            this.wyjdzPrzycisk.UseVisualStyleBackColor = false;
            this.wyjdzPrzycisk.Click += new System.EventHandler(this.wyjdzPrzycisk_Click);
            // 
            // errorNieEmailLubHaslo
            // 
            this.errorNieEmailLubHaslo.AutoSize = true;
            this.errorNieEmailLubHaslo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorNieEmailLubHaslo.ForeColor = System.Drawing.Color.Red;
            this.errorNieEmailLubHaslo.Location = new System.Drawing.Point(262, 139);
            this.errorNieEmailLubHaslo.Name = "errorNieEmailLubHaslo";
            this.errorNieEmailLubHaslo.Size = new System.Drawing.Size(296, 28);
            this.errorNieEmailLubHaslo.TabIndex = 21;
            this.errorNieEmailLubHaslo.Text = "Niepoprawny email lub hasło!";
            this.errorNieEmailLubHaslo.Visible = false;
            // 
            // PodajEmailiHaslo
            // 
            this.PodajEmailiHaslo.AutoSize = true;
            this.PodajEmailiHaslo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PodajEmailiHaslo.ForeColor = System.Drawing.Color.Red;
            this.PodajEmailiHaslo.Location = new System.Drawing.Point(305, 139);
            this.PodajEmailiHaslo.Name = "PodajEmailiHaslo";
            this.PodajEmailiHaslo.Size = new System.Drawing.Size(200, 28);
            this.PodajEmailiHaslo.TabIndex = 22;
            this.PodajEmailiHaslo.Text = "Podaj Email i Hasło!";
            this.PodajEmailiHaslo.Visible = false;
            // 
            // errorZostaloUtworzone
            // 
            this.errorZostaloUtworzone.AutoSize = true;
            this.errorZostaloUtworzone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorZostaloUtworzone.ForeColor = System.Drawing.Color.Black;
            this.errorZostaloUtworzone.Location = new System.Drawing.Point(283, 139);
            this.errorZostaloUtworzone.Name = "errorZostaloUtworzone";
            this.errorZostaloUtworzone.Size = new System.Drawing.Size(250, 28);
            this.errorZostaloUtworzone.TabIndex = 23;
            this.errorZostaloUtworzone.Text = "Konto zostało utworzone";
            this.errorZostaloUtworzone.Visible = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorZostaloUtworzone);
            this.Controls.Add(this.PodajEmailiHaslo);
            this.Controls.Add(this.errorNieEmailLubHaslo);
            this.Controls.Add(this.wyjdzPrzycisk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logowanie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button wyjdzPrzycisk;
        private System.Windows.Forms.Label errorNieEmailLubHaslo;
        private System.Windows.Forms.Label PodajEmailiHaslo;
        private System.Windows.Forms.Label errorZostaloUtworzone;
    }
}

