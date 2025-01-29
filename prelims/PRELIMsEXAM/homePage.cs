using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRELIMsEXAM
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void starthmbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            maintext main = new maintext();
            main.Show();
            this.Hide();
        }
    }
}
