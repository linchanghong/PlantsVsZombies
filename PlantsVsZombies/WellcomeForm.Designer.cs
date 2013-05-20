namespace PlantsVsZombies
{
    partial class WellcomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WellcomeForm));
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.timer_title = new System.Windows.Forms.Timer(this.components);
            this.labStart = new System.Windows.Forms.Label();
            this.timer1_grassCircle = new System.Windows.Forms.Timer(this.components);
            this.timer2_grassCircle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(128, -120);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(554, 119);
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // timer_title
            // 
            this.timer_title.Interval = 10;
            this.timer_title.Tick += new System.EventHandler(this.timer_title_Tick);
            // 
            // labStart
            // 
            this.labStart.BackColor = System.Drawing.Color.Transparent;
            this.labStart.Location = new System.Drawing.Point(363, 545);
            this.labStart.Name = "labStart";
            this.labStart.Size = new System.Drawing.Size(73, 22);
            this.labStart.TabIndex = 1;
            this.labStart.Click += new System.EventHandler(this.labStart_Click);
            this.labStart.MouseEnter += new System.EventHandler(this.labStart_MouseEnter);
            this.labStart.MouseLeave += new System.EventHandler(this.labStart_MouseLeave);
            // 
            // timer1_grassCircle
            // 
            this.timer1_grassCircle.Tick += new System.EventHandler(this.timer1_grassCircle_Tick);
            // 
            // WellcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labStart);
            this.Controls.Add(this.picTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WellcomeForm";
            this.Text = "WellcomeForm";
            this.Load += new System.EventHandler(this.WellcomeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WellcomeForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Timer timer_title;
        private System.Windows.Forms.Label labStart;
        private System.Windows.Forms.Timer timer1_grassCircle;
        private System.Windows.Forms.Timer timer2_grassCircle;

    }
}