   M S B A M L   `   `   `  ����>  :ATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ATM.Forms.adminFormsATM.Forms.adminForms  5      -    'ATM.Forms.adminForms.VerUsuariosControl   5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ATM.Forms.adminForms     5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5	      .��5      � -   5         �Name$ GridVerUsers��5      ���#E0EEEF$	��690��66   $	��547��6B    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��80* �6   �� 5      $
��370* �6   �� 5      $	��57* �6   .+�5   
   �� $��0��6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone  ���#4B5F83$��Bottom=�6<   $��40��6W   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $#��Control de usuarios Banco WPF��6!   $��20(�6F   $��Center=�6T   $��Center=�5      
�������$��WrapWithOverflow=�5       $
��71,0q�6=   5!      5"      5$      � 5'   
   $��1��6    5(      �� 5)      �� 5*      .+�5-      �� $��0��6   $ 
Horizontal=�6&   $��0 10 0 0q�6?   .+�5.      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6*   $��60 0 0 0q�66   $��Center=�6H   $��Center=�6c     5/      $ FileFindOutline=�6*   $��0 0 0 0q�6B   $��Center=�6S   �� 50      $��Buscar Usuario por:��6   $��10 0 0 0q�67   $��Center=�6I   $��15(�6d   �� 51      -   5        $��ComboBoxTipoBuscar��51      $��25��65   $	��150��6A    �� SelectedIndex$ 1��6M   $��10 0 0 0q�6_   .@�52      �� $��Numero de cuenta��6#   �� 53      $��Numero de cedula��6#   54      55      �� 57      $��1��6   $ 
Horizontal=�6&   .+�58      �� -   5         ��Name$ 	TxtBuscar��58      $	��300��6.   $��	80 0 0 10q�6;   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Escribe aqui��6N   �� 59      -   5        	 ��Name$	 	iconClose��59      ��6,   Z� ��6B   Z� .��5:        $ Close=�6.   ��6=   �� 
 �� ElementName$
 	TxtBuscar�� �� Path$ BorderBrush�5;      �� 5<      -   5        $	 	btnBuscar��5<      $��Buscar��6,   $
��30 0q�6=   ���#4B5F83���#4B5F836x   5=      5>      &   System.Windows.Controls.DataGrid  5@   
   -   5        $��dgUsers��5@      $��2��6"      
IsReadOnly . ���	#FF4B5F83   Columns 5B      5E      �� 5G   
   $��3��6   $ 
Horizontal=�6"   $��80 0 0 0q�6;   .+�5H      �� -   5        $��	btnEditar��5H      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6&   ���#4B5F83���#4B5F83$
��20 0q�6   .��5J      �� $ 
Horizontal=�6   .+�5K        $
 Edit=�6.   �� 5L      $��Editar:��6    $
��10 0q�6/   �� 5M      -   5        $��labelConfirmar��5M       $	��off��66   $	��0 0q�6A   5N      5P      �� 5R      -	   5        $��	btnDelete��5R      $ 5��6&   ���#E81123���#4B5F83$��20 0 q�5S   A   .��5T      �� $ 
Horizontal=�6   .+�5U        $ Delete=�6.   �� 5V      $��Eliminar��6    $
��10 0q�60   5X      5Z      �� 5]      -
   5        $��
btnGuardar��5]      $ 5��6'   ���#1A3970���#4B5F83$��20 0 q�5^   +   .��5_      �� $ 
Horizontal=�6   .+�5`        $ ContentSave=�6.   �� 5a      $��Guardar��6    $
��10 0q�6/   5c      5e      5g      5i      5m      