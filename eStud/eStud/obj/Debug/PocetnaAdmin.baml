   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5          eStud.PocetnaAdmin   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������$
��1594��5	   J   $
��1017��6W   .��5
      � -   5          �Name$  GlavniPanel��5
      .+�5   
   �� $	��444��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFF56C2D��6#   � 5      $ 	#FFF56C2D��6#    � Offset$ 1Q�65   � 5      $ 	#FFF5804B��6#   $	 0.5Q�65   5      5      �� 5   
   $	��454��6   
�������$��Bottom=�6.   $��100.5,0,888.5,341q�6I    �� RadiusX$ 15��6d    �� RadiusY$ 15��6q    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFB4B4B4��6#   	   	Direction$	 0Q�65   
   
BlurRadius$
 15Q�6C      RenderingBias$ Quality=�6S   5      �� 5   
   $	��454��6   
�������$��Bottom=�6.   $��868.5,0,120.5,341q�6I   $ 15��6d   $ 15��6q    5        5      $ 	#FFB4B4B4��6#   $	 0Q�65   $
 15Q�6C   $ Quality=�6S   5      �� 5   
   -   5         ��Name$ listaStudenata��5      $
��Left=�6+   $��344.5��6F   $��184.5,273,0,0q�6U   $	��Top=�6l   $��425.5��6�    �� View 5       �� 5!      .P�5"      �� $	��Ime��5$   	    �� DisplayMemberBinding 5#   	   �� *Ime+5$   	   �� 5%      $��Prezime��5'   	    5&   	   �� *	Prezime+5'   	   �� 5(      $��Broj indeksa��5*   	    5)   	   �� *BrojIndeksa+5*   	   5+      5-      �� 5.   
   -   5        $ listaReferenta��5.      $
��Left=�6+   $��344.5��6F   $��955.5,273,0,0q�6U   $	��Top=�6l   $��431.5��6�    5/      �� 50      .P�51      �� $	��Ime��53   	    52   	   �� *Ime1+53   	   �� 54      $��Prezime��56   	    55   	   �� *
Prezime1+56   	   �� 57      $��	Departman��59   	    58   	   �� *	Departman+59   	   5:      5<      �� 5=   
   -   5         ��Name$ btnPrikaziStudente��5=      $��Prikazi vise��6-   $
��Left=�6D   $��286.5,646.703,0,0q�6_   $	��Top=�6z   $��193.5��6�   $��47��6�   $��22(�6�   ���	#FFF5804B��6�   Z� �� 5>   
   -   5        $ btnPrikaziReferente��5>      $��Prikazi vise��6.   $
��Left=�6E   $��1093.5,646.703,0,0q�6`   $	��Top=�6|   $��193.5��6�   $��47��6�   $��22(�6�   ���	#FFF5804B��6�   Z� 6�   5@      5A      