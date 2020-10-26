namespace projedeneme1.formlar
{
    partial class frmdoktorlarlistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoktorlarlistesi));
            this.grddoktorlar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbarama = new System.Windows.Forms.TextBox();
            this.btndoktorguncel = new System.Windows.Forms.Button();
            this.btndoktorsil = new System.Windows.Forms.Button();
            this.btndoktorkayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grddoktorlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grddoktorlar
            // 
            this.grddoktorlar.AllowUserToAddRows = false;
            this.grddoktorlar.AllowUserToDeleteRows = false;
            this.grddoktorlar.AllowUserToResizeColumns = false;
            this.grddoktorlar.AllowUserToResizeRows = false;
            this.grddoktorlar.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grddoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddoktorlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grddoktorlar.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grddoktorlar.Location = new System.Drawing.Point(0, 88);
            this.grddoktorlar.Name = "grddoktorlar";
            this.grddoktorlar.ReadOnly = true;
            this.grddoktorlar.Size = new System.Drawing.Size(962, 365);
            this.grddoktorlar.TabIndex = 0;
            this.grddoktorlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddoktorlar_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbarama);
            this.panel1.Controls.Add(this.btndoktorguncel);
            this.panel1.Controls.Add(this.btndoktorsil);
            this.panel1.Controls.Add(this.btndoktorkayit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 86);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor ara( tc kimlik ) :";
            // 
            // tbarama
            // 
            this.tbarama.Location = new System.Drawing.Point(733, 54);
            this.tbarama.Name = "tbarama";
            this.tbarama.Size = new System.Drawing.Size(217, 20);
            this.tbarama.TabIndex = 3;
            this.tbarama.TextChanged += new System.EventHandler(this.tbarama_TextChanged);
            // 
            // btndoktorguncel
            // 
            this.btndoktorguncel.Image = global::projedeneme1.Properties.Resources.reload;
            this.btndoktorguncel.Location = new System.Drawing.Point(261, 12);
            this.btndoktorguncel.Name = "btndoktorguncel";
            this.btndoktorguncel.Size = new System.Drawing.Size(94, 58);
            this.btndoktorguncel.TabIndex = 2;
            this.btndoktorguncel.Text = "Doktor Güncelle";
            this.btndoktorguncel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndoktorguncel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndoktorguncel.UseVisualStyleBackColor = true;
            this.btndoktorguncel.Click += new System.EventHandler(this.btndoktorguncel_Click);
            // 
            // btndoktorsil
            // 
            this.btndoktorsil.Image = global::projedeneme1.Properties.Resources.man;
            this.btndoktorsil.Location = new System.Drawing.Point(152, 12);
            this.btndoktorsil.Name = "btndoktorsil";
            this.btndoktorsil.Size = new System.Drawing.Size(94, 58);
            this.btndoktorsil.TabIndex = 1;
            this.btndoktorsil.Text = "Doktor Sil";
            this.btndoktorsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndoktorsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndoktorsil.UseVisualStyleBackColor = true;
            this.btndoktorsil.Click += new System.EventHandler(this.btndoktorsil_Click);
            // 
            // btndoktorkayit
            // 
            this.btndoktorkayit.Image = global::projedeneme1.Properties.Resources.add_user__1_;
            this.btndoktorkayit.Location = new System.Drawing.Point(42, 12);
            this.btndoktorkayit.Name = "btndoktorkayit";
            this.btndoktorkayit.Size = new System.Drawing.Size(91, 58);
            this.btndoktorkayit.TabIndex = 0;
            this.btndoktorkayit.Text = "Doktor Kayıt";
            this.btndoktorkayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndoktorkayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndoktorkayit.UseVisualStyleBackColor = true;
            this.btndoktorkayit.Click += new System.EventHandler(this.btndoktorkayit_Click);
            // 
            // frmdoktorlarlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grddoktorlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdoktorlarlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktorlar";
            this.Load += new System.EventHandler(this.frmdoktorlarlistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddoktorlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndoktorguncel;
        private System.Windows.Forms.Button btndoktorsil;
        private System.Windows.Forms.Button btndoktorkayit;
        public System.Windows.Forms.DataGridView grddoktorlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbarama;
    }
}