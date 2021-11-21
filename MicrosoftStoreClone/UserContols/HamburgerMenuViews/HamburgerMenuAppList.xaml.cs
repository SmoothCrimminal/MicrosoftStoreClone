using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MicrosoftStoreClone.UserContols.HamburgerMenuViews
{
    /// <summary>
    /// Logika interakcji dla klasy HamburgerMenuAppList.xaml
    /// </summary>
    public partial class HamburgerMenuAppList : UserControl
    {

        public List<HamburgerMenuApp> AllApps;
        public List<HamburgerMenuApp> AppsOnFilter;
        public HamburgerMenuAppList()
        {
            InitializeComponent();
            AllApps = new List<HamburgerMenuApp>();
            AppsOnFilter = new List<HamburgerMenuApp>();
            for (int i = 0; i < 15; i++)
                AddNewHamburgerApp();
        }

        private void AddNewHamburgerApp()
        {
            HamburgerMenuApp anApp = new HamburgerMenuApp();
            MainStackPanel.Children.Add(anApp);
            AllApps.Add(anApp);
        }

        public void FilterByType(string inFilter)
        {
            AppsOnFilter = AllApps.Where(p => p.Type == inFilter).ToList<HamburgerMenuApp>();
            AddToMainStackPanel(AppsOnFilter);
        }

        public void AddAll()
        {
            var AppsOnFilter = new List<HamburgerMenuApp>();
            AddToMainStackPanel(AllApps);
        }

        public void SortByName()
        {
            var AllAppsSorted = new List<HamburgerMenuApp>();
            if (AppsOnFilter.Count < 1)
            {
                AllAppsSorted = AllApps.OrderBy(p => p.AppName).ToList<HamburgerMenuApp>();
            }
            else
            {
                AllApps = AppsOnFilter.OrderBy(p => p.AppName).ToList<HamburgerMenuApp>();
            }

            AddToMainStackPanel(AllAppsSorted);
        }

        public void SortByDate()
        {
            var AllAppsSorted = new List<HamburgerMenuApp>();
            if (AppsOnFilter.Count < 1)
            {
                AllAppsSorted = AllApps.OrderByDescending(p => p.Purchased).ToList<HamburgerMenuApp>();
            }
            else
            {
                AllApps = AppsOnFilter.OrderByDescending(p => p.Purchased).ToList<HamburgerMenuApp>();
            }

            AddToMainStackPanel(AllAppsSorted);
        }

        private void AddToMainStackPanel(List<HamburgerMenuApp> inList)
        {
            MainStackPanel.Children.Clear();
            foreach (HamburgerMenuApp item in inList)
            {
                MainStackPanel.Children.Add(item);
            }
        }
    }
}
