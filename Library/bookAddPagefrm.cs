using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class bookAddPagefrm : Form
    {
        public bookAddPagefrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Book(barcodenumber,bookname,author,publisher,numberofpages,type,numberofstocks,shelfnumber,description,dateofregistration) values(@barcodenumber,@bookname,@author,@publisher,@numberofpages,@type,@numberofstocks,@shelfnumber,@description,@dateofregistration)", connection);
          
            command.Parameters.AddWithValue("@barcodenumber", txtBookBarcodeNumber.Text);
            command.Parameters.AddWithValue("@bookname", txtBookName.Text);
            command.Parameters.AddWithValue("@author", txtAuthor.Text);
            command.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@numberofpages", txtNumberofPages.Text);
            command.Parameters.AddWithValue("@type", comboType.Text);
            command.Parameters.AddWithValue("@numberofstocks", txtNumberofStocks.Text);
            command.Parameters.AddWithValue("@shelfnumber", txtShelfNumber.Text);
            command.Parameters.AddWithValue("@description", txtDescription.Text);
            command.Parameters.AddWithValue("@dateofregistration", DateTime.Now.ToShortDateString());
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book Registered");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    
                        item.Text = "";
                    
                }

            }
        }
    }
}
