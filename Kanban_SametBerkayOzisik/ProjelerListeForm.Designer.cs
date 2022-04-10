namespace Kanban_SametBerkayOzisik
{
    partial class ProjelerListeForm
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
            this.dgvProjeListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjeListe
            // 
            this.dgvProjeListe.AllowUserToAddRows = false;
            this.dgvProjeListe.AllowUserToDeleteRows = false;
            this.dgvProjeListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjeListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeListe.Location = new System.Drawing.Point(18, 17);
            this.dgvProjeListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProjeListe.MultiSelect = false;
            this.dgvProjeListe.Name = "dgvProjeListe";
            this.dgvProjeListe.ReadOnly = true;
            this.dgvProjeListe.RowHeadersVisible = false;
            this.dgvProjeListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjeListe.Size = new System.Drawing.Size(258, 881);
            this.dgvProjeListe.TabIndex = 0;
            this.dgvProjeListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjeListe_CellDoubleClick);
            // 
            // ProjelerListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 891);
            this.Controls.Add(this.dgvProjeListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 930);
            this.MinimumSize = new System.Drawing.Size(305, 930);
            this.Name = "ProjelerListeForm";
            this.Text = "ProjelerListeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjeListe;
    }
}