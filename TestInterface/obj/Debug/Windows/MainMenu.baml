   M S B A M L   `   `   `  ����H  DTestInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TestInterface.WindowsTestInterface.Windows  5   	   $    TestInterface.Windows.MainMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TestInterface.Windows     5   	     � Title$A  ;Салон красоты 'Бархатные бровки'��5   	   $	��400��5	   	   $	��380��6    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Media/beauty_logo.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��1.2* �6   6,   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��2��6$   $��0��68   ���	#FFE1E1FF5      �� 5   
   $��0��6   $��2��6%   $��0��69   $��Center=�5       $��Right=�60   $��0,0,15,0q�5!      $��Tahoma)�5"      $��20(�6)   !Бархатные бровки6I   �� 5#   
   $��Media/beauty_logo.png��6   $��0��5$      $��2��6    $��0��64   $
��Left=�5%      $��10,10q�6+   6<   �� 5(   
   -   5         ��Name$ ServiceClientBtn��5(      $��0��5)      $��2��6!   $��1��65   ���	#FFE1E1FF$��20,15q�5*   (   $��Tahoma)�5+      $��12(�6%   .��5,   0   Журнал записи6?   �� 5-   
   -   5        $ 	ClientBtn��5-      $��0��5.      $��2��6!   $��2��65   ���	#FFE1E1FF$��20,15q�5/   (   $��Tahoma)�50      $��12(�6%   .��51   )   Список клиентов6:   �� 52   
   -   5        $ 
ServiceBtn��52      $��0��53      $��2��6!   $��3��65   ���	#FFE1E1FF$��20,15q�54   (   $��Tahoma)�55      $��12(�6%   .��56   *   Список услуг68   �� 58   
   -   5        $ 	LogOutBtn��58      $��0��59      $��5��6!   ���	#FFFF4A6D$��20,15q�5:   (   $��Tahoma)�5;      $��12(�6%   
�������.��5<   )   )'Сменить пользователя6?   �� 5=   
   -   5        $ ExitBtn��5=      $��1��5>      $��5��6!   ���	#FFFF4A6D$��20,15q�5?   (   $��Tahoma)�5@      $��12(�6%   
�������.��5A   '   
Выход6.   5B      5C      