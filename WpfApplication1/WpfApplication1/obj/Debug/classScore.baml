   M S B A M L   `   `   `  ����Y  UWPFVisifire.Charts, Version=4.5.2.1, Culture=neutral, PublicKeyToken=0cd785983078370bM9clr-namespace:Visifire.Charts;assembly=WPFVisifire.ChartsVisifire.Charts  5   	   J FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1 5   	       WpfApplication1.classScore   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   LCharts9clr-namespace:Visifire.Charts;assembly=WPFVisifire.Charts     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  班级成绩��5	   	   $	��390��6   $	��500��6#   $	��500��6/   $	��500��6>   $	��390��6M   $	��390��6]    � WindowStartupLocation$ CenterOwner=�6m   .��5
      � ��5   
   �� 5       �� ImageSource$ 1BingWallpapers (11).jpg��6    � RowDefinitions 5   
   �� 5      $
��270* �6   �� 5      $	��50* �6   .+�5   
      Visifire.Charts.Chart  -   5          Name$ chart��5      $��1��6&    J� Opacity$	 0.9Q�66   ��6D   Z�    
Background 5      �� 5       �� Color$ White��6"      AxisIndicatorBackground 5      �� 5      $ 	LightGray��6"   	 �� Opacity$		 0.9Q�64   
   AxesY
 5         Visifire.Charts.Axis     Suffix$ %��6      Interval$ 10X�6)      AxisMinimum$ 0��67      AxisMaximum$	 100��6G      Series 5          Visifire.Charts.DataSeries     
DataPoints 5          Visifire.Charts.DataPoint     
AxisXLabel$ 	不及格��6+     5!      $ 60-69��6+     5"      $ 70-79��6+     5#      $ 80-89��6+     5$      $ 90-99��6+     5%      $ 满分��6+   5'      5)      �� 5*   
   -   5         ��Name$ 	textBlock��5*      $
��Left=�6'   $��23��6B   $��
140,23,0,0q�6N   $
��Wrap=�6b   $��	班级：��6v   $	��Top=�6�   $��50��6�   $��16(�6�   
�������$��1��6�   �� 5+   
   -   5         ��Name$ textBox1��5+      $
��Left=�6$   $��26��6?   $��
190,20,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $��70��6�   $��1��6�   $��1��6�   ��6�   Z� 6�   �� 5,   
   -   5        $ textBlock_Copy��5,      $
��Left=�6,   $��23��6G   $��	10,23,0,0q�6S   $
��Wrap=�6f   $��	年级：��6z   $	��Top=�6�   $��50��6�   $��16(�6�   
�������$��1��6�   �� 5-   
   -   5        $ textBox��5-      $
��Left=�6#   $��26��6>   $��	60,20,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $��70��6�   $��0��6�   $��1��6�   ��6�   Z� 6�   �� 5.   
   -   5         ��Name$ button��5.      $��查询��6!   $
��Left=�6.   $��	405,0,0,4q�6I   $��1��6\   $��77��6i   $��37��6�   $��Bottom=�6�   $��2��6�   $��16(�6�   ��6t   Z� ��5/      �� 50      $ White��6"   $		 0.9Q�60   52      �� 53   
   -   5        $ 
textBlock1��53      $
��Left=�6(   $��23��6C   $��
265,23,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��135��6�   
�������$��1��6�   55      56      