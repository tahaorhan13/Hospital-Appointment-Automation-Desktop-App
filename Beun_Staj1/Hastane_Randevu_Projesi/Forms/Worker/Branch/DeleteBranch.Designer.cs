
namespace Hastane_Randevu_Projesi.Forms.Worker.Branch
{
    partial class DeleteBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteBranch));
            this.button2 = new System.Windows.Forms.Button();
            this.btnBransSil = new System.Windows.Forms.Button();
            this.lblBrans = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(185, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnBransSil
            // 
            this.btnBransSil.BackColor = System.Drawing.Color.Blue;
            this.btnBransSil.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBransSil.Location = new System.Drawing.Point(106, 73);
            this.btnBransSil.Name = "btnBransSil";
            this.btnBransSil.Size = new System.Drawing.Size(64, 33);
            this.btnBransSil.TabIndex = 8;
            this.btnBransSil.Text = "Sil";
            this.btnBransSil.UseVisualStyleBackColor = false;
            this.btnBransSil.Click += new System.EventHandler(this.btnBransSil_Click);
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.Location = new System.Drawing.Point(12, 28);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(53, 19);
            this.lblBrans.TabIndex = 6;
            this.lblBrans.Text = "Branş :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 197);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(106, 26);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(143, 21);
            this.cmbBrans.TabIndex = 10;
            // 
            // DeleteBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(568, 202);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBransSil);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteBranch";
            this.Text = "Branş Sil";
            this.Load += new System.EventHandler(this.DeleteBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBransSil;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBrans;
    }
}