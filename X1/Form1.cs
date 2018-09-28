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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace X1
{
    public partial class Form1 : Form
    {
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "x1_ShopDataSet1.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter1.Fill(this.x1_ShopDataSet1.Tovar);
            string connectionString = "Data Source = DESKTOP-0PU11SR\\SQLEXPRESS; Initial Catalog = X1_Shop; Integrated Security=true;";
            SqlConnection sc = new SqlConnection(connectionString);
            sc.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dobav_Tov bt = new Dobav_Tov();
            bt.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form_Doc fd = new Form_Doc();
            fd.Show();
        }

    }
}
