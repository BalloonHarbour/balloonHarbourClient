   M S B A M L   `   `   `  ����I  EballoonHarbour, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:balloonHarbourballoonHarbour  5   	   ?$clr-namespace:balloonHarbour.MVVM.VMballoonHarbour.MVVM.VM  64       balloonHarbour.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:balloonHarbour     5   	   3vm$clr-namespace:balloonHarbour.MVVM.VM     64   $	��650��5   	   $
��1200��6   $	��400��5	   	   $	��650��6   ���#36393F  � WindowStyle$
  None=�5   	    � AllowsTransparency$
 True��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   .��5      ]� $
��True��6   .+�5   
   �� -   5         ��Name$	 top��5      $	��Top=�5      
������ $	��Top=�5      $��5��5      $��5,0,5,0q�5      ��5      Z� 5      �� 5   
   -   5        $ bottom��5      $��Bottom=�5      
������ $��5��5      $��Bottom=�5      $��5,0,5,0q�5      ��5      Z� 5      �� 5   
   -   5        $
 left��5&      $
��Left=�5       
������ $
��Left=�5#      $��0,5,0,5q�5$      $��5��5%      ��5!      Z� 5&      �� 5'   
   -   5        $ right��5.      $��Right=�5(      
������ $��0,5,0,5q�5+      $��5��5,      $��Right=�5-      ��5)      Z� 5.      � 5/   
    � RowDefinitions 50      �� 51      $��25 �6    �� 52       � ColumnDefinitions 54      �� 55      $	��200 �6#   �� 56      .+�59      �� -   5        $��2��59      ���#252525._�5=      � $��Stretch=�6   .+�5>      �� $��BalloonHarbour��6   
�������$��SemiBold"�5@      �� 5B      $��Right=�6!    �� Orientation$ 
Horizontal=�5C      .+�5E      �� -   5         ��Name$ buttonMinimize��5E   !   $��20��69   $	�� 20��6D   $	��−��5F      
������ $��0q�5H      
�������$
��Bold"�5J      $��16(�6/   ��5K      �� *MinimizeMainWindowCommand+�� 5M      -   5        $ buttonMaximize��5M   !   $��20��69   $	�� 20��6D   $��^��5N      
������ $��0q�5P      
�������$
��Bold"�5R      $��16(�6/   ��5S      �� *MaximizeMainWindowCommand+�� 5U      -   5        $ buttonClose��5U   !   $��20��66   $	�� 20��6A   $	��✕��5V      
������ $��0q�5X      
�������$
��Bold"�5Z      ��5[      �� *CloseMainWindowCommand+5\      5]      5^      � 5`      ���#2F3136$��1��5a       5b      �� 5c      $��50 �6$   �� 5d      �� 5e      $��60 �6$   .+�5h      �� $��Contacts��6   $��Center=�5i      $��Medium"�5j      
�������$��8,0,0,0q�5l      �� 5n      
������ $��0q�5p      $��1��5q         Contactcard#��[  5r      ��5n      �� *
Contacts+5r      �� 5t      $��2��6   $ 
Horizontal=�5u      ���#292B2F.+�5x      ��  �� CornerRadius$ 25��6   $��30��5y      $��30��6(   ���#3bff6f$��18,0,0,0q�5{      �� 5}      $��Center=�6!   .+�5~      �� 
������ $��0q�5   "   	 �� 
IsReadOnly$
	 True��5�   "   
 �� TextWrapping$

 Wrap=�5�   "   $��Username��5�   "   
�������$��SemiBold"�5�   "   $��5 0 0 0 q�5�   "   �� 5�      
������ $��0q�5�   "   $
	 True��5�   "   $

 Wrap=�5�   "   $��Adress��5�   "   
�������$��SemiBold"�5�   "   $��10(�5�   "   $��5 0 0 0q�5�   "   5�      5�      5�      5�      5�      5�      