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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Library
{
    public partial class BookListfrm : Form
    {
        public BookListfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        DataSet daset = new DataSet();

        private void bookList()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Book", connection);
            adapter.Fill(daset, "Book");
            dataGridView1.DataSource = daset.Tables["Book"];
            connection.Close();
        }

        private void BookListfrm_Load(object sender, EventArgs e)
        {
            bookList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;//Bu kod parçası, bir iletişim kutusu gösterildiğinde kullanıcının seçtiği sonucu dialog değişkenine atamak için kullanılabilir
            dialog = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Book where barcodenumber = @barcodenumber", connection);
                command.Parameters.AddWithValue("@barcodenumber", dataGridView1.CurrentRow.Cells["barcodenumber"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted");
                daset.Tables["Book"].Clear();
                bookList();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }



                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Book set bookname=@bookname,author=@author,publisher=@publisher,numberofpages=@numberofpages,type=@type,numberofstocks=@numberofstocks,shelfnumber=@shelfnumber,description=@description where barcodenumber=@barcodenumber", connection);
            command.Parameters.AddWithValue("@barcodenumber", txtBookBarcodeNumber.Text);
            command.Parameters.AddWithValue("@bookname", txtBookName.Text);
            command.Parameters.AddWithValue("@author", txtAuthor.Text);
            command.Parameters.AddWithValue("@publisher", txtPublisher.Text);
            command.Parameters.AddWithValue("@numberofpages", txtNumberofPages.Text);
            command.Parameters.AddWithValue("@type", comboType.Text);
            command.Parameters.AddWithValue("@numberofstocks", txtNumberofStocks.Text);
            command.Parameters.AddWithValue("@shelfnumber", txtShelfNumber.Text);
            command.Parameters.AddWithValue("@description", txtDescription.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated");
            daset.Tables["Book"].Clear();
            bookList();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }



            }
        }

        private void txtBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Book"].Clear();//DataSet içindeki belirli bir tabloyu temizlemeyi (verileri silmeyi) temsil ediyor.
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Book where barcodenumber like '%" + txtBarcodeSearch.Text + "%' ", connection);
            adapter.Fill(daset, "Book");//Veri doldurma işlemi, SqlDataAdapter nesnesinin Fill yöntemiyle gerçekleştirilir. Bu yöntem, belirtilen SQL sorgusunu çalıştırarak verileri veritabanından çeker ve ilgili DataSet veya DataTable içine doldurur.
            dataGridView1.DataSource = daset.Tables["Book"];//DataGridView kontrolünün DataSource özelliği, veri kaynağı olarak bir DataTable veya bir koleksiyon gibi veri yapısını kabul eder. Bu sayede, belirli bir tablodan veya veri kaynağından gelen verileri DataGridView üzerinde gösterebiliriz.
            connection.Close();


        }

        private void txtBookBarcodeNumber_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select *from Book where barcodenumber like '" + txtBookBarcodeNumber.Text + "' ", connection);

            SqlDataReader read = command.ExecuteReader();//ExecuteReader() yöntemi, SqlCommand nesnesiyle bir SELECT sorgusunu çalıştırır ve sorgudan dönen sonuçları okumak için bir SqlDataReader nesnesini döndürür. SqlDataReader, sorgudan dönen satırları tek tek okumak için kullanılır.
            while (read.Read())//Kayıtlar okunduğu sürece devam eder.
            {
                txtBookName.Text = read["bookname"].ToString();// "namesurname" adlı sütundaki değeri okuyarak, bu değeri "txtNameSurname.Text" özelliğine atar.
                txtAuthor.Text = read["author"].ToString();
                txtPublisher.Text = read["publisher"].ToString();
                txtNumberofPages.Text = read["numberofpages"].ToString();
                comboType.Text = read["type"].ToString();
                txtNumberofStocks.Text = read["numberofstocks"].ToString();
                txtShelfNumber.Text = read["shelfnumber"].ToString();
                txtDescription.Text = read["description"].ToString();

            }
            connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
