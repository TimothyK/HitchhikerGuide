using System;
using System.Windows.Forms;

namespace HitchhikerGuide.WinForms
{
    public partial class PlanetBox : UserControl
    {
        private Planet _value;

        public PlanetBox()
        {
            InitializeComponent();
        }

        public Planet Value
        {
            private get => _value;
            set
            {
                _value = value ?? new Planet(Program.Repository);

                txtName.Text = _value.Name;
                txtName.SelectAll();
                chkHasAtmosphere.Checked = _value.HasAtmosphere; 
                cboSkyColour.Text = _value.SkyColour;
                txtNotes.Text = _value.Notes;

                tlpPlanet.Enabled = value != null;
            }
        }


        public void FocusName()
        {
            txtName.Focus();
            txtName.SelectAll();
        }

        #region Validate

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e) => 
            Validate(e, () => Value.Name = txtName.Text);

        private void chkHasAtmosphere_Validating(object sender, System.ComponentModel.CancelEventArgs e) => 
            Validate(e, () => Value.HasAtmosphere = chkHasAtmosphere.Checked);

        private void cboSkyColour_Validating(object sender, System.ComponentModel.CancelEventArgs e) => 
            Validate(e, () => Value.SkyColour = cboSkyColour.Text);


        private void txtNotes_Validating(object sender, System.ComponentModel.CancelEventArgs e) => 
            Validate(e, () => Value.Notes = txtNotes.Text);

        private static void Validate(System.ComponentModel.CancelEventArgs e, Action assign)
        {
            try
            {
                assign();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        #endregion


        private void btnSave_Click(object sender, EventArgs e)
        {
            Value.Save();
        }
    }
}
