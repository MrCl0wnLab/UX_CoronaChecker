namespace CoronaChecker
{
    partial class FormCorona
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorona));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblNameApp = new System.Windows.Forms.Label();
            this.lblSubNameApp = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.panelLine4 = new System.Windows.Forms.Panel();
            this.txtDateV = new System.Windows.Forms.TextBox();
            this.panelLine5 = new System.Windows.Forms.Panel();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.panelLine6 = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.panelLine3 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picCPF = new System.Windows.Forms.PictureBox();
            this.picCVV = new System.Windows.Forms.PictureBox();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.picName = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelLine1);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(799, 35);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLine1.ForeColor = System.Drawing.Color.Gray;
            this.panelLine1.Location = new System.Drawing.Point(2, 34);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(797, 10);
            this.panelLine1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(14)))), ((int)(((byte)(79)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(751, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 35);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(14)))), ((int)(((byte)(79)))));
            this.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(553, 606);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(199, 44);
            this.btnScan.TabIndex = 18;
            this.btnScan.Tag = "";
            this.btnScan.Text = "Scan My Body";
            this.btnScan.UseVisualStyleBackColor = false;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGroup.Location = new System.Drawing.Point(327, 717);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(128, 18);
            this.lblGroup.TabIndex = 23;
            this.lblGroup.Text = "Aftosa Group";
            // 
            // lblNameApp
            // 
            this.lblNameApp.AutoSize = true;
            this.lblNameApp.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameApp.ForeColor = System.Drawing.Color.White;
            this.lblNameApp.Location = new System.Drawing.Point(299, 141);
            this.lblNameApp.Name = "lblNameApp";
            this.lblNameApp.Size = new System.Drawing.Size(474, 64);
            this.lblNameApp.TabIndex = 25;
            this.lblNameApp.Text = "Flat-earther Checker";
            // 
            // lblSubNameApp
            // 
            this.lblSubNameApp.AutoSize = true;
            this.lblSubNameApp.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubNameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(14)))), ((int)(((byte)(79)))));
            this.lblSubNameApp.Location = new System.Drawing.Point(448, 215);
            this.lblSubNameApp.Name = "lblSubNameApp";
            this.lblSubNameApp.Size = new System.Drawing.Size(309, 23);
            this.lblSubNameApp.TabIndex = 26;
            this.lblSubNameApp.Text = "Coronavirus Online Test\r";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSite.Location = new System.Drawing.Point(362, 141);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(400, 23);
            this.lblSite.TabIndex = 27;
            this.lblSite.Text = "www.gabinete-da-bondade.org.br";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(133, 329);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(619, 28);
            this.txtName.TabIndex = 3;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLine2.Location = new System.Drawing.Point(133, 363);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(619, 1);
            this.panelLine2.TabIndex = 4;
            // 
            // txtCard
            // 
            this.txtCard.BackColor = System.Drawing.Color.Black;
            this.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.ForeColor = System.Drawing.Color.LightGray;
            this.txtCard.Location = new System.Drawing.Point(133, 438);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(619, 28);
            this.txtCard.TabIndex = 6;
            this.txtCard.Enter += new System.EventHandler(this.txtCard_Enter);
            this.txtCard.Leave += new System.EventHandler(this.txtCard_Leave);
            // 
            // panelLine4
            // 
            this.panelLine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLine4.Location = new System.Drawing.Point(133, 472);
            this.panelLine4.Name = "panelLine4";
            this.panelLine4.Size = new System.Drawing.Size(619, 1);
            this.panelLine4.TabIndex = 7;
            // 
            // txtDateV
            // 
            this.txtDateV.BackColor = System.Drawing.Color.Black;
            this.txtDateV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateV.ForeColor = System.Drawing.Color.LightGray;
            this.txtDateV.Location = new System.Drawing.Point(133, 494);
            this.txtDateV.Name = "txtDateV";
            this.txtDateV.Size = new System.Drawing.Size(619, 28);
            this.txtDateV.TabIndex = 9;
            this.txtDateV.Enter += new System.EventHandler(this.txtDateV_Enter);
            this.txtDateV.Leave += new System.EventHandler(this.txtDateV_Leave);
            // 
            // panelLine5
            // 
            this.panelLine5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLine5.Location = new System.Drawing.Point(133, 528);
            this.panelLine5.Name = "panelLine5";
            this.panelLine5.Size = new System.Drawing.Size(619, 1);
            this.panelLine5.TabIndex = 10;
            // 
            // txtCVV
            // 
            this.txtCVV.BackColor = System.Drawing.Color.Black;
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.ForeColor = System.Drawing.Color.LightGray;
            this.txtCVV.Location = new System.Drawing.Point(133, 550);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(619, 28);
            this.txtCVV.TabIndex = 12;
            this.txtCVV.Enter += new System.EventHandler(this.txtCVV_Enter);
            this.txtCVV.Leave += new System.EventHandler(this.txtCVV_Leave);
            // 
            // panelLine6
            // 
            this.panelLine6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLine6.Location = new System.Drawing.Point(133, 584);
            this.panelLine6.Name = "panelLine6";
            this.panelLine6.Size = new System.Drawing.Size(619, 1);
            this.panelLine6.TabIndex = 13;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.Black;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.LightGray;
            this.txtCPF.Location = new System.Drawing.Point(133, 382);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(619, 28);
            this.txtCPF.TabIndex = 19;
            this.txtCPF.Enter += new System.EventHandler(this.txtCPF_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // panelLine3
            // 
            this.panelLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLine3.Location = new System.Drawing.Point(133, 416);
            this.panelLine3.Name = "panelLine3";
            this.panelLine3.Size = new System.Drawing.Size(619, 1);
            this.panelLine3.TabIndex = 20;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::CoronaChecker.Properties.Resources.virus;
            this.picLogo.Location = new System.Drawing.Point(12, 50);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(307, 263);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // picCPF
            // 
            this.picCPF.BackColor = System.Drawing.Color.Transparent;
            this.picCPF.Image = global::CoronaChecker.Properties.Resources.dialogue;
            this.picCPF.Location = new System.Drawing.Point(27, 372);
            this.picCPF.Name = "picCPF";
            this.picCPF.Size = new System.Drawing.Size(100, 50);
            this.picCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCPF.TabIndex = 21;
            this.picCPF.TabStop = false;
            // 
            // picCVV
            // 
            this.picCVV.BackColor = System.Drawing.Color.Transparent;
            this.picCVV.Image = global::CoronaChecker.Properties.Resources.internet;
            this.picCVV.Location = new System.Drawing.Point(27, 540);
            this.picCVV.Name = "picCVV";
            this.picCVV.Size = new System.Drawing.Size(100, 50);
            this.picCVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCVV.TabIndex = 14;
            this.picCVV.TabStop = false;
            // 
            // picDate
            // 
            this.picDate.BackColor = System.Drawing.Color.Transparent;
            this.picDate.Image = global::CoronaChecker.Properties.Resources.calendar;
            this.picDate.Location = new System.Drawing.Point(27, 484);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(100, 50);
            this.picDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDate.TabIndex = 11;
            this.picDate.TabStop = false;
            // 
            // picCard
            // 
            this.picCard.BackColor = System.Drawing.Color.Transparent;
            this.picCard.Image = global::CoronaChecker.Properties.Resources.credit_card;
            this.picCard.Location = new System.Drawing.Point(27, 428);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(100, 50);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCard.TabIndex = 8;
            this.picCard.TabStop = false;
            // 
            // picName
            // 
            this.picName.BackColor = System.Drawing.Color.Transparent;
            this.picName.Image = global::CoronaChecker.Properties.Resources.opinion;
            this.picName.Location = new System.Drawing.Point(27, 319);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(100, 50);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picName.TabIndex = 5;
            this.picName.TabStop = false;
            // 
            // FormCorona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(799, 744);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblSubNameApp);
            this.Controls.Add(this.lblNameApp);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.picCPF);
            this.Controls.Add(this.panelLine3);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picCVV);
            this.Controls.Add(this.panelLine6);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.picDate);
            this.Controls.Add(this.panelLine5);
            this.Controls.Add(this.txtDateV);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.panelLine4);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.panelLine2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCorona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCorona";
            this.Load += new System.EventHandler(this.FormCorona_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNameApp;
        private System.Windows.Forms.Label lblSubNameApp;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Panel panelLine4;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.TextBox txtDateV;
        private System.Windows.Forms.Panel panelLine5;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Panel panelLine6;
        private System.Windows.Forms.PictureBox picCVV;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Panel panelLine3;
        private System.Windows.Forms.PictureBox picCPF;
    }
}

