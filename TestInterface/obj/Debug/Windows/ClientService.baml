   M S B A M L   `   `   `  ����H  DTestInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TestInterface.WindowsTestInterface.Windows  5   	   )    #TestInterface.Windows.ClientService   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TestInterface.Windows     5   	     � Title$b  \Запись на услуги (Салон красоты 'Бархатные бровки')��5   	   $	��500��5	   	   $
��1100��6    � 
ResizeMode$ NoResize=�5
   	    � Icon$ Media/beauty_logo.ico��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��1.2* �6   6,   �� 5      $��3* �6   6*   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��3��6$   $��0��68   ���	#FFE1E1FF5      �� 5   
   $��0��6   $��3��6%   $��0��69   $��Center=�5      $��Right=�60   $��0,0,15,0q�5       $��Tahoma)�5!      $��20(�6)    Запись на услуги6I   �� 5"   
   $��Media/beauty_logo.png��6   $��0��5#      $��0��6!   $��10,10,130,10q�5$      6(   &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ ClientServiceTableDtGrd��5'         AutoGenerateColumns .     CanUserAddRows .  $��0��5)      $��3��6#   $��1��67      Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 1* 6%   
   Header$
 Фамилия��5,      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5-      �� *Client.FirstName+6=     5.      $
	 0.8* 6%   $
 Имя��5/       50      �� *Client.LastName+6;     51      $
	 0.8* 6%   $
 Отчество��52       53      �� *Client.Patronymic+6=     54      $
	 1.1* 6%   $
 Вид услуги��55       56      �� *Service.Title+69     57      $
	 0.4* 6%   $
 Дата��58       59      �� *Date+60     5:      $
 
Время��5;       5<      �� *Time+60     5=      $
	 0.4* 6%   $
 До услуги��5>       5?      �� *	Remaining+65   5A      �� 5D   
   -   5         ��Name$ AddClientServiceBtn��5D      $��0��5E      $��2��6!   ���	#FFE1E1FF$
��10,5q�5F   (   $��Tahoma)�5G      $��12(�6%   .��5H   3   Добавить6=   �� 5I   
   -   5        $ ChangeClientServiceBtn��5I      $��1��5J      $��2��6!   ���	#FFE1E1FF$
��10,5q�5K   (   $��Tahoma)�5L      $��12(�6%   .��5M   6   Изменить6@   �� 5N   
   -   5        $ RemoveClientServiceBtn��5N      $��2��5O      $��2��6!   ���	#FFE1E1FF$
��10,5q�5P   (   $��Tahoma)�5Q      $��12(�6%   .��5R   6   Удалить6?   �� 5S   
   -   5        $ BackBtn��5S      $��2��5T      $��3��6!   ���	#FFFF4A6D$
��10,5q�5U   (   $��Tahoma)�5V      $��12(�6%   
�������.��5W   '   В меню6/   5X      5Y      