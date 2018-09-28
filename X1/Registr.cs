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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void Registr_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-0PU11SR\\SQLEXPRESS; Initial Catalog = X1_Shop; Integrated Security=true;";
            SqlConnection sc = new SqlConnection(connectionString);
            string sql = "INSERT INTO Polz(Name_Polz, Fam_Polz, Otch_polz, E_mail_Polz, Data_Rosh_Polz, Log_Polz, Pass_Polz, Status_Polz_ID)VALUES" +
            "(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "',2) ;";
            try
            {
                MessageBox.Show("Ваш логин и пароль: " + textBox6.Text, textBox7.Text);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cp = new SqlCommand(sql, conn);
                    cp.ExecuteNonQuery();
                    Form1 f1 = new Form1();
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
