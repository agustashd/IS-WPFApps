   M S B A M L   `   `   `  ����K  GMVVMInmobiliaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MVVMInmobiliaria.ViewsMVVMInmobiliaria.Views  5      I)clr-namespace:MVVMInmobiliaria.ViewModelsMVVMInmobiliaria.ViewModels  5      ,    &MVVMInmobiliaria.Views.InmuebleDisplay   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      1vw$clr-namespace:MVVMInmobiliaria.Views    5      6vm)clr-namespace:MVVMInmobiliaria.ViewModels    5        � DataContext  5      6   0MVVMInmobiliaria.ViewModels.InmuebleDisplayModel  5   
   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�64   $
��15.5q�6M   .+�5      �� $��2,5,0,0q�6   
������ $��35��6?   $��50��6K   $��0q�6V    � ToolTip$ Recargar��6k   ��5      �� *GetProductsCommand+.��6=   �� $��..\Images\refresh.png��6C   6e   �� 5      $��2,5,0,0q�6   
������ $��35��6?   $��50��6K   $��0q�6V   $ Limpiar��6k   ��5      �� *ClearCommand+.��65   �� $��..\Images\clear.png��6;   6[   �� 5      $��2,5,0,0q�6   
������ $��35��6?   $��50��6K   $��0q�6V   $ Editar��6k   ��5      �� *UpdateCommand+.��66   �� $��..\Images\modify.png��6<   6]   �� 5      $��2,5,0,0q�6   
������ $��35��6?   $��50��6K   $��0q�6V   $ Eliminar��6k   ��5      �� *DeleteCommand+.��66   �� $��..\Images\remove.png��6<   6]   �� 5      $��2,5,0,0q�6   
������ $��35��6?   $��50��6K   $��0q�6V   $ Agregar��6k   $��2q�5   2   ��6   �� *
AddCommand+.��6?   �� $��..\Images\add.png��6E   6c   5      � 5   
   $��10q�6   $��1��6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   62   �� 5      6%    5       �� 5!      $
��Auto �6    60   �� 5"      $
��Auto �6    60   �� 5#      $
��Auto �6    60   �� 5$      $
��Auto �6    60   �� 5%      $
��Auto �6    60   �� 5&      $��* �6    6-   �� 5'      $
��Auto �6    60   �� 5(      $
��Auto �6    60   .+�5+      �� $��7q�6   
Direccion:6/   �� 5,      $��5q�6   $��1��6!   $��1q�6b   ��61   ��  �� Path$ Stat.DireccionBrush���5-      �� $  DisplayedProduct.Direccion� �� UpdateSourceTrigger$ PropertyChanged=�6n   �� 5/      $��7q�6   $��1��6#   	Vendedor:6;   �� 50      $��5q�6   $��1��6!   $��1��6.   $��1q�6t   ��6>   �� $ Stat.NombreVendedorBrush���51      �� $ DisplayedProduct.Vendedor�$ PropertyChanged=�6m   �� 53      $��7q�6   $��2��6#   	Precio:69   �� 54      $��5q�6   $��2��6!   $��1��6.   $��1q�6l   ��6@   �� $ Stat.CostBrush���55      �� $ DisplayedProduct.Precio�$ PropertyChanged=�6k   �� 57      $��7q�6   $��3��6#   
Categoria:6<   �� 58      $��5q�6   $��3��6!   $��1��6.   $��1q�6v   ��6?   �� $ Stat.NombreCategoriaBrush���59      �� $  DisplayedProduct.Categoria�$ PropertyChanged=�6n   �� 5;      $��7,7,7,0q�6   $��4��6)   Descripcion:6D   �� 5<      $��7q�6   $��5��6!   $��0��6.   $��2��6>    �� TextWrapping$
 Wrap=�5=      " �� VerticalScrollBarVisibility$ Visible=�6&   ��6L   �� $" DisplayedProduct.Descripcion�6�   �� 5?      $��	7,25,15,0q�6   $��6��6+   $
��Bold"�68   	Estado:6S   �� 5@      $��7q�6   $��7��6!   $��0��6.   $��2��6>   ��5A      �� $ Stat.Status�66   5B      5C      5D      