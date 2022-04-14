
namespace DiyetUygulamasi
{
    partial class FormDiyetisyen
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
            this.dgvHastalar = new System.Windows.Forms.DataGridView();
            this.HastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastalikAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiyetAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDiyet = new System.Windows.Forms.Button();
            this.cmbDiyetDegistir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cmbHastalik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRapor = new System.Windows.Forms.ComboBox();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnHTML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHastalar
            // 
            this.dgvHastalar.AllowUserToAddRows = false;
            this.dgvHastalar.AllowUserToDeleteRows = false;
            this.dgvHastalar.AllowUserToResizeColumns = false;
            this.dgvHastalar.AllowUserToResizeRows = false;
            this.dgvHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHastalar.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dgvHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHastalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaTC,
            this.HastaAd,
            this.HastaSoyad,
            this.HastalikAd,
            this.DiyetAd});
            this.dgvHastalar.Location = new System.Drawing.Point(12, 12);
            this.dgvHastalar.MultiSelect = false;
            this.dgvHastalar.Name = "dgvHastalar";
            this.dgvHastalar.ReadOnly = true;
            this.dgvHastalar.RowHeadersVisible = false;
            this.dgvHastalar.RowHeadersWidth = 51;
            this.dgvHastalar.RowTemplate.Height = 24;
            this.dgvHastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHastalar.Size = new System.Drawing.Size(661, 289);
            this.dgvHastalar.TabIndex = 0;
            // 
            // HastaTC
            // 
            this.HastaTC.DataPropertyName = "HastaTC";
            this.HastaTC.HeaderText = "Hasta TC";
            this.HastaTC.MinimumWidth = 6;
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.ReadOnly = true;
            // 
            // HastaAd
            // 
            this.HastaAd.DataPropertyName = "HastaAd";
            this.HastaAd.HeaderText = "Hasta Ad";
            this.HastaAd.MinimumWidth = 6;
            this.HastaAd.Name = "HastaAd";
            this.HastaAd.ReadOnly = true;
            // 
            // HastaSoyad
            // 
            this.HastaSoyad.DataPropertyName = "HastaSoyad";
            this.HastaSoyad.HeaderText = "Hasta Soyad";
            this.HastaSoyad.MinimumWidth = 6;
            this.HastaSoyad.Name = "HastaSoyad";
            this.HastaSoyad.ReadOnly = true;
            // 
            // HastalikAd
            // 
            this.HastalikAd.DataPropertyName = "HastalikAd";
            this.HastalikAd.HeaderText = "Hastalık";
            this.HastalikAd.MinimumWidth = 6;
            this.HastalikAd.Name = "HastalikAd";
            this.HastalikAd.ReadOnly = true;
            // 
            // DiyetAd
            // 
            this.DiyetAd.DataPropertyName = "DiyetAd";
            this.DiyetAd.HeaderText = "Diyet Türü";
            this.DiyetAd.MinimumWidth = 6;
            this.DiyetAd.Name = "DiyetAd";
            this.DiyetAd.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDiyet);
            this.groupBox1.Controls.Add(this.cmbDiyetDegistir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(694, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diyet Ekle";
            // 
            // btnDiyet
            // 
            this.btnDiyet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDiyet.Location = new System.Drawing.Point(6, 76);
            this.btnDiyet.Name = "btnDiyet";
            this.btnDiyet.Size = new System.Drawing.Size(241, 52);
            this.btnDiyet.TabIndex = 3;
            this.btnDiyet.Text = "Diyet Uygula";
            this.btnDiyet.UseVisualStyleBackColor = false;
            this.btnDiyet.Click += new System.EventHandler(this.btnDiyet_Click);
            // 
            // cmbDiyetDegistir
            // 
            this.cmbDiyetDegistir.FormattingEnabled = true;
            this.cmbDiyetDegistir.Location = new System.Drawing.Point(126, 31);
            this.cmbDiyetDegistir.Name = "cmbDiyetDegistir";
            this.cmbDiyetDegistir.Size = new System.Drawing.Size(121, 28);
            this.cmbDiyetDegistir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diyet Türü:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTC);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtSoyad);
            this.groupBox2.Controls.Add(this.txtAd);
            this.groupBox2.Controls.Add(this.cmbHastalik);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Ekle";
            // 
            // txtTC
            // 
            this.txtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.Location = new System.Drawing.Point(168, 35);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(121, 30);
            this.txtTC.TabIndex = 11;
            this.txtTC.ValidatingType = typeof(int);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(492, 151);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 49);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(492, 108);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtSoyad.TabIndex = 10;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(492, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 26);
            this.txtAd.TabIndex = 9;
            // 
            // cmbHastalik
            // 
            this.cmbHastalik.FormattingEnabled = true;
            this.cmbHastalik.Location = new System.Drawing.Point(168, 108);
            this.cmbHastalik.Name = "cmbHastalik";
            this.cmbHastalik.Size = new System.Drawing.Size(121, 28);
            this.cmbHastalik.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hastalık:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(315, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(356, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta TC:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbRapor);
            this.groupBox3.Controls.Add(this.btnJSON);
            this.groupBox3.Controls.Add(this.btnHTML);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(694, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 375);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Raporu Oluştur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Rapor Düzeni";
            // 
            // cmbRapor
            // 
            this.cmbRapor.FormattingEnabled = true;
            this.cmbRapor.Items.AddRange(new object[] {
            "Hasta Bilgileri/Diyet Bilgileri",
            "Diyet Bilgileri/Hasta Bilgileri"});
            this.cmbRapor.Location = new System.Drawing.Point(6, 112);
            this.cmbRapor.Name = "cmbRapor";
            this.cmbRapor.Size = new System.Drawing.Size(241, 28);
            this.cmbRapor.TabIndex = 4;
            // 
            // btnJSON
            // 
            this.btnJSON.BackColor = System.Drawing.Color.Red;
            this.btnJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnJSON.Location = new System.Drawing.Point(41, 269);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(166, 65);
            this.btnJSON.TabIndex = 12;
            this.btnJSON.Text = "JSON";
            this.btnJSON.UseVisualStyleBackColor = false;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnHTML
            // 
            this.btnHTML.BackColor = System.Drawing.Color.Red;
            this.btnHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHTML.Location = new System.Drawing.Point(41, 175);
            this.btnHTML.Name = "btnHTML";
            this.btnHTML.Size = new System.Drawing.Size(166, 65);
            this.btnHTML.TabIndex = 11;
            this.btnHTML.Text = "HTML";
            this.btnHTML.UseVisualStyleBackColor = false;
            this.btnHTML.Click += new System.EventHandler(this.btnHTML_Click);
            // 
            // FormDiyetisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHastalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDiyetisyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiyetisyen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDiyetisyen_FormClosed);
            this.Load += new System.EventHandler(this.FormDiyetisyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHastalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDiyet;
        private System.Windows.Forms.ComboBox cmbDiyetDegistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ComboBox cmbHastalik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRapor;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnHTML;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastalikAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiyetAd;
        private System.Windows.Forms.MaskedTextBox txtTC;
    }
}