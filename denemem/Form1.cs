using denemem.DataAccess;
using denemem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemem
{
    public partial class Form1 : Form
    {
        DenememDbContext _db= new DenememDbContext();
        public int  secimId=-1;
        Urun urunler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboDoldurma();
            Listele();

        }

        private void Listele()
        {
            liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in _db.Urunler
                       select new
                       {
                           Id = s.Id,
                           UrunAdi = s.UrunAdi,
                           UreticiFirma = s.UreticiFirma,
                           Fiyat = s.Fiyat,
                           KategoriAdi = s.Kategori.KategoriAdi


                       }).ToList();
            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value= k.UrunAdi;
                liste.Rows[i].Cells[2].Value= k.UreticiFirma;
                liste.Rows[i].Cells[3].Value= k.Fiyat;
                liste.Rows[i].Cells[4].Value = k.KategoriAdi;
                i++;
                sira++;

            }
            liste.AllowUserToAddRows = false;
            liste.ReadOnly = true;
            liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;

        }

        private void ComboDoldurma()
        {
            var kat=_db.Kategoriler.ToList();  
            kategoricombo.DataSource = kat;
            kategoricombo.DisplayMember = "kategori";
            kategoricombo.ValueMember = "kategoriAdi";
            kategoricombo.SelectedIndex = -1;

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Urun urunler=new Urun();
            urunler.UrunAdi = txtürünadi.Text;
            urunler.UreticiFirma = txtüreticifirma.Text;
            urunler.Fiyat = txtfiyat.Text;
            if (kategoricombo.SelectedValue!=null)
            {
                urunler.KategoriId = kategoricombo.SelectedIndex;
            }
            _db.Urunler.Add(urunler);
            _db.SaveChanges();
            Listele();

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtfiyat.Clear();
            txtüreticifirma.Clear();
            txtürünadi.Clear();
            kategoricombo.SelectedIndex = -1;

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            var urun = urunler;
            urun.UrunAdi = txtürünadi.Text;
            urun.UreticiFirma = txtüreticifirma.Text;
            urun.Fiyat = txtfiyat.Text;
            if (kategoricombo.SelectedValue!=null)

            {
                urun.KategoriId = kategoricombo.SelectedIndex;
            }
            _db.SaveChanges();
            Listele();
            Temizle();

        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void Ac(int id)
        {
            secimId=id;
            urunler = _db.Urunler.Find(id);
            try
            {
                Urun urun = urunler;
                txtfiyat.Text= urun.Fiyat;
                txtüreticifirma.Text = urun.UreticiFirma;
                txtürünadi.Text = urun.UrunAdi;
                kategoricombo.Text = urun.Kategori.KategoriAdi;

            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (secimId>0)
            {
                Urun urun = urunler;
                _db.Urunler.Remove(urun);
                _db.SaveChanges();

            }
            Listele();
            Temizle();
        }
    }
}
