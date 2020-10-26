namespace projedeneme1.formlar
{
    partial class frmrandevularlistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrandevularlistesi));
            this.grdrandevular = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbarama = new System.Windows.Forms.TextBox();
            this.btnmuayenekayit = new System.Windows.Forms.Button();
            this.btnrandevuguncelle = new System.Windows.Forms.Button();
            this.btnrandevuiptal = new System.Windows.Forms.Button();
            this.btnrandevukayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdrandevular)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdrandevular
            // 
            this.grdrandevular.AllowUserToAddRows = false;
            this.grdrandevular.AllowUserToDeleteRows = false;
            this.grdrandevular.AllowUserToResizeColumns = false;
            this.grdrandevular.AllowUserToResizeRows = false;
            this.grdrandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdrandevular.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdrandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdrandevular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdrandevular.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdrandevular.Location = new System.Drawing.Point(0, 83);
            this.grdrandevular.Name = "grdrandevular";
            this.grdrandevular.ReadOnly = true;
            this.grdrandevular.Size = new System.Drawing.Size(839, 403);
            this.grdrandevular.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbarama);
            this.panel1.Controls.Add(this.btnmuayenekayit);
            this.panel1.Controls.Add(this.btnrandevuguncelle);
            this.panel1.Controls.Add(this.btnrandevuiptal);
            this.panel1.Controls.Add(this.btnrandevukayit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 77);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Randevu Arama:";
            // 
            // tbarama
            // 
            this.tbarama.Location = new System.Drawing.Point(660, 47);
            this.tbarama.Name = "tbarama";
            this.tbarama.Size = new System.Drawing.Size(167, 20);
            this.tbarama.TabIndex = 14;
            this.tbarama.TextChanged += new System.EventHandler(this.tbarama_TextChanged);
            // 
            // btnmuayenekayit
            // 
            this.btnmuayenekayit.Image = global::projedeneme1.Properties.Resources.tooth__1_;
            this.btnmuayenekayit.Location = new System.Drawing.Point(328, 12);
            this.btnmuayenekayit.Name = "btnmuayenekayit";
            this.btnmuayenekayit.Size = new System.Drawing.Size(92, 54);
            this.btnmuayenekayit.TabIndex = 7;
            this.btnmuayenekayit.Text = "Muayene Kayıt";
            this.btnmuayenekayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmuayenekayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmuayenekayit.UseVisualStyleBackColor = true;
            this.btnmuayenekayit.Click += new System.EventHandler(this.btnmuayenekayit_Click);
            // 
            // btnrandevuguncelle
            // 
            this.btnrandevuguncelle.Image = global::projedeneme1.Properties.Resources.rguncelle;
            this.btnrandevuguncelle.Location = new System.Drawing.Point(216, 12);
            this.btnrandevuguncelle.Name = "btnrandevuguncelle";
            this.btnrandevuguncelle.Size = new System.Drawing.Size(106, 55);
            this.btnrandevuguncelle.TabIndex = 6;
            this.btnrandevuguncelle.Text = "Randevu Güncelle";
            this.btnrandevuguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrandevuguncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrandevuguncelle.UseVisualStyleBackColor = true;
            this.btnrandevuguncelle.Click += new System.EventHandler(this.btnrandevuguncelle_Click);
            // 
            // btnrandevuiptal
            // 
            this.btnrandevuiptal.Image = global::projedeneme1.Properties.Resources.calendar__2_1;
            this.btnrandevuiptal.Location = new System.Drawing.Point(127, 12);
            this.btnrandevuiptal.Name = "btnrandevuiptal";
            this.btnrandevuiptal.Size = new System.Drawing.Size(83, 55);
            this.btnrandevuiptal.TabIndex = 5;
            this.btnrandevuiptal.Text = "Randevu İptal";
            this.btnrandevuiptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrandevuiptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrandevuiptal.UseVisualStyleBackColor = true;
            this.btnrandevuiptal.Click += new System.EventHandler(this.btnrandevuiptal_Click);
            // 
            // btnrandevukayit
            // 
            this.btnrandevukayit.Image = global::projedeneme1.Properties.Resources.randevu;
            this.btnrandevukayit.Location = new System.Drawing.Point(26, 12);
            this.btnrandevukayit.Name = "btnrandevukayit";
            this.btnrandevukayit.Size = new System.Drawing.Size(85, 55);
            this.btnrandevukayit.TabIndex = 4;
            this.btnrandevukayit.Text = "Randevu Kayıt";
            this.btnrandevukayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnrandevukayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrandevukayit.UseVisualStyleBackColor = true;
            this.btnrandevukayit.Click += new System.EventHandler(this.btnrandevukayit_Click);
            // 
            // frmrandevularlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdrandevular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrandevularlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.frmrandevularlistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdrandevular)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdrandevular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnrandevukayit;
        private System.Windows.Forms.Button btnrandevuiptal;
        private System.Windows.Forms.Button btnrandevuguncelle;
        private System.Windows.Forms.Button btnmuayenekayit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbarama;
    }
}