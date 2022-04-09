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
    public partial class FormKisi : Form
    {
        FormSetteings frmSetteings;
        JsonRepository _repository;
        List<KisiCls> orgList;
        public FormKisi()
        {
            InitializeComponent();
            dataGridView1.MultiSelect = false;
            _repository = new JsonRepository();
            RefreshGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKisiEkle frm = new FormKisiEkle();
            frm.ShowDialog();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            List<KisiCls> kisilerListesi = _repository.Get();
            dataGridView1.DataSource = kisilerListesi;
            orgList = kisilerListesi;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Silinecek Kişi Seçiniz");
                return;
            }

            KisiCls silinecelKisi = (KisiCls)dataGridView1.SelectedRows[0].DataBoundItem;

            _repository.Delete(silinecelKisi.Id);
            MessageBox.Show("Kişi Silindi");
            RefreshGrid();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Düzenlenecek Kişi Seçiniz");
                return;
            }
            KisiCls duzenlenecekKisi = (KisiCls)dataGridView1.SelectedRows[0].DataBoundItem;
            FormKisiEkle frm = new FormKisiEkle(duzenlenecekKisi);
            frm.ShowDialog();
            RefreshGrid();
        }

        private void textFilterAd_TextChanged(object sender, EventArgs e)
        {
            string aranacakKelime = textFilterAd.Text;
            //var liste = _repository.Get()

            var liste = orgList.Where(c => c.Ad.ToUpper().Contains(aranacakKelime.ToUpper())).ToList();

            dataGridView1.DataSource = liste;
        }
    }
}
