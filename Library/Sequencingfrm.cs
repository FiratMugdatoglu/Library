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
    public partial class Sequencingfrm : Form
    {
        public Sequencingfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        DataSet daset = new DataSet();
      
        private void Sequencingfrm_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from Member order by numberofbooksread desc", connection);//Bu sorgu, "Member" tablosundaki tüm sütunları seçer ve "numberofbooksread" sütununa göre azalan şekilde sıralar. Sonuçlar, "numberofbooksread" değeri en yüksek olan kayıttan başlayarak listelenir.
            adapter.Fill(daset, "Member");
            dataGridView1.DataSource = daset.Tables["Member"];
            connection.Close();
            lblThememberwhoreadsthemostbooks.Text = "";
            lblThememberwhoreadstheleastbooks.Text = "";
            lblThememberwhoreadsthemostbooks.Text = daset.Tables["Member"].Rows[0]["namesurname"].ToString()+"=";
            lblThememberwhoreadsthemostbooks.Text += daset.Tables["Member"].Rows[0]["numberofbooksread"].ToString();
            lblThememberwhoreadstheleastbooks.Text = daset.Tables["Member"].Rows[dataGridView1.Rows.Count-2]["namesurname"].ToString()+"=";
            lblThememberwhoreadstheleastbooks.Text += daset.Tables["Member"].Rows[dataGridView1.Rows.Count - 2]["numberofbooksread"].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
