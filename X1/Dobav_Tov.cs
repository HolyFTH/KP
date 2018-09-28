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

namespace X1
{
    public partial class Dobav_Tov : Form
    {
        public Dobav_Tov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-0PU11SR\\SQLEXPRESS; Initial Catalog = X1_Shop; Integrated Security=true;";
            SqlConnection sc = new SqlConnection(connectionString);
            string sql = "INSERT INTO Tovar(Nazv_Tovar, Opis_Tovar, Cena_Tovar, Nal_Tovar, Kolvo_Tovar)VALUES" +
            "(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',1,N'" + textBox4.Text + "') ;";
            try
            {
                MessageBox.Show("Был добавлен товар: " + textBox1.Text);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cp = new SqlCommand(sql, conn);
                    cp.ExecuteNonQuery();
                    Form1 f1 = new Form1();
                    f1.dataGridView1.Refresh();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Возникли проблемы во время регистрации");
            }
        }
    }
}
