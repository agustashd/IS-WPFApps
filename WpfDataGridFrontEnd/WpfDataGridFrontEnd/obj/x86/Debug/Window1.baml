   M S B A M L   `   `   `  ����N  JWpfDataGridFrontEnd, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfDataGridFrontEndWpfDataGridFrontEnd  5   2   !    WpfDataGridFrontEnd.Window1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   0my!clr-namespace:WpfDataGridFrontEnd     5   2   -   5          � Title$  Window1��5   	   $	��300��6   $	��300��6&    � 	Resources 5      )   #WpfDataGridFrontEnd.personasDataSet   personasDataSet  tbltelefonosViewSource �� Source �� Path �� Source=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value �� EndPoint	 �� 
StartPoint
 � Color � Offset��%�  &	        &	      7   '  K       5   
   6   �� 5   
    5      �� $ tbltelefonos�8   �� 5   
   "  6   dgch��.�5      ��  � �� 5      �� 5      $ 0.1,1&�6*   $	 0.1,0&�6;   .��5      � $
 	#ff777777��6'   $ 0Q�69   � 5      $
 	#ff232323��6'   $ .4Q�69   � 5      $
 	#ff000000��6'   $ .4Q�69   � 5      $
 	#ff232323��6'   $ 1Q�69   5      5      �� 5       � ��$ 30��6'   �� 5       � ��
 �����6+   �� 5       � ��
 �   �6,   �� 5       �@J�Opacity$ .9Q�6(   �� 5       � ��$ 1q�60   5      5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��tbltelefonosDataGrid��5          AutoGenerateColumns .     EnableRowVirtualization . $��10q�6      RowDetailsVisibilityMode$ VisibleWhenSelected=�6;   ��5   N   ��    Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Id��5$   S      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� $ Id�6_     5%      -   5        numeroColumn��$ Numero��5%   [   $ SizeToHeader 6k    6;   �� $ Numero�6k     5&      -   5        
tipoColumn��$
 Tipo��5&   W   $ SizeToHeader 6e    69   �� $
 Tipo�6e   4  .System.Windows.Controls.DataGridCheckBoxColumn  5'      -   5        canceladoColumn��$ 	Cancelado��5'   e   $ SizeToHeader 6x    6B   �� $ 	Cancelado�6x     5(      -   5        idPersonaColumn��$ 
Id Persona��5(   a   $ SizeToHeader 6u    6>   �� $ 	IdPersona�6u   5*      5+      5,      