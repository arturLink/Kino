namespace Kino
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmiPlt = new System.Windows.Forms.PictureBox();
            this.nimiBox = new System.Windows.Forms.TextBox();
            this.aastaBox = new System.Windows.Forms.TextBox();
            this.zanrBox = new System.Windows.Forms.TextBox();
            this.keelBox = new System.Windows.Forms.TextBox();
            this.kestusBox = new System.Windows.Forms.TextBox();
            this.uuendaBtn = new System.Windows.Forms.Button();
            this.kustutaBtn = new System.Windows.Forms.Button();
            this.liisaBtn = new System.Windows.Forms.Button();
            this.piltBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmiPlt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // filmiPlt
            // 
            this.filmiPlt.Location = new System.Drawing.Point(929, 24);
            this.filmiPlt.Name = "filmiPlt";
            this.filmiPlt.Size = new System.Drawing.Size(278, 330);
            this.filmiPlt.TabIndex = 1;
            this.filmiPlt.TabStop = false;
            // 
            // nimiBox
            // 
            this.nimiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nimiBox.Location = new System.Drawing.Point(684, 24);
            this.nimiBox.Name = "nimiBox";
            this.nimiBox.Size = new System.Drawing.Size(163, 39);
            this.nimiBox.TabIndex = 2;
            this.nimiBox.Text = "Nimi";
            this.nimiBox.Enter += new System.EventHandler(this.nimiBox_Enter);
            this.nimiBox.Leave += new System.EventHandler(this.nimiBox_Leave);
            // 
            // aastaBox
            // 
            this.aastaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.aastaBox.Location = new System.Drawing.Point(684, 99);
            this.aastaBox.Name = "aastaBox";
            this.aastaBox.Size = new System.Drawing.Size(163, 39);
            this.aastaBox.TabIndex = 3;
            this.aastaBox.Text = "Aasta";
            this.aastaBox.Enter += new System.EventHandler(this.aastaBox_Enter);
            this.aastaBox.Leave += new System.EventHandler(this.aastaBox_Leave);
            // 
            // zanrBox
            // 
            this.zanrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.zanrBox.Location = new System.Drawing.Point(684, 174);
            this.zanrBox.Name = "zanrBox";
            this.zanrBox.Size = new System.Drawing.Size(163, 39);
            this.zanrBox.TabIndex = 4;
            this.zanrBox.Text = "Zanr";
            this.zanrBox.Enter += new System.EventHandler(this.zanrBox_Enter);
            this.zanrBox.Leave += new System.EventHandler(this.zanrBox_Leave);
            // 
            // keelBox
            // 
            this.keelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.keelBox.Location = new System.Drawing.Point(684, 246);
            this.keelBox.Name = "keelBox";
            this.keelBox.Size = new System.Drawing.Size(163, 39);
            this.keelBox.TabIndex = 5;
            this.keelBox.Text = "Keel";
            this.keelBox.Enter += new System.EventHandler(this.keelBox_Enter);
            this.keelBox.Leave += new System.EventHandler(this.keelBox_Leave);
            // 
            // kestusBox
            // 
            this.kestusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.kestusBox.Location = new System.Drawing.Point(684, 315);
            this.kestusBox.Name = "kestusBox";
            this.kestusBox.Size = new System.Drawing.Size(163, 39);
            this.kestusBox.TabIndex = 6;
            this.kestusBox.Text = "Kestus";
            this.kestusBox.Enter += new System.EventHandler(this.kestusBox_Enter);
            this.kestusBox.Leave += new System.EventHandler(this.kestusBox_Leave);
            // 
            // uuendaBtn
            // 
            this.uuendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.uuendaBtn.Location = new System.Drawing.Point(185, 300);
            this.uuendaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uuendaBtn.Name = "uuendaBtn";
            this.uuendaBtn.Size = new System.Drawing.Size(129, 43);
            this.uuendaBtn.TabIndex = 17;
            this.uuendaBtn.Text = "Uuenda";
            this.uuendaBtn.UseVisualStyleBackColor = true;
            this.uuendaBtn.Click += new System.EventHandler(this.uuendaBtn_Click);
            // 
            // kustutaBtn
            // 
            this.kustutaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kustutaBtn.Location = new System.Drawing.Point(31, 300);
            this.kustutaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kustutaBtn.Name = "kustutaBtn";
            this.kustutaBtn.Size = new System.Drawing.Size(129, 43);
            this.kustutaBtn.TabIndex = 16;
            this.kustutaBtn.Text = "Kustuta";
            this.kustutaBtn.UseVisualStyleBackColor = true;
            this.kustutaBtn.Click += new System.EventHandler(this.kustutaBtn_Click);
            // 
            // liisaBtn
            // 
            this.liisaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.liisaBtn.Location = new System.Drawing.Point(337, 300);
            this.liisaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.liisaBtn.Name = "liisaBtn";
            this.liisaBtn.Size = new System.Drawing.Size(129, 43);
            this.liisaBtn.TabIndex = 15;
            this.liisaBtn.Text = "Liisa";
            this.liisaBtn.UseVisualStyleBackColor = true;
            this.liisaBtn.Click += new System.EventHandler(this.liisaBtn_Click);
            // 
            // piltBtn
            // 
            this.piltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.piltBtn.Location = new System.Drawing.Point(491, 300);
            this.piltBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.piltBtn.Name = "piltBtn";
            this.piltBtn.Size = new System.Drawing.Size(129, 43);
            this.piltBtn.TabIndex = 14;
            this.piltBtn.Text = "Valita Pildi";
            this.piltBtn.UseVisualStyleBackColor = true;
            this.piltBtn.Click += new System.EventHandler(this.piltBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.uuendaBtn);
            this.Controls.Add(this.kustutaBtn);
            this.Controls.Add(this.liisaBtn);
            this.Controls.Add(this.piltBtn);
            this.Controls.Add(this.kestusBox);
            this.Controls.Add(this.keelBox);
            this.Controls.Add(this.zanrBox);
            this.Controls.Add(this.aastaBox);
            this.Controls.Add(this.nimiBox);
            this.Controls.Add(this.filmiPlt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmiPlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox filmiPlt;
        private System.Windows.Forms.TextBox nimiBox;
        private System.Windows.Forms.TextBox aastaBox;
        private System.Windows.Forms.TextBox zanrBox;
        private System.Windows.Forms.TextBox keelBox;
        private System.Windows.Forms.TextBox kestusBox;
        private System.Windows.Forms.Button uuendaBtn;
        private System.Windows.Forms.Button kustutaBtn;
        private System.Windows.Forms.Button liisaBtn;
        private System.Windows.Forms.Button piltBtn;
    }
}