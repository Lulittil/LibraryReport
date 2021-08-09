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
    public partial class VP : Form
    {
        public VP()
        {
            InitializeComponent();
        }

        private void VP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet6.SellingBook". При необходимости она может быть перемещена или удалена.

            this.sellingBookTableAdapter.Fill(this.libraryDataSet6.SellingBook);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.sellingBookTableAdapter.FillBy(this.libraryDataSet6.SellingBook, Convert.ToString(dateTimePicker1.Value.Date), Convert.ToString(dateTimePicker2.Value.Date));
            
        }
    }
}
