using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelimExam
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintext maintext = new maintext();
            maintext.Show();
            this.Hide();    
        }
    }
}
