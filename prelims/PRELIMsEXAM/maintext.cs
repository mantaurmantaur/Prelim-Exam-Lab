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
    public partial class maintext : Form
    {
        public maintext()
        {
            InitializeComponent();
        }

        private void maintext_Load(object sender, EventArgs e)
        {

        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Clear();
        }

        private void oPENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Text Documents(*.txt)|*txt.|All Files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
                maintbx.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            this.Text = open.FileName;
        }

        private void sAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save";
            save.Filter = "Text Documents(*.txt)";

            if (save.ShowDialog() == DialogResult.OK)
                maintbx.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            this.Text = save.FileName;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uNDOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            maintbx.Undo();
        }

        private void rEDOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            maintbx.Redo();
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            maintbx.Cut();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            maintbx.Copy();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            maintbx.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.SelectAll();
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                maintbx.Font = font.Font;

            }
        }

        private void colorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog font = new ColorDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                maintbx.ForeColor = font.Color;

            }
        }

        private void hOMEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            homePage home_Page = new homePage();
            home_Page.Show();
            this.Hide();
        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
            string date;

            date = datepicker.Text;

            maintbx.Text = date;
        }
    }
}
