   M S B A M L   `   `   `  ����H  DTravel Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Travel_AgencyTravel_Agency  5          Travel_Agency.HotelsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Travel_Agency     5        N� Title$  
HotelsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��70 �6    � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � 
����ح�$��2��6&   $��1��63   6E   �� 5   
   $��Отели!��6   $��1��6"   $��25(�62   6B   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DGridHotel��5      ���#1ba1a5   AutoGenerateColumns .  $��1��6X   $��1��6h      
IsReadOnly . $
��Bold"�6�      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Изображение��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6>   	   CellTemplate	 5      �� 5      .R�5      �� $��Center=�6$   $��UniformToFill=�6A   ��6Z   �� *Изображение+6{   5      5      0  *System.Windows.Controls.DataGridTextColumn  5!      $ Название��6%   $ * 6T   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *Название+6`     5"      $% Количество звезд��6%   $ * 6d   
 6?   �� *!Количество_звезд+6p     5#      $
 auto 6)   	 5$      �� 5%      .R�5&      �� $��BtnEdit7��6=   -   5        $ ��Редактировать��5&   %   6f   5'      5)      5+      �� 5-   
   -   5        $��BtnAdd7��5-   $   $��Добавить��6   $	��300��5.      $��45��6   $
��Left=�6)   $��Center=�6D   $��2��6_   $��1��6l   6~   �� 50   
   -   5        $��
BtnDelete7��50   #   $��Удалить��6   $	��300��51      $��45��6   $��Right=�6)   $��2��6E   $��Center=�6R   $��1��6m   6   52      53      