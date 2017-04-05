namespace SakilaDBFormApp
{
    partial class frmActorsInfo
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
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.lblActors = new System.Windows.Forms.Label();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActors
            // 
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.first_name,
            this.last_name,
            this.film_info});
            this.dgvActors.Location = new System.Drawing.Point(12, 67);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(583, 322);
            this.dgvActors.TabIndex = 0;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.Transparent;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblActors.ForeColor = System.Drawing.Color.White;
            this.lblActors.Location = new System.Drawing.Point(12, 28);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(48, 17);
            this.lblActors.TabIndex = 1;
            this.lblActors.Text = "Actors";
            this.lblActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AID
            // 
            this.AID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AID.DataPropertyName = "actor_id";
            this.AID.HeaderText = "AID";
            this.AID.Name = "AID";
            this.AID.Width = 50;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.Width = 82;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last Name";
            this.last_name.Name = "last_name";
            this.last_name.Width = 83;
            // 
            // film_info
            // 
            this.film_info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.film_info.DataPropertyName = "film_info";
            this.film_info.HeaderText = "Films Info";
            this.film_info.Name = "film_info";
            this.film_info.Width = 76;
            // 
            // frmActorsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.ClientSize = new System.Drawing.Size(607, 401);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.dgvActors);
            this.Name = "frmActorsInfo";
            this.Text = "frmActorsInfo";
            this.Load += new System.EventHandler(this.frmActorsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_info;
    }
}