#pragma checksum "..\..\..\UserContols\HeaderRightButtons.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E3748B47ABF53A2A22625C69CBC5482CECE677EC12B952A417748640D21CF088"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MicrosoftStoreClone.UserContols;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MicrosoftStoreClone.UserContols {
    
    
    /// <summary>
    /// HeaderRightButtons
    /// </summary>
    public partial class HeaderRightButtons : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MicrosoftStoreClone.UserContols.HeaderRightButtons HeaderRightButtonsUC;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SerachMenuItemHeader;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu SignInMenu;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SignInButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu DotDotMenu;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\UserContols\HeaderRightButtons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DotDot;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MicrosoftStoreClone;component/usercontols/headerrightbuttons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserContols\HeaderRightButtons.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.HeaderRightButtonsUC = ((MicrosoftStoreClone.UserContols.HeaderRightButtons)(target));
            return;
            case 2:
            this.SerachMenuItemHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UserContols\HeaderRightButtons.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\UserContols\HeaderRightButtons.xaml"
            this.SearchTextBox.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDown_OutsideOfHeaderRightButtons);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SignInMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 6:
            this.SignInButton = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.DownloadButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\UserContols\HeaderRightButtons.xaml"
            this.DownloadButton.Click += new System.Windows.RoutedEventHandler(this.DownloadButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DotDotMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 9:
            this.DotDot = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 10:
            
            #line 59 "..\..\..\UserContols\HeaderRightButtons.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.DownloadsAndUpdates_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

