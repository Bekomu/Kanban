namespace Kanban_SametBerkayOzisik
{
    partial class ProjeBilgiForm
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proje Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(246, 24);
            this.txtAd.TabIndex = 1;
            this.txtAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAd_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(22, 83);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(324, 42);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Yeni Proje Oluştur";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ProjeBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 148);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 187);
            this.MinimumSize = new System.Drawing.Size(385, 187);
            this.Name = "ProjeBilgiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Proje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
    }
}