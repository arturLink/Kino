namespace Kino
{
    partial class Email
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.mailLbl = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.emailBox.Location = new System.Drawing.Point(397, 123);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(370, 48);
            this.emailBox.TabIndex = 0;
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mailLbl.Location = new System.Drawing.Point(35, 133);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(356, 32);
            this.mailLbl.TabIndex = 1;
            this.mailLbl.Text = "Palun sissesta oma E-mail:";
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.Green;
            this.yesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.yesBtn.Location = new System.Drawing.Point(80, 265);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(240, 100);
            this.yesBtn.TabIndex = 2;
            this.yesBtn.Text = "Kinnitada";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.Red;
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.noBtn.Location = new System.Drawing.Point(472, 265);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(240, 100);
            this.noBtn.TabIndex = 3;
            this.noBtn.Text = "Tühista";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.emailBox);
            this.Name = "Email";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
    }
}