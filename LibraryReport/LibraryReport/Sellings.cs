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
    public partial class Sellings : Form
    {
        SqlConnection con = null;
        SqlCommand com = null;
        public Sellings()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"data source =(localdb)\mssqllocaldb;
                                     initial catalog=library; 
                                     integrated security = true;";
        }

        private void Sellings_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet4.SellingBook". При необходимости она может быть перемещена или удалена.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sellingBookTableAdapter.FillBy(this.libraryDataSet4.SellingBook,Convert.ToString(dateTimePicker1.Value.Date), Convert.ToString(dateTimePicker2.Value.Date));
        }
    }
}
