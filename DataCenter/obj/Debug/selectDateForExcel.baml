   M S B A M L   `   `   `  ����E  ADataCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DataCenter
DataCenter  5   	   #    DataCenter.selectDateForExcel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DataCenter     5   	     � Title$  selectDateForExcel��5   	   $	��200��6$   $	��400��61    � 
ResizeMode$ NoResize=�6=   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $	��100 �6   �� 5      $��30 �6   .+�5   
   �� $)��#Сформировать отчет��6   $��20(�6.   $
��Bold"�6<   
�������$��Center=�6a   $��0 5 0 0q�6~   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   .+�5      �� $
��От��6   $��16(�6"   $
��Bold"�60   
�������$
��Left=�6U   $��10 5 0 0q�6p   (  "System.Windows.Controls.DatePicker  5      -   5        $��dtpSart��5      �� 5      $
��До��6   $��16(�6"   $
��Bold"�60   
�������$
��Left=�6U   $��10 5 0 0q�6p     5      -   5        $��dtpEnd��5      5      �� 5   
   $��2��6   $ 
Horizontal=�6"   .+�5      �� -   5        $��btnStart��5      $��20��6%   $	��100��61   $��Сформировать��6=   $��Center=�6T   $��	20 5 90 0q�6q   6�   �� 5      -   5        $��btnAll��5      $��20��6#   $	��130��6/   $%��Сформировать все��6;   $��Center=�6V   $��20 5 0 0q�6s   6�   5      5      5      