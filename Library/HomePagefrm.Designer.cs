namespace Library
{
    partial class HomePagefrm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListMembers = new System.Windows.Forms.Button();
            this.btnAddingMembers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListBooks = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEscrowBookReturns = new System.Windows.Forms.Button();
            this.btnEscrowListing = new System.Windows.Forms.Button();
            this.btnEscrowBookDelivery = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnSequencing = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListMembers);
            this.groupBox1.Controls.Add(this.btnAddingMembers);
            this.groupBox1.Location = new System.Drawing.Point(48, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Transactions";
            // 
            // btnListMembers
            // 
            this.btnListMembers.Location = new System.Drawing.Point(0, 77);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Size = new System.Drawing.Size(252, 30);
            this.btnListMembers.TabIndex = 1;
            this.btnListMembers.Text = "Member Listing ";
            this.btnListMembers.UseVisualStyleBackColor = true;
            this.btnListMembers.Click += new System.EventHandler(this.btnListMembers_Click);
            // 
            // btnAddingMembers
            // 
            this.btnAddingMembers.Location = new System.Drawing.Point(0, 21);
            this.btnAddingMembers.Name = "btnAddingMembers";
            this.btnAddingMembers.Size = new System.Drawing.Size(252, 30);
            this.btnAddingMembers.TabIndex = 0;
            this.btnAddingMembers.Text = "Adding Members";
            this.btnAddingMembers.UseVisualStyleBackColor = true;
            this.btnAddingMembers.Click += new System.EventHandler(this.btnAddingMembers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListBooks);
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Location = new System.Drawing.Point(476, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Transactions";
            // 
            // btnListBooks
            // 
            this.btnListBooks.Location = new System.Drawing.Point(0, 84);
            this.btnListBooks.Name = "btnListBooks";
            this.btnListBooks.Size = new System.Drawing.Size(254, 29);
            this.btnListBooks.TabIndex = 1;
            this.btnListBooks.Text = "List Books";
            this.btnListBooks.UseVisualStyleBackColor = true;
            this.btnListBooks.Click += new System.EventHandler(this.btnListBooks_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(0, 21);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(254, 30);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEscrowBookReturns);
            this.groupBox3.Controls.Add(this.btnEscrowListing);
            this.groupBox3.Controls.Add(this.btnEscrowBookDelivery);
            this.groupBox3.Location = new System.Drawing.Point(48, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Escrow Book Transactions";
            // 
            // btnEscrowBookReturns
            // 
            this.btnEscrowBookReturns.Location = new System.Drawing.Point(0, 96);
            this.btnEscrowBookReturns.Name = "btnEscrowBookReturns";
            this.btnEscrowBookReturns.Size = new System.Drawing.Size(246, 37);
            this.btnEscrowBookReturns.TabIndex = 4;
            this.btnEscrowBookReturns.Text = "Escrow Book Returns";
            this.btnEscrowBookReturns.UseVisualStyleBackColor = true;
            this.btnEscrowBookReturns.Click += new System.EventHandler(this.btnEscrowBookReturns_Click);
            // 
            // btnEscrowListing
            // 
            this.btnEscrowListing.Location = new System.Drawing.Point(0, 56);
            this.btnEscrowListing.Name = "btnEscrowListing";
            this.btnEscrowListing.Size = new System.Drawing.Size(246, 38);
            this.btnEscrowListing.TabIndex = 1;
            this.btnEscrowListing.Text = "Escrow Listing";
            this.btnEscrowListing.UseVisualStyleBackColor = true;
            this.btnEscrowListing.Click += new System.EventHandler(this.btnEscrowListing_Click);
            // 
            // btnEscrowBookDelivery
            // 
            this.btnEscrowBookDelivery.Location = new System.Drawing.Point(0, 21);
            this.btnEscrowBookDelivery.Name = "btnEscrowBookDelivery";
            this.btnEscrowBookDelivery.Size = new System.Drawing.Size(246, 29);
            this.btnEscrowBookDelivery.TabIndex = 0;
            this.btnEscrowBookDelivery.Text = "Escrow Book Delivery";
            this.btnEscrowBookDelivery.UseVisualStyleBackColor = true;
            this.btnEscrowBookDelivery.Click += new System.EventHandler(this.btnEscrowBookDelivery_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGraphics);
            this.groupBox4.Controls.Add(this.btnSequencing);
            this.groupBox4.Location = new System.Drawing.Point(482, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 111);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sequencing and Graphics";
            // 
            // btnGraphics
            // 
            this.btnGraphics.Location = new System.Drawing.Point(0, 82);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(248, 29);
            this.btnGraphics.TabIndex = 1;
            this.btnGraphics.Text = "Graphics";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnSequencing
            // 
            this.btnSequencing.Location = new System.Drawing.Point(0, 21);
            this.btnSequencing.Name = "btnSequencing";
            this.btnSequencing.Size = new System.Drawing.Size(248, 29);
            this.btnSequencing.TabIndex = 0;
            this.btnSequencing.Text = "Sequencing";
            this.btnSequencing.UseVisualStyleBackColor = true;
            this.btnSequencing.Click += new System.EventHandler(this.btnSequencing_Click);
            // 
            // HomePagefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomePagefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Button btnAddingMembers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEscrowListing;
        private System.Windows.Forms.Button btnEscrowBookDelivery;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnSequencing;
        private System.Windows.Forms.Button btnEscrowBookReturns;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

