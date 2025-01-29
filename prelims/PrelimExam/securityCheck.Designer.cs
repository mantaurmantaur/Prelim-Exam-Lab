namespace PrelimExam
{
    partial class securityCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(securityCheck));
            panel1 = new Panel();
            label1 = new Label();
            passtbx = new TextBox();
            startbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passtbx);
            panel1.Location = new Point(268, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 238);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 77);
            label1.Name = "label1";
            label1.Size = new Size(282, 34);
            label1.TabIndex = 2;
            label1.Text = "ENTER PASSWORD\r\n";
            label1.Click += label1_Click;
            // 
            // passtbx
            // 
            passtbx.Location = new Point(122, 153);
            passtbx.Name = "passtbx";
            passtbx.Size = new Size(217, 27);
            passtbx.TabIndex = 1;
            // 
            // startbtn
            // 
            startbtn.BackColor = Color.Maroon;
            startbtn.FlatStyle = FlatStyle.Flat;
            startbtn.ForeColor = SystemColors.ButtonHighlight;
            startbtn.Location = new Point(360, 519);
            startbtn.Name = "startbtn";
            startbtn.Size = new Size(263, 43);
            startbtn.TabIndex = 2;
            startbtn.Text = "START";
            startbtn.UseVisualStyleBackColor = false;
            startbtn.Click += startbtn_Click;
            // 
            // securityCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(986, 621);
            Controls.Add(startbtn);
            Controls.Add(panel1);
            Name = "securityCheck";
            Text = "securityCheck";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox passtbx;
        private Button startbtn;
    }
}