   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Insurance	Insurance  5   	       Insurance.WindowInsurance   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Insurance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Страховка��5   	   $	��450��6   $	��800��6(    � Icon$' !/Insurance;component/лого.jpg��64   .��5	      � -   5         �Name$
 main��5	       � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $	��43* �6   �� 5      $
��334* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ Close��5      $��
Назад��6    $��70��60   $��25��6;   $��0��6[   $��0��6h   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $
��Left=�6�   $��30 0 0 0q�6�   �� 5   
   -   5        $	 All��5      $��Страховка��6   $��75��62   $��25��6=   $��1��6[   $��0��6h   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $
��Left=�6�   $��	150 0 0 0q�6�   �� 5   
   -   5        $ Check��5      $��Чек на оплату��6    $	��100��68   $��25��6D   $��1��6d   $��0��6q   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $
��Left=�6�   $��30 0 0 0q�6�   �� 5   
   -   5         ��Name$ 	mainLabel��5      $#��Страховой полис��6#   $��25(�6=   $
��Bold"�6K   $��Center=�6]   $��1��6z   $	��220��6�   �� 5   
   -   5         ��Name$
 Empl��5      $	��170��6!   $��25��6-   $��Center=�69   
	 � Tag$		 sex��6]   $��Center=�6g   $��1��6�   $��1��6�   $��85 0 0 0q�6�   �� 5   
   -   5        
 ��Name$
 fNameBox��5      $	��160��6$   $��25��60   $	 fname��6_   $��1��6k   $��2��6x   ���	#FF141415$��40 0 0 0q�6�   � 5   
   -   5        $ mainGrid��5   0   $��1��6   $��4��6   $��2��6B    5      �� 5      $
��106* �6    �� 5      $	��21* �6     5      �� 5       $	��26* �6#   �� 5!      $	��31* �6#   �� 5"      $	��31* �6#   .+�5%      &   System.Windows.Controls.DataGrid  -	   5          Name$ injuredGrid��5%      $��3��6,      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   AutoGenerateColumns .     CanUserAddRows .  $��30,48,30,30q�5&   *      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$
 Left=�5'         
IsReadOnly . 
�������   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Страховка��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	insurence+  5*      $ Дата начала��6)    6>   �� *
start_date+  5+      $! Дата истечения��6)    6A   �� *
end_date+  5,      $ Клиент��6)    69   �� *	id_client+  5-      $ Владелец авто��6)    6@   �� *	car_owner+  5.      $ Модель��6)    69   �� *	car_model+  5/      $3 -Идентификационный номер��6)    6J   �� *identification_number+  50      $- 'Регистрационный знак��6)    6G   �� *registration_number+  51      $+ %Стоимость страховки��6)    6F   �� *id_calculation+  52      $ Сотрудник��6)    6<   �� *id_employee+54      �� 55      -
   5        $	 add��55      $��Добавить��6"   $��1��65   $	��150��6B   $��30��6N   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 56      -   5        $
 edit��56      $��Изменить��6#   $��1��66   $��1��6C   $	��150��6S   $��30��6_   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 57      -   5        $ remove��57      $��Удалить��6%   $��1��67   $��2��6D   $	��150��6T   $��30��6`   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   58      5>      5?      