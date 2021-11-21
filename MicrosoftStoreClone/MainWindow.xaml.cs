using MahApps.Metro.Controls;
using MicrosoftStoreClone.Pages;
using MicrosoftStoreClone.UserContols;
using MicrosoftStoreClone.UserContols.HamburgerMenuViews;
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

namespace MicrosoftStoreClone
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Main MainWindowContentPage;
        private TopAppsWrapped MyTopAppsWrappedPage;
        public MainWindow()
        {
            InitializeComponent();
            MainWindowContentPage = new Main();
            MyTopAppsWrappedPage = new TopAppsWrapped();
            MainWindowContentPage.TopAppButtonClicked += MainWindowContentPage_TopAppButtonClicked;
            MainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;
            MyTopAppsWrappedPage.AnAppClicked += MainWindowContentPage_AppClicked;
            MyTopAppsWrappedPage.BackButtonClicked += BackButtonClicked;
            MainWindowContentPage.DownloadButtonClicked += DownloadButtonClicked;
        }

        private void DownloadButtonClicked(object sender, RoutedEventArgs e)
        {
            var allOwnedApps = new AllOwnedApps();
            MainWindowFrame.Content = allOwnedApps;
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MainWindowContentPage;
        }

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppDetails appDetails = new AppDetails(sender);
            appDetails.BackButtonClicked += BackButtonClicked;
            appDetails.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowFrame.Content = appDetails;
        }

        private void MainWindowContentPage_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MyTopAppsWrappedPage;
        }

        private void BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

    }
}
