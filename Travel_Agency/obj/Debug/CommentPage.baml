   M S B A M L   `   `   `  ����H  DTravel Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Travel_AgencyTravel_Agency  5          Travel_Agency.CommentPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Travel_Agency     5        N� Title$  CommentPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��70 �6    � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � 
����ح�$��2��6&   $��1��63   6E   �� 5   
   $��Коментарии!��6   $��1��6'   $��25(�67   6G   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridComment��5      ���#1ba1a5   AutoGenerateColumns .  $��1��6Z   $��1��6j      
IsReadOnly . $
��Bold"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Отель��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *
Отель+6Z     5      $# Ваш комментарий��6%   $ * 6X   	 6>   �� *
Текст+6d   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Дата создания��6)   $ * 6@   
   CellTemplate
 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker  {�.     SelectedDate 6)   �� *Дата_создания+6d   5       5"        5$      $
 auto 6)   
 5%      �� 5&      .R�5'      �� $��BtnEdit9��6=   -   5        $ ��Редактировать��5'   %   6f   5(      5*      5,      �� 5.   
   -   5        $��BtnAdd9��5.   $   $��Добавить��6   $	��300��5/      $��45��6   $
��Left=�6)   $��Center=�6D   $��2��6_   $��1��6l   6~   �� 51   
   -   5        $��
BtnDelete9��51   #   $��Удалить��6   $	��300��52      $��45��6   $��Right=�6)   $��2��6E   $��Center=�6R   $��1��6m   6   53      54      