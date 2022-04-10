namespace Kanban_SametBerkayOzisik
{
    partial class ProjeForm
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
            this.btnNotEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotEkle
            // 
            this.btnNotEkle.Location = new System.Drawing.Point(0, 1);
            this.btnNotEkle.Name = "btnNotEkle";
            this.btnNotEkle.Size = new System.Drawing.Size(75, 23);
            this.btnNotEkle.TabIndex = 2;
            this.btnNotEkle.Text = "Not Ekle";
            this.btnNotEkle.UseVisualStyleBackColor = true;
            this.btnNotEkle.Click += new System.EventHandler(this.btnNotEkle_Click);
            // 
            // ProjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 911);
            this.Controls.Add(this.btnNotEkle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 950);
            this.MinimumSize = new System.Drawing.Size(750, 950);
            this.Name = "ProjeForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjeForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.ProjeForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNotEkle;
    }
}

