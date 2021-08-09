using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryReport
{
    public partial class ShowBooks : Form
    {
        public ShowBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet3.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.FillAll(this.libraryDataSet3.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                this.booksTableAdapter.Fill(this.libraryDataSet3.Books, textBox1.Text);
            }
            else if (textBox2.Text != "" && textBox1.Text == "")
            {
                this.booksTableAdapter.Fillzero(this.libraryDataSet3.Books, textBox2.Text);
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                this.booksTableAdapter.FillBy(this.libraryDataSet3.Books, textBox1.Text, textBox2.Text);
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.FillAll(this.libraryDataSet3.Books);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
