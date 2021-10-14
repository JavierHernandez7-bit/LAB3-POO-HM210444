
namespace P3_Ejemplo_2
{
    partial class FrmRecibe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecibe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltrar = new System.Windows.Forms.TextBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(256, 436);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(118, 30);
            this.btnLlenar.TabIndex = 1;
            this.btnLlenar.Text = "LLENAR";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por nombre:";
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Location = new System.Drawing.Point(190, 38);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(221, 22);
            this.txtfiltrar.TabIndex = 3;
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(457, 26);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(75, 46);
            this.btnfiltrar.TabIndex = 4;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // FrmRecibe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 478);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.txtfiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecibe";
            this.Text = "FrmRecibe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltrar;
        private System.Windows.Forms.Button btnfiltrar;
    }
}