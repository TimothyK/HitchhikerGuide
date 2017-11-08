namespace HitchhikerGuide.WinForms
{
    partial class MainForm
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
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.planetNavigationBox = new HitchhikerGuide.WinForms.PlanetNavigationBox();
            this.planetBox = new HitchhikerGuide.WinForms.PlanetBox();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(0, 0);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.planetNavigationBox);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.planetBox);
            this.splMain.Size = new System.Drawing.Size(512, 407);
            this.splMain.SplitterDistance = 170;
            this.splMain.TabIndex = 0;
            // 
            // planetNavigationBox
            // 
            this.planetNavigationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planetNavigationBox.Location = new System.Drawing.Point(0, 0);
            this.planetNavigationBox.Name = "planetNavigationBox";
            this.planetNavigationBox.Size = new System.Drawing.Size(170, 407);
            this.planetNavigationBox.TabIndex = 0;
            // 
            // planetBox
            // 
            this.planetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planetBox.Location = new System.Drawing.Point(0, 0);
            this.planetBox.Name = "planetBox";
            this.planetBox.Size = new System.Drawing.Size(338, 407);
            this.planetBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 407);
            this.Controls.Add(this.splMain);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Hitchhiker\'s Guide";            
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splMain;
        private PlanetNavigationBox planetNavigationBox;
        private PlanetBox planetBox;
    }
}

