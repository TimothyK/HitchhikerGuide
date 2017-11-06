namespace HitchhikerGuide
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
            this.tlpNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.lstNavigation = new System.Windows.Forms.ListBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tlpPlanet = new System.Windows.Forms.TableLayoutPanel();
            this.cboSkyColour = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSkyColour = new System.Windows.Forms.Label();
            this.chkHasAtmosphere = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.tlpNavigation.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpPlanet.SuspendLayout();
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
            this.splMain.Panel1.Controls.Add(this.tlpNavigation);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.tlpPlanet);
            this.splMain.Size = new System.Drawing.Size(512, 407);
            this.splMain.SplitterDistance = 170;
            this.splMain.TabIndex = 0;
            // 
            // tlpNavigation
            // 
            this.tlpNavigation.AutoSize = true;
            this.tlpNavigation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNavigation.ColumnCount = 1;
            this.tlpNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.Controls.Add(this.lstNavigation, 0, 0);
            this.tlpNavigation.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavigation.Location = new System.Drawing.Point(0, 0);
            this.tlpNavigation.Name = "tlpNavigation";
            this.tlpNavigation.RowCount = 2;
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNavigation.Size = new System.Drawing.Size(170, 407);
            this.tlpNavigation.TabIndex = 0;
            // 
            // lstNavigation
            // 
            this.lstNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNavigation.FormattingEnabled = true;
            this.lstNavigation.Location = new System.Drawing.Point(3, 3);
            this.lstNavigation.Name = "lstNavigation";
            this.lstNavigation.Size = new System.Drawing.Size(164, 366);
            this.lstNavigation.TabIndex = 0;
            this.lstNavigation.SelectedIndexChanged += new System.EventHandler(this.lstNavigation_SelectedIndexChanged);
            // 
            // tlpButtons
            // 
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tlpButtons.Controls.Add(this.btnDelete, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 375);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpButtons.Size = new System.Drawing.Size(164, 29);
            this.tlpButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(85, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tlpPlanet
            // 
            this.tlpPlanet.ColumnCount = 2;
            this.tlpPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPlanet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlanet.Controls.Add(this.cboSkyColour, 1, 2);
            this.tlpPlanet.Controls.Add(this.txtName, 1, 0);
            this.tlpPlanet.Controls.Add(this.lblNotes, 0, 3);
            this.tlpPlanet.Controls.Add(this.txtNotes, 0, 4);
            this.tlpPlanet.Controls.Add(this.lblName, 0, 0);
            this.tlpPlanet.Controls.Add(this.lblSkyColour, 0, 2);
            this.tlpPlanet.Controls.Add(this.chkHasAtmosphere, 1, 1);
            this.tlpPlanet.Controls.Add(this.btnSave, 1, 5);
            this.tlpPlanet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlanet.Enabled = false;
            this.tlpPlanet.Location = new System.Drawing.Point(0, 0);
            this.tlpPlanet.Name = "tlpPlanet";
            this.tlpPlanet.RowCount = 6;
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.Size = new System.Drawing.Size(338, 407);
            this.tlpPlanet.TabIndex = 0;
            // 
            // cboSkyColour
            // 
            this.cboSkyColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSkyColour.FormattingEnabled = true;
            this.cboSkyColour.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.cboSkyColour.Location = new System.Drawing.Point(80, 52);
            this.cboSkyColour.Name = "cboSkyColour";
            this.cboSkyColour.Size = new System.Drawing.Size(255, 21);
            this.cboSkyColour.TabIndex = 4;
            this.cboSkyColour.SelectedIndexChanged += new System.EventHandler(this.cboSkyColour_SelectedIndexChanged);
            this.cboSkyColour.TextChanged += new System.EventHandler(this.cboSkyColour_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(80, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 76);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.tlpPlanet.SetColumnSpan(this.txtNotes, 2);
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 92);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(332, 283);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Planet Name:";
            // 
            // lblSkyColour
            // 
            this.lblSkyColour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSkyColour.AutoSize = true;
            this.lblSkyColour.Location = new System.Drawing.Point(3, 56);
            this.lblSkyColour.Name = "lblSkyColour";
            this.lblSkyColour.Size = new System.Drawing.Size(61, 13);
            this.lblSkyColour.TabIndex = 3;
            this.lblSkyColour.Text = "Sky Colour:";
            // 
            // chkHasAtmosphere
            // 
            this.chkHasAtmosphere.AutoSize = true;
            this.chkHasAtmosphere.Checked = true;
            this.chkHasAtmosphere.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHasAtmosphere.Location = new System.Drawing.Point(80, 29);
            this.chkHasAtmosphere.Name = "chkHasAtmosphere";
            this.chkHasAtmosphere.Size = new System.Drawing.Size(104, 17);
            this.chkHasAtmosphere.TabIndex = 2;
            this.chkHasAtmosphere.Text = "Has Atmosphere";
            this.chkHasAtmosphere.UseVisualStyleBackColor = true;
            this.chkHasAtmosphere.CheckedChanged += new System.EventHandler(this.chkHasAtmosphere_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(260, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel1.PerformLayout();
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.tlpNavigation.ResumeLayout(false);
            this.tlpNavigation.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpPlanet.ResumeLayout(false);
            this.tlpPlanet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.TableLayoutPanel tlpNavigation;
        private System.Windows.Forms.ListBox lstNavigation;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tlpPlanet;
        private System.Windows.Forms.CheckBox chkHasAtmosphere;
        private System.Windows.Forms.Label lblSkyColour;
        private System.Windows.Forms.ComboBox cboSkyColour;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

