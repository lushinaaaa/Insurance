   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Insurance.EditInsurance.Edit  5   	       Insurance.Edit.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Insurance.Edit     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Пользователи��5   	   $	��450��6   $	��800��6+    � Icon$' !/Insurance;component/лого.jpg��67   .��5	      � -   5         �Name$
 main��5	       � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��114* �6   �� 5      $
��167* �6   �� 5      $
��115* �6   .+�5   
   �� -   5         ��Name$ return��5      $��
Назад��6!   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6v   $��14(�6�   $��80��6�   $��30��6�   �� 5   
   -   5         ��Name$ 	mainLabel��5      $��Пользователи��6#   $��25(�6:   $
��Bold"�6H   $��Center=�6Z   $��1��6x   $	��184��6�   $��74,10,76,10q�6�   �� 5   
   -   5         ��Name$
 Empl��5      $	��150��6!   $��30��6-   $��Center=�69   
	 � Tag$		 sex��6]   $��Center=�6g   $��2��6�   6�   � 5   
   -   5        $ mainGrid��5   0   $��1��6   $��3��6    5      �� 5      �� 5      $
��0.2* �6     5      �� 5      �� 5      �� 5      .+�5       &   System.Windows.Controls.DataGrid  -   5        
  Name$
 injuredGrid��5       $��3��6,      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   AutoGenerateColumns .     CanUserAddRows .  $��30q�5!   *      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$
 Left=�5"         
IsReadOnly . 
�������   Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *login+  5%      $ Пароль��6)    69   �� *
password+  5&      $ Роль��6)    67   �� *role+  5'      $ Сотрудник��6)    6<   �� *id_employees+5)      �� 5*      -   5        $	 add��5*      $��Добавить��6"   $��1��65   $��0��6B   $	��120��6R   $��30��6^   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5+      -   5        $
 edit��5+      $��Изменить��6#   $��1��66   $��1��6C   $	��120��6S   $��30��6_   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5,      -	   5        $ remove��5,      $��Удалить��6%   $��1��67   $��2��6D   $	��120��6T   $��30��6`   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5-      51      52      