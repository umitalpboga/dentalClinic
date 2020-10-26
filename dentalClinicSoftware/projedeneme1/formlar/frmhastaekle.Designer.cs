namespace projedeneme1.formlar
{
    partial class frmhastaekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhastaekle));
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbkimlik = new System.Windows.Forms.TextBox();
            this.tbcinsiyet = new System.Windows.Forms.TextBox();
            this.tbtelefon = new System.Windows.Forms.TextBox();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(82, 29);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(100, 20);
            this.tbadi.TabIndex = 0;
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(82, 65);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbsoyadi.TabIndex = 1;
            // 
            // tbkimlik
            // 
            this.tbkimlik.Location = new System.Drawing.Point(82, 103);
            this.tbkimlik.Name = "tbkimlik";
            this.tbkimlik.Size = new System.Drawing.Size(151, 20);
            this.tbkimlik.TabIndex = 2;
            // 
            // tbcinsiyet
            // 
            this.tbcinsiyet.Location = new System.Drawing.Point(82, 138);
            this.tbcinsiyet.Name = "tbcinsiyet";
            this.tbcinsiyet.Size = new System.Drawing.Size(65, 20);
            this.tbcinsiyet.TabIndex = 3;
            // 
            // tbtelefon
            // 
            this.tbtelefon.Location = new System.Drawing.Point(82, 207);
            this.tbtelefon.Name = "tbtelefon";
            this.tbtelefon.Size = new System.Drawing.Size(151, 20);
            this.tbtelefon.TabIndex = 4;
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.CustomFormat = "date";
            this.dtpdogumtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdogumtarihi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpdogumtarihi.Location = new System.Drawing.Point(82, 173);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(80, 20);
            this.dtpdogumtarihi.TabIndex = 5;
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(82, 237);
            this.tbadres.Multiline = true;
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(228, 33);
            this.tbadres.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tc Kimlik : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cinsiyet : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(21, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "D. Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(21, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(33, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres : ";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Image = global::projedeneme1.Properties.Resources.save__1_;
            this.btnkaydet.Location = new System.Drawing.Point(269, 294);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(52, 44);
            this.btnkaydet.TabIndex = 20;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btniptal
            // 
            this.btniptal.Image = global::projedeneme1.Properties.Resources.cross__1_;
            this.btniptal.Location = new System.Drawing.Point(200, 294);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(52, 44);
            this.btniptal.TabIndex = 20;
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmhastaekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 350);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbadres);
            this.Controls.Add(this.dtpdogumtarihi);
            this.Controls.Add(this.tbtelefon);
            this.Controls.Add(this.tbcinsiyet);
            this.Controls.Add(this.tbkimlik);
            this.Controls.Add(this.tbsoyadi);
            this.Controls.Add(this.tbadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhastaekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmhastaekle_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmhastaekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbkimlik;
        private System.Windows.Forms.TextBox tbcinsiyet;
        private System.Windows.Forms.TextBox tbtelefon;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}