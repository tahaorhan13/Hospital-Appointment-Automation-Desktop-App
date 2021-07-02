
namespace Hastane_Randevu_Projesi.Forms
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalisan = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taha Hastanesi Randevu Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aşağıdaki butonlardan \'Kullanıcı\' isimli butona tıklayarak randevu sistemine giri" +
    "ş yapabilirsiniz.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eğerki hastanemizde çalışan iseniz \'Çalışan\' butonuna tıklayarak sisteme giriş ya" +
    "pabilirsiniz.\r\n";
            // 
            // btnCalisan
            // 
            this.btnCalisan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalisan.BackgroundImage")));
            this.btnCalisan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalisan.Location = new System.Drawing.Point(415, 189);
            this.btnCalisan.Name = "btnCalisan";
            this.btnCalisan.Size = new System.Drawing.Size(81, 72);
            this.btnCalisan.TabIndex = 4;
            this.btnCalisan.UseVisualStyleBackColor = true;
            this.btnCalisan.Click += new System.EventHandler(this.btnCalisan_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHasta.BackgroundImage")));
            this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHasta.Location = new System.Drawing.Point(20, 189);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(83, 71);
            this.btnHasta.TabIndex = 5;
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Çalışan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(526, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHasta);
            this.Controls.Add(this.btnCalisan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Taha Hastanesi Randevu Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalisan;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}