namespace Eczane_Proje_Ödevi
{
    partial class Menü
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
            this.Ltfnsçm = new System.Windows.Forms.Label();
            this.HstolTxt = new System.Windows.Forms.Button();
            this.İlçeklTxt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ltfnsçm
            // 
            this.Ltfnsçm.AutoSize = true;
            this.Ltfnsçm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ltfnsçm.Location = new System.Drawing.Point(12, 31);
            this.Ltfnsçm.Name = "Ltfnsçm";
            this.Ltfnsçm.Size = new System.Drawing.Size(206, 18);
            this.Ltfnsçm.TabIndex = 0;
            this.Ltfnsçm.Text = "ECZANE OTOMASYONU";
            // 
            // HstolTxt
            // 
            this.HstolTxt.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HstolTxt.Location = new System.Drawing.Point(41, 87);
            this.HstolTxt.Name = "HstolTxt";
            this.HstolTxt.Size = new System.Drawing.Size(112, 23);
            this.HstolTxt.TabIndex = 1;
            this.HstolTxt.Text = "Hasta Oluştur";
            this.HstolTxt.UseVisualStyleBackColor = true;
            this.HstolTxt.Click += new System.EventHandler(this.HstolTxt_Click);
            // 
            // İlçeklTxt
            // 
            this.İlçeklTxt.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.İlçeklTxt.Location = new System.Drawing.Point(41, 134);
            this.İlçeklTxt.Name = "İlçeklTxt";
            this.İlçeklTxt.Size = new System.Drawing.Size(112, 23);
            this.İlçeklTxt.TabIndex = 2;
            this.İlçeklTxt.Text = "İlaç Ekle";
            this.İlçeklTxt.UseVisualStyleBackColor = true;
            this.İlçeklTxt.Click += new System.EventHandler(this.İlçeklTxt_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(41, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reçete Oluştur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(291, 272);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.İlçeklTxt);
            this.Controls.Add(this.HstolTxt);
            this.Controls.Add(this.Ltfnsçm);
            this.Name = "Menü";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.Menü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ltfnsçm;
        private Button HstolTxt;
        private Button İlçeklTxt;
        private Button button3;
    }
}