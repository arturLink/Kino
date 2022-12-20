namespace Kino
{
    partial class Parool
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
            this.paroolBox = new System.Windows.Forms.TextBox();
            this.paroolLbl = new System.Windows.Forms.Label();
            this.jatkaBtn = new System.Windows.Forms.Button();
            this.valjaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paroolBox
            // 
            this.paroolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.paroolBox.Location = new System.Drawing.Point(344, 78);
            this.paroolBox.Name = "paroolBox";
            this.paroolBox.Size = new System.Drawing.Size(269, 39);
            this.paroolBox.TabIndex = 0;
            // 
            // paroolLbl
            // 
            this.paroolLbl.AutoSize = true;
            this.paroolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.paroolLbl.Location = new System.Drawing.Point(49, 77);
            this.paroolLbl.Name = "paroolLbl";
            this.paroolLbl.Size = new System.Drawing.Size(289, 40);
            this.paroolLbl.TabIndex = 1;
            this.paroolLbl.Text = "Sissesta parool:";
            // 
            // jatkaBtn
            // 
            this.jatkaBtn.BackColor = System.Drawing.Color.Green;
            this.jatkaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.jatkaBtn.Location = new System.Drawing.Point(445, 157);
            this.jatkaBtn.Name = "jatkaBtn";
            this.jatkaBtn.Size = new System.Drawing.Size(143, 54);
            this.jatkaBtn.TabIndex = 2;
            this.jatkaBtn.Text = "Jätka";
            this.jatkaBtn.UseVisualStyleBackColor = false;
            this.jatkaBtn.Click += new System.EventHandler(this.jatkaBtn_Click);
            // 
            // valjaBtn
            // 
            this.valjaBtn.BackColor = System.Drawing.Color.DarkRed;
            this.valjaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.valjaBtn.Location = new System.Drawing.Point(94, 157);
            this.valjaBtn.Name = "valjaBtn";
            this.valjaBtn.Size = new System.Drawing.Size(143, 54);
            this.valjaBtn.TabIndex = 3;
            this.valjaBtn.Text = "Välja";
            this.valjaBtn.UseVisualStyleBackColor = false;
            this.valjaBtn.Click += new System.EventHandler(this.valjaBtn_Click);
            // 
            // Parool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 249);
            this.Controls.Add(this.valjaBtn);
            this.Controls.Add(this.jatkaBtn);
            this.Controls.Add(this.paroolLbl);
            this.Controls.Add(this.paroolBox);
            this.Name = "Parool";
            this.Text = "Parool";
            this.Load += new System.EventHandler(this.Parool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox paroolBox;
        private System.Windows.Forms.Label paroolLbl;
        private System.Windows.Forms.Button jatkaBtn;
        private System.Windows.Forms.Button valjaBtn;
    }
}