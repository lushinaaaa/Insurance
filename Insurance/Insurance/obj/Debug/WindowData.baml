   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Insurance	Insurance  5   	       Insurance.WindowData   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Insurance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ Admin��5   	   $	��479��6   $	��800��6$    � Icon$ лого.jpg��60    � 	Resources 5	      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        '�� L     �� 5
   
   "  6   .�5      ��  � ��$ Center=�6;   5      �� 5   
   " ��6   .�5      ��  � ��$ 	20px 10pxq�6'   5      6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��250px �6   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��70px �6   �� 5      $
��112* �6   �� 5      $
��70px �6   .+�5   
   � $��3��6    5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5&      �� -   5        	 ��Name$	 imageBox��5&      $��0��6&   $��лого.jpg��63   �� 5'      -   5        
 ��Name$
 	positions��5'      $��Должности��6(   $��1��6<   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5(      -   5        $
 	employees��5(      $��Сотрудники��6(   $��2��6=   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5)      -   5        $
 clients��5)      $��Клиенты��6&   $��3��69   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5*      -   5        $
 users��5*      $��Пользователи��6$   $��4��6;   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   �� 5+      -   5        $
 Insur��5+      $��Страховка��6$   $��5��68   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $��2��6�   �� 5,      -   5        $
 	Insur_cal��5,      $%��Расчет страховки��6(   $��6��6C   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $��2��6�   50      � 51   
   $��1��6   $��2��6    52      �� 53      �� 54      �� 55      .+�57      �� -   5         ��Name$ 	mainLabel��57      $)��#Страховая компания��6'   $��25(�6D   $
��Bold"�6R   $��3��6d   $��Center=�6x   $��10q�6�   5U      &   System.Windows.Controls.DataGrid  5V   
   -	   5          Name$ mainGrid��5V      $��1��6%   $��1��63   $��2��6C      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     CanUserResizeRows .     CanUserSortColumns .   �� TextAlignment$
 Left=�5X         
IsReadOnly . 
���������62   �� *items+ �� ElementName$ 
dataWindow��6z   �� 5[   
   -
   5        $

 edit��5[      $
��40px��6   $��0 8 0 0q�6-   $/��)Редактировать таблицы��6>   $��2��6^   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   $��1��6�   �� 5\   
   -   5        $

 exit��5\      $
��40px��6   $��	10 8 10 0q�6-   $��
Выход��6@   $��2��6P   $��2��6]   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5^      5_      