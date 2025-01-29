namespace PRELIMsEXAM
{
    partial class security_Check
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(security_Check));
            passtbx = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // passtbx
            // 
            passtbx.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passtbx.Location = new Point(355, 371);
            passtbx.Name = "passtbx";
            passtbx.Size = new Size(283, 32);
            passtbx.TabIndex = 0;
            passtbx.KeyDown += enter;
            passtbx.Validated += enter_sulod;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 310);
            label1.Name = "label1";
            label1.Size = new Size(282, 34);
            label1.TabIndex = 1;
            label1.Text = "ENTER PASSWORD";
            label1.Click += label1_Click;
            // 
            // security_Check
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(986, 641);
            Controls.Add(label1);
            Controls.Add(passtbx);
            Name = "security_Check";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passtbx;
        private Label label1;
    }
}
