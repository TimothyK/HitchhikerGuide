namespace HitchhikerGuide.WinForms
{
    partial class PlanetBox
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
            this.tlpPlanet = new System.Windows.Forms.TableLayoutPanel();
            this.cboSkyColour = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSkyColour = new System.Windows.Forms.Label();
            this.chkHasAtmosphere = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpPlanet.SuspendLayout();
            this.SuspendLayout();
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
            this.tlpPlanet.Location = new System.Drawing.Point(0, 0);
            this.tlpPlanet.Name = "tlpPlanet";
            this.tlpPlanet.RowCount = 6;
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlanet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlanet.Size = new System.Drawing.Size(455, 486);
            this.tlpPlanet.TabIndex = 1;
            // 
            // cboSkyColour
            // 
            this.cboSkyColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSkyColour.FormattingEnabled = true;
            this.cboSkyColour.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Green",
            "Blue"});
            this.cboSkyColour.Location = new System.Drawing.Point(80, 52);
            this.cboSkyColour.Name = "cboSkyColour";
            this.cboSkyColour.Size = new System.Drawing.Size(372, 21);
            this.cboSkyColour.TabIndex = 4;
            this.cboSkyColour.Validating += new System.ComponentModel.CancelEventHandler(this.cboSkyColour_Validating);
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(80, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(372, 20);
            this.txtName.TabIndex = 1;
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
            this.txtNotes.Size = new System.Drawing.Size(449, 362);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.Validating += new System.ComponentModel.CancelEventHandler(this.txtNotes_Validating);
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
            this.chkHasAtmosphere.Validating += new System.ComponentModel.CancelEventHandler(this.chkHasAtmosphere_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(377, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PlanetBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPlanet);
            this.Name = "PlanetBox";
            this.Size = new System.Drawing.Size(455, 486);
            this.tlpPlanet.ResumeLayout(false);
            this.tlpPlanet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPlanet;
        private System.Windows.Forms.ComboBox cboSkyColour;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSkyColour;
        private System.Windows.Forms.CheckBox chkHasAtmosphere;
        private System.Windows.Forms.Button btnSave;
    }
}
