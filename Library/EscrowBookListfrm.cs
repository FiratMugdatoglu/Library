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
    public partial class EscrowBookListfrm : Form
    {
        public EscrowBookListfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        DataSet daset = new DataSet();

        private void EscrowBookListfrm_Load(object sender, EventArgs e)
        {
            EscrowList();
            comboBox1.SelectedIndex= 0;
        }

        private void EscrowList()
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks", connection);
            adapter.Fill(daset, "EscrowBooks");
            dataGridView1.DataSource = daset.Tables["EscrowBooks"];
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EscrowBooks"].Clear();
            if (comboBox1.SelectedIndex==0)
            {
                EscrowList();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where '"+ DateTime.Now.ToShortDateString() +"' > returndate", connection);
                adapter.Fill(daset, "EscrowBooks");
                dataGridView1.DataSource = daset.Tables["EscrowBooks"];
                connection.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from EscrowBooks where '" + DateTime.Now.ToShortDateString() + "' <= returndate", connection);
                adapter.Fill(daset, "EscrowBooks");
                dataGridView1.DataSource = daset.Tables["EscrowBooks"];
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
