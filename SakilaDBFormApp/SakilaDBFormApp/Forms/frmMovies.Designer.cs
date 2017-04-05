namespace SakilaDBFormApp
{
    partial class frmMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovies));
            this.label4 = new System.Windows.Forms.Label();
            this.dvgMovies = new System.Windows.Forms.DataGridView();
            this.FID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realeasedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replacementCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.cbxCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(706, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Movie Name:";
            // 
            // dvgMovies
            // 
            this.dvgMovies.AllowUserToAddRows = false;
            this.dvgMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FID,
            this.title,
            this.Category,
            this.rentalDuration,
            this.length,
            this.realeasedYear,
            this.rentalRate,
            this.replacementCost,
            this.description,
            this.specialFeatures});
            this.dvgMovies.Location = new System.Drawing.Point(12, 67);
            this.dvgMovies.MultiSelect = false;
            this.dvgMovies.Name = "dvgMovies";
            this.dvgMovies.ReadOnly = true;
            this.dvgMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMovies.Size = new System.Drawing.Size(996, 351);
            this.dvgMovies.TabIndex = 17;
            this.dvgMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMovies_CellContentClick);
            this.dvgMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMovies_CellDoubleClick);
            // 
            // FID
            // 
            this.FID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FID.DataPropertyName = "FID";
            this.FID.HeaderText = "FID";
            this.FID.Name = "FID";
            this.FID.ReadOnly = true;
            this.FID.Width = 49;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.DataPropertyName = "title";
            this.title.FillWeight = 160F;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 52;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.DataPropertyName = "category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 74;
            // 
            // rentalDuration
            // 
            this.rentalDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentalDuration.DataPropertyName = "rental_duration";
            this.rentalDuration.HeaderText = "Rental Duration";
            this.rentalDuration.Name = "rentalDuration";
            this.rentalDuration.ReadOnly = true;
            this.rentalDuration.Width = 97;
            // 
            // length
            // 
            this.length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "Length ( min )";
            this.length.MinimumWidth = 10;
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Width = 69;
            // 
            // realeasedYear
            // 
            this.realeasedYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.realeasedYear.DataPropertyName = "rating";
            this.realeasedYear.HeaderText = "Rating";
            this.realeasedYear.Name = "realeasedYear";
            this.realeasedYear.ReadOnly = true;
            this.realeasedYear.Width = 63;
            // 
            // rentalRate
            // 
            this.rentalRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rentalRate.DataPropertyName = "price";
            this.rentalRate.HeaderText = "Price ( $ )";
            this.rentalRate.Name = "rentalRate";
            this.rentalRate.ReadOnly = true;
            this.rentalRate.Width = 60;
            // 
            // replacementCost
            // 
            this.replacementCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.replacementCost.DataPropertyName = "replacement_cost";
            this.replacementCost.HeaderText = "Replacement Cost ( $ )";
            this.replacementCost.Name = "replacementCost";
            this.replacementCost.ReadOnly = true;
            this.replacementCost.Width = 117;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 250;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 250;
            // 
            // specialFeatures
            // 
            this.specialFeatures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.specialFeatures.DataPropertyName = "special_features";
            this.specialFeatures.HeaderText = "Special Features";
            this.specialFeatures.Name = "specialFeatures";
            this.specialFeatures.ReadOnly = true;
            this.specialFeatures.Width = 102;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(968, 36);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(40, 23);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMovieName.Location = new System.Drawing.Point(709, 38);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(100, 20);
            this.txtMovieName.TabIndex = 15;
            this.txtMovieName.TextChanged += new System.EventHandler(this.txtMovieName_TextChanged);
            // 
            // cbxCategories
            // 
            this.cbxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(815, 38);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(147, 21);
            this.cbxCategories.TabIndex = 14;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(812, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Category";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.BackColor = System.Drawing.Color.Transparent;
            this.lblMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMovies.ForeColor = System.Drawing.Color.White;
            this.lblMovies.Location = new System.Drawing.Point(12, 25);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(100, 17);
            this.lblMovies.TabIndex = 24;
            this.lblMovies.Text = "Movies Found:";
            // 
            // frmMovies
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 432);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgMovies);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.cbxCategories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.frmMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvgMovies;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.ComboBox cbxCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn FID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn realeasedYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn replacementCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialFeatures;
    }
}