
namespace PolAir
{
    partial class Rezerwacja
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.WybierzFrom = new System.Windows.Forms.Button();
            this.WybierzTo = new System.Windows.Forms.Button();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.IslandiaFROM = new System.Windows.Forms.Button();
            this.FrancjaFROM = new System.Windows.Forms.Button();
            this.NiemcyFROM = new System.Windows.Forms.Button();
            this.USAFROM = new System.Windows.Forms.Button();
            this.HolandiaFROM = new System.Windows.Forms.Button();
            this.GrecjaFROM = new System.Windows.Forms.Button();
            this.HiszpaniaFROM = new System.Windows.Forms.Button();
            this.PortugaliaFROM = new System.Windows.Forms.Button();
            this.PolskaFROM = new System.Windows.Forms.Button();
            this.panelTO = new System.Windows.Forms.Panel();
            this.IslandiaTO = new System.Windows.Forms.Button();
            this.FrancjaTO = new System.Windows.Forms.Button();
            this.NiemcyTO = new System.Windows.Forms.Button();
            this.USATO = new System.Windows.Forms.Button();
            this.HolandiaTO = new System.Windows.Forms.Button();
            this.GrecjaTO = new System.Windows.Forms.Button();
            this.HiszpaniaTO = new System.Windows.Forms.Button();
            this.PortugaliaTO = new System.Windows.Forms.Button();
            this.PolskaTO = new System.Windows.Forms.Button();
            this.dalej = new System.Windows.Forms.Button();
            this.errorData = new System.Windows.Forms.Label();
            this.errorZaDuzo = new System.Windows.Forms.Label();
            this.rezerwacjaWToku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.Label();
            this.ErrorTakieSame = new System.Windows.Forms.Label();
            this.ErrorWybierz = new System.Windows.Forms.Label();
            this.errorTo = new System.Windows.Forms.Label();
            this.panelFrom.SuspendLayout();
            this.panelTO.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(448, 131);
            this.monthCalendar1.MinDate = new System.DateTime(2022, 5, 20, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // WybierzFrom
            // 
            this.WybierzFrom.BackColor = System.Drawing.Color.White;
            this.WybierzFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WybierzFrom.Location = new System.Drawing.Point(297, 396);
            this.WybierzFrom.Name = "WybierzFrom";
            this.WybierzFrom.Size = new System.Drawing.Size(356, 37);
            this.WybierzFrom.TabIndex = 11;
            this.WybierzFrom.Text = "Wybierz";
            this.WybierzFrom.UseVisualStyleBackColor = false;
            this.WybierzFrom.Click += new System.EventHandler(this.WybierzFrom_Click);
            // 
            // WybierzTo
            // 
            this.WybierzTo.BackColor = System.Drawing.Color.White;
            this.WybierzTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WybierzTo.Location = new System.Drawing.Point(716, 396);
            this.WybierzTo.Name = "WybierzTo";
            this.WybierzTo.Size = new System.Drawing.Size(356, 37);
            this.WybierzTo.TabIndex = 12;
            this.WybierzTo.Text = "Wybierz";
            this.WybierzTo.UseVisualStyleBackColor = false;
            this.WybierzTo.Click += new System.EventHandler(this.WybierzTo_Click);
            // 
            // panelFrom
            // 
            this.panelFrom.AutoSize = true;
            this.panelFrom.Controls.Add(this.IslandiaFROM);
            this.panelFrom.Controls.Add(this.FrancjaFROM);
            this.panelFrom.Controls.Add(this.NiemcyFROM);
            this.panelFrom.Controls.Add(this.USAFROM);
            this.panelFrom.Controls.Add(this.HolandiaFROM);
            this.panelFrom.Controls.Add(this.GrecjaFROM);
            this.panelFrom.Controls.Add(this.HiszpaniaFROM);
            this.panelFrom.Controls.Add(this.PortugaliaFROM);
            this.panelFrom.Controls.Add(this.PolskaFROM);
            this.panelFrom.Location = new System.Drawing.Point(297, 451);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(356, 333);
            this.panelFrom.TabIndex = 13;
            // 
            // IslandiaFROM
            // 
            this.IslandiaFROM.BackColor = System.Drawing.Color.White;
            this.IslandiaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.IslandiaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IslandiaFROM.Location = new System.Drawing.Point(0, 296);
            this.IslandiaFROM.Name = "IslandiaFROM";
            this.IslandiaFROM.Size = new System.Drawing.Size(356, 37);
            this.IslandiaFROM.TabIndex = 9;
            this.IslandiaFROM.Text = "Islandia (Reykjavik)";
            this.IslandiaFROM.UseVisualStyleBackColor = false;
            this.IslandiaFROM.Click += new System.EventHandler(this.IslandiaFROM_Click);
            // 
            // FrancjaFROM
            // 
            this.FrancjaFROM.BackColor = System.Drawing.Color.White;
            this.FrancjaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrancjaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FrancjaFROM.Location = new System.Drawing.Point(0, 259);
            this.FrancjaFROM.Name = "FrancjaFROM";
            this.FrancjaFROM.Size = new System.Drawing.Size(356, 37);
            this.FrancjaFROM.TabIndex = 7;
            this.FrancjaFROM.Text = "Francja (Paryż)";
            this.FrancjaFROM.UseVisualStyleBackColor = false;
            this.FrancjaFROM.Click += new System.EventHandler(this.FrancjaFROM_Click);
            // 
            // NiemcyFROM
            // 
            this.NiemcyFROM.BackColor = System.Drawing.Color.White;
            this.NiemcyFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.NiemcyFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NiemcyFROM.Location = new System.Drawing.Point(0, 222);
            this.NiemcyFROM.Name = "NiemcyFROM";
            this.NiemcyFROM.Size = new System.Drawing.Size(356, 37);
            this.NiemcyFROM.TabIndex = 6;
            this.NiemcyFROM.Text = "Niemcy (Berlin)";
            this.NiemcyFROM.UseVisualStyleBackColor = false;
            this.NiemcyFROM.Click += new System.EventHandler(this.NiemcyFROM_Click);
            // 
            // USAFROM
            // 
            this.USAFROM.BackColor = System.Drawing.Color.White;
            this.USAFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.USAFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.USAFROM.Location = new System.Drawing.Point(0, 185);
            this.USAFROM.Name = "USAFROM";
            this.USAFROM.Size = new System.Drawing.Size(356, 37);
            this.USAFROM.TabIndex = 5;
            this.USAFROM.Text = "Stany Zjednoczone (Los Angeles)";
            this.USAFROM.UseVisualStyleBackColor = false;
            this.USAFROM.Click += new System.EventHandler(this.USAFROM_Click);
            // 
            // HolandiaFROM
            // 
            this.HolandiaFROM.BackColor = System.Drawing.Color.White;
            this.HolandiaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HolandiaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HolandiaFROM.Location = new System.Drawing.Point(0, 148);
            this.HolandiaFROM.Name = "HolandiaFROM";
            this.HolandiaFROM.Size = new System.Drawing.Size(356, 37);
            this.HolandiaFROM.TabIndex = 4;
            this.HolandiaFROM.Text = "Holandia (Amsterdam)";
            this.HolandiaFROM.UseVisualStyleBackColor = false;
            this.HolandiaFROM.Click += new System.EventHandler(this.HolandiaFROM_Click);
            // 
            // GrecjaFROM
            // 
            this.GrecjaFROM.BackColor = System.Drawing.Color.White;
            this.GrecjaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrecjaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrecjaFROM.Location = new System.Drawing.Point(0, 111);
            this.GrecjaFROM.Name = "GrecjaFROM";
            this.GrecjaFROM.Size = new System.Drawing.Size(356, 37);
            this.GrecjaFROM.TabIndex = 3;
            this.GrecjaFROM.Text = "Grecja (Ateny)";
            this.GrecjaFROM.UseVisualStyleBackColor = false;
            this.GrecjaFROM.Click += new System.EventHandler(this.GrecjaFROM_Click);
            // 
            // HiszpaniaFROM
            // 
            this.HiszpaniaFROM.BackColor = System.Drawing.Color.White;
            this.HiszpaniaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.HiszpaniaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HiszpaniaFROM.Location = new System.Drawing.Point(0, 74);
            this.HiszpaniaFROM.Name = "HiszpaniaFROM";
            this.HiszpaniaFROM.Size = new System.Drawing.Size(356, 37);
            this.HiszpaniaFROM.TabIndex = 2;
            this.HiszpaniaFROM.Text = "Hiszpania (Madryt)";
            this.HiszpaniaFROM.UseVisualStyleBackColor = false;
            this.HiszpaniaFROM.Click += new System.EventHandler(this.HiszpaniaFROM_Click);
            // 
            // PortugaliaFROM
            // 
            this.PortugaliaFROM.BackColor = System.Drawing.Color.White;
            this.PortugaliaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortugaliaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PortugaliaFROM.Location = new System.Drawing.Point(0, 37);
            this.PortugaliaFROM.Name = "PortugaliaFROM";
            this.PortugaliaFROM.Size = new System.Drawing.Size(356, 37);
            this.PortugaliaFROM.TabIndex = 1;
            this.PortugaliaFROM.Text = "Portugalia (Lizbona Portela)";
            this.PortugaliaFROM.UseVisualStyleBackColor = false;
            this.PortugaliaFROM.Click += new System.EventHandler(this.PortugaliaFROM_Click);
            // 
            // PolskaFROM
            // 
            this.PolskaFROM.BackColor = System.Drawing.Color.White;
            this.PolskaFROM.Dock = System.Windows.Forms.DockStyle.Top;
            this.PolskaFROM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PolskaFROM.Location = new System.Drawing.Point(0, 0);
            this.PolskaFROM.Name = "PolskaFROM";
            this.PolskaFROM.Size = new System.Drawing.Size(356, 37);
            this.PolskaFROM.TabIndex = 0;
            this.PolskaFROM.Text = "Polska (Warszawa Chopin)";
            this.PolskaFROM.UseVisualStyleBackColor = false;
            this.PolskaFROM.Click += new System.EventHandler(this.PolskaFROM_Click);
            // 
            // panelTO
            // 
            this.panelTO.AutoSize = true;
            this.panelTO.Controls.Add(this.IslandiaTO);
            this.panelTO.Controls.Add(this.FrancjaTO);
            this.panelTO.Controls.Add(this.NiemcyTO);
            this.panelTO.Controls.Add(this.USATO);
            this.panelTO.Controls.Add(this.HolandiaTO);
            this.panelTO.Controls.Add(this.GrecjaTO);
            this.panelTO.Controls.Add(this.HiszpaniaTO);
            this.panelTO.Controls.Add(this.PortugaliaTO);
            this.panelTO.Controls.Add(this.PolskaTO);
            this.panelTO.Location = new System.Drawing.Point(716, 451);
            this.panelTO.Name = "panelTO";
            this.panelTO.Size = new System.Drawing.Size(356, 333);
            this.panelTO.TabIndex = 15;
            // 
            // IslandiaTO
            // 
            this.IslandiaTO.BackColor = System.Drawing.Color.White;
            this.IslandiaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.IslandiaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IslandiaTO.Location = new System.Drawing.Point(0, 296);
            this.IslandiaTO.Name = "IslandiaTO";
            this.IslandiaTO.Size = new System.Drawing.Size(356, 37);
            this.IslandiaTO.TabIndex = 10;
            this.IslandiaTO.Text = "Islandia (Reykjavik)";
            this.IslandiaTO.UseVisualStyleBackColor = false;
            this.IslandiaTO.Click += new System.EventHandler(this.IslandiaTO_Click);
            // 
            // FrancjaTO
            // 
            this.FrancjaTO.BackColor = System.Drawing.Color.White;
            this.FrancjaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.FrancjaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FrancjaTO.Location = new System.Drawing.Point(0, 259);
            this.FrancjaTO.Name = "FrancjaTO";
            this.FrancjaTO.Size = new System.Drawing.Size(356, 37);
            this.FrancjaTO.TabIndex = 7;
            this.FrancjaTO.Text = "Francja (Paryż)";
            this.FrancjaTO.UseVisualStyleBackColor = false;
            this.FrancjaTO.Click += new System.EventHandler(this.FrancjaTO_Click);
            // 
            // NiemcyTO
            // 
            this.NiemcyTO.BackColor = System.Drawing.Color.White;
            this.NiemcyTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.NiemcyTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NiemcyTO.Location = new System.Drawing.Point(0, 222);
            this.NiemcyTO.Name = "NiemcyTO";
            this.NiemcyTO.Size = new System.Drawing.Size(356, 37);
            this.NiemcyTO.TabIndex = 6;
            this.NiemcyTO.Text = "Niemcy (Berlin)";
            this.NiemcyTO.UseVisualStyleBackColor = false;
            this.NiemcyTO.Click += new System.EventHandler(this.NiemcyTO_Click);
            // 
            // USATO
            // 
            this.USATO.BackColor = System.Drawing.Color.White;
            this.USATO.Dock = System.Windows.Forms.DockStyle.Top;
            this.USATO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.USATO.Location = new System.Drawing.Point(0, 185);
            this.USATO.Name = "USATO";
            this.USATO.Size = new System.Drawing.Size(356, 37);
            this.USATO.TabIndex = 5;
            this.USATO.Text = "Stany Zjednoczone (Los Angeles)";
            this.USATO.UseVisualStyleBackColor = false;
            this.USATO.Click += new System.EventHandler(this.USATO_Click);
            // 
            // HolandiaTO
            // 
            this.HolandiaTO.BackColor = System.Drawing.Color.White;
            this.HolandiaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.HolandiaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HolandiaTO.Location = new System.Drawing.Point(0, 148);
            this.HolandiaTO.Name = "HolandiaTO";
            this.HolandiaTO.Size = new System.Drawing.Size(356, 37);
            this.HolandiaTO.TabIndex = 4;
            this.HolandiaTO.Text = "Holandia (Amsterdam)";
            this.HolandiaTO.UseVisualStyleBackColor = false;
            this.HolandiaTO.Click += new System.EventHandler(this.HolandiaTO_Click);
            // 
            // GrecjaTO
            // 
            this.GrecjaTO.BackColor = System.Drawing.Color.White;
            this.GrecjaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrecjaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrecjaTO.Location = new System.Drawing.Point(0, 111);
            this.GrecjaTO.Name = "GrecjaTO";
            this.GrecjaTO.Size = new System.Drawing.Size(356, 37);
            this.GrecjaTO.TabIndex = 3;
            this.GrecjaTO.Text = "Grecja (Ateny)";
            this.GrecjaTO.UseVisualStyleBackColor = false;
            this.GrecjaTO.Click += new System.EventHandler(this.GrecjaTO_Click);
            // 
            // HiszpaniaTO
            // 
            this.HiszpaniaTO.BackColor = System.Drawing.Color.White;
            this.HiszpaniaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.HiszpaniaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HiszpaniaTO.Location = new System.Drawing.Point(0, 74);
            this.HiszpaniaTO.Name = "HiszpaniaTO";
            this.HiszpaniaTO.Size = new System.Drawing.Size(356, 37);
            this.HiszpaniaTO.TabIndex = 2;
            this.HiszpaniaTO.Text = "Hiszpania (Madryt)";
            this.HiszpaniaTO.UseVisualStyleBackColor = false;
            this.HiszpaniaTO.Click += new System.EventHandler(this.HiszpaniaTO_Click);
            // 
            // PortugaliaTO
            // 
            this.PortugaliaTO.BackColor = System.Drawing.Color.White;
            this.PortugaliaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortugaliaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PortugaliaTO.Location = new System.Drawing.Point(0, 37);
            this.PortugaliaTO.Name = "PortugaliaTO";
            this.PortugaliaTO.Size = new System.Drawing.Size(356, 37);
            this.PortugaliaTO.TabIndex = 1;
            this.PortugaliaTO.Text = "Portugalia (Lizbona Portela)";
            this.PortugaliaTO.UseVisualStyleBackColor = false;
            this.PortugaliaTO.Click += new System.EventHandler(this.PortugaliaTO_Click);
            // 
            // PolskaTO
            // 
            this.PolskaTO.BackColor = System.Drawing.Color.White;
            this.PolskaTO.Dock = System.Windows.Forms.DockStyle.Top;
            this.PolskaTO.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PolskaTO.Location = new System.Drawing.Point(0, 0);
            this.PolskaTO.Name = "PolskaTO";
            this.PolskaTO.Size = new System.Drawing.Size(356, 37);
            this.PolskaTO.TabIndex = 0;
            this.PolskaTO.Text = "Polska (Warszawa Chopin)";
            this.PolskaTO.UseVisualStyleBackColor = false;
            this.PolskaTO.Click += new System.EventHandler(this.PolskaTO_Click);
            // 
            // dalej
            // 
            this.dalej.BackColor = System.Drawing.Color.White;
            this.dalej.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dalej.Location = new System.Drawing.Point(944, 809);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(174, 29);
            this.dalej.TabIndex = 16;
            this.dalej.Text = "Dalej";
            this.dalej.UseVisualStyleBackColor = false;
            this.dalej.Click += new System.EventHandler(this.dalej_Click);
            // 
            // errorData
            // 
            this.errorData.AutoSize = true;
            this.errorData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorData.ForeColor = System.Drawing.Color.Red;
            this.errorData.Location = new System.Drawing.Point(541, 94);
            this.errorData.Name = "errorData";
            this.errorData.Size = new System.Drawing.Size(148, 28);
            this.errorData.TabIndex = 20;
            this.errorData.Text = "Wybierz Datę!";
            this.errorData.Visible = false;
            // 
            // errorZaDuzo
            // 
            this.errorZaDuzo.AutoSize = true;
            this.errorZaDuzo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorZaDuzo.ForeColor = System.Drawing.Color.Red;
            this.errorZaDuzo.Location = new System.Drawing.Point(398, 94);
            this.errorZaDuzo.Name = "errorZaDuzo";
            this.errorZaDuzo.Size = new System.Drawing.Size(412, 28);
            this.errorZaDuzo.TabIndex = 21;
            this.errorZaDuzo.Text = "Nie możesz zarezerwować więcej biletów!";
            this.errorZaDuzo.Visible = false;
            // 
            // rezerwacjaWToku
            // 
            this.rezerwacjaWToku.AutoSize = true;
            this.rezerwacjaWToku.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rezerwacjaWToku.Location = new System.Drawing.Point(314, 367);
            this.rezerwacjaWToku.Name = "rezerwacjaWToku";
            this.rezerwacjaWToku.Size = new System.Drawing.Size(610, 81);
            this.rezerwacjaWToku.TabIndex = 22;
            this.rezerwacjaWToku.Text = "Rezerwacja w toku...";
            this.rezerwacjaWToku.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 59);
            this.label1.TabIndex = 23;
            this.label1.Text = "Rezerwacja Biletów Lotniczych";
            // 
            // textBox4
            // 
            this.textBox4.AutoSize = true;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(209, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 31);
            this.textBox4.TabIndex = 24;
            this.textBox4.Text = "WHEN:";
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = true;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(205, 398);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 31);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "FROM:";
            // 
            // textBox3
            // 
            this.textBox3.AutoSize = true;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(659, 398);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 31);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "TO:";
            // 
            // ErrorTakieSame
            // 
            this.ErrorTakieSame.AutoSize = true;
            this.ErrorTakieSame.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorTakieSame.Location = new System.Drawing.Point(457, 360);
            this.ErrorTakieSame.Name = "ErrorTakieSame";
            this.ErrorTakieSame.Size = new System.Drawing.Size(306, 23);
            this.ErrorTakieSame.TabIndex = 27;
            this.ErrorTakieSame.Text = "Lokalizacje FROM i TO są takie same!";
            // 
            // ErrorWybierz
            // 
            this.ErrorWybierz.AutoSize = true;
            this.ErrorWybierz.BackColor = System.Drawing.Color.Red;
            this.ErrorWybierz.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorWybierz.Location = new System.Drawing.Point(535, 360);
            this.ErrorWybierz.Name = "ErrorWybierz";
            this.ErrorWybierz.Size = new System.Drawing.Size(173, 23);
            this.ErrorWybierz.TabIndex = 28;
            this.ErrorWybierz.Text = "Wybierz FROM i TO!";
            // 
            // errorTo
            // 
            this.errorTo.AutoSize = true;
            this.errorTo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorTo.Location = new System.Drawing.Point(448, 360);
            this.errorTo.Name = "errorTo";
            this.errorTo.Size = new System.Drawing.Size(325, 23);
            this.errorTo.TabIndex = 29;
            this.errorTo.Text = "Najpierw Wybierz Lokalizację Startową";
            // 
            // Rezerwacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1164, 850);
            this.Controls.Add(this.errorTo);
            this.Controls.Add(this.ErrorWybierz);
            this.Controls.Add(this.ErrorTakieSame);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezerwacjaWToku);
            this.Controls.Add(this.errorZaDuzo);
            this.Controls.Add(this.errorData);
            this.Controls.Add(this.dalej);
            this.Controls.Add(this.panelTO);
            this.Controls.Add(this.panelFrom);
            this.Controls.Add(this.WybierzTo);
            this.Controls.Add(this.WybierzFrom);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezerwacja";
            this.Text = "E";
            this.Load += new System.EventHandler(this.Rezerwacja_Load);
            this.panelFrom.ResumeLayout(false);
            this.panelTO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button WybierzFrom;
        private System.Windows.Forms.Button WybierzTo;
        private System.Windows.Forms.Panel panelFrom;
        private System.Windows.Forms.Button PolskaFROM;
        private System.Windows.Forms.Button FrancjaFROM;
        private System.Windows.Forms.Button NiemcyFROM;
        private System.Windows.Forms.Button USAFROM;
        private System.Windows.Forms.Button HolandiaFROM;
        private System.Windows.Forms.Button GrecjaFROM;
        private System.Windows.Forms.Button HiszpaniaFROM;
        private System.Windows.Forms.Button PortugaliaFROM;
        private System.Windows.Forms.Button IslandiaFROM;
        private System.Windows.Forms.Panel panelTO;
        private System.Windows.Forms.Button IslandiaTO;
        private System.Windows.Forms.Button FrancjaTO;
        private System.Windows.Forms.Button NiemcyTO;
        private System.Windows.Forms.Button USATO;
        private System.Windows.Forms.Button HolandiaTO;
        private System.Windows.Forms.Button GrecjaTO;
        private System.Windows.Forms.Button HiszpaniaTO;
        private System.Windows.Forms.Button PortugaliaTO;
        private System.Windows.Forms.Button PolskaTO;
        private System.Windows.Forms.Button dalej;
        private System.Windows.Forms.Label errorData;
        private System.Windows.Forms.Label errorZaDuzo;
        private System.Windows.Forms.Label rezerwacjaWToku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBox4;
        private System.Windows.Forms.Label textBox2;
        private System.Windows.Forms.Label textBox3;
        private System.Windows.Forms.Label ErrorTakieSame;
        private System.Windows.Forms.Label ErrorWybierz;
        private System.Windows.Forms.Label errorTo;
    }
}