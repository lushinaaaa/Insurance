   M S B A M L   `   `   `  ����D  @Insurance, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Insurance	Insurance  5   	       Insurance.EmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Insurance     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$9 3Редактирование сотрудников��5   	   $	��450��6,   $	��800��69    � Icon$' !/Insurance;component/лого.jpg��6E   .��5	      � -   5         �Name$
 main��5	       � RowDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��33* �6   �� 5      $
��109* �6   �� 5      $	��56* �6   .+�5*   
   �� -   5         ��Name$ return��5*      $��
Назад��6!   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6v   $��14(�6�   $��26,20q�6�   �� 5+   
   -   5         ��Name$ 	mainLabel��5+      $��Сотрудники��6#   $��25(�68   $
��Bold"�6F   $��Center=�6X   $��194,10,86,10q�6u   $��1��6�   $	��156��6�   � 5,   
   -   5        $ mainGrid��5,   0   $��1��6   $��3��6    5-      �� 5.      �� 5/      $
��0.2* �6     51      �� 52      �� 53      �� 54      .+�56      �� -   5         ��Name$ MainData��56   (   $��5,5,0,5q�6   $��Stretch=�6:   	 �� SelectionMode$	 Single=�6�   $��3��6�   ��57      �� 58      .R�59      �� $	��1.5q�6D   
 �� Padding$
 7q�6Z   ��6!   �� *
ColorFrame+._�5:      �  5;   "   �� 5<   &   �� 5=   &   $
��80px �67   .+�5?   "   ��  �� Orientation$ 
Horizontal=�6-   $��0��6F   .+�5@   &   �� $	��100��6F   $	��100��6R   $��	10 0 50 0q�6`   ��6,   �� *Photo+6`   � 5A   &   $
��Left=�6+    5B   *   �� 5C   .   $
��1.3* �6<   �� 5D   .   �� 5E   .   �� 5F   .   .+�5H   *   � .+�5I   .   �� $
��Bold"�6V   ��68   �� *FIO_insurer+6V   5J   +   � 5K   *   $��1��64   .+�5L   .   �� ��68   �� *phone+5M   +   � 5N   *   $��2��64   .+�5O   .   �� ��68   �� *	address+5P   +   � 5Q   *   $��3��64   .+�5R   .   �� $ DeleteButton��65   -   5        $��Удалить��5R   K   $	��130��6]   $��25��6i   
 � Tag 6�   �� *id+5S   +   5T   '   5U   #   5V      5W      5X      5Z      �� 5[      -   5        $	 add��5[      $��Добавить��6"   $��1��65   $��1��6B   $	��120��6R   $��30��6^   ���	#FFD1E2F1���	#FFCBDCEA$��Imprint MT Shadow)�6�   $��14(�6�   5^      5_      5`      