   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Insurance.EditInsurance.Edit  5   	   '    !Insurance.Edit.InsuranceCalcAdmin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Insurance.Edit     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$+ %Стоимость страховки��5   	   $	��450��6%   $	��800��62    � Icon$' !/Insurance;component/лого.jpg��6>   .��5	      � -   5         �Name$
 main��5	       � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      .+�5   
   �� -   5         ��Name$ return��5      $��80��6!   $��30��6,   $��
Назад��68   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5   
   -   5         ��Name$ 	mainLabel��5      $G��AРасчет стоимости страхового полиса��6#   $��25(�6P   $
��Bold"�6^   $��3��6p   $��Center=�6�   $��10q�6�   � 5   
   -   5        $ mainGrid��5   0   $��1��6   $��2��6    5      �� 5      �� 5      $
��0.2* �6     5      �� 5      �� 5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ injuredGrid��5      $��3��6,   	   HorizontalGridLinesBrush
	 �����
   VerticalGridLinesBrush

 �����   AutoGenerateColumns .     CanUserAddRows .  $��30q�5    *      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$ Center=�5!         
IsReadOnly . 
�������   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$! Базовый ставка��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *tb+  5$      $; 5Территориальный коэффициент��6)    6N   �� *kt+  5%      $2 ,Коэффициент бонус-малус��6)    6J   �� *kbm+  5&      $e _Коэффициент, зависящий от возраста и стажа водителя��6)    6f   �� *kvs+  5'      $] WКоэффициент, зависящий от количества водителей��6)    6a   �� *ko+  5(      $r lКоэффициент, зависящий от мощности транспортного средства��6)    6l   �� *km+  5)      $W QКоэффициент, зависящий от срока страхования��6)    6^   �� *ks+  5*      $) #Итоговая стоимости��6)    6E   �� *total+5,      �� 5-      -   5        $ remove��5-      $��Удалить��6%   $��1��67   $��1��6D   $	��120��6T   $��30��6`   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5.      5/      50      