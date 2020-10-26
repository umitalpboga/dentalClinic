namespace projedeneme1.formlar
{
    partial class frmrandevuguncelleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrandevuguncelleme));
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btniptal = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.tbpoliklinik = new System.Windows.Forms.TextBox();
            this.cbrandevusaati = new System.Windows.Forms.ComboBox();
            this.dtprandevutarihi = new System.Windows.Forms.DateTimePicker();
            this.cbdoktorlar = new System.Windows.Forms.ComboBox();
            this.cbhastalar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(15, -21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hasta :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btniptal
            // 
            this.btniptal.Image = global::projedeneme1.Properties.Resources.cross__1_;
            this.btniptal.Location = new System.Drawing.Point(229, 235);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(52, 44);
            this.btniptal.TabIndex = 34;
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Image = global::projedeneme1.Properties.Resources.save__1_;
            this.btnkaydet.Location = new System.Drawing.Point(287, 235);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(52, 44);
            this.btnkaydet.TabIndex = 33;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // tbpoliklinik
            // 
            this.tbpoliklinik.Location = new System.Drawing.Point(116, 195);
            this.tbpoliklinik.Name = "tbpoliklinik";
            this.tbpoliklinik.Size = new System.Drawing.Size(122, 20);
            this.tbpoliklinik.TabIndex = 32;
            // 
            // cbrandevusaati
            // 
            this.cbrandevusaati.BackColor = System.Drawing.SystemColors.Window;
            this.cbrandevusaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrandevusaati.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbrandevusaati.FormatString = "t";
            this.cbrandevusaati.FormattingEnabled = true;
            this.cbrandevusaati.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cbrandevusaati.Location = new System.Drawing.Point(116, 151);
            this.cbrandevusaati.MaxDropDownItems = 15;
            this.cbrandevusaati.Name = "cbrandevusaati";
            this.cbrandevusaati.Size = new System.Drawing.Size(81, 21);
            this.cbrandevusaati.TabIndex = 31;
            this.cbrandevusaati.Tag = "";
            // 
            // dtprandevutarihi
            // 
            this.dtprandevutarihi.CustomFormat = "";
            this.dtprandevutarihi.Location = new System.Drawing.Point(116, 111);
            this.dtprandevutarihi.Name = "dtprandevutarihi";
            this.dtprandevutarihi.Size = new System.Drawing.Size(200, 20);
            this.dtprandevutarihi.TabIndex = 30;
            this.dtprandevutarihi.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            // 
            // cbdoktorlar
            // 
            this.cbdoktorlar.DisplayMember = "doktor";
            this.cbdoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoktorlar.FormattingEnabled = true;
            this.cbdoktorlar.Location = new System.Drawing.Point(116, 70);
            this.cbdoktorlar.Name = "cbdoktorlar";
            this.cbdoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cbdoktorlar.TabIndex = 28;
            this.cbdoktorlar.ValueMember = "DoktorKodu";
            // 
            // cbhastalar
            // 
            this.cbhastalar.DisplayMember = "hasta";
            this.cbhastalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhastalar.FormattingEnabled = true;
            this.cbhastalar.Location = new System.Drawing.Point(116, 26);
            this.cbhastalar.Name = "cbhastalar";
            this.cbhastalar.Size = new System.Drawing.Size(121, 21);
            this.cbhastalar.TabIndex = 27;
            this.cbhastalar.ValueMember = "HastaKodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(46, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Poliklinik : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Randevu Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Randevu Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(62, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Doktor :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(66, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hasta :";
            // 
            // frmrandevuguncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 298);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.tbpoliklinik);
            this.Controls.Add(this.cbrandevusaati);
            this.Controls.Add(this.dtprandevutarihi);
            this.Controls.Add(this.cbdoktorlar);
            this.Controls.Add(this.cbhastalar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrandevuguncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Güncelleme";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmrandevuguncelleme_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmrandevuguncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox tbpoliklinik;
        private System.Windows.Forms.DateTimePicker dtprandevutarihi;
        private System.Windows.Forms.ComboBox cbdoktorlar;
        private System.Windows.Forms.ComboBox cbhastalar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbrandevusaati;
    }
}