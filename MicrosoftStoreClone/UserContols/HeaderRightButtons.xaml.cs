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

namespace MicrosoftStoreClone.UserContols
{
    /// <summary>
    /// Logika interakcji dla klasy HeaderRightButtons.xaml
    /// </summary>
    public partial class HeaderRightButtons : UserControl
    {
        public delegate void OnDownloadButtonClick(object sender, RoutedEventArgs e);
        public event OnDownloadButtonClick HeaderRightDownloadClick;
        public HeaderRightButtons()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            SearchTextBox.Visibility = Visibility.Visible;
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightDownloadClick(sender, e);
        }

        private void DownloadsAndUpdates_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightDownloadClick(sender, e);
        }

        private void MouseDown_OutsideOfHeaderRightButtons(object sender, MouseButtonEventArgs e)
        {
            if (!SearchTextBox.IsMouseOver)
            {
                SearchButton.Visibility = Visibility.Visible;
                SearchTextBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
