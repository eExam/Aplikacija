   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5      #    eStud.StudentPrijavljeniIspit   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      $
��1591��5   %   $
��1017��62   .��5	      � -   5          �Name$  GlavniPanel��5	      
�������$
��1591��63   $��1017.5��6@   $��0,0,-10,-302q�6P   $	��Top=�6f   .+�5
   
   �� $	��444��6   $	��Top=�6!   $��	-14,0,0,0q�69   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFF56C2D��6#   � 5      $ 	#FFF56C2D��6#    � Offset$ 1Q�65   � 5      $ 	#FFF5804B��6#   $	 0.5Q�65   5      5      �� 5   
   $	��668��6   
�������$��Bottom=�6.   $��256,0,157,187.5q�6I    �� RadiusX$ 15��6b    �� RadiusY$ 15��6o    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFB4B4B4��6#   	   	Direction$	 0Q�65   
   
BlurRadius$
 15Q�6C      RenderingBias$ Quality=�6S   5      �� 5   
   $
��Left=�6   $	��525��60      SimpleTabControl#���   6=   $	��Top=�6h   $
��1049��6�   $��6,1,1,1q�6�   $��310,231,0,0q�6�   ��6�   Z� .@�5      �� $ ��Uspesno prijavljeni ispiti��6     SimpleTabItem#���  6:   $��40��6b   $��20(�6n   ���	#FF6A6868��5      �� 5      $	 0,1&�6*   $	 0,0&�69   .��5      � $ 	#FFF0F0F0��6'   $ 0Q�69   � 5      $ 	#FFEEBABA��6'   $ 1Q�69   5       .��5"      � ���	#FFE5E5E5.+�5%      &   System.Windows.Controls.DataGrid  -   5          Name$ TabelaPrijavljeniIspiti��5%      $
��Left=�6@   $	��476��6[   $	��Top=�6h   $
��1039��6�   
�������$��13(�6�   6�   5(      5)      �� 5*      $"��Neuspesno prijavljeni ispiti��6   #���  6<   $��20(�6d   ���	#FF6A6868��5+      �� 5,      $	 0,1&�6*   $	 0,0&�69   .��5-      � $ 	#FFF0F0F0��6'   $ 0Q�69   � 5.      $ 	#FFEEBABA��6'   $ 1Q�69   5/      .��51      � 
�������.+�52        -   5        $ tabelaNeprijavljeniIspiti��52      $
��Left=�6B   $	��466��6]   $	��Top=�6j   $
��1028��6�   $��13(�6�   
�������6�   53      54      55      59      5:      