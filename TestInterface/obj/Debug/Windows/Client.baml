   M S B A M L   `   `   `  ����H  DTestInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TestInterface.WindowsTestInterface.Windows  5   	   "    TestInterface.Windows.Client   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TestInterface.Windows     5   	     � Title$a  [Список клиентов (Салон красоты 'Бархатные бровки')��5   	   $	��500��5	   	   $	��800��6    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Media/beauty_logo.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��1.2* �6   6,   �� 5      $��3* �6   6*   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��3��6$   $��0��68   ���	#FFE1E1FF5      �� 5   
   $��0��6   $��3��6%   $��0��69   $��Center=�5      $��Right=�60   $��0,0,15,0q�5       $��Tahoma)�5!      $��20(�6)   Список клиентов6H   �� 5"   
   $��Media/beauty_logo.png��6   $��0��5#      $��0��6!   $��10,10,130,10q�5$      6(   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ ClientTableDtGrd��5'         AutoGenerateColumns .     CanUserAddRows .     CanUserSortColumns .  $��0��5*      $��3��6#   $��1��67   	   Columns	 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1* 6%      Header$ Фамилия��5-      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5.      �� *	FirstName+65     5/      $

 0.8* 6%   $ Имя��50       51      �� *
LastName+64     52      $

 0.8* 6%   $ Отчество��53       54      �� *
Patronymic+66     55      $

 1.1* 6%   $ Дата рождения��56       57      �� *
Birthday+64     58      $

 0.4* 6%   $ Пол��59       5:      �� *Gender.Name+67     5;      $! Номер телефона��5<       5=      �� *Phone+61     5>      $
 1* 6%   $ E-mail��5?       5@      �� *Email+61     5A      $

 1.1* 6%   $% Дата регистрации��5B       5C      �� *RegistrationDate+6<   5E      �� 5H   
   -   5         ��Name$ AddClientBtn��5H      $��0��5I      $��2��6!   ���	#FFE1E1FF$
��10,5q�5J   (   $��Tahoma)�5K      $��12(�6%   .��5L   ,   Добавить66   �� 5M   
   -   5        $ ChangeClientBtn��5M      $��1��5N      $��2��6!   ���	#FFE1E1FF$
��10,5q�5O   (   $��Tahoma)�5P      $��12(�6%   .��5Q   /   Изменить69   �� 5R   
   -   5        $ RemoveClientBtn��5R      $��2��5S      $��2��6!   ���	#FFE1E1FF$
��10,5q�5T   (   $��Tahoma)�5U      $��12(�6%   .��5V   /   Удалить68   �� 5W   
   -   5        $ BackBtn��5W      $��2��5X      $��3��6!   ���	#FFFF4A6D$
��10,5q�5Y   (   $��Tahoma)�5Z      $��12(�6%   
�������.��5[   '   В меню6/   5\      5]      