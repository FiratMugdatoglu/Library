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
    public partial class EscrowBookReturnfrm : Form
    {
        public EscrowBookReturnfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        DataSet daset = new DataSet();


        private void EscrowList()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks", connection);
            adapter.Fill(daset, "EscrowBooks");
            dataGridView1.DataSource = daset.Tables["EscrowBooks"];
            connection.Close();
        }


        private void EscrowBookReturnfrm_Load(object sender, EventArgs e)
        {
            EscrowList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcSearch_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EscrowBooks"].Clear();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where tc like '%"+txtTcSearch.Text+"%'",connection);
            adapter.Fill(daset,"EscrowBooks");
            connection.Close();
            if (txtTcSearch.Text=="")
            {
                daset.Tables["EscrowBooks"].Clear();
                EscrowList();
            }
        }

        private void txtBarcodeNumberSearch_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EscrowBooks"].Clear();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where barcodenumber like '%" + txtBarcodeNumberSearch.Text + "%'", connection);
            adapter.Fill(daset, "EscrowBooks");
            connection.Close();
            if (txtBarcodeNumberSearch.Text == "")
            {
                daset.Tables["EscrowBooks"].Clear();
                EscrowList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand command = new SqlCommand("delete from EscrowBooks where tc=@tc and barcodenumber=@barcodenumber", connection);
            command.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            command.Parameters.AddWithValue("@barcodenumber", dataGridView1.CurrentRow.Cells["barcodenumber"].Value.ToString());
            command.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("update Book set numberofstocks=numberofstocks+'" + dataGridView1.CurrentRow.Cells["numberofbook"].Value.ToString() + "' where barcodenumber=@barcodenumber", connection);
            command2.Parameters.AddWithValue("@barcodenumber", dataGridView1.CurrentRow.Cells["barcodenumber"].Value.ToString());
            command2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Books returned");
            daset.Tables["EscrowBooks"].Clear();
            EscrowList();
           
        }
    }
}
