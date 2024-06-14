using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class HomePagefrm : Form
    {
        public HomePagefrm()
        {
            InitializeComponent();
        }

     

        private void btnAddingMembers_Click(object sender, EventArgs e)
        {
            AddMemberfrm addMember = new AddMemberfrm();
            addMember.ShowDialog();
        }

        private void btnListMembers_Click(object sender, EventArgs e)
        {
            MemberListingfrm memberList = new MemberListingfrm();
            memberList.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bookAddPagefrm bookaddpage = new bookAddPagefrm();
            bookaddpage.ShowDialog();
        }

        private void btnListBooks_Click(object sender, EventArgs e)
        {
            BookListfrm booklist = new BookListfrm();
            booklist.ShowDialog();
        }

        private void btnEscrowBookDelivery_Click(object sender, EventArgs e)
        {
            GiveEscrowBookfrm giveEscrowBook = new GiveEscrowBookfrm();
            giveEscrowBook.ShowDialog();
        }

        private void btnEscrowListing_Click(object sender, EventArgs e)
        {
            EscrowBookListfrm escrowBookList = new EscrowBookListfrm();
            escrowBookList.ShowDialog();
        }

        private void btnEscrowBookReturns_Click(object sender, EventArgs e)
        {
            EscrowBookReturnfrm escrowBookReturn = new EscrowBookReturnfrm();
            escrowBookReturn.ShowDialog();
        }

        private void btnSequencing_Click(object sender, EventArgs e)
        {
            Sequencingfrm sequencing = new Sequencingfrm();
            sequencing.ShowDialog();
        }

        private void btnGraphics_Click(object sender, EventArgs e)
        {
            Graphicsfrm graphics = new Graphicsfrm();
            graphics.ShowDialog();
        }
    }
}
