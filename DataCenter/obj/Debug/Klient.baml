   M S B A M L   `   `   `  ����E  ADataCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DataCenter
DataCenter  5          DataCenter.Klient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DataCenter     5        N� Title$  Клиент��5	      .��5      � 
�������$��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Клиенты��6   
�������$��30(�66   $
��Bold"�6D   $��10q�6V   $
��Left=�6b   $	��Top=�6}   $��0��6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��10q�6.   $��1��6:   .+�5      �� $��ФИО:��6   $��Center=�6$   
�������$��0,0,10,0q�6R   �� 5      -   5         ��Name$ 	txtFilter��5      $	��200��6)   $��Center=�65   ���	#26FFFFFF
�������$
��Bold"�6z   6�   �� 5      -   5        $��btnClear��5      $��Сбросить��6%   ���	#4CFFFFFF
�������$
��Bold"�6b   $��10 0 0 0q�6t   $��10q�6�   $��20��6�   ��5      �� 5       �� 
TargetType" ��6&   .R�5      �� ���	#4CFFFFFF �� CornerRadius$ 15��68   
������ $��0q�6d   ._�5      �� $��Center=�6/   $��Center=�6L   5      5       5"      5#      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ dataGridClients��5&      $��2��6,      AutoGenerateColumns .  $��Stretch=�6U   $��Stretch=�6s      CanUserAddRows .  	   CanUserDeleteRows	 .  
   
IsReadOnly
 .    SelectionMode$ Single=�5'   V   $��10q�6m      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *ФИО+6J     5*      $! Номер Телефона��6%   $ * 6Y    6=   �� *Телефон+6Y   4  .System.Windows.Controls.DataGridTemplateColumn  5+      $  ��6)      CellTemplate 5,      �� 5-      .R�5.      �� $ 
Horizontal=�6)   .+�5/   "   �� $��btnEdit��6)   -   5        $ ��Редактировать��5/   8   ���	#4CFFFFFF
�������$
��Bold"�6z   $��5q�6�   $��10q�6�   ��50   &   �� 51   *   " ��6:   .R�52   .   �� ���	#4CFFFFFF$ 15��6L   
������ $��0q�6x   ._�53   2   �� $��Center=�6C   $��Center=�6`   54   /   55   +   57   #   58      59      5;      5=      �� 5@   
   -   5        $��btnAdd��5@      $%��Добавить клиента��6   $��3��6:   $��Center=�6G   $��Bottom=�6d   ���	#4CFFFFFF$
��Bold"�6�   $��40��6�   $	��200��6�   $��10q�6�   
���������5B      �� 5C      " ��6"   .R�5D      �� ���	#4CFFFFFF$ 15��64   
������ $��0q�6`   ._�5E      �� $��Center=�6+   $��Center=�6H   5F      5G      5I      �� 5L   
   -   5        $��btnBack��5L      $��
Назад��6    $��0��60   $��Right=�6=   $	��Top=�6Y   ���	#4CFFFFFF$
��Bold"�6�   $��40��6�   $	��100��6�   $��10q�6�   
���������5N      �� 5O      " ��6"   .R�5P      �� ���	#4CFFFFFF$ 15��64   
������ $��0q�6`   ._�5Q      �� $��Center=�6+   $��Center=�6H   5R      5S      5U      5V      5W      