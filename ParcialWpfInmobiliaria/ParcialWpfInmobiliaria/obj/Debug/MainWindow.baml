   M S B A M L   `   `   `  ����Q  MParcialWpfInmobiliaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ParcialWpfInmobiliariaParcialWpfInmobiliaria  5   	   '    !ParcialWpfInmobiliaria.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ParcialWpfInmobiliaria     5   	   -   5          � Title$  Inmobiliaria��5   	   $��464.655��6   $��657.997��6/    � 	Resources 5
      3   -ParcialWpfInmobiliaria.InmobiliariaDunDataSet   inmobiliariaDunDataSet  inmueblesViewSource �� Source �� Source  ButtonStyle �� 
TargetType �� Property �� Value��%�   &	        &	      7   &	 B       5   
   6'   �� 5   
    6;   �� *	Inmuebles+8   �� 5   
   " ��6$   .�5      ��  � ��$
 15,5q�6'   5      5      .��5      �  � DataContext# [ 6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��200* �6   �� 5      $��60 �6   ��5   
   �� 5      	 j� Stretch$	 UniformToFill=�6   
 �� ImageSource$
 Images\fondoMain.jpg��61   .+�5   
   �� $��0��6   $��30(�6!   $��Calibri)�6/   $��Center=�6D   Bienvenido a Dun Inmobiliaria5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	tablaGrid��5      $��1��6&   $��	Britannic)�63      AlternatingRowBackground
 �����   CanUserSortColumns . $��Center=�6�   $��Center=�6�      AutoGenerateColumns .    EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�6  ��6�   �� 6  � 5   
   $��2��6   $��Center=�6!   .+�5      �� -   5        #��[ 5   2   
������ $��0q�6p    � ToolTip$ Ver Vendedores��6�   .��5       �� $��Images\employee.png��6   5!      �� 5"      #��[ 6   
������ $��0q�6S   $ Buscar Inmuebles��6g   .��5#      �� $��Images\search.png��6   5$      �� 5%      -   5        #��[ 5%   4   
������ $��0q�6r   $ Editar tabla��6�   .��5&      �� $��Images\edit.png��6   5'      �� 5(      -   5        #��[ 5(   +   
������ $��0q�6i   $ Recargar tabla��6~   .��5)      �� $��Images\refresh.png��6   5*      �� 5+      -   5        #��[ 5+   )   
������ $��0q�6g   $ Cerrar��6{   .��5,      �� $��Images\close.png��6   5-      5.      5/      50      