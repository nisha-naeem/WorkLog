namespace Demo
{
    partial class WorkLogUIView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkLogUIView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewIssue = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewIssue,
            this.toolStripButtonHistory,
            this.toolStripLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewIssue
            // 
            this.toolStripButtonNewIssue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewIssue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewIssue.Image")));
            this.toolStripButtonNewIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewIssue.Name = "toolStripButtonNewIssue";
            this.toolStripButtonNewIssue.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewIssue.Text = "New Issue";
            this.toolStripButtonNewIssue.Click += new System.EventHandler(this.ToolStripButtonNewIssue_Click);
            // 
            // toolStripButtonHistory
            // 
            this.toolStripButtonHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHistory.Image")));
            this.toolStripButtonHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHistory.Name = "toolStripButtonHistory";
            this.toolStripButtonHistory.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHistory.Text = "History";
            this.toolStripButtonHistory.Click += new System.EventHandler(this.ToolStripButtonHistory_Click);
            // 
            // toolStripLogout
            // 
            this.toolStripLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLogout.Image")));
            this.toolStripLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLogout.Name = "toolStripLogout";
            this.toolStripLogout.Size = new System.Drawing.Size(23, 22);
            this.toolStripLogout.Text = "toolStripButton1";
            this.toolStripLogout.Click += new System.EventHandler(this.toolStripLogout_Click);
            // 
            // WorkLogUIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "WorkLogUIView";
            this.Text = "Work Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewIssue;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistory;
        private System.Windows.Forms.ToolStripButton toolStripLogout;
    }
}

