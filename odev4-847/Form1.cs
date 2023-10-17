using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev4_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                this.BackColor = Color.Black;
                rb1.ForeColor = Color.White;
                rb2.ForeColor = Color.White;
            }
                
            if(!rb1.Checked == true)
            {      
                this.BackColor = Color.White;
                rb1.ForeColor = Color.Black;
                rb2.ForeColor = Color.Black;
            }
        }
    }
}
