using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2a
{
    public partial class formKasir : Form
    {
        public formKasir()
        {
            InitializeComponent();

            makananCb.DisplayMember = "Text";
            makananCb.ValueMember = "Value";

            #anonymous type
            var items = new[]
            {
                new { Text = "Ayam Goreng", Value = 25000},
                new { Text = "Ayam Bakar", Value = 27000},
                new { Text = "Mie Ayam", Value = 15000},
                new { Text = "Mie Goreng", Value = 19000},
            };

            makananCb.DataSource = items;

            minumanCb.DisplayMember = "Text";
            minumanCb.ValueMember = "Value";

            var itemsMinuman = new[]
            {
                new {Text = "Es Teh", Value = 5000},
                new {Text = "Es Teh Tawar", Value = 3000},
                new {Text = "Es Jeruk", Value = 7000},
                new {Text = "Jus Jambu", Value = 10000},
            };

            minumanCb.DataSource = itemsMinuman;

            makananCb.SelectedIndexChanged += new EventHandler(makananCb_SelectedIndexChanged);
            minumanCb.SelectedIndexChanged += new EventHandler(minumanCb_SelectedIndexChanged);
            bayarTb.Leave += new EventHandler(kembaliTb_TextChanged);
            satuanMakanan.ValueChanged += new EventHandler(satuanMakanan_ValueChanged);
            satuanMinuman.ValueChanged += new EventHandler(satuanMinuman_ValueChanged);

            makananCb.SelectedIndex = -1;
            minumanCb.SelectedIndex = -1;
            hargaMakananTb.Text = string.Empty;
            hargaMinumanTb.Text = string.Empty;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void makananCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (makananCb.SelectedItem != null)
            {
                hargaMakananTb.Text = makananCb.SelectedValue.ToString();
            }
        }

        private void hargaMinumanTb_TextChanged(object sender, EventArgs e)
        {
            updateTotal();
        }

        private void minumanCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (minumanCb.SelectedItem != null)
            {
                hargaMinumanTb.Text = minumanCb.SelectedValue.ToString();
            }
        }

        private void totalTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void hargaMakananTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateTotal()
        {
            int makanan = 0, minuman = 0;

            if (!string.IsNullOrEmpty(subTotalMakananTb.Text))
            {
                int.TryParse(subTotalMakananTb.Text, out makanan);
            }

            if (!string.IsNullOrEmpty(subTotalMinumanTb.Text))
            {
                int.TryParse(subTotalMinumanTb.Text, out minuman);
            }

            int total = makanan + minuman;
            totalTb.Text = total.ToString();
        }

        private void kembaliTb_TextChanged(object sender, EventArgs e)
        {
            int total = 0, bayar = 0;

            if (!string.IsNullOrEmpty(totalTb.Text) && !string.IsNullOrEmpty(bayarTb.Text))
            {
                int.TryParse(totalTb.Text, out total);
                int.TryParse(bayarTb.Text, out bayar);
            }

            if (total >= bayar)
            {
                MessageBox.Show("Duit Buat Bayar Kurang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                kembaliTb.Text = string.Empty;
            }
            else
            {
                int kembalian = bayar - total;
                kembaliTb.Text = kembalian.ToString();
            }
        }

        private void namaKasirTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            namaKasirTb.Text = string.Empty;
            hargaMakananTb.Text = string.Empty;
            hargaMinumanTb.Text = string.Empty;
            subTotalMakananTb.Text = string.Empty;
            subTotalMinumanTb.Text = string.Empty;
            bayarTb.Text = string.Empty;
            totalTb.Text = string.Empty;

            kembaliTb.Text = string.Empty;

            makananCb.SelectedIndex = -1;
            minumanCb.SelectedIndex = -1;

            satuanMakanan.Value = 0;
            satuanMinuman.Value = 0;
        }

        private void TotalGb_Enter(object sender, EventArgs e)
        {

        }

        private void subTotalMakananTb_TextChanged(object sender, EventArgs e)
        {
            updateTotal();
        }

        private void subTotalMinumanTb_TextChanged(object sender, EventArgs e)
        {
            updateTotal();
        }

        private void satuanMakanan_ValueChanged(object sender, EventArgs e)
        {
            updateSubTotalMakanan();
        }

        private void satuanMinuman_ValueChanged(object sender, EventArgs e)
        {
            updateSubTotalMinuman();
        }

        private void updateSubTotalMakanan()
        {
            int hargaMakanan = 0, satuan = 0;

            if (!string.IsNullOrEmpty(hargaMakananTb.Text))
            {
                int.TryParse(hargaMakananTb.Text, out hargaMakanan);
            }

            #menconvert decimal menjadi int dari nilai numeric up and down
            satuan = (int)satuanMakanan.Value;

            int subTotal = hargaMakanan * satuan;

            subTotalMakananTb.Text = subTotal.ToString();

        }

        private void updateSubTotalMinuman()
        {
            int hargaMinuman = 0, satuan = 0;

            if (!string.IsNullOrEmpty(hargaMinumanTb.Text))
            {
                int.TryParse(hargaMinumanTb.Text, out hargaMinuman);
            }

            satuan = (int)satuanMinuman.Value;

            int subTotal = hargaMinuman * satuan;

            subTotalMinumanTb.Text = subTotal.ToString();
        }

        private void orderBt_Click(object sender, EventArgs e)
        {
            if (namaKasirTb.Text.Length > 0)
            {
                MessageBox.Show(
                "========================\n" +
                "\t   Warung Makan\n" +
                "========================\n" +
                "Kasir\t\t: " + namaKasirTb.Text + "\n" +
                "-----------------------------------------------\n" +
                "Pesanan\n" +
                makananCb.Text.PadLeft(15) + "\tRp. " + hargaMakananTb.Text + " x" + satuanMakanan.Value + "\n" +
                minumanCb.Text.PadLeft(15) + "\tRp. " + hargaMinumanTb.Text + " x" + satuanMinuman.Value + "\n" +
                "-----------------------------------------------\n" +
                "Total\t\t: Rp. " + totalTb.Text + "\n" +
                "Bayar\t\t: Rp. " + bayarTb.Text + "\n" +
                "Kembali\t\t: Rp. " + kembaliTb.Text + "\n" +
                "========================");
            }
        }
    }
}
