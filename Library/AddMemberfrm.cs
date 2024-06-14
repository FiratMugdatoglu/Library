using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class AddMemberfrm : Form
    {
        public AddMemberfrm()
        {
            InitializeComponent();
        }

       SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Member(tc,namesurname,age,gender,phonenumber,address,email,numberofbooksread) values(@tc,@namesurname,@age,@gender,@phonenumber,@address,@email,@numberofbooksread)", connection);
          
            command.Parameters.AddWithValue("@tc", txtTc.Text);
            command.Parameters.AddWithValue("@namesurname", txtNameSurname.Text);
            command.Parameters.AddWithValue("@age", txtAge.Text);
            command.Parameters.AddWithValue("@gender", comboGender.Text);
            command.Parameters.AddWithValue("@phonenumber",txtPhoneNumber.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@numberofbooksread", txtNumberofBooksRead.Text);
            command.ExecuteNonQuery();//SqlCommand nesnesiyle belirtilen SQL sorgusunu veritabanında çalıştırır.
            // sorgunun veritabanında başarıyla çalıştırılıp çalıştırılmadığını belirtmek için kullanılır.etkilenen satır sayısınıda verebilir.
            connection.Close();
            MessageBox.Show("Member Registered");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtNumberofBooksRead)
                    {
                        item.Text = "";
                    }
                }

            }
        }

       
    }
}
