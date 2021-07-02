
namespace Hastane_Randevu_Projesi.Forms.Worker.Branch
{
    partial class AddBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBranch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBrans = new System.Windows.Forms.Label();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.btnBransEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(13, 28);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(53, 19);
            this.lblBrans.TabIndex = 1;
            this.lblBrans.Text = "Branş :";
            // 
            // txtBrans
            // 
            this.txtBrans.Location = new System.Drawing.Point(107, 27);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(143, 20);
            this.txtBrans.TabIndex = 2;
            this.txtBrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrans_KeyPress);
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.BackColor = System.Drawing.Color.Blue;
            this.btnBransEkle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransEkle.Location = new System.Drawing.Point(107, 73);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(64, 33);
            this.btnBransEkle.TabIndex = 3;
            this.btnBransEkle.Text = "Ekle";
            this.btnBransEkle.UseVisualStyleBackColor = false;
            this.btnBransEkle.Click += new System.EventHandler(this.btnBransEkle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(186, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(575, 207);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBransEkle);
            this.Controls.Add(this.txtBrans);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBranch";
            this.Text = "Branş Ekle";
            this.Load += new System.EventHandler(this.AddBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Button btnBransEkle;
        private System.Windows.Forms.Button button2;
    }
}