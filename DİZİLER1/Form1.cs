using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DİZİLER1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] days = new string[7];
            days[0] = "MONDAY";
            days[1] = "TUESDAY";
            days[2] = "WEDNESDAY";
            days[3] = "THURSDAY";
            days[4] = "FRİDAY";
            days[5] = "SATURDAY";
            days[6] = "SUNDAY";
            label1.Text = days[4];
        }
    }
}
