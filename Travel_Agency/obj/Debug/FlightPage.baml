   M S B A M L   `   `   `  ����H  DTravel Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Travel_AgencyTravel_Agency  5          Travel_Agency.FlightPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Travel_Agency     5        N� Title$  
FlightPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��70 �6    � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � 
����ح�$��2��6&   $��1��63   6E   �� 5   
   $��Рейсы:��6   $��1��6"   $��25(�62   6B   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridFlight��5      ���#1ba1a5   AutoGenerateColumns .  $��1��6Y   $��1��6i      
IsReadOnly . $
��Bold"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$! Тип транспорта��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6`   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6=   �� *Тип_транспорта+6l     5      $' !Пункт отправления��6%   $ * 6f   	 6@   �� *#!Пункт_отправления+6r     5      $% Пункт назначения��6%   $ * 6d   	 6?   �� *!Пункт_назначения+6p   4  .System.Windows.Controls.DataGridTemplateColumn  5      $% Дата отправления��6)   $ * 6C   
   CellTemplate
 5      �� 5      .R�5       (  "System.Windows.Controls.DatePicker  {�.     SelectedDate 6)   �� *!Дата_отправления+6g   5!      5#        5%      $! Время в пути (ч)��6%   $ * 6h   	 6?   �� *&$Время_в_пути_в_часах+6t     5&      $# Количество мест��6%   $ * 6a   	 6>   �� *Количетво_мест+6m     5'      $ Цена��6%   $ * 6L   	 63   �� *
Цена+6X     5(      $
 auto 6)   
 5)      �� 5*      .R�5+      �� $��	BtnEdit10��6=   -   5        $ ��Редактировать��5+   %   6h   5,      5.      50      �� 52   
   -   5        $��BtnAdd10��52   $   $��Добавить��6   $	��300��6K   $��45��6W   $
��Left=�53      $��Center=�6,   $��2��6G   $��1��6T   6f   �� 55   
   -   5        $��BtnDelete10��55   #   $��Удалить��6   $	��300��6P   $��45��6\   $��Right=�56      $��2��6-   $��Center=�6:   $��1��6U   6g   57      58      