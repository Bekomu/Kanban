namespace Kanban_SametBerkayOzisik
{
    partial class NotEkleForm
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
            this.pnlNotYeni = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.pnlNotYeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNotYeni
            // 
            this.pnlNotYeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.pnlNotYeni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotYeni.Controls.Add(this.lblKategori);
            this.pnlNotYeni.Controls.Add(this.lblBaslik);
            this.pnlNotYeni.Controls.Add(this.lblIcerik);
            this.pnlNotYeni.Location = new System.Drawing.Point(317, 28);
            this.pnlNotYeni.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNotYeni.Name = "pnlNotYeni";
            this.pnlNotYeni.Size = new System.Drawing.Size(200, 200);
            this.pnlNotYeni.TabIndex = 8;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Enabled = false;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(12, 6);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(173, 19);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Başlık";
            // 
            // lblIcerik
            // 
            this.lblIcerik.Enabled = false;
            this.lblIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcerik.Location = new System.Drawing.Point(12, 51);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(173, 147);
            this.lblIcerik.TabIndex = 2;
            this.lblIcerik.Text = "İçerik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık :";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslik.Location = new System.Drawing.Point(115, 28);
            this.txtBaslik.MaxLength = 15;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(175, 23);
            this.txtBaslik.TabIndex = 1;
            this.txtBaslik.TextChanged += new System.EventHandler(this.txtBaslik_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "İçerik :";
            // 
            // txtIcerik
            // 
            this.txtIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerik.Location = new System.Drawing.Point(115, 80);
            this.txtIcerik.MaxLength = 140;
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.Size = new System.Drawing.Size(175, 148);
            this.txtIcerik.TabIndex = 3;
            this.txtIcerik.TextChanged += new System.EventHandler(this.txtIcerik_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori :";
            // 
            // cboKategori
            // 
            this.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(115, 253);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(175, 26);
            this.cboKategori.TabIndex = 7;
            this.cboKategori.SelectedIndexChanged += new System.EventHandler(this.cboKategori_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(317, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 33);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Not Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maksimum 140 Karakter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalan
            // 
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(27, 208);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(82, 20);
            this.lblKalan.TabIndex = 5;
            this.lblKalan.Text = "Kalan : 140";
            // 
            // lblKategori
            // 
            this.lblKategori.Enabled = false;
            this.lblKategori.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(13, 26);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(173, 20);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori";
            // 
            // NotEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 306);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cboKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlNotYeni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 345);
            this.Name = "NotEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Not";
            this.pnlNotYeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNotYeni;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblKategori;
    }
}