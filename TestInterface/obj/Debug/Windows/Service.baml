   M S B A M L   `   `   `  ����H  DTestInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TestInterface.WindowsTestInterface.Windows  5   	   #    TestInterface.Windows.Service   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TestInterface.Windows     5   	     � Title$[  UСписок услуг (Салон красоты 'Бархатные бровки')��5   	   $	��500��5	   	   $	��800��6    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Media/beauty_logo.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��1.2* �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��2��6$   $��0��68   ���	#FFE1E1FF5      �� 5   
   $��0��6   $��2��6%   $��0��69   $��Center=�5       $��Right=�60   $��0,0,15,0q�5!      $��Tahoma)�5"      $��20(�6)   Список услуг6E   �� 5#   
   $��Media/beauty_logo.png��6   $��0��5$      $��0��6!   $��10,10,300,10q�5%      6(   �� 5'   
   -   5         ��Name$ ListServiceView��5'      $��1��6,   $��3��69   $��2��6J   ��5(      �� 5)      .R�5*      �� $��5q�6   $	��744��5+      $��1q�5,       �� CornerRadius$ 4��61   ���	#FFFF4A6D��5-   5   �� *	ColorFill+._�5.      ��  �� Orientation$ 
Horizontal=�6%   $
��auto��6>   .+�5/      �� $	��150��50   $   ��5/   $   �� *MainImagePath+50   2   �� 51      $ Vertical=�6)   .+�52   "   �� $��Tahoma)�53   (   $��12(�6<   $��5q�54   (   ��52   ,   �� *Title+54   5   �� 55   "   $��Tahoma)�56   (   $��12(�6<   $��5q�57   (   ��55   ,   �� *
CostSale+57   5   �� 58   "   $��Tahoma)�59   (   $��12(�6<   $��5q�5:   (   ��58   ,   �� *SizeOfDiscount+5:   5   �� 5;   "   $ 
Horizontal=�6-   .+�5<   &   ��  ��Name$ ChanceService��6-   -   5        $
��10,5q�5=   )   .��5>   E   Редактировать6T   �� 5?   &   $ RemoveService��6-   -   5        $
��10,5q�5@   )   .��5A   E   Удалить6N   5B   #   5C      5D      5E      5F      5N      �� 5P   
   -   5        $ AddServiceBtn��5P      $��0��5Q      $��5��6!   ���	#FFE1E1FF$
��10,5q�5R   (   $��Tahoma)�5S      $��12(�6%   .��5T   -   Добавить67   �� 5U   
   -   5        $ NextListBtn��5U      $��1��5V      $��4��6!   
�������$
��10,5q�5W   $   $��Tahome)�5X      $��15(�6%   .��5Y   +   Следующая66   �� 5Z   
   -   5        $ BackListBtn��5Z      $��0��5[      $��4��6!   
�������$
��10,5q�5\   $   $��Tahome)�5]      $��15(�6%   .��5^   +   Предыдущая67   �� 5_   
   -   5        $ BackBtn��5_      $��1��5`      $��5��6!   ���	#FFFF4A6D$
��10,5q�5a   (   $��Tahoma)�5b      $��12(�6%   
�������.��5c   '   В меню6/   5e      5f      