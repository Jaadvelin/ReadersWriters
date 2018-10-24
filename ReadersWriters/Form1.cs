using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ReadersWriters;

namespace ReadersWriters
{
    

    public partial class Form1 : Form
    {

        public string SetLabelText

        {

            get { return this.wrtrlbl.Text; }

            set { this.wrtrlbl.Text = value; }

        }


        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdrtrck1_Scroll(object sender, EventArgs e)
        {
            Program.rdr1 = rdrtrck1.Value;
        }

        private void rdrtrck2_Scroll(object sender, EventArgs e)
        {
            Program.rdr2 = rdrtrck2.Value;
        }

        private void rdrtrck3_Scroll(object sender, EventArgs e)
        {
            Program.rdr3 = rdrtrck3.Value;
        }

        private void wrtrtrck_Scroll(object sender, EventArgs e)
        {
            Program.wrtr = wrtrtrck.Value;
        }

        private void rdrlbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
