   M S B A M L   `   `   `  ����>  :Ex1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Ex1Ex1  5   	       Ex1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Ex1     5   	     � Title$  Text to Speech��5   	   $	��500��6    $	��525��6-   
���   � � WindowStartupLocation$ CenterScreen=�5	   	   .��5      ��  J� RenderTransformOrigin$ 0.5,0.5&�6   .+�5   
   �� -   5        $��lblInput��5      
�������$��16(�63   $��Your Said..��6A   5      �� 5   
   -   5        $��txtInput��5       �� MinLines$ 10��5      $	��5,5q�5      $��16(�5      $
��Bold"�5      
����ح�
������  �� TextWrapping$
 Wrap=�5      $	��102��6!   �� 5   
   -   5        $��lblMsg��5      $	��0,2q�6   
�������$��16(�6>   6N   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��16(�5      $
��70px��6#   $��5,5,0,5q�60   .��6V   Record6^   �� 5      -   5        $��16(�5      $
��70px��6#   $��5,5,0,5q�61   .��6W   Replay6_   �� 5      -   5        $��16(�5      $
��70px��6#   $��5,5,0,5q�60   .��6U   Reset6\   5      �� 5   
   $ 
Horizontal=�6   .+�5       �� -   5        $��txtDoctoOpen��5       $ 1��5!      $	��5,5q�5"      $��16(�5#      $
��Bold"�5$      
����ح�
������  �� 
IsReadOnly . $
 Wrap=�5(      $	��348��6!   �� 5*      -   5        $��16(�5*      $��150px��6#   $��5,5,0,5q�61   .��6Y   Open File To Map6k   5+      �� 5-   
   -	   5        $	��0,2q�5-      $��16(�6   .��6G   Save Template6V   �� 5.   
   -
   5        $��	lblOutput��5.      
�������$��16(�64   $��Output��6B   6U   �� 5/   
   -   5        $��	txtOutput��5/      $ 10��50      $	��5,5q�51      $��16(�52      $
��Bold"�53      
����ح�
������ $
 Wrap=�56      $	��102��6!   �� 5:   
   -   5        $	��0,2q�5:      $��16(�6   .��6B   
Get List6L   �� 5;   
   -   5        $	��0,2q�5;      $��16(�6   .��6F   Get Keyboard6T   5<      5>      