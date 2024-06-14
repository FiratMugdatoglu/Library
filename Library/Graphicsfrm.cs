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
    public partial class Graphicsfrm : Form
    {
        public Graphicsfrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2M7U78F\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        private void Graphicsfrm_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select namesurname,numberofbooksread from Member", connection);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                chart1.Series["Number of Books Read"].Points.AddXY(read["namesurname"].ToString(), read["numberofbooksread"]);
            }
            connection.Close();
            chart1.Series["Number of Books Read"].Color = Color.Orange;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
