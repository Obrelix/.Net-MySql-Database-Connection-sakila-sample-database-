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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pnlConnection.SuspendLayout();
            this.pnlReaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
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
            this.pnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnection.Controls.Add(this.lblConnection);
            this.pnlConnection.Controls.Add(this.chbCoonectionForm);
            this.pnlConnection.Controls.Add(this.btnDisconnect);
            this.pnlConnection.Controls.Add(this.btnConnect);
            this.pnlConnection.Location = new System.Drawing.Point(19, 108);
            this.pnlConnection.Margin = new System.Windows.Forms.Padding(10);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(186, 75);
            this.pnlConnection.TabIndex = 3;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblConnection.Location = new System.Drawing.Point(17, 2);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(144, 16);
            this.lblConnection.TabIndex = 3;
            this.lblConnection.Text = "Connect to local DB";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMovies
            // 
            this.btnMovies.Location = new System.Drawing.Point(10, 14);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(80, 46);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "Show Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // pnlReaders
            // 
            this.pnlReaders.BackgroundImage = global::SakilaDBFormApp.Properties.Resources.cinema;
            this.pnlReaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlReaders.Controls.Add(this.btnCustomers);
            this.pnlReaders.Controls.Add(this.btnMovies);
            this.pnlReaders.Location = new System.Drawing.Point(432, 105);
            this.pnlReaders.Margin = new System.Windows.Forms.Padding(10);
            this.pnlReaders.Name = "pnlReaders";
            this.pnlReaders.Size = new System.Drawing.Size(186, 75);
            this.pnlReaders.TabIndex = 5;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(96, 14);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(80, 46);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Show Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
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
    }
}

