namespace PassCarrie
{
    partial class Carrie
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
            this.lbRodape = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lbSeria = new System.Windows.Forms.Label();
            this.lbAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRodape
            // 
            this.lbRodape.AutoSize = true;
            this.lbRodape.BackColor = System.Drawing.Color.Transparent;
            this.lbRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodape.ForeColor = System.Drawing.Color.White;
            this.lbRodape.Location = new System.Drawing.Point(12, 211);
            this.lbRodape.Name = "lbRodape";
            this.lbRodape.Size = new System.Drawing.Size(51, 20);
            this.lbRodape.TabIndex = 11;
            this.lbRodape.Text = "label1";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(40, 131);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(220, 35);
            this.txtSerial.TabIndex = 12;
            this.txtSerial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyUp);
            // 
            // lbSeria
            // 
            this.lbSeria.AutoSize = true;
            this.lbSeria.BackColor = System.Drawing.Color.Transparent;
            this.lbSeria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeria.ForeColor = System.Drawing.Color.White;
            this.lbSeria.Location = new System.Drawing.Point(36, 108);
            this.lbSeria.Name = "lbSeria";
            this.lbSeria.Size = new System.Drawing.Size(49, 20);
            this.lbSeria.TabIndex = 13;
            this.lbSeria.Text = "Serial";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.Color.Transparent;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Red;
            this.lbAviso.Location = new System.Drawing.Point(36, 181);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(51, 20);
            this.lbAviso.TabIndex = 14;
            this.lbAviso.Text = "label1";
            // 
            // Carrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PassCarrie.Properties.Resources.logoPreto;
            this.ClientSize = new System.Drawing.Size(644, 240);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.lbSeria);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.lbRodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Carrie";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass Carrie  V1.0.0";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRodape;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lbSeria;
        private System.Windows.Forms.Label lbAviso;
    }
}

