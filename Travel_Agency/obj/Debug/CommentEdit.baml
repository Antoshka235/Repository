   M S B A M L   `   `   `  ����H  DTravel Agency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Travel_AgencyTravel_Agency  5          Travel_Agency.CommentEdit   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Travel_Agency     5        N� Title$  CommentEdit��5	      .��5      � ���#1ba1a5 � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $	��140 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $0��*Оставить отзыв о отеле:��6   $��25(�63   $��2��6A   6S   �� 5   
   $��Отель:��6   $��1��6"   $��1��62   6A   �� 5   
   $$��Ваш комментарий:��6   $��1��6,   $��2��6<   6K   �� 5   
   $ ��Дата создания:��6   $��1��6*   $��3��6:   6I   �� 5   
   -   5         ��Name$ 
ComboHotel��5   *    �� DisplayMemberPath$ Название��6>   $��2��5      $��1��6#   $��30��60   $	��580��6<   $
��Left=�6H    �� Text 5      �� *
Отель+5   e   �� 5!   
   $
��Left=�6)   $��2��5"      $��2��6"   $��30��6/   $	��580��6;   ��5!      �� *
Текст+5"   I   (  "System.Windows.Controls.DatePicker  5$   
   $��2��6<   $
��Left=�6L   $��3��5%      $��30��6   $	��580��6+      SelectedDate 5$      �� *Дата_создания+5%   9   �� 5'   
   -   5        $��BtnSave9��5'   %   $��Сохранить��6   $��Center=�5(      $��Center=�6.   $��4��6I   $��2��6V   5)      5*      