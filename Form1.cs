using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace LK07
{
    public partial class LK07 : Form
    {
        public LK07()
        {
            InitializeComponent();
        }

        private void LK07_Load(object sender, EventArgs e)
        {
            DateTime Start = DateTime.Now;
            DateTime EndDay = new DateTime(2021, 12, 31);
            TimeSpan Time = Start - EndDay;
            String x = Time.ToString();
           x= x.Substring(0, 3);
            label3.Text =x ;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
            this.label2.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }
    }
}
