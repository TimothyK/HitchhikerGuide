using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace HitchhikerGuide
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lstNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNavigation.SelectedItem == null)
            {
                tlpPlanet.Enabled = false;
                return;
            }

            var planet = (Planet) lstNavigation.SelectedItem;

            txtName.Text = planet.Name;
            chkHasAtmosphere.Checked = planet.HasAtmosphere;
            cboSkyColour.Text = planet.SkyColour;
            txtNotes.Text = planet.Notes;

            tlpPlanet.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var planet = new Planet {Name = "<New Planet>"};

            lstNavigation.Items.Add(planet);
            lstNavigation.SelectedItem = planet;

            if (txtName.Focused)
                RefreshNavigationList();
            txtName.Focus();
            txtName.SelectionStart = 0;
            txtName.SelectionLength = txtName.TextLength;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var isoStore = GetStore())
            {
                var fileName = txtName.Text + ".xml";
                if (isoStore.FileExists(fileName))
                    isoStore.DeleteFile(fileName);
            }

            var index = lstNavigation.SelectedIndex;
            lstNavigation.Items.Remove(lstNavigation.SelectedItem);
            lstNavigation.SelectedIndex = Math.Min(index, lstNavigation.Items.Count-1);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var planet = (Planet)lstNavigation.SelectedItem;
            planet.Name = txtName.Text;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            RefreshNavigationList();
        }

        private void RefreshNavigationList()
        {
            typeof(ListBox).InvokeMember("RefreshItems",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, lstNavigation, new object[] { });
        }

        private void chkHasAtmosphere_CheckedChanged(object sender, EventArgs e)
        {
            var planet = (Planet)lstNavigation.SelectedItem;
            planet.HasAtmosphere = chkHasAtmosphere.Checked;
        }

        private void cboSkyColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            var planet = (Planet)lstNavigation.SelectedItem;
            planet.SkyColour = cboSkyColour.Text;
        }

        private void cboSkyColour_TextChanged(object sender, EventArgs e)
        {
            var planet = (Planet)lstNavigation.SelectedItem;
            planet.SkyColour = cboSkyColour.Text;
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            var planet = (Planet)lstNavigation.SelectedItem;
            planet.Notes = txtNotes.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var planet = (Planet)lstNavigation.SelectedItem;
            using (var isoStore = GetStore())
            using (var fileStream = isoStore.CreateFile(planet.Name + ".xml"))
            using (var writer = new StreamWriter(fileStream))
                writer.WriteLine(planet.ToSerializedXml());
        }

        private void LoadAllFiles()
        {
            using (var isoStore = GetStore())
            {
                foreach (var fileName in isoStore.GetFileNames())
                {
                    ReadFile(fileName, isoStore);
                }
            }
            
        }

        private static IsolatedStorageFile GetStore()
        {
            return IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly | IsolatedStorageScope.Domain, null, null);
        }

        private void ReadFile(string fileName, IsolatedStorageFile isoStore)
        {
            try
            {
                using (var fileStream = new IsolatedStorageFileStream(fileName, FileMode.Open, isoStore))
                {
                    using (var reader = new StreamReader(fileStream))
                    {
                        var serializedData = reader.ReadToEnd();
                        var planet = serializedData.Deserialize<Planet>();
                        lstNavigation.Items.Add(planet);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't read file " + fileName + ".  " + ex.Message,"Couldn't Read File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAllFiles();
        }
    }
}
