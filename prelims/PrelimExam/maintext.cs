namespace PrelimExam
{
    public partial class maintext : Form
    {
        public maintext()
        {
            InitializeComponent();
            securityCheck  secr = new securityCheck();
            secr.Show();
            home_page home_Page = new home_page();
            home_Page.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Clear();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Open";
            open.Filter = "Text Documents(*.txt)|*txt.|All Files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
                maintbx.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            this.Text = open.FileName;
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            open.Title = "Save";
            open.Filter = "Text Documents(*.txt)|*txt.|All Files(*.*)|*.*";

            if (open.ShowDialog() == DialogResult.OK)
                maintbx.SaveFile(open.FileName, RichTextBoxStreamType.PlainText);
            this.Text = open.FileName;
        }

        private void ecxitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.Paste();
        }

        private void seleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintbx.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                maintbx.Font = font.Font;

            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog font = new ColorDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                maintbx.ForeColor = font.Color;

            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home_page home_Page = new home_page();
            home_Page.Show();
            this.Hide();
        }
    }
}
