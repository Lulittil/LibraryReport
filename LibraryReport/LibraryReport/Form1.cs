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
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand com = null;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Base\Library.mdf;
                                      Initial Catalog = Library;
                                      Integrated Security = True;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.ShowDialog();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void продажаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellingBooks sb = new SellingBooks();
            sb.ShowDialog();
        }

        private void fAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Программа для учета книг\n\n\nРазработчик: Лобачева Ю.В.");
        }

        private void книгиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowBooks sb = new ShowBooks();
            sb.ShowDialog();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sellings sel = new Sellings();
            sel.ShowDialog();
        }

        private void валоваяПрибыльToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VP vp = new VP();
            vp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Base\Library.mdf;
                                      Initial Catalog = Library;
                                      Integrated Security = True;";
                con.Open();
                con.Close();
            
        }
    }
}
