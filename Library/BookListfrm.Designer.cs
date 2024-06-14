namespace Library
{
    partial class BookListfrm
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
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBookBarcodeNumber = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtNumberofPages = new System.Windows.Forms.TextBox();
            this.txtNumberofStocks = new System.Windows.Forms.TextBox();
            this.txtShelfNumber = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBarcodeSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Children\'s Books",
            "Story",
            "Novel"});
            this.comboType.Location = new System.Drawing.Point(207, 262);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(165, 24);
            this.comboType.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 456);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Shelf Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Number of Stocks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Number of Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Book Barcode Number";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(207, 375);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(165, 52);
            this.txtDescription.TabIndex = 29;
            // 
            // txtBookBarcodeNumber
            // 
            this.txtBookBarcodeNumber.Location = new System.Drawing.Point(207, 70);
            this.txtBookBarcodeNumber.Name = "txtBookBarcodeNumber";
            this.txtBookBarcodeNumber.Size = new System.Drawing.Size(165, 22);
            this.txtBookBarcodeNumber.TabIndex = 28;
            this.txtBookBarcodeNumber.TextChanged += new System.EventHandler(this.txtBookBarcodeNumber_TextChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(207, 110);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(165, 22);
            this.txtBookName.TabIndex = 27;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(207, 144);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(165, 22);
            this.txtAuthor.TabIndex = 26;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(207, 185);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(165, 22);
            this.txtPublisher.TabIndex = 25;
            // 
            // txtNumberofPages
            // 
            this.txtNumberofPages.Location = new System.Drawing.Point(207, 223);
            this.txtNumberofPages.Name = "txtNumberofPages";
            this.txtNumberofPages.Size = new System.Drawing.Size(165, 22);
            this.txtNumberofPages.TabIndex = 24;
            // 
            // txtNumberofStocks
            // 
            this.txtNumberofStocks.Location = new System.Drawing.Point(207, 299);
            this.txtNumberofStocks.Name = "txtNumberofStocks";
            this.txtNumberofStocks.Size = new System.Drawing.Size(165, 22);
            this.txtNumberofStocks.TabIndex = 23;
            // 
            // txtShelfNumber
            // 
            this.txtShelfNumber.Location = new System.Drawing.Point(207, 336);
            this.txtShelfNumber.Name = "txtShelfNumber";
            this.txtShelfNumber.Size = new System.Drawing.Size(165, 22);
            this.txtShelfNumber.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 357);
            this.dataGridView1.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1054, 456);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 34);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Book Barcode Number Search";
            // 
            // txtBarcodeSearch
            // 
            this.txtBarcodeSearch.Location = new System.Drawing.Point(782, 26);
            this.txtBarcodeSearch.Name = "txtBarcodeSearch";
            this.txtBarcodeSearch.Size = new System.Drawing.Size(165, 22);
            this.txtBarcodeSearch.TabIndex = 44;
            this.txtBarcodeSearch.TextChanged += new System.EventHandler(this.txtBarcodeSearch_TextChanged);
            // 
            // BookListfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 625);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBarcodeSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtBookBarcodeNumber);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtNumberofPages);
            this.Controls.Add(this.txtNumberofStocks);
            this.Controls.Add(this.txtShelfNumber);
            this.Name = "BookListfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Listing Page";
            this.Load += new System.EventHandler(this.BookListfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtBookBarcodeNumber;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtNumberofPages;
        private System.Windows.Forms.TextBox txtNumberofStocks;
        private System.Windows.Forms.TextBox txtShelfNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBarcodeSearch;
    }
}