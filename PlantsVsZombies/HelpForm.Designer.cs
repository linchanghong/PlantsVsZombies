namespace PlantsVsZombies
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.lbHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHelp
            // 
            this.lbHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbHelp.Image = ((System.Drawing.Image)(resources.GetObject("lbHelp.Image")));
            this.lbHelp.Location = new System.Drawing.Point(327, 522);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(153, 40);
            this.lbHelp.TabIndex = 0;
            this.lbHelp.Click += new System.EventHandler(this.lbHelp_Click);
            this.lbHelp.MouseEnter += new System.EventHandler(this.lbHelp_MouseEnter);
            this.lbHelp.MouseLeave += new System.EventHandler(this.lbHelp_MouseLeave);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHelp;

    }
}