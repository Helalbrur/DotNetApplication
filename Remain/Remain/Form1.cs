using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                remain.Text = (Double.Parse(total.Text) - Double.Parse(paid.Text)).ToString();
            }
            catch (Exception exe)
            {
                remain.Text = "";
            }
            
        }
    }
}
