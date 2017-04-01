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
            this.label4.Location = new System.Drawing.Point(519, 22);
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
            this.dvgMovies.Location = new System.Drawing.Point(12, 67);
            this.dvgMovies.MultiSelect = false;
            this.dvgMovies.Name = "dvgMovies";
            this.dvgMovies.ReadOnly = true;
            this.dvgMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMovies.Size = new System.Drawing.Size(809, 282);
            this.dvgMovies.TabIndex = 17;
            this.dvgMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick_1);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(781, 36);
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
            this.txtMovieName.Location = new System.Drawing.Point(522, 38);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(100, 20);
            this.txtMovieName.TabIndex = 15;
            // 
            // cbxCategories
            // 
            this.cbxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.Location = new System.Drawing.Point(628, 38);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(147, 21);
            this.cbxCategories.TabIndex = 14;
            this.cbxCategories.SelectedIndexChanged += new System.EventHandler(this.cbxCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Category";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(12, 45);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(77, 13);
            this.lblMovies.TabIndex = 24;
            this.lblMovies.Text = "Movies Found:";
            // 
            // frmMovies
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 363);
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
    }
}