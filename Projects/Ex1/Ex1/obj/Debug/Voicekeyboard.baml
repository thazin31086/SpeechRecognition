   M S B A M L   `   `   `  ����>  :Ex1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Ex1Ex1  5   	       Ex1.Voicekeyboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Ex1     5   	     � Title$  Voicekeyboard��5   	   $	��300��6    .��5	      ��  �� Orientation$ Vertical=�6   $��5,5,5,5q�6(   .+�5
   
   �� .��6   Speak6   �� 5   
   -   5        $��txtInput��5       �� MinLines$ 10��5      $	��5,5q�5      $��16(�5      $
��Bold"�5      
����ح�
������  �� TextWrapping$
 Wrap=�5      $	��102��6!   �� 5   
   $ 
Horizontal=�6   .+�5      �� -   5        $
��Open��5      6$   �� 5      -   5        $��Close��5      6%   �� 5      -   5        $��	Scroll up��5      6)   �� 5      -   5        $��Scroll down��5      6+   5      �� 5   
   $ Vertical=�6   .+�5      �� $��Go��6   5      o� 5   
   -  'System.Windows.Input.KeyboardNavigation   TabNavigation$ Cycle=�6   .@�5      m� -   5        $��Menu Item 1��5      6,   m� 5      $��Menu Item 2��6   m� 5       $��Menu Item 3��6   m� 5!      $��Menu Item 4��6   5"      5#      5%      