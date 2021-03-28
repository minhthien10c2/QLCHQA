using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KIEU
{
    public partial class Report_GUI : Form
    {
        public Report_GUI()
        {
            InitializeComponent();
        }

        private void Report_GUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCHQADataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.QLCHQADataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
