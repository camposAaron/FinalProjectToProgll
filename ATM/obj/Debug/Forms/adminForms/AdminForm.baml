   M S B A M L   `   `   `  ����>  :ATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ATM.Forms.adminFormsATM.Forms.adminForms  5   	   $    ATM.Forms.adminForms.AdminForm   5   
   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:ATM.Forms.adminForms     5   	   -   5        $��	adminForm��5   
      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5	       � Title$ 	AdminForm��5   	   $	��577��6   $	��890��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o    � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��547 �6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��690 �6   .+�5!   
   �� -   5        $��0��5!      
�������
������ $��2��6|   ._�5"      � .+�5#      (  "MaterialDesignThemes.Wpf.ColorZone  ���#0D2C5B$��	 0  0 0 0q�6@   .��5$      �� $��Right=�6!   $��40��6=   .+�5%      �� -   5        $��btnClose��5%   !   ���	#FF1A3970+  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth2=�6H   $��5q�6y   ���	#FF1A3970���	#DDFFFFFF.��5'      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 WindowClose=�66   $��Center=�6I   5(      5)      5*      5+      5,      � 51   
   -   5         �Name$
 Grid��51      $��1��6   $	��200��6*   $
��Left=�66   ���	#FF1A3970.+�52      �� .+�53      ��  �� Padding$ 20q�6   ._�54      ��  �� Orientation$ Vertical=�6!   .+�55      �� $��0,0,0,0q�6!   $��85��63   $	��110��6?   $��User.png��6K   �� 56      $��Administrador:��6$   
�������$��
40 10 0 0 q�6M   57      59      �� 5:      
�������.@�5<      �� -   5        $��45��5<   #   .��5=      �� $ 
Horizontal=�6%   .+�5>        $
 PlusBoxMultiple=�66   $��32��6M   $��27��6Y   �� 5?      $��Registrar usuario��6(   $��Center=�6A   $��10 0 0 0q�6\   5@      5A      �� 5C      -   5        $��45��5C   #   .��5D      �� $ 
Horizontal=�6%   .+�5E        $	
 eye=�66   $��32��6A   $��27��6M   �� 5F      $��Ver usuarios��6(   $��Center=�6<   $��10 0 0 0q�6W   5G      5H      �� 5J      -   5        $��45��5J   #   .��5K      �� $ 
Horizontal=�6%   .+�5L        $
 ExitRun=�66   $��32��6E   $��27��6Q   �� 5M      $��Cerrar sesion��6(   $��Center=�6=   $��10 0 0 0q�6X   5N      5O      5Q      5S      5V      � 5X   
   -   5        $ GridPrincipal��5X      $��1��6&   $��1��63   .+�5Y      �� $�� ��6   5Z      5[      5\      