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

namespace LibraryReport
{
    public partial class AddBook : Form
    {
        SqlConnection conn = null;
        SqlCommand com = null;
        public AddBook()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; 
                                      Initial Catalog = Library;
                                      Integrated Security = True;";
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet5.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter1.Fill(this.libraryDataSet5.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Books". При необходимости она может быть перемещена или удалена.


        }

        private bool checkbook()
        {
            int j = 0;
            for(int i=0;i<dataGridView1.RowCount-1;i++)
            {
                string s= dataGridView1[1, i].Value.ToString();
                string s1 = dataGridView1[2, i].Value.ToString();
                if (textBox1.Text == s &&
            textBox2.Text == s1)
                {
                    return false;

                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkbook())
                {
                    MessageBox.Show("Такая книга есть, Кол-во прибавилось");
                    this.booksTableAdapter1.UpdateQuery(Convert.ToInt32(textBox7.Text), textBox1.Text, textBox2.Text);
                    this.booksTableAdapter1.Fill(this.libraryDataSet5.Books);

                }
                else
                { 
                this.booksTableAdapter1.Insert(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), 123,  Convert.ToInt32(textBox7.Text), textBox6.Text);
                MessageBox.Show("Книга добавлена!");
                this.booksTableAdapter1.Fill(this.libraryDataSet5.Books);
                }
            }
             catch
            {
                MessageBox.Show("Lобавление не удалось!");
                this.booksTableAdapter1.Fill(this.libraryDataSet5.Books);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                this.booksTableAdapter1.Update(this.libraryDataSet5.Books);
                MessageBox.Show("Изменение успешно произошло!");
                this.booksTableAdapter1.Fill(this.libraryDataSet5.Books);

            }
            catch
            {
                MessageBox.Show("Изменение не удалось!");
                this.booksTableAdapter.Fill(this.libraryDataSet.Books);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter1.FillBy(this.libraryDataSet5.Books,textBox5.Text);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }
    }
}
