namespace projedeneme1.formlar
{
    partial class frmrandevuekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrandevuekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbhastalar = new System.Windows.Forms.ComboBox();
            this.cbdoktorlar = new System.Windows.Forms.ComboBox();
            this.dtprandevutarihi = new System.Windows.Forms.DateTimePicker();
            this.cbrandevusaati = new System.Windows.Forms.ComboBox();
            this.tbpoliklinik = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Randevu Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Randevu Saati:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(53, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Poliklinik : ";
            // 
            // cbhastalar
            // 
            this.cbhastalar.DisplayMember = "hasta";
            this.cbhastalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhastalar.FormattingEnabled = true;
            this.cbhastalar.Location = new System.Drawing.Point(123, 39);
            this.cbhastalar.Name = "cbhastalar";
            this.cbhastalar.Size = new System.Drawing.Size(121, 21);
            this.cbhastalar.TabIndex = 6;
            this.cbhastalar.ValueMember = "HastaKodu";
            // 
            // cbdoktorlar
            // 
            this.cbdoktorlar.DisplayMember = "doktor";
            this.cbdoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdoktorlar.FormattingEnabled = true;
            this.cbdoktorlar.Location = new System.Drawing.Point(123, 83);
            this.cbdoktorlar.Name = "cbdoktorlar";
            this.cbdoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cbdoktorlar.TabIndex = 7;
            this.cbdoktorlar.ValueMember = "DoktorKodu";
            // 
            // dtprandevutarihi
            // 
            this.dtprandevutarihi.CustomFormat = "";
            this.dtprandevutarihi.Location = new System.Drawing.Point(123, 127);
            this.dtprandevutarihi.Name = "dtprandevutarihi";
            this.dtprandevutarihi.Size = new System.Drawing.Size(200, 20);
            this.dtprandevutarihi.TabIndex = 9;
            this.dtprandevutarihi.Value = new System.DateTime(2020, 4, 20, 0, 0, 0, 0);
            // 
            // cbrandevusaati
            // 
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
            this.cbrandevusaati.Location = new System.Drawing.Point(123, 167);
            this.cbrandevusaati.Name = "cbrandevusaati";
            this.cbrandevusaati.Size = new System.Drawing.Size(81, 21);
            this.cbrandevusaati.TabIndex = 10;
            // 
            // tbpoliklinik
            // 
            this.tbpoliklinik.Location = new System.Drawing.Point(123, 211);
            this.tbpoliklinik.Name = "tbpoliklinik";
            this.tbpoliklinik.Size = new System.Drawing.Size(122, 20);
            this.tbpoliklinik.TabIndex = 11;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Image = global::projedeneme1.Properties.Resources.save__1_;
            this.btnkaydet.Location = new System.Drawing.Point(309, 261);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(52, 42);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btniptal
            // 
            this.btniptal.Image = global::projedeneme1.Properties.Resources.cross__1_;
            this.btniptal.Location = new System.Drawing.Point(242, 261);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(52, 42);
            this.btniptal.TabIndex = 13;
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmrandevuekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 325);
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
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmrandevuekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Kayıt";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmrandevuekle_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmrandevuekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbhastalar;
        private System.Windows.Forms.ComboBox cbdoktorlar;
        private System.Windows.Forms.DateTimePicker dtprandevutarihi;
        private System.Windows.Forms.ComboBox cbrandevusaati;
        private System.Windows.Forms.TextBox tbpoliklinik;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}