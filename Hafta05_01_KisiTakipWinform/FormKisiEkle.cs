using _05_Tipler;
using _08_DosyaRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta05_01_KisiTakipWinform
{
    public partial class FormKisiEkle : Form
    {
        FormSetteings frmSetteings;
        JsonRepository _repository;
        int kisiId = 0;
        public FormKisiEkle()
        {
            _repository = new JsonRepository();
            InitializeComponent();

            cmbCinsiyet.Items.Add(CinsiyetEnum.Kadın);
            cmbCinsiyet.Items.Add(CinsiyetEnum.Erkek);
            cmbCinsiyet.Items.Add(CinsiyetEnum.BelirtmekIstemiyor);

        }

        public FormKisiEkle(KisiCls kisi)
        {
            _repository = new JsonRepository();
            InitializeComponent();

            cmbCinsiyet.Items.Add(CinsiyetEnum.Kadın);
            cmbCinsiyet.Items.Add(CinsiyetEnum.Erkek);
            cmbCinsiyet.Items.Add(CinsiyetEnum.BelirtmekIstemiyor);

            txtAd.Text = kisi.Ad;
            txtSoyad.Text = kisi.Soyad;
            txtYas.Text = kisi.Yas.ToString();
            cmbCinsiyet.SelectedItem = kisi.Cinsiyet;
            kisiId = kisi.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KisiCls kisi = new KisiCls();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Cinsiyet = (CinsiyetEnum)cmbCinsiyet.SelectedItem;
            kisi.Id = kisiId;
            int yas = 0;
            if (int.TryParse(txtYas.Text, out yas))
            {
                kisi.Yas = yas;
            }
            else
            {
                MessageBox.Show("yaş bir sayı olmalıdır");
                return;
            }
            if (kisi.Id <= 0)
                _repository.Add(kisi);
            else
                _repository.Update(kisi);
            
            MessageBox.Show("Kişi Başarıyla Eklendi");
            this.Close();

        }
    }
}
