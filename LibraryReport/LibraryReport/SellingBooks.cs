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
    public partial class SellingBooks : Form
    {
        SqlConnection conn = null;
        SqlCommand com = null;
        public SellingBooks()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                     Initial Catalog=Library; 
                                     Integrated Security = True;";
        }

        private void SellingBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet2.SellingBook". При необходимости она может быть перемещена или удалена.
            this.sellingBookTableAdapter.Fill(this.libraryDataSet2.SellingBook);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet1.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet1.Books);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                this.booksTableAdapter.FillBy(this.libraryDataSet1.Books, textBox1.Text);
            }
            else if(textBox2.Text!="")
            {
                this.booksTableAdapter.FillBy1(this.libraryDataSet1.Books, textBox2.Text);
            }
            else if(textBox1.Text != "" && textBox2.Text != "")
            {
                this.booksTableAdapter.FillBy2(this.libraryDataSet1.Books,textBox1.Text,textBox2.Text);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet2.SellingBook". При необходимости она может быть перемещена или удалена.
            this.sellingBookTableAdapter.Fill(this.libraryDataSet2.SellingBook);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet1.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet1.Books);
        }

        private bool checkbook()
        {
            int j = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string s = dataGridView2[4, i].Value.ToString();
                if (textBox4.Text == s )
                {
                    return false;

                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkbook())
            {
                this.sellingBookTableAdapter.UpdateQuery(Convert.ToString(dateTimePicker1.Value.Date), Convert.ToInt32(textBox4.Text));
                this.booksTableAdapter.UpdateQuery1(Convert.ToInt32(textBox4.Text));
            }
            else
            {
                this.sellingBookTableAdapter.Insert(Convert.ToDouble(textBox3.Text), Convert.ToString(dateTimePicker1.Value.Date), Convert.ToInt32(textBox4.Text));
                this.sellingBookTableAdapter.UpdateQuery(Convert.ToString(dateTimePicker1.Value.Date), Convert.ToInt32(textBox4.Text));
                this.booksTableAdapter.UpdateQuery1(Convert.ToInt32(textBox4.Text));
            }
            this.sellingBookTableAdapter.Fill(this.libraryDataSet2.SellingBook);
            this.booksTableAdapter.Fill(this.libraryDataSet1.Books);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value) * 1.25);
        }
        
    }
}
