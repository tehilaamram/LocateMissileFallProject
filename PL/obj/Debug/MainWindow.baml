   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	       PL.MainWindow   5   	   [ WXceed.Wpf.AvalonDock, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h dXceed.Wpf.AvalonDock.Themes.Metro, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4g cXceed.Wpf.AvalonDock.Themes.Aero, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4=xcad,http://schemas.xceed.com/wpf/xaml/avalondock     R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   X	 TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit 	 5   	   -   5          �Name$  MainWindow1��5   A    � Title$ Missile Fall Prediction��5	   	    � WindowState$ 	Maximized=�6*   $	��600��6B   $	��900��6O   .��5      �� ���#e7e6df$��15(�6&   $��	Yu Gothic)�66   $��0,20,0,0q�6M   .@�5   
   �� $��Add Report or real fall��6   $
��Bold"�63   ���#003053.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6   .+�5      �� $��
Add reoprt��6   $��0,20,0,0q�62   $��18(�6D   $
��Bold"�6R   ���#003053���#e7e6df$	��414��6�      PL.NewReportUC  5      -   5          Name$ NewReportElement��5   (   $��
10,5,10,10q�6B   �� 5      $��Add Fall��6   $��0,10,0,0q�60   $��18(�6B   $
��Bold"�6P   ���#003053���#e7e6df6w      PL.NewFallUC  5      $��
10,5,10,10q�6&   ��6:   ��  �� ElementName$ NewReportElement�� �� Path$ Width�5      � 5      .+�5         PL.GoogleMapsUC  -   5          Name$ MainMap��5   )   $
��1000��6:   A� 5      -   5        $
��Left=�5      $��40��6:   $��9,9,0,0q�6F   $	��Top=�6W   $��40��6o   ��5      �� 5       �� ImageSource$ images/images.png��6)   5      5      �� 5      $	��100��6   5!      5#      �� 5$   
   -   5        $��
Statistics��5$      $
��Bold"�6&   ���#003053.��5%      �� $ Vertical=�6   .+�5&      �� $ 
Horizontal=�6   .+�5'         PL.StatisticsUC  -   5        	  Name$	 StatisticsElement��5'   )   $	��151��6D   $
��Left=�6Q   $��50,30,50,20q�6l      
PL.ChartUC  5(      -   5        
  Name$
 PieChartElement��5(   2   $	��220��6%   $	��301��6K   $��Right=�6W   $��50,30q�6s   5*         
PL.GraphUC  5+      -   5          Name$ GraphElement��5+       5,      5-      �� 5.   
   -	   5        $��Falls information��5.      $
��Bold"�6-   ���#003053.��5/      �� $ 
Horizontal=�6   .+�50         PL.FallsImagesUC  -
   5          Name$ fallImageElement��50   &   $	��250��6@   �� 51      $ Vertical=�6     52      -   5        $ secondMapElement��52   %   $��0,0,0,-0.333q�6?   $
��1075��6U   53      54      55      57      