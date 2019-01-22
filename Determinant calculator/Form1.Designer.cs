namespace Determinant
{
    partial class Form1
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
            this.tbxmatris = new System.Windows.Forms.TextBox();
            this.btnberäkna = new System.Windows.Forms.Button();
            this.tbxdeterminant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Determinant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxmatris
            // 
            this.tbxmatris.Location = new System.Drawing.Point(12, 49);
            this.tbxmatris.Multiline = true;
            this.tbxmatris.Name = "tbxmatris";
            this.tbxmatris.Size = new System.Drawing.Size(610, 460);
            this.tbxmatris.TabIndex = 0;
            // 
            // btnberäkna
            // 
            this.btnberäkna.Location = new System.Drawing.Point(628, 131);
            this.btnberäkna.Name = "btnberäkna";
            this.btnberäkna.Size = new System.Drawing.Size(100, 23);
            this.btnberäkna.TabIndex = 1;
            this.btnberäkna.Text = "Beräkna";
            this.btnberäkna.UseVisualStyleBackColor = true;
            this.btnberäkna.Click += new System.EventHandler(this.btnberäkna_Click);
            // 
            // tbxdeterminant
            // 
            this.tbxdeterminant.Location = new System.Drawing.Point(628, 203);
            this.tbxdeterminant.Name = "tbxdeterminant";
            this.tbxdeterminant.Size = new System.Drawing.Size(100, 20);
            this.tbxdeterminant.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matris";
            // 
            // Determinant
            // 
            this.Determinant.AutoSize = true;
            this.Determinant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Determinant.Location = new System.Drawing.Point(628, 169);
            this.Determinant.Name = "Determinant";
            this.Determinant.Size = new System.Drawing.Size(97, 20);
            this.Determinant.TabIndex = 4;
            this.Determinant.Text = "Determinant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.Determinant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxdeterminant);
            this.Controls.Add(this.btnberäkna);
            this.Controls.Add(this.tbxmatris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxmatris;
        private System.Windows.Forms.Button btnberäkna;
        private System.Windows.Forms.TextBox tbxdeterminant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Determinant;
    }
}

