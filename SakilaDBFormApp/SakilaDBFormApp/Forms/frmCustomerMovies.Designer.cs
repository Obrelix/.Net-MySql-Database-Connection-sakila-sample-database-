namespace SakilaDBFormApp.Forms
{
    partial class frmCustomerMovies
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dvgCustMovies = new System.Windows.Forms.DataGridView();
            this.film_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // dvgCustMovies
            // 
            this.dvgCustMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCustMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.film_id,
            this.film_name,
            this.return_date,
            this.rent_id});
            this.dvgCustMovies.Location = new System.Drawing.Point(12, 29);
            this.dvgCustMovies.Name = "dvgCustMovies";
            this.dvgCustMovies.Size = new System.Drawing.Size(402, 278);
            this.dvgCustMovies.TabIndex = 1;
            // 
            // film_id
            // 
            this.film_id.DataPropertyName = "film_id";
            this.film_id.HeaderText = "Film ID";
            this.film_id.Name = "film_id";
            // 
            // film_name
            // 
            this.film_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.film_name.DataPropertyName = "title";
            this.film_name.HeaderText = "Film Name";
            this.film_name.Name = "film_name";
            // 
            // return_date
            // 
            this.return_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.return_date.DataPropertyName = "return_date";
            this.return_date.HeaderText = "Return Date";
            this.return_date.Name = "return_date";
            // 
            // rent_id
            // 
            this.rent_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rent_id.DataPropertyName = "rental_id";
            this.rent_id.HeaderText = "Rental ID";
            this.rent_id.Name = "rent_id";
            // 
            // frmCustomerMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.ClientSize = new System.Drawing.Size(426, 319);
            this.Controls.Add(this.dvgCustMovies);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "frmCustomerMovies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.frmCustomerMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dvgCustMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent_id;
    }
}