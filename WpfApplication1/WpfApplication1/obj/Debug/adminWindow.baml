   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	   !    WpfApplication1.adminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  列表��5      $	��550��6   $	��480��6    � WindowStartupLocation$ CenterOwner=�6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ snowflakesandfrost2.jpg��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $��	0,0,0,100q�6%      CanUserAddRows .     AutoGenerateColumns .     
IsReadOnly .    HorizontalGridLinesBrush 6k   Z�    VerticalGridLinesBrush 6�   Z� ��6�   Z� ��5      �� 5      	 �� Color$	 	#FFF7F7F7��6"   
 �� Opacity$

 0.25Q�64      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header 5      �� 5      -   5         ��Name$ cBox_All��5   1   $	��All��6#   6\      CellTemplate 5      �� 5      .R�5      ��  d� 	IsChecked 6'   ��  �� Path$ 	isChecked� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6~   5      5      5      �� 5   
   -   5         ��Name$ button��5      $��添加��6!   $��Right=�6.   $��45��6J   $��	0,0,80,10q�6V   $��Bottom=�6i   $��66��6�   ��6�   Z� 6�   �� 5   
   -   5        $ button_Delete��5      $��删除��6(   $��Right=�65   $��45��6Q   $��	0,0,10,10q�6]   $��Bottom=�6p   $��65��6�   ��6�   Z� 6�   �� 5    
   -   5        $ button_Copy��5       $��刷新��6&   $��
0,0,151,10q�63   $��Right=�6t   $��55��6�   $��45��6�   $��Bottom=�6�   ��6G   Z� 6�   �� 5!   
   -   5         ��Name$ 	textBlock��5!      $��45��6'   $��10,0,211,10q�63   $
��Wrap=�6H   $��Bottom=�6\   �� 5"   
   -   5        $ 
textBlock1��5"      $��Right=�6(   $��35��6D   $��
0,0,247,60q�6P   $
��Wrap=�6d   $��搜索��6x   $��Bottom=�6�   $	��185��6�   $��16(�6�    �� TextAlignment$ Right=�6�   �� 5#   
   -   5         ��Name$ textBox��5#      $��26��6#   $��	0,0,50,69q�6/    �� TextWrapping$
 Wrap=�6B   $��Bottom=�6V   $��Right=�6q   $	��192��6�   �� 5$   
   -	   5        $ button1��5$      $��搜索��6"   $��Right=�6/   $��26��6K   $��	0,0,10,69q�6W   $��Bottom=�6j   $��40��6�   ��6�   Z� 6�   5&      5'      