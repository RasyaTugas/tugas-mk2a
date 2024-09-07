namespace modul2a
{
    partial class formKasir
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            minumanCb = new ComboBox();
            makananCb = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            hargaMinumanTb = new TextBox();
            hargaMakananTb = new TextBox();
            label4 = new Label();
            namaKasirTb = new TextBox();
            TotalGb = new GroupBox();
            kembaliTb = new TextBox();
            bayarTb = new TextBox();
            totalTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            clearBt = new Button();
            orderBt = new Button();
            groupBox3 = new GroupBox();
            satuanMinuman = new NumericUpDown();
            satuanMakanan = new NumericUpDown();
            groupBox4 = new GroupBox();
            subTotalMinumanTb = new TextBox();
            subTotalMakananTb = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            TotalGb.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)satuanMinuman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)satuanMakanan).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 0;
            label1.Text = "Warung Makan";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(minumanCb);
            groupBox1.Controls.Add(makananCb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // minumanCb
            // 
            minumanCb.FormattingEnabled = true;
            minumanCb.Location = new Point(87, 74);
            minumanCb.Name = "minumanCb";
            minumanCb.Size = new Size(179, 25);
            minumanCb.TabIndex = 3;
            minumanCb.SelectedIndexChanged += minumanCb_SelectedIndexChanged;
            // 
            // makananCb
            // 
            makananCb.FormattingEnabled = true;
            makananCb.Location = new Point(87, 35);
            makananCb.Name = "makananCb";
            makananCb.Size = new Size(179, 25);
            makananCb.TabIndex = 2;
            makananCb.SelectedIndexChanged += makananCb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 1;
            label3.Text = "Minuman";
            // 
            // label2
            // 
            label2.AccessibleName = "makanan";
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 0;
            label2.Text = "Makanan";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hargaMinumanTb);
            groupBox2.Controls.Add(hargaMakananTb);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(305, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(157, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Harga";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // hargaMinumanTb
            // 
            hargaMinumanTb.Location = new Point(18, 74);
            hargaMinumanTb.Name = "hargaMinumanTb";
            hargaMinumanTb.ReadOnly = true;
            hargaMinumanTb.Size = new Size(123, 25);
            hargaMinumanTb.TabIndex = 1;
            hargaMinumanTb.TextChanged += hargaMinumanTb_TextChanged;
            // 
            // hargaMakananTb
            // 
            hargaMakananTb.Location = new Point(18, 35);
            hargaMakananTb.Name = "hargaMakananTb";
            hargaMakananTb.ReadOnly = true;
            hargaMakananTb.Size = new Size(123, 25);
            hargaMakananTb.TabIndex = 0;
            hargaMakananTb.TextChanged += hargaMakananTb_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 220);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 3;
            label4.Text = "Nama Kasir";
            // 
            // namaKasirTb
            // 
            namaKasirTb.Location = new Point(18, 244);
            namaKasirTb.Name = "namaKasirTb";
            namaKasirTb.Size = new Size(188, 23);
            namaKasirTb.TabIndex = 4;
            namaKasirTb.TextChanged += namaKasirTb_TextChanged;
            // 
            // TotalGb
            // 
            TotalGb.Controls.Add(kembaliTb);
            TotalGb.Controls.Add(bayarTb);
            TotalGb.Controls.Add(totalTb);
            TotalGb.Controls.Add(label7);
            TotalGb.Controls.Add(label6);
            TotalGb.Controls.Add(label5);
            TotalGb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalGb.Location = new Point(553, 202);
            TotalGb.Name = "TotalGb";
            TotalGb.Size = new Size(235, 152);
            TotalGb.TabIndex = 5;
            TotalGb.TabStop = false;
            TotalGb.Text = "Total";
            TotalGb.Enter += TotalGb_Enter;
            // 
            // kembaliTb
            // 
            kembaliTb.Location = new Point(68, 107);
            kembaliTb.Name = "kembaliTb";
            kembaliTb.ReadOnly = true;
            kembaliTb.Size = new Size(146, 23);
            kembaliTb.TabIndex = 5;
            kembaliTb.TextChanged += kembaliTb_TextChanged;
            // 
            // bayarTb
            // 
            bayarTb.Location = new Point(68, 68);
            bayarTb.Name = "bayarTb";
            bayarTb.Size = new Size(146, 23);
            bayarTb.TabIndex = 4;
            // 
            // totalTb
            // 
            totalTb.Location = new Point(68, 30);
            totalTb.Name = "totalTb";
            totalTb.ReadOnly = true;
            totalTb.Size = new Size(146, 23);
            totalTb.TabIndex = 6;
            totalTb.TextChanged += totalTb_TextChanged;
            // 
            // label7
            // 
            label7.AccessibleName = "makanan";
            label7.AutoSize = true;
            label7.Location = new Point(6, 110);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 3;
            label7.Text = "KEMBALI";
            // 
            // label6
            // 
            label6.AccessibleName = "makanan";
            label6.AutoSize = true;
            label6.Location = new Point(6, 71);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 2;
            label6.Text = "BAYAR";
            // 
            // label5
            // 
            label5.AccessibleName = "makanan";
            label5.AutoSize = true;
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 1;
            label5.Text = "TOTAL";
            // 
            // clearBt
            // 
            clearBt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBt.Location = new Point(18, 314);
            clearBt.Name = "clearBt";
            clearBt.Size = new Size(91, 40);
            clearBt.TabIndex = 6;
            clearBt.Text = "CLEAR";
            clearBt.UseVisualStyleBackColor = true;
            clearBt.Click += clearBt_Click;
            // 
            // orderBt
            // 
            orderBt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderBt.Location = new Point(115, 314);
            orderBt.Name = "orderBt";
            orderBt.Size = new Size(91, 40);
            orderBt.TabIndex = 7;
            orderBt.Text = "ORDER";
            orderBt.UseVisualStyleBackColor = true;
            orderBt.Click += orderBt_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(satuanMinuman);
            groupBox3.Controls.Add(satuanMakanan);
            groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(468, 71);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(83, 125);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Satuan";
            // 
            // satuanMinuman
            // 
            satuanMinuman.Location = new Point(6, 77);
            satuanMinuman.Name = "satuanMinuman";
            satuanMinuman.Size = new Size(69, 25);
            satuanMinuman.TabIndex = 9;
            satuanMinuman.ValueChanged += satuanMinuman_ValueChanged;
            // 
            // satuanMakanan
            // 
            satuanMakanan.Location = new Point(6, 35);
            satuanMakanan.Name = "satuanMakanan";
            satuanMakanan.Size = new Size(69, 25);
            satuanMakanan.TabIndex = 0;
            satuanMakanan.ValueChanged += satuanMakanan_ValueChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(subTotalMinumanTb);
            groupBox4.Controls.Add(subTotalMakananTb);
            groupBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(557, 73);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(231, 123);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sub Total";
            // 
            // subTotalMinumanTb
            // 
            subTotalMinumanTb.Location = new Point(6, 74);
            subTotalMinumanTb.Name = "subTotalMinumanTb";
            subTotalMinumanTb.ReadOnly = true;
            subTotalMinumanTb.Size = new Size(204, 25);
            subTotalMinumanTb.TabIndex = 3;
            subTotalMinumanTb.TextChanged += subTotalMinumanTb_TextChanged;
            // 
            // subTotalMakananTb
            // 
            subTotalMakananTb.Location = new Point(6, 33);
            subTotalMakananTb.Name = "subTotalMakananTb";
            subTotalMakananTb.ReadOnly = true;
            subTotalMakananTb.Size = new Size(204, 25);
            subTotalMakananTb.TabIndex = 2;
            subTotalMakananTb.TextChanged += subTotalMakananTb_TextChanged;
            // 
            // formKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 406);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(orderBt);
            Controls.Add(clearBt);
            Controls.Add(TotalGb);
            Controls.Add(namaKasirTb);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formKasir";
            Text = "formKasir";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TotalGb.ResumeLayout(false);
            TotalGb.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)satuanMinuman).EndInit();
            ((System.ComponentModel.ISupportInitialize)satuanMakanan).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private ComboBox minumanCb;
        private ComboBox makananCb;
        private TextBox hargaMakananTb;
        private TextBox hargaMinumanTb;
        private Label label4;
        private TextBox namaKasirTb;
        private GroupBox TotalGb;
        private Label label6;
        private Label label5;
        private TextBox kembaliTb;
        private TextBox bayarTb;
        private TextBox totalTb;
        private Label label7;
        private Button clearBt;
        private Button orderBt;
        private GroupBox groupBox3;
        private NumericUpDown satuanMinuman;
        private NumericUpDown satuanMakanan;
        private GroupBox groupBox4;
        private TextBox subTotalMinumanTb;
        private TextBox subTotalMakananTb;
    }
}