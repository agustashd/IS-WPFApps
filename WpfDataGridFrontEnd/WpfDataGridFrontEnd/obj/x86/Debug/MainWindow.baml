   M S B A M L   `   `   `  ����N  JWpfDataGridFrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfDataGridFrontEndWpfDataGridFrontEnd  5   	   $    WpfDataGridFrontEnd.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0my!clr-namespace:WpfDataGridFrontEnd     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      )   #WpfDataGridFrontEnd.personasDataSet   personasDataSet  tblpersonasViewSource �� Source �� Path �� Source  SelectedBrush �� 
StartPoint �� EndPoint � Offset � Color  RolloverBrush  
GlassBrush)  #System.Windows.Controls.DataGridRow	 �� 
TargetType
 �� Property �� Value �� Triggers P� Property P� Value*  $System.Windows.Controls.DataGridCell �� 
TargetType �� Padding J� SnapsToDevicePixels&   System.Windows.Controls.DataGrid   FocusBorderBrushKey=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� CornerRadius �� ContentStringFormat �� ContentStringFormat E� 
StartPoint �� Point �� Triggers �� 
TargetNameG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  GroupContainerStyle 9� 
IsExpanded � ColumnDefinitions � RowDefinitions �� Orientation	 �� X1	 �� X2  �� Stretch  RowHeaderStyle:  4System.Windows.Controls.Primitives.DataGridRowHeader  ExpanderToggleButton! �Name" � OverridesDefaultStyle# d� 	IsChecked$ �� Mode% �� RelativeSource& �� ElementName��%�  &	        &	      7   &	 J     &	 �     &	 r    '  :    7  7  '  �    7  '  �    7  '      &	 �    &	 E    &	 �    '9� �    7    5   
   6   �� 5	   
    5
      �� $ tblpersonas�8   �� 5   
   $	 0,0&�64   $	 0,1&�6E   .��5      � $ 0Q�6   $ #767474��6&   � 5      $ 1Q�6   $ #A1A1A1��6&   5      �� 5   
   $	 0,0&�64   $	 0,1&�6E   .��5      � $ 0Q�6   $ #FEB74B��6&   � 5      $ 1Q�6   $ #F19201��6&   5      �� 5   
   $	 0,0&�61   $	 1,0&�6B   .��5      � $ 0Q�6   $ 	#66ffffff��6&   � 5      $ 0Q�6   $ 	#36FFFFFF��6&   � 5      $ 1Q�6   $ 	#B5EBE7E7��6&   5      �� 5   
   "	  6   .�5      �� 
 � ��
 �����6+   �� 5       
 � �� �#4140406+   �� 5!      
 � ��$ 0,1,0,1q�60   �� 5"      
 � �� �#6161616,    5#      P� 5$       �@J�IsMouseOver . . �5%      �� 
 � ��8   63   5&      P� 5'       �@ 
IsSelected . . �5(      �� 
 � ��8  63   5)      5+      �� 5.   
   "	  6.   .�5/      �� 
 � ��
 ���� 6+   �� 50      
 � ��
 ���� 6,   �� 51      
 � ��$ 0q�60   �� 52      
 � �� 53      �� 54      "  6&   .R�55      �� $ 5q�6!   #��z��6.   #��z��56      #��z��57       . ._�59      �� # z 6/   5:      5;      5=       5>      P� 5?       �@J�IsKeyboardFocusWithin . . �5@      �� 
 � ��# �  64   5A      P� 5B       �@ 
IsSelected . . �5C      �� 
 � ��8   63   5D      5F      �� 5I   
   "	  6   .�5J      �� 
 � ��$ Center=�69   �� 5K      
 � ��
 �����6+   �� 5L      
 � �� 5M      �� 5N      "  6&   .R�5O      � .+�5P      �� $��
MainBorder��6%   $��2,2,2,0q�67   $ 8,8,0,0��6Q   $��0,0,1,0q�5Q   %   ���#5FACE7���#2F73B2._�5R   "   � .+�5T   &   �� $��GradientBorder��6E   $	��Top=�6-   $��10��6[   $ 7,7,0,0��5U   -   ���#D994668��  5V   -   �� 5W   &   $��3q�67   $��Center=�6B   $��Center=�5X   7   #��z��5Y   7   # z 5Z   7   #��z��5[   7   5\   #   5]      F� 5^      $��UpArrow��6#   
�������$��Right=�6?   $��Center=�5_   #   $��0,2,7,0q�6>   $y�Hidden=�6O   ��5`   "   B� 5a   &   .��5b   *   E� $	 0,0&�65   .��5c   .   �� $	 7,0&�6:   �� 5d   .   $ 3.5,6&�6:   �� 5e   .   $	 0,0&�6:   5f   +   5g   '   5i      F� 5j      $��	DownArrow��6#   
�������$��Right=�6A   $��Center=�5k   #   $��0,2,7,0q�6>   $y�Hidden=�6O   ��5l   "   B� 5m   &   .��5n   *   E� $	 0,6&�65   .��5o   .   �� $	 7,6&�6:   �� 5p   .   $ 3.5,0&�6:   �� 5q   .   $	 0,6&�6:   5r   +   5s   '   5u      5v       5w      P� 5x       �@ SortDirection$ 
DescendingX�6?   . �5y   "   �� $ UpArrow��6)   
 � y�$ Hidden=�6T   �� 5z   "   $ 	DownArrow��6)   
 � y�$ Visible=�6V   5{      P� 5|       �@ SortDirection$ 	AscendingX�6?   . �5}   "   �� $ 	DownArrow��6)   
 � y�$ Hidden=�6V   �� 5~   "   $ UpArrow��6)   
 � y�$ Visible=�6T   5      5�      5�      5�      �� 5�   
   "	  6@   .�5�      �� 
 � �� 5�      �� 5�      "  6&   .R�5�      � .+�5�      �� 5�      5�      5�      5�      �� 5�   
   "	 ��6,   .�5�      �� 
 � �� 5�      �� 5�      " ��6&   .R�5�      9�  . ���#414040��5�      � 5�   "    5�   &   �� 5�   *   $
��Auto �6;   �� 5�   *    5�   &   �� 5�   *   .+�5�   &   �� $ 
Horizontal=�61   
�������$��0,0,10,0q�6g   .+�5�   *   �� ��64   �� $
 Name��� 5�   *   $�� has uploaded ��64   �� 5�   *   $
��Bold"�64   ��6F   �� $ 	ItemCount��� 5�   *   $�� photos��64   5�   '   �� 5�   &   $��1��6+    . $ 0��6W   $ 1��6^   $
  Fill=�6e   
��� ���$��1��6�   5�   #   .��5�      �� 5�      5�      5�      5�      �� 5�   
   "	  6'   .�5�      �� 
 � �� �#A1A1A16+   5�      �� 5�   
   " d�67   .R�5�      �� 
���   �._�5�      F� $��Arrow��6   
�������$��Center=�61   $��Center=�6N   "����        � 	=  	= � z     	5�      5�       5�      P� 5�       �@d�	IsChecked$
 trueY�6/   . �5�      �� $ Arrow��6   
 � ��" ��     	= � 	=     � z  	= 	6@   5�      5�      �� 5�   
   "	 9�6   .�5�      �� 
 � �� 5�      �� 5�      " 9�6&   .R�5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $! 
ContentRow��60   $��0 �6B   .+�5�      �� $��Border��6%   $��0��63   
���   �._�5�   "   �  5�   &   �� 5�   *   $��20 �6;   �� 5�   *   $��* �6;   .+�5�   &   d� " . 8��  # 63   �� $ 
IsExpanded�$$ TwoWay=�% �� *TemplatedParent+5�   J   �� 5�   &   $��1��67   $��4q�6G   $��Header��6R   ��. 6i   5�   #   5�      �� 5�      $��Content��6%   $��1��65   
������ $��0q�6[   ._�5�   "   �� $��3,0,0,0q�63   5�      5�       5�      P� 5�       �@9�
IsExpanded . . �5�   "   �� $ 
ContentRow��6)    6S   �� $& Content��$ DesiredHeight�
 � ��5�      5�      5�      5�      5�      .��5�      � ' � DataContext#' [ 6   .+�5�   
     -   5        $��tblpersonasDataGrid��5�   @   (   AutoGenerateColumns( .  )   EnableRowVirtualization) . $��10,60,10,10q�6+   *   RowDetailsVisibilityMode$* VisibleWhenSelected=�5�      ��5�      �� +   Columns+ 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      -   5        idColumn��,	  &System.Windows.Controls.DataGridColumn, 	  Header$, Id��5�   S   - 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$- SizeToHeader
 5�   %   1  +System.Windows.Controls.DataGridBoundColumn.   Binding. 5�   7   �� $ Id�5�   %     5�      -   5        apellidoColumn��$, Apellido��5�   %   $- SizeToHeader
 67   . 5�   =   �� $ Apellido�5�   7     5�      -   5        nombreColumn��$, Nombre��5�   %   $- SizeToHeader
 65   . 5�   ;   �� $ Nombre�5�   5   4  .System.Windows.Controls.DataGridTemplateColumn  5�      -   5        fechaNacimientoColumn��$, Fecha Nacimiento��5�   H   $- SizeToHeader
 5�   )   /   CellTemplate/ 5�      �� 5�      .R�5�      (  "System.Windows.Controls.DatePicker  0   SelectedDate0 6)   �� $ FechaNacimiento�$$ TwoWay=�1 �� ValidatesOnExceptions1 . 2 �� NotifyOnValidationError2 . 5�      5�        5�      -   5        documentoColumn��$, 	Documento��5�   %   $- SizeToHeader
 68   . 5�   >   �� $ 	Documento�5�   8   5�      5�      5      