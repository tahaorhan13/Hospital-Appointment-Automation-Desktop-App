
namespace Hastane_Randevu_Projesi.Forms
{
    partial class OldAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OldAppointment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRandevuiptal = new System.Windows.Forms.Button();
            this.txtDoktor = new System.Windows.Forms.TextBox();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.lblRandevuNo = new System.Windows.Forms.Label();
            this.txtRandevu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(725, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRandevuiptal
            // 
            this.btnRandevuiptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRandevuiptal.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuiptal.Location = new System.Drawing.Point(639, 228);
            this.btnRandevuiptal.Name = "btnRandevuiptal";
            this.btnRandevuiptal.Size = new System.Drawing.Size(75, 39);
            this.btnRandevuiptal.TabIndex = 1;
            this.btnRandevuiptal.Text = "Randevu İptal";
            this.btnRandevuiptal.UseVisualStyleBackColor = false;
            this.btnRandevuiptal.Click += new System.EventHandler(this.btnRandevuiptal_Click);
            // 
            // txtDoktor
            // 
            this.txtDoktor.Location = new System.Drawing.Point(382, 239);
            this.txtDoktor.Name = "txtDoktor";
            this.txtDoktor.Size = new System.Drawing.Size(114, 20);
            this.txtDoktor.TabIndex = 7;
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.Location = new System.Drawing.Point(408, 217);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(57, 13);
            this.lblDoktor.TabIndex = 16;
            this.lblDoktor.Text = "Doktor Adı";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(290, 217);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(34, 13);
            this.lblBrans.TabIndex = 18;
            this.lblBrans.Text = "Branş";
            // 
            // txtBrans
            // 
            this.txtBrans.Location = new System.Drawing.Point(253, 239);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(114, 20);
            this.txtBrans.TabIndex = 17;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(161, 217);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(29, 13);
            this.lblSaat.TabIndex = 20;
            this.lblSaat.Text = "Saat";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(124, 239);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(114, 20);
            this.txtSaat.TabIndex = 19;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(41, 216);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 22;
            this.lblTarih.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(4, 238);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(114, 20);
            this.txtTarih.TabIndex = 21;
            // 
            // lblRandevuNo
            // 
            this.lblRandevuNo.AutoSize = true;
            this.lblRandevuNo.Location = new System.Drawing.Point(508, 216);
            this.lblRandevuNo.Name = "lblRandevuNo";
            this.lblRandevuNo.Size = new System.Drawing.Size(98, 13);
            this.lblRandevuNo.TabIndex = 24;
            this.lblRandevuNo.Text = "Randevu Numarası";
            // 
            // txtRandevu
            // 
            this.txtRandevu.Location = new System.Drawing.Point(502, 239);
            this.txtRandevu.Name = "txtRandevu";
            this.txtRandevu.Size = new System.Drawing.Size(114, 20);
            this.txtRandevu.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Randevularım sayfasına hoşgeldiniz aşağıdaki pencereden randevularınızı görüntüle" +
    "yebilirsiniz\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Randevunuzu iptal etmek isterseniz aşağıdaki pencereden seçtiğiniz randevuyu \'Ran" +
    "devu İptal\' butonu ile iptal edebilirsiniz.\r\n";
            // 
            // OldAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(727, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRandevuNo);
            this.Controls.Add(this.txtRandevu);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.txtBrans);
            this.Controls.Add(this.lblDoktor);
            this.Controls.Add(this.txtDoktor);
            this.Controls.Add(this.btnRandevuiptal);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OldAppointment";
            this.Text = "Randevular";
            this.Load += new System.EventHandler(this.OldAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRandevuiptal;
        private System.Windows.Forms.TextBox txtDoktor;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label lblRandevuNo;
        private System.Windows.Forms.TextBox txtRandevu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}