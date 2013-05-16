namespace PlantsVsZombies
{
    partial class QuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labexit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(231, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 42);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labexit
            // 
            this.labexit.BackColor = System.Drawing.Color.Transparent;
            this.labexit.Image = ((System.Drawing.Image)(resources.GetObject("labexit.Image")));
            this.labexit.Location = new System.Drawing.Point(55, 226);
            this.labexit.Name = "labexit";
            this.labexit.Size = new System.Drawing.Size(160, 42);
            this.labexit.TabIndex = 1;
            this.labexit.Click += new System.EventHandler(this.labexit_Click);
            // 
            // QuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuitForm";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuitForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.QuitForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.QuitForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labexit;
    }
}