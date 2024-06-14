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
    public partial class MemberListingfrm : Form
    {
        public MemberListingfrm()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }


        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
           

            SqlCommand command = new SqlCommand("SELECT * FROM Member WHERE tc LIKE @tc" , connection);
            command.Parameters.AddWithValue("@tc", "%" + txtTc.Text + "%");//Parametre kullanımı, SQL enjeksiyon saldırılarına karşı koruma sağlar ve kullanıcı tarafından girilen verilerin güvenli bir şekilde işlenmesini sağlar.

            

            SqlDataReader read = command.ExecuteReader();//ExecuteReader() yöntemi, SqlCommand nesnesiyle bir SELECT sorgusunu çalıştırır ve sorgudan dönen sonuçları okumak için bir SqlDataReader nesnesini döndürür. SqlDataReader, sorgudan dönen satırları tek tek okumak için kullanılır.
            //SQL Server veritabanlarından veri okumak için kullanılan bir sınıftır.
            while (read.Read())//Kayıtlar okunduğu sürece devam eder.
            {
                txtNameSurname.Text = read["namesurname"].ToString();
                txtAge.Text = read["age"].ToString();
                comboGender.Text = read["gender"].ToString();
                txtPhoneNumber.Text = read["phonenumber"].ToString();
                txtAddress.Text = read["address"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtNumberofBooksRead.Text = read["numberofbooksread"].ToString();
            }
            connection.Close();
        }
        DataSet daset = new DataSet();//DataSet nesnesi, veri kaynaklarından verilerin çekilmesi için kullanılır. Veritabanı sorgularından elde edilen sonuçlar veya diğer veri kaynaklarından alınan veriler, DataSet içinde tablolar ve sütunlar olarak organize edilebilir ve bu verilere erişim sağlanabilir.
        private void txtSearchTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Member"].Clear();//DataSet içindeki belirli bir tabloyu temizlemeyi (verileri silmeyi) temsil ediyor.
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Member where tc like '%"+txtSearchTc.Text+"%' ",connection);//SqlCommand sınıfı veritabanı üzerinde sorguları yürütmek için kullanılırken, SqlDataAdapter sınıfı veri okuma veya yazma işlemleri için kullanılır. 
            adapter.Fill(daset, "Member");//Veri doldurma işlemi, SqlDataAdapter nesnesinin Fill yöntemiyle gerçekleştirilir. Bu yöntem, belirtilen SQL sorgusunu çalıştırarak verileri veritabanından çeker ve ilgili DataSet veya DataTable içine doldurur.
            dataGridView1.DataSource = daset.Tables["Member"];//DataGridView kontrolünün DataSource özelliği, veri kaynağı olarak bir DataTable veya bir koleksiyon gibi veri yapısını kabul eder. Bu sayede, belirli bir tablodan veya veri kaynağından gelen verileri DataGridView üzerinde gösterebiliriz.
            connection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Are you sure you want to delete this record?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("delete from Member where tc = @tc", connection);
                command.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Deleted");
                daset.Tables["Member"].Clear();
                memberList();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }



                }
            }
           
        }
        private void memberList()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Member", connection);
            adapter.Fill(daset, "Member");
            dataGridView1.DataSource = daset.Tables["Member"];
            connection.Close();
        }
        private void MemberListingfrm_Load(object sender, EventArgs e)
        {
            memberList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update Member set namesurname=@namesurname,age=@age,gender=@gender,phonenumber=@phonenumber,address=@address,email=@email,numberofbooksread=@numberofbooksread where tc=@tc",connection);
            command.Parameters.AddWithValue("@tc",txtTc.Text);
            command.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
            command.Parameters.AddWithValue("@age", txtAge.Text);
            command.Parameters.AddWithValue("@gender", comboGender.Text);
            command.Parameters.AddWithValue("@phonenumber", txtPhoneNumber.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@numberofbooksread", int.Parse(txtNumberofBooksRead.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Updated");
            daset.Tables["Member"].Clear();
            memberList();
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
