#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class Pasiyent { public string AdSoyad { get; set; } public string Telefon { get; set; } public int Yas { get; set; } }
    public class Hekim { public string AdSoyad { get; set; } public string Ixtisas { get; set; } }
    public class Randevu { public string Tarix { get; set; } public string Pasiyent { get; set; } public string Hekim { get; set; } }

    public partial class Form1 : Form
    {
        List<Pasiyent> pasiyentler = new List<Pasiyent>();
        List<Hekim> hekimler = new List<Hekim>();
        List<Randevu> randevular = new List<Randevu>();

        TabControl tabControl1;
        DataGridView dgvPasiyentler, dgvHekimler, dgvRandevular;
        TextBox txtPasiyentAd, txtPasiyentTelefon, txtPasiyentYas, txtHekimAd, txtHekimIxtisas, txtRandevuTarix;
        ComboBox cbRandevuPasiyent, cbRandevuHekim;

        public Form1()
        {
            InitializeComponent();
            InterfeysiQur();
        }

        private void InterfeysiQur()
        {
            this.Text = "Klinika Randevu Sistemi";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            pasiyentler.Add(new Pasiyent { AdSoyad = "Aysel Memmedova", Telefon = "055-555-55-55", Yas = 32 });
            hekimler.Add(new Hekim { AdSoyad = "Dr. Kamran Eliyev", Ixtisas = "Kardioloq" });

            tabControl1 = new TabControl { Dock = DockStyle.Fill, Font = new Font("Segoe UI", 10) };

            // PASİYENTLƏR SƏHİFƏSİ
            TabPage tabPasiyent = new TabPage("Pasiyentlər") { BackColor = Color.WhiteSmoke };
            tabPasiyent.Controls.Add(new Label { Text = "Ad Soyad:", Location = new Point(20, 20), AutoSize = true });
            tabPasiyent.Controls.Add(txtPasiyentAd = new TextBox { Location = new Point(100, 20), Width = 200 });
            tabPasiyent.Controls.Add(new Label { Text = "Telefon:", Location = new Point(20, 60), AutoSize = true });
            tabPasiyent.Controls.Add(txtPasiyentTelefon = new TextBox { Location = new Point(100, 60), Width = 200 });
            tabPasiyent.Controls.Add(new Label { Text = "Yaş:", Location = new Point(20, 100), AutoSize = true });
            tabPasiyent.Controls.Add(txtPasiyentYas = new TextBox { Location = new Point(100, 100), Width = 200 });

            Button btnPas = new Button { Text = "Əlavə Et", Location = new Point(100, 140), Width = 100, BackColor = Color.LightGray };
            btnPas.Click += (s, e) => {
                pasiyentler.Add(new Pasiyent { AdSoyad = txtPasiyentAd.Text, Telefon = txtPasiyentTelefon.Text, Yas = int.TryParse(txtPasiyentYas.Text, out int y) ? y : 0 });
                dgvPasiyentler.DataSource = null; dgvPasiyentler.DataSource = pasiyentler; DropDaunlariYenile();
                txtPasiyentAd.Clear(); txtPasiyentTelefon.Clear(); txtPasiyentYas.Clear();
            };
            tabPasiyent.Controls.Add(btnPas);
            tabPasiyent.Controls.Add(dgvPasiyentler = new DataGridView { Location = new Point(20, 190), Width = 730, Height = 320, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill });
            dgvPasiyentler.DataSource = pasiyentler;

            // HƏKİMLƏR SƏHİFƏSİ
            TabPage tabHekim = new TabPage("Həkimlər") { BackColor = Color.WhiteSmoke };
            tabHekim.Controls.Add(new Label { Text = "Ad Soyad:", Location = new Point(20, 20), AutoSize = true });
            tabHekim.Controls.Add(txtHekimAd = new TextBox { Location = new Point(100, 20), Width = 200 });
            tabHekim.Controls.Add(new Label { Text = "İxtisas:", Location = new Point(20, 60), AutoSize = true });
            tabHekim.Controls.Add(txtHekimIxtisas = new TextBox { Location = new Point(100, 60), Width = 200 });

            Button btnHek = new Button { Text = "Əlavə Et", Location = new Point(100, 100), Width = 100, BackColor = Color.LightGray };
            btnHek.Click += (s, e) => {
                hekimler.Add(new Hekim { AdSoyad = txtHekimAd.Text, Ixtisas = txtHekimIxtisas.Text });
                dgvHekimler.DataSource = null; dgvHekimler.DataSource = hekimler; DropDaunlariYenile();
                txtHekimAd.Clear(); txtHekimIxtisas.Clear();
            };
            tabHekim.Controls.Add(btnHek);
            tabHekim.Controls.Add(dgvHekimler = new DataGridView { Location = new Point(20, 150), Width = 730, Height = 360, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill });
            dgvHekimler.DataSource = hekimler;

            // RANDEVULAR SƏHİFƏSİ
            TabPage tabRandevu = new TabPage("Randevular") { BackColor = Color.WhiteSmoke };
            tabRandevu.Controls.Add(new Label { Text = "Pasiyent:", Location = new Point(20, 20), AutoSize = true });
            tabRandevu.Controls.Add(cbRandevuPasiyent = new ComboBox { Location = new Point(100, 20), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList });
            tabRandevu.Controls.Add(new Label { Text = "Həkim:", Location = new Point(20, 60), AutoSize = true });
            tabRandevu.Controls.Add(cbRandevuHekim = new ComboBox { Location = new Point(100, 60), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList });
            tabRandevu.Controls.Add(new Label { Text = "Tarix/Saat:", Location = new Point(20, 100), AutoSize = true });
            tabRandevu.Controls.Add(txtRandevuTarix = new TextBox { Location = new Point(100, 100), Width = 200, Text = "15 Fevral, 14:00" });

            Button btnRan = new Button { Text = "Randevu Yarat", Location = new Point(100, 140), Width = 120, BackColor = Color.LightGray };
            btnRan.Click += (s, e) => {
                if (cbRandevuPasiyent.SelectedItem == null || cbRandevuHekim.SelectedItem == null) return;
                randevular.Add(new Randevu { Pasiyent = ((Pasiyent)cbRandevuPasiyent.SelectedItem).AdSoyad, Hekim = ((Hekim)cbRandevuHekim.SelectedItem).AdSoyad, Tarix = txtRandevuTarix.Text });
                dgvRandevular.DataSource = null; dgvRandevular.DataSource = randevular;
            };
            tabRandevu.Controls.Add(btnRan);
            tabRandevu.Controls.Add(dgvRandevular = new DataGridView { Location = new Point(20, 190), Width = 730, Height = 320, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill });

            DropDaunlariYenile();

            tabControl1.TabPages.Add(tabPasiyent); tabControl1.TabPages.Add(tabHekim); tabControl1.TabPages.Add(tabRandevu);
            this.Controls.Add(tabControl1);
        }

        void DropDaunlariYenile()
        {
            cbRandevuPasiyent.DataSource = null; cbRandevuPasiyent.DataSource = pasiyentler; cbRandevuPasiyent.DisplayMember = "AdSoyad";
            cbRandevuHekim.DataSource = null; cbRandevuHekim.DataSource = hekimler; cbRandevuHekim.DisplayMember = "AdSoyad";
        }
    }
}
