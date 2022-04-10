namespace Kanban_SametBerkayOzisik
{
    partial class KategoriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pboRenk = new System.Windows.Forms.PictureBox();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pboKategoriRenk = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboKategoriRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı :";
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(126, 33);
            this.txtKategoriAd.MaxLength = 15;
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(205, 24);
            this.txtKategoriAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Renk :";
            // 
            // pboRenk
            // 
            this.pboRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.pboRenk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboRenk.Location = new System.Drawing.Point(126, 82);
            this.pboRenk.Name = "pboRenk";
            this.pboRenk.Size = new System.Drawing.Size(205, 25);
            this.pboRenk.TabIndex = 3;
            this.pboRenk.TabStop = false;
            this.pboRenk.Click += new System.EventHandler(this.pboRenk_Click);
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 18;
            this.lstKategoriler.Location = new System.Drawing.Point(28, 184);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(268, 166);
            this.lstKategoriler.TabIndex = 5;
            this.lstKategoriler.SelectedIndexChanged += new System.EventHandler(this.lstKategoriler_SelectedIndexChanged);
            this.lstKategoriler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstKategoriler_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(218, 125);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 33);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Kategori Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pboKategoriRenk
            // 
            this.pboKategoriRenk.BackColor = System.Drawing.SystemColors.Control;
            this.pboKategoriRenk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboKategoriRenk.Location = new System.Drawing.Point(302, 184);
            this.pboKategoriRenk.Name = "pboKategoriRenk";
            this.pboKategoriRenk.Size = new System.Drawing.Size(29, 166);
            this.pboKategoriRenk.TabIndex = 6;
            this.pboKategoriRenk.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Listeden seçtiğiniz kategoriyi silmek için Delete tuşuna basın";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(218, 381);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 33);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet ve Çık";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(217, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maksimum 15 karakter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pboKategoriRenk);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.pboRenk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 465);
            this.Name = "KategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.pboRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboKategoriRenk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboRenk;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pboKategoriRenk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
    }
}