   M S B A M L   `   `   `  ����N  JMicrosoftStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:MicrosoftStoreClone.PagesMicrosoftStoreClone.Pages  5      Q-clr-namespace:MicrosoftStoreClone.UserContolsMicrosoftStoreClone.UserContols  5      $    MicrosoftStoreClone.Pages.Main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:MicrosoftStoreClone.Pages     5      <uc-clr-namespace:MicrosoftStoreClone.UserContols     5        N� Title$
  Main��5
      .��5      � -   5        $��MainWindowMainGrid��5       � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��35 �6   �� 5      $
��0.6* �6   �� 5      $
��0.4* �6   �� 5      $��35 �6   .+�5   
   �� -   5         ��Name$ MainTabControl��5      $y�Visible=�5      $��0��5      $��1��6   $��2��5      $��2��6   }�. .@�5      �� -   5        $��HomeTab��5   $   $
��Home��6   .��5      �� -   5         ��Name$ MainScrollViewer��5      $��10q�5       $��Hidden=�5!      $��Hidden=�5"       J� Opacity$ .5Q�5$       � Triggers 5%      :� 5&       :� RoutedEvent$ Loaded��6'   .[�5'      �� .��5(   "   �� .��5)   &   W�  W� From$ 0X�5*   )   		 W� To$	 1X�5+   )   
 g� Duration$
 0:0:03D�5,   )    �� TargetProperty$ Opacity�5-   )   5.   #   5/      50      .��52      �� -   5        $��MainHomeStackPane��53      $	��Top=�54      $
��Left=�55      $y�Visible=�56      ��57      ��  �� ElementName$ MainScrollViewer�� �� Path$ ActualWidth�.+�59      -   'MicrosoftStoreClone.UserContols.TopApps  -   5          Name$ TopApps��59   %   $
��Left=�5:   %   $��2q�5<   %   ��5;   %   �� $ MainTabControl��$ ActualWidth�5<   %   �� 5=      $
��Left=�5>      $��10q�5?      $��Featured apps��5@      $��40(�5A      0   *MicrosoftStoreClone.UserContols.AppsViewer  5B      -   5          Name$ FeaturesAppsViewer��5B   (   $
��Left=�5D   (   $��2q�5E   (   ��5C   (   �� $ MainScrollViewer��$ ActualWidth�5E   (   �� 5G      $
��Left=�5H      $��10q�5I      $��Most Popular��5J      $��40(�5K        5L      -   5        $ PopularAppsViewer��5L   (   $
��Left=�5N   (   $��2q�5O   (   ��5M   (   �� $ MainScrollViewer��$ ActualWidth�5O   (   �� 5Q      $
��Left=�5R      $��10q�5S      $��
Top 3 Apps��5T      $��40(�5U        5V      -	   5        $ Top3AppsViewer��5V   (   $
��Left=�5X   (   $��2q�5Y   (   ��5W   (   �� $ MainScrollViewer��$ ActualWidth�5Y   (   �� 5[      $
��Left=�5\      $��10q�5]      $��Top 3 Games��5^      $��40(�5_        5`      -
   5        $ Top3GamesViewer��5`   (   $
��Left=�5b   (   $��2q�5c   (   ��5a   (   �� $ MainScrollViewer��$ ActualWidth�5c   (   5d      5e      5f      �� 5g      -   5        $��	GamingTab��5g   &   $��Gaming��6   .��5h      �� -   5         ��Name$ GamingStackPanel��5h      .+�5i      �� $
��Left=�5j      $��10q�5k      $��Top free games��5l      $��40(�5m        5n      -   5        $ GamingAppsViewer��5n   $   $
��Left=�5p   (   $��2q�5q   (   ��5o   (   �� $ GamingStackPanel��$ ActualWidth�5q   (   5r      5s      �� 5t      -   5        $��EntertainmentTab��5t   -   $��Entertainment��6   .��5u      �� -   5        $ EntertainmentStackPanel��5u      .+�5v      �� $
��Left=�5w      $��10q�5x      $��Top free apps��5y      $��40(�5z        5{      -   5        $ EntertainmentAppsViewer��5{   $   $
��Left=�5}   (   $��2q�5~   (   ��5|   (   �� $ GamingStackPanel��$ ActualWidth�5~   (   5      5�      �� 5�      -   5        $��ProductivityTab��5�   ,   $��Productivity��6   .��5�      �� -   5        $ ProductivityScrollViewer��5�      $��10q�5�      $��Hidden=�5�      $��Hidden=�5�      .��5�      �� .+�5�      6   0MicrosoftStoreClone.UserContols.ProductivityApps  -   5          Name$ ProductivityAppsViewer��5�   .   $
��Left=�5�   (   $��2q�5�   (   ��5�   (   �� $ ProductivityScrollViewer��$ ActualWidth�5�   (   �� 5�      $
��Left=�5�      $��App specials��5�      $��10q�5�      $��40(�5�        5�      -   5        $ SpecialAppsViewer��5�   (   $
��Left=�5�   (   $��2q�5�   (   ��5�   (   �� $ ProductivityScrollViewer��$ ActualWidth�5�   (   5�      5�      5�      �� 5�      -   5        $��DealsTab��5�   %   $��Deals��6   .��5�      �� -   5        $ DealsStackPanel��5�      .+�5�      �� $
��Left=�5�      $��10q�5�      $��	Top Deals��5�      $��40(�5�        5�      -   5        $ DealsAppsViewer��5�   $   $
��Left=�5�   (   $��2q�5�   (   ��5�   (   �� $ DealsStackPanel��$ ActualWidth�5�   (   5�      5�      5�      8   2MicrosoftStoreClone.UserContols.HeaderRightButtons  5�   
   -   5          Name$ RightHeaderButtons��5�      $��0��5�      $��2��5�      5�      5�      