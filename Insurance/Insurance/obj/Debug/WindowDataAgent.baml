   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Insurance	Insurance  5   	       Insurance.WindowDataAgent   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Insurance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Agent��5   	   $	��479��6   $	��800��6$    � Icon$ лого.jpg��60    � 	Resources 5	      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        '�� L     �� 5
   
   "  6   .�5      ��  � ��$ Center=�6;   5      �� 5   
   " ��6   .�5      ��  � ��$ 	20px 10pxq�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��250px �6   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��70px �6   �� 5      $
��112* �6   �� 5      $
��70px �6   .+�5   
   � $��3��6    5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      .+�5'      �� -   5        	 ��Name$	 imageBox��5'      $��0��6&   $��лого.jpg��63   �� 5(      -   5        
 ��Name$
 	positions��5(      $��Должности��6(   $��1��6<   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   {�.  6�   �� 5)      -   5        $
 	employees��5)      $��Сотрудники��6(   $��2��6=   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   {�.  6�   �� 5*      -   5        $
 clients��5*      $��Клиенты��6&   $��3��69   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5+      -   5        $
 users��5+      $��Пользователи��6$   $��4��6;   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   {�.  6�   �� 5,      -   5        $
 Insur��5,      $��Страховки��6$   $��5��68   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $��2��6�   �� 5-      -   5        $
 AddCl��5-      $+��%Добавление клиентов��6$   $
��40px��6C   $��6��6Q   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $��2��6�   5.      � 5/   
   $��1��6   $��2��6    50      �� 51      �� 52      �� 53      .+�55      �� -   5         ��Name$ 	mainLabel��55      $)��#Страховая компания��6'   $��25(�6D   $
��Bold"�6R   $��3��6d   $��Center=�6x   $��10q�6�   56      &   System.Windows.Controls.DataGrid  57   
   -	   5          Name$ 	mainGrid1��57      $��1��6&   $��1��64   $��2��6D      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$
 Left=�59         
IsReadOnly . 
���������62   �� *items+ �� ElementName$ dataWindow1��6{   �� 5;   
   -
   5        $
 	Insur_cal��5;      $-��'Добавление страховок��6$   $��0 8 0 0q�6C   $
��40px��6T   $��2��6b   $��1��6o   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5<   
   -   5        $

 exit��5<      $
��40px��6   $��
Выход��6-   $��2��6=   $��	10 8 10 0q�6J   $��2��6]   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5=      5>      