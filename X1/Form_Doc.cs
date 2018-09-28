using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace X1
{
    public partial class Form_Doc : Form
    {
        public Form_Doc()
        {
            InitializeComponent();
        }

        private void Form_Doc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "x1_ShopDataSet1.Polz". При необходимости она может быть перемещена или удалена.
            this.polzTableAdapter.Fill(this.x1_ShopDataSet1.Polz);

        }

        public void Vizov()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Vizov();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 20, 20, 42, 35);
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Name: " + textBox1.Text));
            doc.Add(new Paragraph("Last name: " + textBox2.Text));
            doc.Add(new Paragraph("Patronymic: " + textBox3.Text));
            doc.Add(new Paragraph("E-mail: " + textBox4.Text));
            doc.Add(new Paragraph("Date of birth: " + textBox5.Text));
            doc.Close();

            if (!(File.Exists(@"Test.pdf")))
            {
                MessageBox.Show("Файла нет");
            }
            else
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.yandex.ru", 587);
                    client.Credentials = new NetworkCredential("inozemtsev.ilia@yandex.ru", "15975366");
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    MailMessage mes = new MailMessage();
                    Attachment sndfl = new Attachment("Test.pdf");
                    mes.From = new MailAddress("inozemtsev.ilia@yandex.ru");
                    mes.To.Add(new MailAddress(textBox4.Text));
                    mes.Subject = ("Test-PDF");
                    mes.Body = ("Look this PDF");
                    mes.Attachments.Add(sndfl);
                    mes.IsBodyHtml = false;
                    mes.Priority = MailPriority.High;
                    client.Send(mes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}
