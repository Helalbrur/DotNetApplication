using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime birth = date.Value;
            DateTime today = DateTime.Now;
            TimeSpan total = today - birth;
            Double totalDays = total.TotalDays;
            int year, month, day;
            if (totalDays >= 365)
            {
                year = (int)totalDays / 365;
                totalDays = totalDays - 365 * year;
                if (totalDays >= 30)
                {
                    month =(int) totalDays / 30;
                    totalDays = totalDays - month * 30;
                    day = (int)totalDays;
                }
                else
                {
                    month = 0;
                    day = (int)totalDays;

                }
            }
            else
            {
                year = 0;
                if (totalDays >= 30)
                {
                    month = (int)totalDays / 30;
                    totalDays = totalDays - month * 30;
                    day = (int)totalDays;
                }
                else
                {
                    month = 0;
                    day = (int)totalDays;

                }
            }
            MessageBox.Show("You age is  " + year + " year " + month + " month " + day + " days");
            
            

        }
    }
}
