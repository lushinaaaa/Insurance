   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Insurance	Insurance  5   	       Insurance.ClientWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Insurance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$3 -Редактирование клиентов��5   	   $	��450��6)   $	��800��66    � Icon$' !/Insurance;component/лого.jpg��6B   .��5	      � -   5         �Name$
 main��5	       � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��238* �6   �� 5      $
��333* �6   �� 5      $
��221* �6   .+�5   
   �� -   5         ��Name$ return��5      $��
Назад��6!   $��90��6F   $��30��6Q   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5   
   -   5         ��Name$ 	mainLabel��5      $��Клиенты��6#   $��25(�65   $
��Bold"�6C   $��Center=�6U   $��1��6s   $	��138��6�   $��50��6�   �� 5   
   -   5         ��Name$ fNameBox��5      
	 � Tag$	 fname��6G   $��0��6S   $��2��6`   ���	#FF141415$��41,22,40,22q�6�   � 5   
   -   5        $ mainGrid��5   0   $��1��6   $��3��6    5      �� 5      �� 5      $
��0.2* �6     5      �� 5      �� 5      �� 5      .+�5!      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 injuredGrid��5!      $��3��6,      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   AutoGenerateColumns .     CanUserAddRows .  $��30q�5"   *      CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$
 Left=�5#         
IsReadOnly . 
�������   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
FIO_client+  5&      $ Дата рождения��6)    6@   �� *
date_birth+  5'      $ Паспорт��6)    6:   �� *
passport+  5(      $9 3Водительское удостоверение��6)    6M   �� *driving_licence+  5)      $ ПТС��6)    66   �� *PTS+5+      �� 5,      -   5        $	 add��5,      $��Добавить��6"   $��1��65   $��0��6B   $	��120��6R   $��30��6^   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5-      -   5        $
 edit��5-      $��Изменить��6#   $��1��66   $��1��6C   $	��120��6S   $��30��6_   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5.      -	   5        $ remove��5.      $��Удалить��6%   $��1��67   $��2��6D   $	��120��6T   $��30��6`   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5/      53      54      