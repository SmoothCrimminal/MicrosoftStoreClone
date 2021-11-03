﻿using MiscUtil;
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

namespace MicrosoftStoreClone.UserContols
{
    /// <summary>
    /// Logika interakcji dla klasy AnApp.xaml
    /// </summary>
    public partial class AnApp : UserControl
    {
        public string AppName;
        public ImageSource AppImageSource;
        public AnApp()
        {
            InitializeComponent();
            List<string> filePaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images", "*.png").ToList();
            FileInfo myRandomFile = new FileInfo(filePaths[StaticRandom.Next(filePaths.Count)]);
            ProductImage.Source = new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));

            AppNameText.Text = new CultureInfo("en-Us", false).TextInfo.ToTitleCase(myRandomFile.FullName.Split('\\').Last()
                .Split('-').Last().Split('.').First());

            AppName = AppNameText.Text.ToString();
            AppImageSource = ProductImage.Source;
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
