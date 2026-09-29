using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
       
        private HashSet<string> alinanBiletler = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Başlıq etiketi
            label10.Text = "BMU travel";
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            var temp = comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = temp;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Şəhər seçimi yoxlanışı
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Xahiş olunur, gediş və gəliş şəhərlərini seçin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem.ToString() == comboBox2.SelectedItem.ToString())
            {
                MessageBox.Show("Gediş və gəliş şəhəri eyni ola bilməz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Xahiş olunur, Ad və Soyad xanasını doldurun!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string finKod = textBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(finKod) || finKod.Length != 7)
            {
                MessageBox.Show("FİN kod dəqiq 7 simvoldan ibarət olmalıdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string email = textBox3.Text.Trim();
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Xahiş olunur, düzgün e-poçt ünvanı daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string tarix = maskedTextBox1.Text;
            string saat = maskedTextBox2.Text;
            string yer = comboBox3.SelectedItem != null ? comboBox3.SelectedItem.ToString() : "Təyin edilməyib";

            string haradan = comboBox1.SelectedItem.ToString();
            string haraya = comboBox2.SelectedItem.ToString();
            string adSoyad = textBox1.Text.Trim();
            string telefon = maskedTextBox3.Text;

            string biletAçari = $"{haradan}-{haraya}-{tarix}-{saat}-{yer}-{finKod}";

            if (alinanBiletler.Contains(biletAçari))
            {
                MessageBox.Show("Bu bilet artıq alınıb! Eyni məlumatlarla 2 dəfə bilet almaq olmaz.", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            
            alinanBiletler.Add(biletAçari);

            string biletMəlumati = $"--------------------------------------------------\n" +
                                   $"Sərnişin: {adSoyad} | FİN: {finKod} | Tel: {telefon} | Email: {email}\n" +
                                   $"Marşrut: {haradan} -> {haraya} | Tarix: {tarix} | Saat: {saat} | Yer No: {yer}\n";

            richTextBox1.AppendText(biletMəlumati + "\n");

            MessageBox.Show("Bilet uğurla alındı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Silinəcək bilet tapılmadı.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("Siyahıdakı biletləri silməyə əminsinizmi?", "Siyahını Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                richTextBox1.Clear();
                alinanBiletler.Clear();
                MessageBox.Show("Bilet siyahısı təmizləndi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}