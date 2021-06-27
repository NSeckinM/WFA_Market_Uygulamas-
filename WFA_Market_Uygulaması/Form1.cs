using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Market_Uygulaması
{
    public partial class AnaForm : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=KuzeyYeli1; uid=sa; pwd=123");
        List<Kategori> kategoriler;
        List<Urun> Urunler;

        public AnaForm()
        {
            con.Open();
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false; // otomatik sütn oluşturmayı durdurur.
            KategorileriListele();
        }

        private void KategorileriListele()
        {
            // SQL serverdan alacağımız verileri tutacağımız kategori class ı türünde bir liste oluşturuyoruz.
            kategoriler = new List<Kategori>();

            // SqlCommand nesnesi ile SQL server a sorgu gönderip verileri alıyoruz bağlantıyı con ile gerçekleştiriyoruz
            //daha sonra dr ye executeReader ile sorgu sonucu okunan değerler aktarılıyor.
            // ve daha sonra bu değerler okunup oluşturduğumuz listeye aktarıyoruz.

            var cmd = new SqlCommand("SELECT Id, KategoriAd, UstKategoriId FROM Kategoriler" , con);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kategoriler.Add(new Kategori()
                {
                    Id = (int)dr[0],
                    KategoriAd = (string)dr[1],
                    UstKategoriId = dr[2] is DBNull ? null as int? : (int)dr[2]
                });
            }
            dr.Close();
            tviKategoriler.Nodes.Clear();
            KategorileriDugumOlarakEKle(tviKategoriler.Nodes,null);
        }

        /// <summary>
        /// Bu metot verilen düğüm koleksiyonuna üst kategori id'sine ait olan tüm alt kategorileri
        /// düğüm olarak (TreeNode) ekler ve aynı işlemi her bir eklenen node'un -varsa- alt 
        /// kategorileri içinde recursive olarak yapar.
        /// </summary>
        /// <param name="nodes">İçerisine düğümlerin ekleneceği düğüm koleksiyonu</param>
        /// <param name="ustKategoriId">Eklenecek kategorilerin üst kategorisinin id'si</param>
        /// 
        private void KategorileriDugumOlarakEKle(TreeNodeCollection nodes, int? ustKategoriId )
        {

            foreach (Kategori item in kategoriler.Where(x => x.UstKategoriId == ustKategoriId))
            {
                TreeNode node = new TreeNode(item.KategoriAd);
                node.Tag = item;
                KategorileriDugumOlarakEKle(node.Nodes, item.Id);
                nodes.Add(node);
            }

        }
        private void UrunleriListele()
        {
            //eğer treeview de bir şey seçilmemişse datagridview de ürünleri gösterme.
            if (tviKategoriler.SelectedNode == null)
            {
                dgvUrunler.DataSource = null;
                return;
            }

            //tvi de secileni nesneyi objeden tekrar kategori türüne cast ederek alıp,
            // ıd sini kategorId adında bir local variable a atadık.
            Kategori kategori  = (Kategori)tviKategoriler.SelectedNode.Tag;
            int kategoriId = kategori.Id;

            Urunler = new List<Urun>(); //sql den alacağımız ürün verilerini tutmak için bir liste oluşturduk.

            var cmd = new SqlCommand("SELECT Id, KategoriId, UrunAd, BirimFiyat, StokAdet, Resim FROM Urunler"
                + " WHERE KategoriId = @p1" , con);
            cmd.Parameters.AddWithValue("@p1", kategoriId);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Urunler.Add(new Urun()
                {
                    Id = (int)dr[0],
                    KategoriId = (int)dr[1],
                    UrunAd = (string)dr[2],
                    BirimFiyat = (decimal)dr[3],
                    StokAdet = (int)dr[4],
                    Resim = dr[5] is DBNull ? null : (byte[])dr[5]
                });
            }
            dr.Close();
            dgvUrunler.DataSource = Urunler;

        }

        private void tviKategoriler_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UrunleriListele();
            btnKategoriEkle.Enabled = btnKategoriDuzenle.Enabled = btnKategoriSil.Enabled = tviKategoriler.SelectedNode != null;
        }

        private void dgvUrunler_SelectionChanged(object sender, EventArgs e)
        {
            btnUrunDuzenle.Enabled = btnUrunSil.Enabled = dgvUrunler.SelectedRows.Count != 0;
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (tviKategoriler.SelectedNode == null) return;

            DialogResult dr = MessageBox.Show("Seçili kategori ve altındaki tüm ürünler silinecektir. Onaylıyor musunuz?", "Silme Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                Kategori kategori = (Kategori)tviKategoriler.SelectedNode.Tag;
                int Id = kategori.Id;
                var cmd = new SqlCommand("DELETE FROM Kategoriler WHERE Id = @p1", con);
                cmd.Parameters.AddWithValue("@p1", Id);
                cmd.ExecuteNonQuery();
                KategorileriListele();
            }

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0) return;

            DialogResult dr = MessageBox.Show("Seçili ürün silinecektir onaylıyor musunuz ? ","Ürün Silme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.Yes)
            {
                Urun urun = (Urun)dgvUrunler.SelectedRows[0].DataBoundItem;
                int Id = urun.Id;
                var cmd = new SqlCommand("DELETE FROM Urunler WHERE Id = @p1", con);
                cmd.Parameters.AddWithValue("@p1", Id);
                cmd.ExecuteNonQuery();
                KategorileriListele();
                KategoriyiSec(urun.KategoriId);
            }

        }
        private void KategoriyiSec(int kategoriId)
        {
            foreach (TreeNode node in tviKategoriler.Descendants())
            {
                Kategori kategori = (Kategori)node.Tag;
                if (kategori.Id == kategoriId)
                {
                    tviKategoriler.SelectedNode = node;
                    return;
                }
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriForm KForm = new KategoriForm(con);
            DialogResult dr = KForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                KategorileriListele();
                KategoriyiSec(KForm.SonEklenenId);
            }
        }
        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            if (tviKategoriler.SelectedNode == null) return;

            Kategori kategori = (Kategori)tviKategoriler.SelectedNode.Tag;
            KategoriForm Kform = new KategoriForm(con, kategori);
            DialogResult dr = Kform.ShowDialog();
            if (dr == DialogResult.OK)
            {
                KategorileriListele();
                KategoriyiSec(kategori.Id);
            }


        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunForm UForm = new UrunForm(con);
            DialogResult dr = UForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                KategorileriListele();
                UrunSec(UForm.Urun);
            }


        }

        private void UrunSec(Urun urun)
        {
            KategoriyiSec(urun.KategoriId);

            dgvUrunler.ClearSelection();
            for (int i = 0; i < dgvUrunler.Rows.Count; i++)
            {
                DataGridViewRow row = dgvUrunler.Rows[i];
                Urun u = (Urun)row.DataBoundItem;

                if (urun.Id == u.Id)
                {
                    row.Selected = true;
                }
            }
        }

        private void dgvUrunler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvUrunler.SelectedRows.Count > 0)
            {
                btnUrunSil.PerformClick();
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0) return;
            Urun urun = (Urun)dgvUrunler.SelectedRows[0].DataBoundItem;
            UrunForm UForm = new UrunForm(con, urun);
            DialogResult dr = UForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                KategorileriListele();
                UrunSec(urun);
            }

        }
    }
}
