   M S B A M L   `   `   `  ����Q  MParcialWpfInmobiliaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ParcialWpfInmobiliariaParcialWpfInmobiliaria  5   	   &     ParcialWpfInmobiliaria.Empleados   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ParcialWpfInmobiliaria     5   	   -   5          � Title$  
Vendedores��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      3   -ParcialWpfInmobiliaria.InmobiliariaDunDataSet   inmobiliariaDunDataSet  vendedoresViewSource �� Source �� Source  ButtonStyle �� 
TargetType �� Property �� Value��%�   &	        &	      7   &	 C       5
   
   6'   �� 5   
    6<   �� *
Vendedores+8   �� 5   
   " ��6$   .�5      ��  � ��$
 25,5q�6'   5      5      .��5      �  � DataContext# [ 6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��200* �6   �� 5      $��60 �6   ��5   
   �� 5      	 j� Stretch$	 UniformToFill=�6   
 �� ImageSource$
 Images\fondoMain.jpg��61   .+�5   
   �� $��0��6   $��30(�6!   $��Calibri)�6/   $��Center=�6D   Tabla de Vendedores5      &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��	Britannic)�6       AlternatingRowBackground
 �����   CanUserSortColumns . $��Center=�6w   $��Center=�6�      AutoGenerateColumns . ��6�   �� � 5   
   $��2��6   $��Center=�6!   .+�5      �� -   5        #��[ 5   )   
������ $��0q�6g    � ToolTip$ Cerrar��6{   .��5      �� $��Images\close.png��6   5       5!      5"      5#      