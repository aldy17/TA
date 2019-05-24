namespace Penyewaan_Penginapan
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tmmasuk = new System.Windows.Forms.DateTimePicker();
            this.tmkeluar = new System.Windows.Forms.DateTimePicker();
            this.btnhitung = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.combokamar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.twkeluar = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btncetak = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textnama = new System.Windows.Forms.TextBox();
            this.textAl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbayar = new System.Windows.Forms.TextBox();
            this.txtdurasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radiof1 = new System.Windows.Forms.RadioButton();
            this.radiof2 = new System.Windows.Forms.RadioButton();
            this.radiof3 = new System.Windows.Forms.RadioButton();
            this.radiof4 = new System.Windows.Forms.RadioButton();
            this.radiof5 = new System.Windows.Forms.RadioButton();
            this.radiof6 = new System.Windows.Forms.RadioButton();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.twmasuk = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tmmasuk
            // 
            this.tmmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tmmasuk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tmmasuk.Location = new System.Drawing.Point(148, 319);
            this.tmmasuk.Name = "tmmasuk";
            this.tmmasuk.Size = new System.Drawing.Size(136, 20);
            this.tmmasuk.TabIndex = 1;
            this.tmmasuk.ValueChanged += new System.EventHandler(this.tmmasuk_ValueChanged);
            // 
            // tmkeluar
            // 
            this.tmkeluar.Checked = false;
            this.tmkeluar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tmkeluar.Location = new System.Drawing.Point(148, 345);
            this.tmkeluar.Name = "tmkeluar";
            this.tmkeluar.Size = new System.Drawing.Size(136, 20);
            this.tmkeluar.TabIndex = 4;
            this.tmkeluar.ValueChanged += new System.EventHandler(this.tmkembali_ValueChanged);
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(303, 374);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(78, 33);
            this.btnhitung.TabIndex = 9;
            this.btnhitung.Text = "Hasil";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(129, 374);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(78, 33);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // combokamar
            // 
            this.combokamar.BackColor = System.Drawing.SystemColors.Window;
            this.combokamar.Cursor = System.Windows.Forms.Cursors.Default;
            this.combokamar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combokamar.FormattingEnabled = true;
            this.combokamar.Items.AddRange(new object[] {
            "SINGLE ROOM",
            "TWIN ROOM",
            "DOUBLE ROOM",
            "TRIPLE ROOM"});
            this.combokamar.Location = new System.Drawing.Point(148, 266);
            this.combokamar.Name = "combokamar";
            this.combokamar.Size = new System.Drawing.Size(136, 21);
            this.combokamar.TabIndex = 35;
            this.combokamar.SelectedIndexChanged += new System.EventHandler(this.combokamar_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(318, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Durasi(Jam)";
            // 
            // twkeluar
            // 
            this.twkeluar.CustomFormat = "HH:mm";
            this.twkeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.twkeluar.Location = new System.Drawing.Point(411, 312);
            this.twkeluar.Name = "twkeluar";
            this.twkeluar.ShowUpDown = true;
            this.twkeluar.Size = new System.Drawing.Size(59, 20);
            this.twkeluar.TabIndex = 38;
            this.twkeluar.Value = new System.DateTime(2019, 5, 19, 11, 55, 54, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(130, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Nama Pemesan";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(130, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "Alamat Pemesan";
            // 
            // btncetak
            // 
            this.btncetak.Location = new System.Drawing.Point(215, 374);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(78, 33);
            this.btncetak.TabIndex = 44;
            this.btncetak.Text = "Reset";
            this.btncetak.UseVisualStyleBackColor = true;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(211, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 32);
            this.label16.TabIndex = 45;
            this.label16.Text = "AYS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 19);
            this.button1.TabIndex = 46;
            this.button1.Text = "Data Praktikan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(248, 128);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(100, 20);
            this.textnama.TabIndex = 40;
            this.textnama.TextChanged += new System.EventHandler(this.textnama_TextChanged);
            // 
            // textAl
            // 
            this.textAl.Location = new System.Drawing.Point(248, 157);
            this.textAl.Name = "textAl";
            this.textAl.Size = new System.Drawing.Size(100, 20);
            this.textAl.TabIndex = 47;
            this.textAl.Text = "JL.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(318, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Waktu Masuk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(35, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Biaya Per Jam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(35, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tanggal Masuk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(36, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tanggal Keluar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Tipe Kamar";
            // 
            // txtbayar
            // 
            this.txtbayar.Location = new System.Drawing.Point(120, 413);
            this.txtbayar.Multiline = true;
            this.txtbayar.Name = "txtbayar";
            this.txtbayar.Size = new System.Drawing.Size(270, 111);
            this.txtbayar.TabIndex = 54;
            // 
            // txtdurasi
            // 
            this.txtdurasi.Location = new System.Drawing.Point(411, 341);
            this.txtdurasi.Name = "txtdurasi";
            this.txtdurasi.Size = new System.Drawing.Size(59, 20);
            this.txtdurasi.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Jenis Fasilitas";
            // 
            // radiof1
            // 
            this.radiof1.AutoSize = true;
            this.radiof1.BackColor = System.Drawing.Color.Transparent;
            this.radiof1.ForeColor = System.Drawing.Color.White;
            this.radiof1.Location = new System.Drawing.Point(107, 217);
            this.radiof1.Name = "radiof1";
            this.radiof1.Size = new System.Drawing.Size(85, 17);
            this.radiof1.TabIndex = 58;
            this.radiof1.TabStop = true;
            this.radiof1.Text = "STANDARD";
            this.radiof1.UseVisualStyleBackColor = false;
            // 
            // radiof2
            // 
            this.radiof2.AutoSize = true;
            this.radiof2.BackColor = System.Drawing.Color.Transparent;
            this.radiof2.ForeColor = System.Drawing.Color.White;
            this.radiof2.Location = new System.Drawing.Point(107, 240);
            this.radiof2.Name = "radiof2";
            this.radiof2.Size = new System.Drawing.Size(81, 17);
            this.radiof2.TabIndex = 59;
            this.radiof2.TabStop = true;
            this.radiof2.Text = "SUPERIOR";
            this.radiof2.UseVisualStyleBackColor = false;
            // 
            // radiof3
            // 
            this.radiof3.AutoSize = true;
            this.radiof3.BackColor = System.Drawing.Color.Transparent;
            this.radiof3.ForeColor = System.Drawing.Color.White;
            this.radiof3.Location = new System.Drawing.Point(221, 217);
            this.radiof3.Name = "radiof3";
            this.radiof3.Size = new System.Drawing.Size(68, 17);
            this.radiof3.TabIndex = 60;
            this.radiof3.TabStop = true;
            this.radiof3.Text = "DELUXE";
            this.radiof3.UseVisualStyleBackColor = false;
            // 
            // radiof4
            // 
            this.radiof4.AutoSize = true;
            this.radiof4.BackColor = System.Drawing.Color.Transparent;
            this.radiof4.ForeColor = System.Drawing.Color.White;
            this.radiof4.Location = new System.Drawing.Point(221, 240);
            this.radiof4.Name = "radiof4";
            this.radiof4.Size = new System.Drawing.Size(57, 17);
            this.radiof4.TabIndex = 61;
            this.radiof4.TabStop = true;
            this.radiof4.Text = "SUITE";
            this.radiof4.UseVisualStyleBackColor = false;
            // 
            // radiof5
            // 
            this.radiof5.AutoSize = true;
            this.radiof5.BackColor = System.Drawing.Color.Transparent;
            this.radiof5.ForeColor = System.Drawing.Color.White;
            this.radiof5.Location = new System.Drawing.Point(327, 217);
            this.radiof5.Name = "radiof5";
            this.radiof5.Size = new System.Drawing.Size(45, 17);
            this.radiof5.TabIndex = 62;
            this.radiof5.TabStop = true;
            this.radiof5.Text = "JSR";
            this.radiof5.UseVisualStyleBackColor = false;
            // 
            // radiof6
            // 
            this.radiof6.AutoSize = true;
            this.radiof6.BackColor = System.Drawing.Color.Transparent;
            this.radiof6.ForeColor = System.Drawing.Color.White;
            this.radiof6.Location = new System.Drawing.Point(327, 240);
            this.radiof6.Name = "radiof6";
            this.radiof6.Size = new System.Drawing.Size(103, 17);
            this.radiof6.TabIndex = 63;
            this.radiof6.TabStop = true;
            this.radiof6.Text = "PRESIDENTIAL";
            this.radiof6.UseVisualStyleBackColor = false;
            // 
            // textHarga
            // 
            this.textHarga.Location = new System.Drawing.Point(148, 294);
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(136, 20);
            this.textHarga.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(95, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Jl. Prof. Soedarto, Tembalang, Semarang,Jawa Tengah, Indonesia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(318, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Waktu Keluar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 32);
            this.label2.TabIndex = 67;
            this.label2.Text = "SEWA  PENGINAPAN";
            // 
            // twmasuk
            // 
            this.twmasuk.CustomFormat = "HH:mm";
            this.twmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.twmasuk.Location = new System.Drawing.Point(411, 283);
            this.twmasuk.Name = "twmasuk";
            this.twmasuk.ShowUpDown = true;
            this.twmasuk.Size = new System.Drawing.Size(59, 20);
            this.twmasuk.TabIndex = 68;
            this.twmasuk.Value = new System.DateTime(2019, 5, 19, 11, 55, 54, 0);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 536);
            this.Controls.Add(this.twmasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textHarga);
            this.Controls.Add(this.radiof6);
            this.Controls.Add(this.radiof5);
            this.Controls.Add(this.radiof4);
            this.Controls.Add(this.radiof3);
            this.Controls.Add(this.radiof2);
            this.Controls.Add(this.radiof1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdurasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.twkeluar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.combokamar);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.tmkeluar);
            this.Controls.Add(this.tmmasuk);
            this.Controls.Add(this.txtbayar);
            this.Name = "Menu";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tmmasuk;
        private System.Windows.Forms.DateTimePicker tmkeluar;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox combokamar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker twkeluar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btncetak;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.TextBox textAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbayar;
        private System.Windows.Forms.TextBox txtdurasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radiof1;
        private System.Windows.Forms.RadioButton radiof2;
        private System.Windows.Forms.RadioButton radiof3;
        private System.Windows.Forms.RadioButton radiof4;
        private System.Windows.Forms.RadioButton radiof5;
        private System.Windows.Forms.RadioButton radiof6;
        private System.Windows.Forms.TextBox textHarga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker twmasuk;
    }

}

