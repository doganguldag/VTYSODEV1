namespace VTYSodev
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Konteyner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agirlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuktur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Konteyner,
            this.Varis,
            this.cikis,
            this.varis1,
            this.agirlik,
            this.yuktur,
            this.kullanici});
            this.dataGridView1.Location = new System.Drawing.Point(23, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(187, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlgili Araç Bilgisi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Agency FB", 56.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(56, 451);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(538, 91);
            this.label20.TabIndex = 13;
            this.label20.Text = "TELEPORT LOJİSTİK";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(248, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 49);
            this.button2.TabIndex = 32;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Konteyner
            // 
            this.Konteyner.DataPropertyName = "konteynerID";
            this.Konteyner.HeaderText = "Konteyner Numarası";
            this.Konteyner.Name = "Konteyner";
            // 
            // Varis
            // 
            this.Varis.DataPropertyName = "varisyeri";
            this.Varis.HeaderText = "Varış Yeri";
            this.Varis.Name = "Varis";
            // 
            // cikis
            // 
            this.cikis.DataPropertyName = "cikistarih";
            this.cikis.HeaderText = "Çıkış Tarihi";
            this.cikis.Name = "cikis";
            // 
            // varis1
            // 
            this.varis1.DataPropertyName = "varistarih";
            this.varis1.HeaderText = "Varış Tarihi";
            this.varis1.Name = "varis1";
            // 
            // agirlik
            // 
            this.agirlik.DataPropertyName = "agirlik";
            this.agirlik.HeaderText = "Ağırlık";
            this.agirlik.Name = "agirlik";
            // 
            // yuktur
            // 
            this.yuktur.DataPropertyName = "yukturu";
            this.yuktur.HeaderText = "Yük Türü";
            this.yuktur.Name = "yuktur";
            // 
            // kullanici
            // 
            this.kullanici.DataPropertyName = "kullaniciadi";
            this.kullanici.HeaderText = "Kullanıcı Adı";
            this.kullanici.Name = "kullanici";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(666, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araçta Bulunan Konteynerler";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konteyner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Varis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn varis1;
        private System.Windows.Forms.DataGridViewTextBoxColumn agirlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn yuktur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici;
    }
}