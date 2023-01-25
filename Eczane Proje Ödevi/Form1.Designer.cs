namespace Eczane_Proje_Ödevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.usernmLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.Location = new System.Drawing.Point(12, 59);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(0, 15);
            this.emailLbl.TabIndex = 0;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.Location = new System.Drawing.Point(12, 126);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(67, 15);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(1, 87);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(100, 23);
            this.EmailTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(1, 154);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(100, 23);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(1, 197);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(142, 72);
            this.EnterBtn.TabIndex = 2;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // usernmLBL
            // 
            this.usernmLBL.AutoSize = true;
            this.usernmLBL.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernmLBL.Location = new System.Drawing.Point(18, 59);
            this.usernmLBL.Name = "usernmLBL";
            this.usernmLBL.Size = new System.Drawing.Size(74, 15);
            this.usernmLBL.TabIndex = 3;
            this.usernmLBL.Text = "Username";
            this.usernmLBL.Click += new System.EventHandler(this.usernmLBL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usernmLBL);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label emailLbl;
        private Label passwordLbl;
        private TextBox EmailTxt;
        private TextBox passwordTxt;
        private Button EnterBtn;
        private Label usernmLBL;
    }
}