using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
    /// Logika interakcji dla klasy HamburgerMenuApp.xaml
    /// </summary>
    public partial class HamburgerMenuApp : UserControl
    {
        public List<string> AppNames;
        public List<string> AppTypes;
        public string AppName;
        public DateTime Purchased;
        public string Type;

        public HamburgerMenuApp()
        {
            InitializeComponent();

            AppTypes = new List<string>()
            {
                "Apps",
                "Games",
                "Movies",
                "Avatars"
            };

            List<string> filePaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images\MiniIcons", "*.png").ToList();
            FileInfo myRandomFile = new FileInfo(filePaths[StaticRandom.Next(filePaths.Count)]);
            AppImage.Source = new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));

            AppNameLabel.Content = new CultureInfo("en-Us", false).TextInfo.ToTitleCase(AppImage.Source.ToString().Split('/').Last()
                .Split('.').First().Split('-').Last().Split('.').First());

            AppName = AppNameLabel.Content.ToString();
            Type = AppTypes[StaticRandom.Next(AppTypes.Count)];
            Purchased = new DateTime(2021, 2, StaticRandom.Next(1, DateTime.Now.Day + 1));
            PurchasedLabel.Content = "Purchased " + Purchased.ToString("d");
        }
    }
}
