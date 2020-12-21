using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FoodAppWindow
{
    public partial class MySecondCustomControl : UserControl
    {
        public MySecondCustomControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Delay(4000);
            MessageBox.Show("Ale se poczekales", "FoodY");
        }
    }
}
