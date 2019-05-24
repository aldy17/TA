using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Penyewaan_Penginapan
{
    public partial class Menu : Form
    {
        Timer t = new Timer();
        public Menu()
        {
            InitializeComponent();
        }
        class pelanggan
        {
            private string nama;
            public void set_nama(string nama)
            {
                this.nama = nama;
            }
            public string get_nama()
            {
                return nama;
            }
        }
        long biaya_per_jam;
        short waktu;
        DateTime tanggal_masuk;
        DateTime tanggal_keluar;
        int harga;
        pelanggan baik = new pelanggan();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmmasuk_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
       
            if (Int64.TryParse(textHarga.Text, out biaya_per_jam) && Int16.TryParse(txtdurasi.Text, out waktu))
            {

                txtbayar.Text = "================AYS HOTEL================" +
                Environment.NewLine +
                "Hello   : " + baik.get_nama() +
                Environment.NewLine +
                "Alamat : " + textAl.Text +
                Environment.NewLine +
                "Total Biaya Yang Harus Kamu Bayar Untuk : "
                + Environment.NewLine +
                "Tipe Kamar " + combokamar.Text +
                Environment.NewLine +
                "Dengan Durasi Waktu Selama " + waktu + "Jam" +
                Environment.NewLine +
                "Sebesar Rp. " + Convert.ToString(biaya_per_jam * waktu) + ",-";

            }
        }

        private void tmkembali_ValueChanged(object sender, EventArgs e)
        {

            tanggal_masuk = tmmasuk.Value.Date + twmasuk.Value.TimeOfDay;
            tanggal_keluar = tmkeluar.Value.Date + twkeluar.Value.TimeOfDay;

            if (tanggal_keluar < tanggal_masuk)
            {
                MessageBox.Show("Tanggal yang anda masukan salah");
            }
            else
            {
                TimeSpan temp = tanggal_keluar - tanggal_masuk;
                txtdurasi.Text = Convert.ToString(Math.Round(temp.TotalHours));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                DialogResult a = MessageBox.Show("Yakin akan keluar ?", "Tanya", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    this.Close();

                    Application.Exit();
                }

            }
        }
       
        private void combokamar_SelectedIndexChanged(object sender, EventArgs e)
        { 
            textHarga.Focus();

            if (combokamar.Text == "SINGLE ROOM")
            {
                if (radiof1.Checked)
                {
                    harga = 10000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof2.Checked)
                {
                    harga = 15000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof3.Checked)
                {
                    harga = 20000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof4.Checked)
                {
                    MessageBox.Show("Jenis Fasilitas Tidak Tersedia");
                }
                else if (radiof5.Checked)
                {
                    MessageBox.Show("Jenis Fasilitas Tidak Tersedia");
                }
                else if (radiof6.Checked)
                {
                    MessageBox.Show("Jenis Fasilitas Tidak Tersedia");
                }

            }


            else if (combokamar.Text == "TWIN ROOM")
            {
                if (radiof1.Checked)
                {
                    harga = 25000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof2.Checked)
                {
                    harga = 30000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof3.Checked)
                {
                    harga = 35000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof4.Checked)
                {
                    harga = 40000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof5.Checked)
                {
                    MessageBox.Show("Jenis Fasilitas Tidak Tersedia");
                }
                else if (radiof6.Checked)
                {
                    MessageBox.Show("Jenis Fasilitas Tidak Tersedia");
                }

            }
            else if (combokamar.Text == "DOUBLE ROOM")
            {
                if (radiof1.Checked)
                {
                    harga = 55000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof2.Checked)
                {
                    harga = 60000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof3.Checked)
                {
                    harga = 65000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof4.Checked)
                {
                    harga = 70000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof5.Checked)
                {
                    harga = 75000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof6.Checked)
                {
                    MessageBox.Show("Jenis Fasilitas Tidak Tersedia");
                }

            }
            else if (combokamar.Text == "TRIPLE ROOM")
            {
                if (radiof1.Checked)
                {
                    harga = 80000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof2.Checked)
                {
                    harga = 85000;
                    textHarga.Text = harga.ToString();

                }
                else if (radiof3.Checked)
                {
                    harga = 95000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof4.Checked)
                {
                    harga = 100000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof5.Checked)
                {
                    harga = 150000;
                    textHarga.Text = harga.ToString();
                }
                else if (radiof6.Checked)
                {
                    harga = 250000;
                    textHarga.Text = harga.ToString();
                }
            }
        }  
       
        private void textnama_TextChanged(object sender, EventArgs e)
        {
            
            baik.set_nama(textnama.Text);
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            {
                DialogResult a = MessageBox.Show("Yakin Data Sebelumnya Sudah Selesai ?", "Tanya", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    combokamar.Text = "";
                    tmmasuk.Text = "";
                    tmkeluar.Text = "";
                    textHarga.Text = "";
                    textnama.Text = "";
                    textAl.Text = "";
                    txtdurasi.Text = "";
                    txtbayar.Text = "";
                    twmasuk.Text = "";
                    twkeluar.Text = "";
                }
               
            }
        }
        public void cetakNamapraktikan(string nama,string nim, string alamat, string angkatan){
            MessageBox.Show("Hello nama saya " + nama + "\n" +"Nim : "+nim+ "\n"+ "Asal Saya Dari " + alamat + "\n"+"Teknik Komputer " +angkatan);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cetakNamapraktikan("Aldy Sufriyanto","21120118120021","semarang", "18");
        }

       
        private void twmasuk_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}