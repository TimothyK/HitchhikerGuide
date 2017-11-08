using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace HitchhikerGuide.WinForms
{
    public partial class PlanetNavigationBox : UserControl
    {
        private readonly PlanetList _planetList;

        public PlanetNavigationBox()
        {
            InitializeComponent();

            _planetList = new PlanetList();
            _planetList.CollectionChanged += PlanetListChanged;
            _planetList.SelectedPlanetChanged += SelectedPlanetChanged;

            BindPlanetList();
        }

        #region List Change

        public event EventHandler PlanetAdded;

        private void OnPlanetAdded() => PlanetAdded?.Invoke(this, EventArgs.Empty);

        private void PlanetListChanged(object sender, CollectionChangedEventArgs e)
        {
            BindPlanetList();
            if (e.Reason == CollectionChangeReason.ItemAdded)
                OnPlanetAdded();
        }

        private void BindPlanetList()
        {
            lstNavigation.Items.Clear();
            lstNavigation.Items.AddRange(_planetList.Cast<object>().ToArray());
            lstNavigation.SelectedItem = _planetList.SelectedItem;            
        }

        #endregion

        #region Selected Item

        public event EventHandler SelectedItemChanged;

        private void OnSelectedItemChanged() => SelectedItemChanged?.Invoke(this, EventArgs.Empty);

        public Planet SelectedItem => _planetList.SelectedItem;

        private void lstNavigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            _planetList.SelectedItem = (Planet) lstNavigation.SelectedItem;
        }

        private void SelectedPlanetChanged(object sender, SelectedPlanetChangedEventArgs e)
        {
            lstNavigation.SelectedItem = _planetList.SelectedItem;
            SubscribeToNameChange();
            OnSelectedItemChanged();
        }

        private Planet _current;
        private void SubscribeToNameChange()
        {
            if (_current != null)
                _current.NameChanged -= NameChanged;

            _current = _planetList.SelectedItem;

            _current.NameChanged += NameChanged;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            RedrawItems();
        }

        private void RedrawItems()
        {
            typeof(ListBox).InvokeMember("RefreshItems",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod,
                null, lstNavigation, new object[] { });
        }

        #endregion

        #region Buttons

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _planetList.Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _planetList.Delete();
        }

        #endregion
    }
}
