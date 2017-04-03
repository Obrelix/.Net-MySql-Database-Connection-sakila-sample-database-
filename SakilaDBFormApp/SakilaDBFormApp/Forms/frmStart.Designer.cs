namespace SakilaDBFormApp
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.btnConnect = new System.Windows.Forms.Button();
            this.chbCoonectionForm = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btnMovies = new System.Windows.Forms.Button();
            this.pnlReaders = new System.Windows.Forms.Panel();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCategoryMovies = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pnlConnection.SuspendLayout();
            this.pnlReaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(9, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(80, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chbCoonectionForm
            // 
            this.chbCoonectionForm.AutoSize = true;
            this.chbCoonectionForm.Location = new System.Drawing.Point(18, 54);
            this.chbCoonectionForm.Name = "chbCoonectionForm";
            this.chbCoonectionForm.Size = new System.Drawing.Size(152, 17);
            this.chbCoonectionForm.TabIndex = 1;
            this.chbCoonectionForm.Text = "Show Connection Window";
            this.chbCoonectionForm.UseVisualStyleBackColor = true;
            this.chbCoonectionForm.CheckedChanged += new System.EventHandler(this.chbCoonectionForm_CheckedChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(95, 22);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 30);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // pnlConnection
            // 
            this.pnlConnection.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnection.Controls.Add(this.lblConnection);
            this.pnlConnection.Controls.Add(this.chbCoonectionForm);
            this.pnlConnection.Controls.Add(this.btnDisconnect);
            this.pnlConnection.Controls.Add(this.btnConnect);
            this.pnlConnection.ForeColor = System.Drawing.Color.White;
            this.pnlConnection.Location = new System.Drawing.Point(19, 19);
            this.pnlConnection.Margin = new System.Windows.Forms.Padding(10);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(186, 75);
            this.pnlConnection.TabIndex = 3;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblConnection.Location = new System.Drawing.Point(16, 2);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(154, 16);
            this.lblConnection.TabIndex = 3;
            this.lblConnection.Text = "Connect to Sakila DB";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(10, 14);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(139, 46);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "Edit Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // pnlReaders
            // 
            this.pnlReaders.BackColor = System.Drawing.Color.Transparent;
            this.pnlReaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReaders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReaders.Controls.Add(this.btnPayments);
            this.pnlReaders.Controls.Add(this.btnCategoryMovies);
            this.pnlReaders.Controls.Add(this.btnCustomers);
            this.pnlReaders.Controls.Add(this.btnMovies);
            this.pnlReaders.Location = new System.Drawing.Point(156, 114);
            this.pnlReaders.Margin = new System.Windows.Forms.Padding(10);
            this.pnlReaders.Name = "pnlReaders";
            this.pnlReaders.Size = new System.Drawing.Size(330, 148);
            this.pnlReaders.TabIndex = 5;
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(175, 77);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(139, 46);
            this.btnPayments.TabIndex = 7;
            this.btnPayments.Text = "Show Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCategoryMovies
            // 
            this.btnCategoryMovies.Location = new System.Drawing.Point(175, 14);
            this.btnCategoryMovies.Name = "btnCategoryMovies";
            this.btnCategoryMovies.Size = new System.Drawing.Size(139, 46);
            this.btnCategoryMovies.TabIndex = 6;
            this.btnCategoryMovies.Text = "Search for Movies";
            this.btnCategoryMovies.UseVisualStyleBackColor = true;
            this.btnCategoryMovies.Click += new System.EventHandler(this.btnCategoryMovies_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(10, 77);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(139, 46);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Show Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.ClientSize = new System.Drawing.Size(637, 333);
            this.Controls.Add(this.pnlReaders);
            this.Controls.Add(this.pnlConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStart";
            this.Text = "Sakila Video Club";
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.pnlReaders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chbCoonectionForm;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Panel pnlReaders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnCategoryMovies;
        private System.Windows.Forms.Button btnPayments;
    }
}

