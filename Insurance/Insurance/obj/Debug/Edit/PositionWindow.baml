   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Insurance	Insurance  5   	       Insurance.PositionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Insurance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$7 1Редактирование должностей��5   	   $	��450��6+   $	��800��68    � Icon$' !/Insurance;component/лого.jpg��6D   .��5	      � -   5         �Name$
 main��5	       � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      .+�5   
   �� -   5         ��Name$ return��5      $��80��6!   $��30��6,   $��
Назад��68   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5   
   -   5         ��Name$ 	mainLabel��5      $��Должности��6#   $��25(�67   $
��Bold"�6E   $��3��6W   $��Center=�6k   $��10q�6�   � 5   
   -   5        $ mainGrid��5   0   $��1��6   $��2��6    5      �� 5      �� 5      $
��0.2* �6     5      �� 5      �� 5      �� 5      .+�5D      &   System.Windows.Controls.DataGrid  -   5          Name$ MainGrid��5D      $��3��6)   	   HorizontalGridLinesBrush
	 �����
   VerticalGridLinesBrush

 �����   AutoGenerateColumns .     CanUserAddRows .  $��30q�5E   *      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$
 Left=�5F         
IsReadOnly . 
�������   Columns 5G      0  *System.Windows.Controls.DataGridTextColumn  5H      ,  &System.Windows.Controls.DataGridColumn   Header$ Должность��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
position+  5I      $ 
Оклад��6)    68   �� *salary+5K      �� 5L      -   5        $	 add��5L      $��Добавить��6"   $��1��65   $��0��6B   $	��120��6R   $��30��6^   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5M      -   5        $
 edit��5M      $��Изменить��6#   $��1��66   $��1��6C   $	��120��6S   $��30��6_   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5N      -   5        $ remove��5N      $��Удалить��6%   $��1��67   $��2��6D   $	��120��6T   $��30��6`   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5O      5S      5T      