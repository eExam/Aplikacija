   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5          eStud.StudentPodaci   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��1594��5	   #   $��1017.5��60   .��5      � 
�������$��1017.5��6   $��0,0,0,-1q�6.   $	��Top=�6@   $
��1594��6X   .+�5   
   �� $	��444��6   $	��Top=�6!   ��5      �� 5        �� EndPoint$  0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFF56C2D��6#   � 5      $ 	#FFF56C2D��6#    � Offset$ 1Q�65   � 5      $ 	#FFF5804B��6#   $	 0.5Q�65   5      5      �� 5   
   $	��826��6   
�������$��Bottom=�6.   $��86.5,0,62.5,76.5q�6I    �� RadiusX$ 15��6c    �� RadiusY$ 15��6p    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFB4B4B4��6#      	Direction$ 0Q�65   	   
BlurRadius$	 15Q�6C   
   RenderingBias$
 Quality=�6S   5      �� 5   
   $
��Left=�6   $	��749��60   $��130,156,0,0q�6=   $	��Top=�6R   $��1361.5��6j   .@�5      �� $��Spisak studenata��6   $��22(�60   ���	#FF616161.��5      � 
�������.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ TabelaStudenti��5      $
��Left=�67   $	��652��6R   $	��Top=�6_   $	��842��6w   
�������$��	0,58,0,-2q�6�   $��Segoe UI)�6�   �� 5      -   5         ��Name$ 
btnIzbrisi��5      $��Izbriši��61   $
��Left=�6C   $	��Top=�6^   $��246.5��6v   ���	#FFF5804B$��851.5,0,0,0q�6�   $��46��6�   $��22(�6�   ��6�   Z� 6�   �� 5       -   5        $ 
btnIzmenii��5       $��Izmeni��61   $
��Left=�6B   $	��Top=�6]   $��246.5��6u   ���	#FFF5804B$��1103.5,0,0,0q�6�   $��46��6�   $��22(�6�   ��6�   Z� 6�   �� 5!      -   5         ��Name$ pnlDodajStud��5!   !   $
��Left=�67   $��644.027��6R   $��851.5,46,0,0q�6c   $	��Top=�6y   $��502.5��6�   
�������6�   �� 5#      -   5         ��Name$ 	txtSearch��5#      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Pretraga studenta��6`    %  !MaterialDesignFloatingHintTextBox#��[  6�   $
��Left=�6�   $��58��6   �� TextWrapping$
 Wrap=�6  $�� ��6-  $	��Top=�65  $	��376��6M  $��	470,0,0,0q�6Y  ���	#896C6C6C6l  5%      5&      �� 5'      $��Dodaj novog studenta��6   $��22(�64   ���	#FF444444.��5(      � .+�5)      �� -   5        $ pnlDodajStud_Copy��5)   !   $
��Left=�6<   $��651.027��6W   $	��Top=�6h   $	��901��6�   $��
228,31,0,0q�6�   ���	#FFD3D1D16�   5*      5+      5,      50      51      