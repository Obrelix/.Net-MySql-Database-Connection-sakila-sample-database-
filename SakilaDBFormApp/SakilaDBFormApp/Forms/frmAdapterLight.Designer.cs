namespace SakilaDBFormApp
{
    partial class frmAdapterLight
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.film_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.release_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.original_language_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rental_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replacement_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.special_features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.film_id,
            this.title,
            this.description,
            this.release_year,
            this.language_id,
            this.original_language_id,
            this.rental_duration,
            this.rental_rate,
            this.length,
            this.replacement_cost,
            this.rating,
            this.special_features,
            this.last_update});
            this.dgvDisplay.Location = new System.Drawing.Point(12, 55);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(1106, 548);
            this.dgvDisplay.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(1043, 26);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // film_id
            // 
            this.film_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.film_id.DataPropertyName = "film_id";
            this.film_id.Frozen = true;
            this.film_id.HeaderText = "ID";
            this.film_id.Name = "film_id";
            this.film_id.ReadOnly = true;
            this.film_id.Width = 43;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.DataPropertyName = "title";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.title.DefaultCellStyle = dataGridViewCellStyle1;
            this.title.Frozen = true;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.Width = 52;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 85;
            // 
            // release_year
            // 
            this.release_year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.release_year.DataPropertyName = "release_year";
            this.release_year.HeaderText = "Release Year";
            this.release_year.Name = "release_year";
            this.release_year.Width = 96;
            // 
            // language_id
            // 
            this.language_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.language_id.DataPropertyName = "language_id";
            this.language_id.HeaderText = "Language id";
            this.language_id.Name = "language_id";
            this.language_id.Width = 91;
            // 
            // original_language_id
            // 
            this.original_language_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.original_language_id.DataPropertyName = "original_language_id";
            this.original_language_id.HeaderText = "Original Language id";
            this.original_language_id.Name = "original_language_id";
            this.original_language_id.Width = 108;
            // 
            // rental_duration
            // 
            this.rental_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rental_duration.DataPropertyName = "rental_duration";
            this.rental_duration.HeaderText = "Rental Duration";
            this.rental_duration.Name = "rental_duration";
            this.rental_duration.Width = 97;
            // 
            // rental_rate
            // 
            this.rental_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rental_rate.DataPropertyName = "rental_rate";
            this.rental_rate.HeaderText = "Price";
            this.rental_rate.Name = "rental_rate";
            this.rental_rate.Width = 56;
            // 
            // length
            // 
            this.length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "Length";
            this.length.Name = "length";
            this.length.Width = 65;
            // 
            // replacement_cost
            // 
            this.replacement_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.replacement_cost.DataPropertyName = "replacement_cost";
            this.replacement_cost.HeaderText = "Replacement Cost";
            this.replacement_cost.Name = "replacement_cost";
            this.replacement_cost.Width = 109;
            // 
            // rating
            // 
            this.rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rating.DataPropertyName = "rating";
            this.rating.HeaderText = "Rating";
            this.rating.Name = "rating";
            this.rating.Width = 63;
            // 
            // special_features
            // 
            this.special_features.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.special_features.DataPropertyName = "special_features";
            this.special_features.HeaderText = "Special Features";
            this.special_features.Name = "special_features";
            this.special_features.Width = 102;
            // 
            // last_update
            // 
            this.last_update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.last_update.DataPropertyName = "last_update";
            this.last_update.HeaderText = "Last Update";
            this.last_update.Name = "last_update";
            this.last_update.Width = 83;
            // 
            // frmAdapterLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.ClientSize = new System.Drawing.Size(1130, 615);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvDisplay);
            this.Name = "frmAdapterLight";
            this.Text = "frmAdapterLight";
            this.Load += new System.EventHandler(this.frmAdapterLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn language_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn original_language_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rental_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn rental_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn replacement_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn special_features;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_update;
    }
}