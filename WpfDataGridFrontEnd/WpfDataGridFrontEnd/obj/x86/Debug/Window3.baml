   M S B A M L   `   `   `  ����N  JWpfDataGridFrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfDataGridFrontEndWpfDataGridFrontEnd  5   2   !    WpfDataGridFrontEnd.Window3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0my!clr-namespace:WpfDataGridFrontEnd     5   2   -   5          � Title$  Window3��5   	   $	��300��6   $	��444��6&    � 	Resources 5      )   #WpfDataGridFrontEnd.personasDataSet   personasDataSet  tblpersonasViewSource �� Source �� Path �� Source��%b   &	        &	      7     5   
   6   �� 5   
    5      �� $ tblpersonas�8   5	      .��5
      �  � RowDefinitions 5   
   �� 5      $��33 �6   �� 5      $
��203* �6   �� 5      $��27 �6   .+�5   
   c� .@�5      �� -   5        .��5      �� $9��3/WpfDataGridFrontEnd;component/Images/disk_blue.png��6   5      �� 5      -   5        .��5      �� $��Images/window_sidebar.png��6   5      �� 5      -   5        .��5      �� $��Images/delete2.png��6   5      5      � 5   
   $��1��6   .+�5   
   � -   5        $��grid1��5   D    � DataContext# [ 6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5!      �� 5"      $
��Auto �6    .+�5$      �� $	��Id:��6   $��0��6"   $��0��62   $
��Left=�6?   $��3q�6Z   $��Center=�6e   �� 5%      -   5        $��	idTextBox��5%   e   $��1��6   $��0��6&   $��23��63   $
��Left=�6?   $��3q�6Z   $��Center=�5'      $��80��61   ��5&      �� $ Id� �� Mode$ TwoWay=�	 �� ValidatesOnExceptions	 . 
 �� NotifyOnValidationError
 . 5'   1   5(      � 5)   
   -   5        $��grid2��5)   D   # [ 6    5*      �� 5+      $
��Auto �6#   �� 5,      $
��Auto �6#    5.      �� 5/      $
��Auto �6    .+�51      �� $��	Apellido:��6   $��0��6(   $��0��68   $
��Left=�6E   $��3q�6`   $��Center=�52      �� 53      -   5        $��apellidoTextBox��54      $��1��53      $��0��6&   $��23��63   $
��Left=�6?   $��3q�6Z   $��Center=�55   L   $	��160��6g   ��54   -   �� $ Apellido�$ TwoWay=�	 . 
 . 55   g   56      � 57   
   -	   5        $��grid3��57   D   # [ 6    58      �� 59      $
��Auto �6#   �� 5:      $
��Auto �6#    5<      �� 5=      $
��Auto �6    .+�5?      �� $��Nombre:��6   $��0��6&   $��0��66   $
��Left=�6C   $��3q�6^   $��Center=�6i   �� 5@      -
   5        $��nombreTextBox��5@   e   $��1��6   $��0��6&   $��23��63   $
��Left=�6?   $��3q�6Z   $��Center=�6�   $	��120��6�   ��6z   �� $ Nombre�$ TwoWay=�	 . 
 . 6�   5A      � 5B   
   -   5        $��grid4��5B   D   # [ 6    5C      �� 5D      $
��Auto �6#   �� 5E      $
��Auto �6'   �� 5F      $
��Auto �6'    5H      �� 5I      $
��Auto �6    .+�5K      �� $��Fecha Nacimiento:��6   $��0��60   $��0��6@   $
��Left=�6M   $��3q�6h   $��Center=�6s   (  "System.Windows.Controls.DatePicker  5L      -   5        $��fechaNacimientoDatePicker��5M   $   $��1��5L      $��0��6)   $��25��66   $
��Left=�6B   $��3q�5M      $��Center=�5Q      $	��115��64      SelectedDate 5N      �� $ FechaNacimiento�$ TwoWay=�	 . 
 . 5Q   4   �� 5R      -   5        $��2��5R      $	��...��6)   6P   5S      � 5T   
   -   5        $��grid5��5T   D   # [ 6    5U      �� 5V      $
��Auto �6#   �� 5W      $
��Auto �6#    5Y      �� 5Z      $
��Auto �6    .+�5\      �� $��
Documento:��6   $��0��6)   $��0��69   $
��Left=�6F   $��3q�6a   $��Center=�6l   �� 5]      -   5        $��documentoTextBox��5]   e   $��1��6   $��0��6&   $��23��63   $
��Left=�6?   $��3q�6Z   $��Center=�6�   $	��120��6�   ��6}   �� $ 	Documento�$ TwoWay=�	 . 
 . 6�   5^      5_      �� 5`   
   $��2��6   ��5a      �� 5b      .R�5c      �  5d      �� 5e      $��* �6,    5g      �� 5h      $��27 �6/   �� 5i      $��27 �6/   �� 5j      $��* �6/   �� 5k      $��40 �6/   �� 5l      $��27 �6/   �� 5m      $��27 �6/   �� 5n      $��27 �6/   �� 5p      $��* �6/   �� 5q      $
��Auto �6/   �� 5r      $��* �6/   �� 5s      $��* �6/   5u      5v      .@�5x      �� $��0��6   .��5y      �� -   5        $��buttonFirst��5y      $��20��6,   $��20��68   .��5z      �� $>��8/WpfDataGridFrontEnd;component/Images/navigate_left2.png��6   5{      5|      �� 5}      $��1��6   .��5~      �� -   5        $��buttonPrevious��5~      $��20��6/   $��20��6;   .��5      �� $=��7/WpfDataGridFrontEnd;component/Images/navigate_left.png��6   5�      5�      �� 5�      $��2��6   .��5�      �� -   5        $��TextboxCurrent��5�      $��50��60   6;   5�      �� 5�      $��3��6   .��5�      �� -   5        $��
LabelCount��5�      $��10��6*   $�� ��65   5�      �� 5�      $��4��6   .��5�      �� -   5        $��
buttonNext��5�      $��20��6+   $��20��67   .��5�      �� $>��8/WpfDataGridFrontEnd;component/Images/navigate_right.png��6   5�      5�      �� 5�      $��5��6   .��5�      �� -   5        $��
buttonLast��5�      $��20��6+   $��20��67   .��5�      �� $?��9/WpfDataGridFrontEnd;component/Images/navigate_right2.png��6   5�      5�      �� 5�      $��6��6   .��5�      �� -   5        $��buttonRefresh��5�      $��20��6.   $��20��6:   .��5�      �� $7��1/WpfDataGridFrontEnd;component/Images/refresh.png��6   5�      5�      �� 5�      $��7��6   .��5�      �� Ready6#   5�      �� 5�      $��8��6   .��5�      �  � Value$ 30Q�6   $��80��6)   $��18��64   5�      �� 5�      $��9��6   .��5�      �� Set6!   5�      �� 5�      $��10��6   .��5�      �� Go!6!   5�      5�      5�      5�      