   M S B A M L   `   `   `  ����E  ADataCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DataCenter
DataCenter  5          DataCenter.EditDevice   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:DataCenter     5        N� Title$5  /Редактировать Устройство��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��	titlePage��5      $5��/Редактировать устройство��6%   
�������$��30(�6X   $
��Bold"�6f   $��10q�6x   $��Center=�6�   $	��Top=�6�   �� 5   
   -   5        $��btnBack��5      $��
Назад��6    $��0��60   $��Right=�6=   $	��Top=�6Y   ���	#4CFFFFFF$
��Bold"�6�   $��40��6�   $	��100��6�   $��10q�6�   ��5      �� 5       �� 
TargetType" ��6"   .R�5      �� ���	#4CFFFFFF �� CornerRadius$ 15��64   
������ $��0q�6`   ._�5      �� $��Center=�6+   $��Center=�6H   5      5      5      �� 5"   
   $��1��6    �� Orientation$ Vertical=�6"   $��20q�69   .+�5#      �� $ 
Horizontal=�6   $��Center=�62   .+�5$      �� $"��Тип устройства:��6   $��Center=�63   
�������$
��Bold"�6a   $	��150��6s   �� 5%      -   5         ��Name$ cmbDeviceType��5%      $	��300��62   $��Center=�6>   ���	#26FFFFFF
�������$
��Bold"�6�   5'      5(      �� 5*      $ 
Horizontal=�6   $��Center=�62   $
��0 10q�6M   .+�5+      �� $��Наименование:��6   $��Center=�61   
�������$
��Bold"�6_   $	��150��6q   �� 5,      -   5         ��Name$ txtDeviceName��5,      $	��300��61   $��Center=�6=   ���	#26FFFFFF
�������$
��Bold"�6�   5-      �� 5/      $ 
Horizontal=�6   $��Center=�62   .+�50      �� $"��Серийный номер:��6   $��Center=�63   
�������$
��Bold"�6a   $	��150��6s   �� 51      -   5        $ txtSerialNumber��51      $	��300��63   $��Center=�6?   ���	#26FFFFFF
�������$
��Bold"�6�   52      53      �� 56   
   -   5        $��btnSave��56      $ ��Редактировать��6    $��2��68   $��Center=�6E   $��Bottom=�6b   ���	#4CFFFFFF$
��Bold"�6�   $��40��6�   $	��200��6�   $��10q�6�   ��58      �� 59      " ��6"   .R�5:      �� ���	#4CFFFFFF$ 15��64   
������ $��0q�6`   ._�5;      �� $��Center=�6+   $��Center=�6H   5<      5=      5?      5@      5A      