namespace SakilaDBFormApp
{
    partial class frmActors
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
            this.lblActors = new System.Windows.Forms.Label();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(12, 9);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(46, 13);
            this.lblActors.TabIndex = 1;
            this.lblActors.Text = "Actors : ";
            // 
            // dgvActors
            // 
            this.dgvActors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.Location = new System.Drawing.Point(12, 25);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.Size = new System.Drawing.Size(355, 191);
            this.dgvActors.TabIndex = 2;
            // 
            // frmActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 228);
            this.Controls.Add(this.dgvActors);
            this.Controls.Add(this.lblActors);
            this.Name = "frmActors";
            this.Text = "frmActors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.DataGridView dgvActors;
    }
}