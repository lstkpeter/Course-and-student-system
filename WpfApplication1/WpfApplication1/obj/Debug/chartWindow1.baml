   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	   Y UWPFVisifire.Charts, Version=4.5.2.1, Culture=neutral, PublicKeyToken=0cd785983078370bM9clr-namespace:Visifire.Charts;assembly=WPFVisifire.ChartsVisifire.Charts 5   	   "    WpfApplication1.chartWindow1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   LCharts9clr-namespace:Visifire.Charts;assembly=WPFVisifire.Charts     5   	     � Title$  成绩分布��5	   	   $	��360��6   $	��500��6#   .��5
      � ��5   
   �� 5       �� ImageSource$ 1BingWallpapers (11).jpg��6    � RowDefinitions 5   
   �� 5      $
��280* �6   �� 5      $	��50* �6   .+�5   
     Visifire.Charts.Chart  -   5          Name$ chart��5         LightingEnabled .  J� Opacity$	 0.9Q�6T   ��6=   Z�    
Background 5      �� 5       �� Color$ White��6"    �� Opacity$	 0.9Q�60   	   AxesY	 5        Visifire.Charts.Axis  
   Suffix$
 %��6      Interval$ 10X�6)      AxisMinimum$ 0��67      AxisMaximum$	 100��6G      Series 5         Visifire.Charts.DataSeries     BubbleStyle$ Style1X�6$      
DataPoints 5        Visifire.Charts.DataPoint     
AxisXLabel$ 	不及格��6+     5      $ 60-69��6+     5       $ 70-79��6+     5!      $ 80-89��6+     5"      $ 90-99��6+     5#      $ 满分��6+   5%      5'      �� 5(   
   -   5         ��Name$ 	textBlock��5(      $��1��6'   $
��Wrap=�64   $
��10,0q�6H   $��16(�6V   $
��Bold"�6d   
�������6v   5)      5*      