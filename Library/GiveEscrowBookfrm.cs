using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class GiveEscrowBookfrm : Form
    {
        public GiveEscrowBookfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        DataSet daset = new DataSet();

        private void basketList()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Basket",connection);
            adapter.Fill(daset,"Basket");
            dataGridView1.DataSource = daset.Tables["Basket"];
            connection.Close();
        }


        private void numberOfBooks()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select sum(numberofbook) from Basket", connection);
            lblNumberofBooks.Text=command.ExecuteScalar().ToString();//ExecuteScalar() Tek alanlık bir değeri geri döndürmek için kullanılmaktadır. Object tipinde veri döndürmektedir.
            connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into basket(barcodenumber,bookname,author,publisher,numberofpages,numberofbook,deliverydate,returndate) values(@barcodenumber,@bookname,@author,@publisher,@numberofpages,@numberofbook,@deliverydate,@returndate)", connection);
            command.Parameters.AddWithValue("@barcodenumber",txtBarcodeNumber.Text);
            command.Parameters.AddWithValue("@bookname", txtBookName.Text);
            command.Parameters.AddWithValue("@author",   txtAuthor.Text);
            command.Parameters.AddWithValue("@publisher",txtPublisher.Text);
            command.Parameters.AddWithValue("@numberofpages", txtNumberofPages.Text);
            command.Parameters.AddWithValue("@numberofbook", int.Parse(txtNumberofBooks.Text));
            command.Parameters.AddWithValue("@deliverydate", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@returndate", dateTimePicker2.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Books added to cart", "Adding Process");
            daset.Tables["Basket"].Clear();
            basketList();
            lblNumberofBooks.Text = "";
            numberOfBooks();
            foreach (Control item in grpBookInformation.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtNumberofBooks)
                    {
                        item.Text = "";
                    }
                }



            }
        }

        private void GiveEscrowBookfrm_Load(object sender, EventArgs e)
        {
            basketList();
            numberOfBooks();
        }

        private void txtTcSearch_TextChanged(object sender, EventArgs e)
        {
             connection.Open();
            SqlCommand command = new SqlCommand("select *from Member where tc like '"+txtTcSearch.Text+"' ", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtNameSurname.Text = read["namesurname"].ToString();
                txtAge.Text = read["age"].ToString();
                txtPhoneNumber.Text = read["phonenumber"].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("select sum(numberofbook) from EscrowBooks where tc='"+ txtTcSearch.Text+"'", connection);
            lblNumberofRegisteredBooks.Text=command2.ExecuteScalar().ToString();
            connection.Close();

            if (txtTcSearch.Text == "")
            {
                foreach (Control item in grpMemberInformation.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        
                    }
                    
                }
                lblNumberofRegisteredBooks.Text = "";
            }

            
        }

        private void txtBarcodeNumber_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from Book where barcodenumber like  '"+txtBarcodeNumber.Text+"' ", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtBookName.Text = read["bookname"].ToString();
                txtAuthor.Text = read["author"].ToString();
                txtPublisher.Text = read["publisher"].ToString();
                txtNumberofPages.Text = read["numberofpages"].ToString();
                
            }
            connection.Close();
            if (txtBarcodeNumber.Text=="")
            {
                foreach (Control item in grpBookInformation.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtNumberofBooks)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Delete record?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Basket where barcodenumber='" + dataGridView1.CurrentRow.Cells["barcodenumber"].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted", "Deletion Process");
                daset.Tables["Basket"].Clear();
                basketList();
                lblNumberofBooks.Text = "";
                numberOfBooks();
            }
          
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {

            if (lblNumberofBooks.Text!="")
            {
                if (lblNumberofRegisteredBooks.Text == "" && int.Parse(lblNumberofBooks.Text)<=3 || lblNumberofRegisteredBooks.Text!="" && int.Parse(lblNumberofRegisteredBooks.Text)+int.Parse(lblNumberofBooks.Text)<=3)
                    {
                    if (txtTcSearch.Text!="" && txtNameSurname.Text!="" && txtAge.Text!="" && txtPhoneNumber.Text!="")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand("insert into EscrowBooks(tc,namesurname,age,phonenumber,barcodenumber,bookname,author,publisher,numberofpages,numberofbook,deliverydate,returndate) values(@tc,@namesurname,@age,@phonenumber,@barcodenumber,@bookname,@author,@publisher,@numberofpages,@numberofbook,@deliverydate,@returndate)", connection);
                            command.Parameters.AddWithValue("@tc",txtTcSearch.Text);
                            command.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
                            command.Parameters.AddWithValue("@age", txtAge.Text);
                            command.Parameters.AddWithValue("@phonenumber", txtPublisher.Text);
                            command.Parameters.AddWithValue("barcodenumber", dataGridView1.Rows[i].Cells["barcodenumber"].Value.ToString());
                            command.Parameters.AddWithValue("bookname", dataGridView1.Rows[i].Cells["bookname"].Value.ToString());
                            command.Parameters.AddWithValue("author", dataGridView1.Rows[i].Cells["author"].Value.ToString());
                            command.Parameters.AddWithValue("publisher", dataGridView1.Rows[i].Cells["publisher"].Value.ToString());
                            command.Parameters.AddWithValue("numberofpages", dataGridView1.Rows[i].Cells["numberofpages"].Value.ToString());
                            command.Parameters.AddWithValue("numberofbook",int.Parse(dataGridView1.Rows[i].Cells["numberofbook"].Value.ToString()));
                            command.Parameters.AddWithValue("deliverydate", dataGridView1.Rows[i].Cells["deliverydate"].Value.ToString());
                            command.Parameters.AddWithValue("returndate", dataGridView1.Rows[i].Cells["returndate"].Value.ToString());
                            command.ExecuteNonQuery();
                            SqlCommand command2 = new SqlCommand("update Member set numberofbooksread=numberofbooksread+ '" + int.Parse(dataGridView1.Rows[i].Cells["numberofbook"].Value.ToString())+"'  where tc = '"+txtTcSearch.Text +"'    ", connection);
                            command2.ExecuteNonQuery();
                            SqlCommand command3 = new SqlCommand("update Book set numberofstocks=numberofstocks-'" + Convert.ToInt32(dataGridView1.Rows[i].Cells["numberofbook"].Value.ToString()) + "'  where barcodenumber = '" + dataGridView1.Rows[i].Cells["barcodenumber"].Value.ToString() + "'    ", connection);
                            command3.ExecuteNonQuery();
                            connection.Close(); 
                        }

                        connection.Open();
                        SqlCommand command4 = new SqlCommand("delete from Basket", connection); 
                        command4.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("The books were entrusted");
                        daset.Tables["Basket"].Clear();
                        basketList();
                        txtTcSearch.Text = "";

                        lblNumberofBooks.Text = "";
                        numberOfBooks();
                        lblNumberofRegisteredBooks.Text = "";
                    
                    }
                    else
                    {
                        MessageBox.Show("First you must choose a member name", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("The number of escrow books cannot be more than 3","Warning");
                }

            }
            else
            {
                MessageBox.Show("Add book to cart first", "Warning");
            }






        
        }

       
    }
}
