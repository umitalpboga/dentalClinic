namespace projedeneme1.formlar
{
    partial class frmsecilikisimuayene
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsecilikisimuayene));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tbpoliklinik = new System.Windows.Forms.TextBox();
            this.tbnumara = new System.Windows.Forms.TextBox();
            this.dtpmuayenetarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbdoktor = new System.Windows.Forms.ComboBox();
            this.cbhasta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbaciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbucret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbarama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdmuayeneler = new System.Windows.Forms.DataGridView();
            this.btnsonlandir = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdmuayeneler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bölüm:";
            // 
            // tbpoliklinik
            // 
            this.tbpoliklinik.Enabled = false;
            this.tbpoliklinik.Location = new System.Drawing.Point(115, 204);
            this.tbpoliklinik.Name = "tbpoliklinik";
            this.tbpoliklinik.Size = new System.Drawing.Size(100, 20);
            this.tbpoliklinik.TabIndex = 21;
            // 
            // tbnumara
            // 
            this.tbnumara.Location = new System.Drawing.Point(117, 80);
            this.tbnumara.Name = "tbnumara";
            this.tbnumara.Size = new System.Drawing.Size(34, 20);
            this.tbnumara.TabIndex = 18;
            // 
            // dtpmuayenetarihi
            // 
            this.dtpmuayenetarihi.Location = new System.Drawing.Point(115, 146);
            this.dtpmuayenetarihi.Name = "dtpmuayenetarihi";
            this.dtpmuayenetarihi.Size = new System.Drawing.Size(173, 20);
            this.dtpmuayenetarihi.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbpoliklinik);
            this.groupBox1.Controls.Add(this.btniptal);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.tbnumara);
            this.groupBox1.Controls.Add(this.dtpmuayenetarihi);
            this.groupBox1.Controls.Add(this.cbdoktor);
            this.groupBox1.Controls.Add(this.cbhasta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbaciklama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbucret);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(669, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 268);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muayene Kayıt";
            // 
            // cbdoktor
            // 
            this.cbdoktor.DisplayMember = "doktor";
            this.cbdoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoktor.Enabled = false;
            this.cbdoktor.FormattingEnabled = true;
            this.cbdoktor.Location = new System.Drawing.Point(115, 50);
            this.cbdoktor.Name = "cbdoktor";
            this.cbdoktor.Size = new System.Drawing.Size(121, 21);
            this.cbdoktor.TabIndex = 16;
            this.cbdoktor.ValueMember = "DoktorKodu";
            // 
            // cbhasta
            // 
            this.cbhasta.DisplayMember = "hasta";
            this.cbhasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhasta.Enabled = false;
            this.cbhasta.FormattingEnabled = true;
            this.cbhasta.Location = new System.Drawing.Point(115, 24);
            this.cbhasta.Name = "cbhasta";
            this.cbhasta.Size = new System.Drawing.Size(121, 21);
            this.cbhasta.TabIndex = 15;
            this.cbhasta.ValueMember = "HastaKodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Toplam Ücret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Muayene Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doktor Adı:";
            // 
            // tbaciklama
            // 
            this.tbaciklama.Location = new System.Drawing.Point(115, 106);
            this.tbaciklama.Multiline = true;
            this.tbaciklama.Name = "tbaciklama";
            this.tbaciklama.Size = new System.Drawing.Size(173, 34);
            this.tbaciklama.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Muayene Açıklaması:";
            // 
            // tbucret
            // 
            this.tbucret.Location = new System.Drawing.Point(115, 172);
            this.tbucret.Name = "tbucret";
            this.tbucret.Size = new System.Drawing.Size(121, 20);
            this.tbucret.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Diş Numarası:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tbarama
            // 
            this.tbarama.Location = new System.Drawing.Point(102, 283);
            this.tbarama.Name = "tbarama";
            this.tbarama.Size = new System.Drawing.Size(167, 20);
            this.tbarama.TabIndex = 26;
            this.tbarama.TextChanged += new System.EventHandler(this.tbarama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Muayene Arama:";
            // 
            // grdmuayeneler
            // 
            this.grdmuayeneler.AllowUserToAddRows = false;
            this.grdmuayeneler.AllowUserToDeleteRows = false;
            this.grdmuayeneler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdmuayeneler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdmuayeneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdmuayeneler.ContextMenuStrip = this.contextMenuStrip1;
            this.grdmuayeneler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdmuayeneler.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdmuayeneler.Location = new System.Drawing.Point(0, 315);
            this.grdmuayeneler.Name = "grdmuayeneler";
            this.grdmuayeneler.ReadOnly = true;
            this.grdmuayeneler.Size = new System.Drawing.Size(1024, 177);
            this.grdmuayeneler.TabIndex = 24;
            // 
            // btnsonlandir
            // 
            this.btnsonlandir.Image = ((System.Drawing.Image)(resources.GetObject("btnsonlandir.Image")));
            this.btnsonlandir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsonlandir.Location = new System.Drawing.Point(886, 274);
            this.btnsonlandir.Name = "btnsonlandir";
            this.btnsonlandir.Size = new System.Drawing.Size(126, 36);
            this.btnsonlandir.TabIndex = 29;
            this.btnsonlandir.Text = "Tedaviyi Sonlandır";
            this.btnsonlandir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsonlandir.UseVisualStyleBackColor = true;
            this.btnsonlandir.Click += new System.EventHandler(this.btnsonlandir_Click);
            // 
            // btniptal
            // 
            this.btniptal.Image = global::projedeneme1.Properties.Resources.cross__1_;
            this.btniptal.Location = new System.Drawing.Point(234, 215);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(41, 45);
            this.btniptal.TabIndex = 20;
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Image = global::projedeneme1.Properties.Resources.save__1_;
            this.btnkaydet.Location = new System.Drawing.Point(281, 215);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(42, 45);
            this.btnkaydet.TabIndex = 19;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmsecilikisimuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 492);
            this.Controls.Add(this.btnsonlandir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbarama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdmuayeneler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmsecilikisimuayene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçili Kişi Muayene";
            this.Load += new System.EventHandler(this.frmsecilikisimuayene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdmuayeneler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsonlandir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbpoliklinik;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox tbnumara;
        private System.Windows.Forms.DateTimePicker dtpmuayenetarihi;
        private System.Windows.Forms.ComboBox cbdoktor;
        private System.Windows.Forms.ComboBox cbhasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbucret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbarama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdmuayeneler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}