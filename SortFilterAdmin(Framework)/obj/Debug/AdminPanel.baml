   M S B A M L   `   `   `  ����U  QSortFilterAdmin(Framework), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SortFilterAdmin_Framework_SortFilterAdmin_Framework_  5   	   +    %SortFilterAdmin_Framework_.AdminPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:SortFilterAdmin_Framework_     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
AdminPanel��5	   	   $	��700��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��575* �6   �� 5      $
��109* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGrid��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *Name+6K     5      $ Фамилия��6%   $ * 6S   	 66   �� *
LastName+6S     5      $ Отчество��6%   $ * 6V   	 67   �� *
MiddleName+6V     5      $ Телефон��6%   $ * 6T   	 66   �� *	telephone+6T     5      $ Email��6%   $ * 6N   	 64   �� *email+6N     5      $ 
Логин��6%   $ * 6N   	 64   �� *login+6N     5      $ Пароль��6%   $ * 6R   	 65   �� *
password+6R   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ BtnEdit��6=   -   5        $ ��Редактировать��5   %   6N   5      5!      5#      �� 5$   
   -   5        $ PanelButtonNew��5$      $��Добавить��6)   $
��Left=�6<   $��1��6W   $��Center=�6d   $��10,0,0,0q�6�   $	��200��6�   �� 5%   
   -   5        $ PanelButtonDel��5%      $��Удалить��6)   $��1��6;   $��Center=�6H   $��0,0,10,0q�6�   $��Right=�6�   $	��200��6�   5'      5(      