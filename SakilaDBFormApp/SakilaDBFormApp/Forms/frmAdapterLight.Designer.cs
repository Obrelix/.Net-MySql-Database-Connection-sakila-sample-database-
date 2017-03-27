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
            this.description});
            this.dgvDisplay.Location = new System.Drawing.Point(12, 55);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.Size = new System.Drawing.Size(344, 195);
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
            this.btnsave.Location = new System.Drawing.Point(281, 26);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // film_id
            // 
            this.film_id.DataPropertyName = "film_id";
            this.film_id.Frozen = true;
            this.film_id.HeaderText = "ID";
            this.film_id.Name = "film_id";
            this.film_id.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.title.DefaultCellStyle = dataGridViewCellStyle1;
            this.title.Frozen = true;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // frmAdapterLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 262);
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
    }
}