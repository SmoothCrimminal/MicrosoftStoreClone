using MicrosoftStoreClone.UserContols;
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

namespace MicrosoftStoreClone.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppClicked += Curr_AppClicked;

            ProductivityAppsViewer.AppClicked += Curr_AppClicked;
            TopApps.AppClicked += Curr_AppClicked;
            EntertainmentAppsViewer.AppClicked += Curr_AppClicked;
            GamingAppsViewer.AppClicked += Curr_AppClicked;
            FeaturesAppsViewer.AppClicked += Curr_AppClicked;
            PopularAppsViewer.AppClicked += Curr_AppClicked;
            Top3AppsViewer.AppClicked += Curr_AppClicked;
            Top3GamesViewer.AppClicked += Curr_AppClicked;
        }

        private void Curr_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
