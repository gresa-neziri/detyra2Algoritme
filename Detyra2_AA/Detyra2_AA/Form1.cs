using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detyra2_AA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKalkulo_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int k = int.Parse(txtK.Text);

            txtRez.Text = DivFree.dfcount(n,k).ToString();

            DivFree.counter = 0;
        }
    }
}
