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
    public partial class Auth : Form
    {
        Authoriz ath = new Authoriz();

        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-0PU11SR\\SQLEXPRESS; Initial Catalog = X1_Shop; Integrated Security=true;";
            SqlConnection sc = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                if (ath.Authz(textBox2.Text, textBox1.Text) == textBox2.Text + " " + textBox1.Text)
                {
                    MessageBox.Show("Вы успешно вошли!");
                    f1.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Ошибка авторизации. Проверьте логин или пароль");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr reg = new Registr();
            reg.Show();
        }
    }
}
