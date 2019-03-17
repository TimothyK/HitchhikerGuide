namespace HitchhikerGuide.WinForms
{
    partial class PlanetNavigationBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetNavigationBox));
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.lstNavigation = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddPlanet = new System.Windows.Forms.ToolStripButton();
            this.tsmiDeletePlanet = new System.Windows.Forms.ToolStripButton();
            this.tlpNavigation.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.AutoSize = true;
            this.tlpNavigation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNavigation.ColumnCount = 1;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Controls.Add(this.lstNavigation, 0, 1);
            this.tlpNavigation.Controls.Add(this.toolStrip1, 0, 0);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavigation.Location = new System.Drawing.Point(0, 0);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 2;
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNavigation.Size = new System.Drawing.Size(335, 580);
            this.tlpNavigation.TabIndex = 1;
            // 
            // lstNavigation
            // 
            this.lstNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNavigation.FormattingEnabled = true;
            this.lstNavigation.Location = new System.Drawing.Point(3, 28);
            this.lstNavigation.Name = "lstNavigation";
            this.lstNavigation.Size = new System.Drawing.Size(329, 549);
            this.lstNavigation.Sorted = true;
            this.lstNavigation.TabIndex = 0;
            this.lstNavigation.SelectedIndexChanged += new System.EventHandler(this.lstNavigation_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRefresh,
            this.toolStripSeparator1,
            this.tsmiAddPlanet,
            this.tsmiDeletePlanet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(335, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsmiRefresh.Image")));
            this.tsmiRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsmiRefresh.Text = "Refresh";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmiAddPlanet
            // 
            this.tsmiAddPlanet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiAddPlanet.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddPlanet.Image")));
            this.tsmiAddPlanet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiAddPlanet.Name = "tsmiAddPlanet";
            this.tsmiAddPlanet.Size = new System.Drawing.Size(23, 22);
            this.tsmiAddPlanet.Text = "New Planet";
            this.tsmiAddPlanet.Click += new System.EventHandler(this.tsmiAddPlanet_Click);
            // 
            // tsmiDeletePlanet
            // 
            this.tsmiDeletePlanet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiDeletePlanet.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDeletePlanet.Image")));
            this.tsmiDeletePlanet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiDeletePlanet.Name = "tsmiDeletePlanet";
            this.tsmiDeletePlanet.Size = new System.Drawing.Size(23, 22);
            this.tsmiDeletePlanet.Text = "Delete Planet";
            this.tsmiDeletePlanet.Click += new System.EventHandler(this.tsmiDeletePlanet_Click);
            // 
            // PlanetNavigationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpNavigation);
            this.Name = "PlanetNavigationBox";
            this.Size = new System.Drawing.Size(335, 580);
            this.tlpNavigation.ResumeLayout(false);
            this.tlpNavigation.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.ListBox lstNavigation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsmiRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsmiAddPlanet;
        private System.Windows.Forms.ToolStripButton tsmiDeletePlanet;
    }
}
