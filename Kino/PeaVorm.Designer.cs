namespace Kino
{
    partial class PeaVorm
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
            this.FilmiBtn = new System.Windows.Forms.Button();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmiBtn
            // 
            this.FilmiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.FilmiBtn.Location = new System.Drawing.Point(77, 42);
            this.FilmiBtn.Name = "FilmiBtn";
            this.FilmiBtn.Size = new System.Drawing.Size(648, 207);
            this.FilmiBtn.TabIndex = 0;
            this.FilmiBtn.Text = "Vaata Filmid";
            this.FilmiBtn.UseVisualStyleBackColor = true;
            this.FilmiBtn.Click += new System.EventHandler(this.FilmiBtn_Click);
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(679, 387);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(109, 51);
            this.AdminBtn.TabIndex = 1;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // PeaVorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kino.Properties.Resources.PeaVormBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.FilmiBtn);
            this.Name = "PeaVorm";
            this.Text = "PeaVorm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FilmiBtn;
        private System.Windows.Forms.Button AdminBtn;
    }
}