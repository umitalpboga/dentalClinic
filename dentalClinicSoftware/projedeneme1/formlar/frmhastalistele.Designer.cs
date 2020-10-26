namespace projedeneme1.formlar
{
    partial class frmhastalistele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastalistele));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbarama = new System.Windows.Forms.TextBox();
            this.btnhastaguncel = new System.Windows.Forms.Button();
            this.btnhastasil = new System.Windows.Forms.Button();
            this.btnhastakayit = new System.Windows.Forms.Button();
            this.grdhastalar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdhastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbarama);
            this.panel1.Controls.Add(this.btnhastaguncel);
            this.panel1.Controls.Add(this.btnhastasil);
            this.panel1.Controls.Add(this.btnhastakayit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta ara( tc kimlik ) :";
            // 
            // tbarama
            // 
            this.tbarama.Location = new System.Drawing.Point(733, 56);
            this.tbarama.Name = "tbarama";
            this.tbarama.Size = new System.Drawing.Size(217, 20);
            this.tbarama.TabIndex = 6;
            this.tbarama.TextChanged += new System.EventHandler(this.tbarama_TextChanged);
            // 
            // btnhastaguncel
            // 
            this.btnhastaguncel.Image = global::projedeneme1.Properties.Resources.dental_insurance;
            this.btnhastaguncel.Location = new System.Drawing.Point(263, 12);
            this.btnhastaguncel.Name = "btnhastaguncel";
            this.btnhastaguncel.Size = new System.Drawing.Size(91, 58);
            this.btnhastaguncel.TabIndex = 5;
            this.btnhastaguncel.Text = "Hasta Güncelle";
            this.btnhastaguncel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhastaguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhastaguncel.UseVisualStyleBackColor = true;
            this.btnhastaguncel.Click += new System.EventHandler(this.btnhastaguncel_Click);
            // 
            // btnhastasil
            // 
            this.btnhastasil.Image = global::projedeneme1.Properties.Resources.tooth__5_;
            this.btnhastasil.Location = new System.Drawing.Point(156, 12);
            this.btnhastasil.Name = "btnhastasil";
            this.btnhastasil.Size = new System.Drawing.Size(91, 58);
            this.btnhastasil.TabIndex = 4;
            this.btnhastasil.Text = "Hasta Sil";
            this.btnhastasil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhastasil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhastasil.UseVisualStyleBackColor = true;
            this.btnhastasil.Click += new System.EventHandler(this.btnhastasil_Click);
            // 
            // btnhastakayit
            // 
            this.btnhastakayit.Image = global::projedeneme1.Properties.Resources.dental_care;
            this.btnhastakayit.Location = new System.Drawing.Point(45, 12);
            this.btnhastakayit.Name = "btnhastakayit";
            this.btnhastakayit.Size = new System.Drawing.Size(91, 58);
            this.btnhastakayit.TabIndex = 3;
            this.btnhastakayit.Text = "Hasta Kayıt";
            this.btnhastakayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhastakayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhastakayit.UseVisualStyleBackColor = true;
            this.btnhastakayit.Click += new System.EventHandler(this.btnhastakayit_Click);
            // 
            // grdhastalar
            // 
            this.grdhastalar.AllowUserToAddRows = false;
            this.grdhastalar.AllowUserToDeleteRows = false;
            this.grdhastalar.AllowUserToResizeColumns = false;
            this.grdhastalar.AllowUserToResizeRows = false;
            this.grdhastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdhastalar.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdhastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdhastalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdhastalar.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdhastalar.Location = new System.Drawing.Point(0, 86);
            this.grdhastalar.Name = "grdhastalar";
            this.grdhastalar.ReadOnly = true;
            this.grdhastalar.Size = new System.Drawing.Size(962, 367);
            this.grdhastalar.TabIndex = 1;
            // 
            // frmhastalistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.grdhastalar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhastalistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastalar";
            this.Load += new System.EventHandler(this.frmhastalistele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdhastalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdhastalar;
        private System.Windows.Forms.Button btnhastakayit;
        private System.Windows.Forms.Button btnhastaguncel;
        private System.Windows.Forms.Button btnhastasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbarama;
    }
}