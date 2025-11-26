using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("quantità", "quantità");
            dataGridView1.Columns.Add("ddomanda", "domanda");
            dataGridView1.Columns.Add("offerta", "offerta");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
