using System;
using System.Windows.Forms;

namespace HitchhikerGuide.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            planetNavigationBox.SelectedItemChanged += SelectedPlanetChanged;
            planetNavigationBox.PlanetAdded += PlanetAdded;

            planetBox.Value = planetNavigationBox.SelectedItem;
        }

        private void PlanetAdded(object sender, EventArgs e)
        {
            planetBox.FocusName();
        }


        private void SelectedPlanetChanged(object sender, EventArgs e)
        {
            planetBox.Value = planetNavigationBox.SelectedItem;
        }
    }
}
