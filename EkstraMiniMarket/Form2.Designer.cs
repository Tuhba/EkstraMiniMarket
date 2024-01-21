namespace EkstraMiniMarket
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.btnSatisIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(478, 261);
            this.btnDukkanIslemleri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(283, 92);
            this.btnDukkanIslemleri.TabIndex = 13;
            this.btnDukkanIslemleri.Text = "Dükkan İşlemleri";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click_1);
            // 
            // btnSatisIslemleri
            // 
            this.btnSatisIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btnSatisIslemleri.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIslemleri.Location = new System.Drawing.Point(31, 261);
            this.btnSatisIslemleri.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSatisIslemleri.Name = "btnSatisIslemleri";
            this.btnSatisIslemleri.Size = new System.Drawing.Size(282, 92);
            this.btnSatisIslemleri.TabIndex = 12;
            this.btnSatisIslemleri.Text = "Satış İşlemleri";
            this.btnSatisIslemleri.UseVisualStyleBackColor = false;
            this.btnSatisIslemleri.Click += new System.EventHandler(this.btnSatisIslemleri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.btnSatisIslemleri);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDukkanIslemleri;
        private System.Windows.Forms.Button btnSatisIslemleri;
    }
}