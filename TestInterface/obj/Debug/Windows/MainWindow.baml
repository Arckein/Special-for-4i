   M S B A M L   `   `   `  ����H  DTestInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TestInterfaceTestInterface  5   	   &     TestInterface.Windows.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TestInterface     5   	     � Title$A  ;Салон красоты 'Бархатные бровки'��5   	   $	��300��5	   	   $	��400��6    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Media/beauty_logo.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   6,   �� 5      $
��1.2* �6   6,   �� 5      $
��1.2* �6   6,   �� 5      $
��1.0* �6   6,    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��2��6$   $��0��68   ���	#FFE1E1FF5      �� 5   
   $��0��6   $��2��6%   $��0��69   $��Center=�5      $��Center=�60   $��Tahoma)�5       $��20(�6)   Авторизация6D   �� 5!   
   $��Media/beauty_logo.png��6   $��0��5"      $��0��6    $
��Left=�5#      $
��10,5q�6+   6;   �� 5&   
    �� Orientation$ Vertical=�6   $��1��6,   $��0��69   $��2��6I   $��Center=�5'      .+�5(      �� $��5q�6   $��Введите логин��5)      $��Tahoma)�5*      $��14(�6&   $��Center=�5+      $��Center=�6-   5,      �� 5-      -   5         ��Name$ LoginTxt��5-      $��25��5.      $
��50,0q�5/      $��Tahoma)�50      $��18(�6&   $��Center=�51      $��Center=�64   6Z   52      �� 53   
   $ Vertical=�6   $��2��6,   $��0��69   $��2��6I   $��Center=�54      .+�55      �� $��5q�6   $��Введите логин��56      $��Tahoma)�57      $��14(�6&   $��Center=�58      $��Center=�6-   59      G� 5:      -   5         G�Name$ PasswordTxt��5:      $��25��5;      $
��50,0q�5<      $��Tahoma)�5=      $��18(�6&   $��Center=�5>      $��Center=�64   6Z   5?      �� 5B   
   -   5         ��Name$ AutorizationBtn��5B      $��0��5C      $��3��6!   $��20,10q�6.   ���	#FFFF4A6D$��Tahoma)�5D   (   $��20(�6<   
�������.��5E   1   
Войти68   �� 5F   
   -   5        $ ExitBtn��5F      $��1��5G      $��3��6!   $��20,10q�6.   ���	#FFFF4A6D$��Tahoma)�5H   (   $��20(�6<   
�������.��5I   (   
Выход6/   5K      5L      