namespace SakilaDBFormApp
{
    partial class frmMoviesPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoviesPay));
            this.lblFilms = new System.Windows.Forms.Label();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.films = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilms
            // 
            this.lblFilms.AutoSize = true;
            this.lblFilms.BackColor = System.Drawing.Color.Transparent;
            this.lblFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFilms.ForeColor = System.Drawing.Color.White;
            this.lblFilms.Location = new System.Drawing.Point(12, 9);
            this.lblFilms.Name = "lblFilms";
            this.lblFilms.Size = new System.Drawing.Size(56, 17);
            this.lblFilms.TabIndex = 1;
            this.lblFilms.Text = "Movies:";
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.films});
            this.dgvFilms.Location = new System.Drawing.Point(12, 29);
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.Size = new System.Drawing.Size(392, 44);
            this.dgvFilms.TabIndex = 2;
            this.dgvFilms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilms_CellContentClick);
            // 
            // films
            // 
            this.films.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.films.DataPropertyName = "title";
            this.films.HeaderText = "Film Tittle";
            this.films.Name = "films";
            this.films.ReadOnly = true;
            // 
            // frmMoviesPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 85);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.lblFilms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(432, 123);
            this.MinimumSize = new System.Drawing.Size(432, 123);
            this.Name = "frmMoviesPay";
            this.Text = "Films";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFilms;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.DataGridViewTextBoxColumn films;
    }
}