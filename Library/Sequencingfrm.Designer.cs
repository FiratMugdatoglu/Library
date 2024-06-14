namespace Library
{
    partial class Sequencingfrm
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblThememberwhoreadsthemostbooks = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblThememberwhoreadstheleastbooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(150, 27);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(243, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "The member who reads the most books";
            // 
            // lblThememberwhoreadsthemostbooks
            // 
            this.lblThememberwhoreadsthemostbooks.AutoSize = true;
            this.lblThememberwhoreadsthemostbooks.Location = new System.Drawing.Point(417, 27);
            this.lblThememberwhoreadsthemostbooks.Name = "lblThememberwhoreadsthemostbooks";
            this.lblThememberwhoreadsthemostbooks.Size = new System.Drawing.Size(44, 16);
            this.lblThememberwhoreadsthemostbooks.TabIndex = 2;
            this.lblThememberwhoreadsthemostbooks.Text = "label2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(150, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(243, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "The member who reads the least books";
            // 
            // lblThememberwhoreadstheleastbooks
            // 
            this.lblThememberwhoreadstheleastbooks.AutoSize = true;
            this.lblThememberwhoreadstheleastbooks.Location = new System.Drawing.Point(417, 66);
            this.lblThememberwhoreadstheleastbooks.Name = "lblThememberwhoreadstheleastbooks";
            this.lblThememberwhoreadstheleastbooks.Size = new System.Drawing.Size(44, 16);
            this.lblThememberwhoreadstheleastbooks.TabIndex = 4;
            this.lblThememberwhoreadstheleastbooks.Text = "label4";
            // 
            // Sequencingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThememberwhoreadstheleastbooks);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblThememberwhoreadsthemostbooks);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sequencingfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequencing Page";
            this.Load += new System.EventHandler(this.Sequencingfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblThememberwhoreadsthemostbooks;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblThememberwhoreadstheleastbooks;
    }
}