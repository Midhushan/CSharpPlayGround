   M S B A M L   `   `   `  ����M  IDropDownSampleMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DropDownSampleMenuDropDownSampleMenu  5   	   #    DropDownSampleMenu.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DropDownSampleMenu     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Drop Down Menu��5	   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowState$ 	Maximized=�6^   .��5
      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��358* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   .��5      � .+�5      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6*   $��Right=�6S   $��10q�6o   6~   5      5      � 5   
   $��Stretch=�6   $��1��6.      PrimaryHueMidBrush#��[  6;    5      �� 5      $	��70* �6    �� 5      $
��326* �6    .+�5       � 
�������$��0��6+   .+�5!      �� $��0��6   $��Assets/logo.png��6%   5"      �� 5#      $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   $��1��6�   .��5$      �� -   5         ��Name$
 Menu��5$      $��10q�6+   5%      5&      �� 5'   
   -   5        $ StackPanelMain��5'      $��1��6.   $�� 1��6;   $��Stretch=�6L   5(      5)      