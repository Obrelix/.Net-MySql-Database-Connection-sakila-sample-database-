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
            this.lblConnected = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.cbxMovies = new System.Windows.Forms.ComboBox();
            this.dtpEos = new System.Windows.Forms.DateTimePicker();
            this.dtpApo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(699, 9);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(59, 13);
            this.lblConnected.TabIndex = 22;
            this.lblConnected.Text = "Connected";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Movie ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Εώς";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Από";
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 67);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(746, 176);
            this.dgvOrders.TabIndex = 17;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(718, 37);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(40, 23);
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(577, 39);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(100, 20);
            this.txtMovie.TabIndex = 15;
            // 
            // cbxMovies
            // 
            this.cbxMovies.FormattingEnabled = true;
            this.cbxMovies.Location = new System.Drawing.Point(424, 40);
            this.cbxMovies.Name = "cbxMovies";
            this.cbxMovies.Size = new System.Drawing.Size(147, 21);
            this.cbxMovies.TabIndex = 14;
            // 
            // dtpEos
            // 
            this.dtpEos.Location = new System.Drawing.Point(218, 41);
            this.dtpEos.Name = "dtpEos";
            this.dtpEos.Size = new System.Drawing.Size(200, 20);
            this.dtpEos.TabIndex = 13;
            // 
            // dtpApo
            // 
            this.dtpApo.Location = new System.Drawing.Point(12, 41);
            this.dtpApo.Name = "dtpApo";
            this.dtpApo.Size = new System.Drawing.Size(200, 20);
            this.dtpApo.TabIndex = 12;
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 257);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.cbxMovies);
            this.Controls.Add(this.dtpEos);
            this.Controls.Add(this.dtpApo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.frmMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.ComboBox cbxMovies;
        private System.Windows.Forms.DateTimePicker dtpEos;
        private System.Windows.Forms.DateTimePicker dtpApo;
    }
}