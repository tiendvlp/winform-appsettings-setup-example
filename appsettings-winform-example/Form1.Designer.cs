
namespace appsettings_winform_example
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
            this.txtAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.AutoSize = true;
            this.txtAdminPassword.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdminPassword.Location = new System.Drawing.Point(360, 217);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(112, 50);
            this.txtAdminPassword.TabIndex = 1;
            this.txtAdminPassword.Text = "None";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.AutoSize = true;
            this.txtAdminEmail.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdminEmail.Location = new System.Drawing.Point(360, 147);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(112, 50);
            this.txtAdminEmail.TabIndex = 2;
            this.txtAdminEmail.Text = "None";
            this.txtAdminEmail.Click += new System.EventHandler(this.txtAdminEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdminEmail);
            this.Controls.Add(this.txtAdminPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAdminPassword;
        private System.Windows.Forms.Label txtAdminEmail;
    }
}

