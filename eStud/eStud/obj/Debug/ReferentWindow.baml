   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5   	       eStud.ReferentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:eStud     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
      MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $
��1104��5      $
��1930��6    � Icon$ Slike/HomeIcon.png��6#    � WindowStyle$ ThreeDBorderWindow=�6=    � 
ResizeMode$ NoResize=�6^    � WindowStartupLocation$ CenterScreen=�6t    � WindowState$ 	Maximized=�6�   .��5      � $
��1930��6   $��	0,0,-6,-5q�6    � ColumnDefinitions 5   
   �� 5      $
��163* �6   �� 5      $
��802* �6   .+�5   
   � -   5         �Name$ pnlLeft��5      $
��Left=�6    $
��1080��6;   $��Bottom=�6I   $	��326��6d   ���	#FF1E262C	 J� OpacityMask	 �	#FF60685E.+�5      �� -   5        
 ��Name$	
 ime��5      $��22(�6!   
�������$��Ime i prezime��6B   $	��Top=�6\   $��42��6t   $��Right=�6�   $	��233��6�   $��0,1012,32,0q�6�   $
��Bold"�6�   $��Century Gothic)�6�   ��6�   Z� 6�   	� 5      -   5         	�Name$ 
btnPocetna��5   w    d� 	IsChecked$
 TrueY�6      MaterialDesignTabRadioButton#��[ 6,   $��
46,128,0,0q�6b   $
��Left=�6�   $��50��6�   $	��Top=�6�   $	��226��6�   ���	#FFF56C2D$��22(�6  $
��Left=�6   J� RenderTransformOrigin$ 0.5,0.5&�65  $��Početna��6U  $��	0,0,0,0.3q�6g  $��Century Gothic)�6�  ���	#DDFFFFFF��6�   Z� 6�  �� 5      $��eSTUD��6   $
��Left=�6$   $��89.008,25,0,0q�6?   $	��Top=�6V   $��36(�6n   ���	#DDFDF9F9$��147.07��6�   $��Century Gothic)�6�   	� 5      -   5        $ btnPromenaLozinke��5   v   $ falseY�6   #��[ 6,   $��
20,752,0,0q�6b   $��Promena lozinke��6�   $
��Left=�6�   $	��Top=�6�   $	��289��6�   $��66��6�   $��22(�6  ���	#FFF56C2D$��Century Gothic)�63  ���	#DDFFFFFF��6�   Z� 6o  	� 5      -   5        $ btnZahteviIspit��5      $ FalseY�63   #��[ 6E   $
��Left=�6|   $��50��6�   $	��Top=�6�   $	��226��6�   ���	#FFF56C2D$��22(�6�   $
��Left=�6  $ 0.5,0.5&�6%  $��	0,0,0,0.3q�6F  $��Century Gothic)�6b  $��
46,183,0,0q�6�  ���	#DDFFFFFF��6�   Z� .��6�  	Zahtevi5      	� 5#      -   5        $ btnIspitniRokovi��5#      #��[ 64   $ falseY�6j   $
��Left=�6|   $��50��6�   $��
46,333,0,0q�6�   $	��Top=�6�   $	��226��6�   ���	#FFF56C2D$��22(�6	  $
��Left=�6  $ 0.5,0.5&�69  $��Ispitni rokovi��6Y  $��	0,0,0,0.3q�6r  $��Century Gothic)�6�  ���	#DDFFFFFF��6�   Z� 6�  	� 5$      -   5        $ btnPrijavljeniIspiti��5$      $ FalseY�68   #��[ 6J   $
��Left=�6�   $��50��6�   $��
46,233,0,0q�6�   $	��Top=�6�   $	��226��6�   ���	#FFF56C2D$��22(�6  $
��Left=�6  $ 0.5,0.5&�6=  $��Prijavljeni ispiti��6]  $��	0,0,0,0.3q�6z  $��Century Gothic)�6�  ���	#DDFFFFFF��6�   Z� 6�  	� 5%      -   5        $ btnPrijavnice��5%      $ FalseY�61   $
��Left=�6C   #��[ 6^   $��50��6�   $��
46,283,0,0q�6�   $	��Top=�6�   $	��226��6�   ���	#FFF56C2D$��22(�6  $
��Left=�6  $ 0.5,0.5&�66  $��
Prijavnice��6V  $��	0,0,0,0.3q�6k  $��Century Gothic)�6�  ���	#DDFFFFFF��6�   Z� 6�  �� 5&      -	   5         ��Name$ 	btnOdjava��5&      ���	#FFF56C2D$��Center=�6?   $��0q�6\   $��20,844,17,176q�6�   $��60��6�   $	��289��6�   $��
Odjavi se
��6�   $��22(�6�   $��Center=�6�   $��Center=�6  $��16q�64  $��Century Gothic)�6A  ��6�   Z� 6A  �� 5'      $
��Left=�6   $��1��63   $��	0,988,0,0q�6>     SimpleSeparator#���  6Q   $	��Top=�6{   $	��326��6�   	� 5(      -
   5        $ btnMolbe��5(      $ falseY�6,   #��[ 6>   $
��Left=�6u   $��50��6�   $��
46,383,0,0q�6�   $	��Top=�6�   $	��178��6�   ���	#FFF56C2D$��22(�6  $
��Left=�6  $ 0.5,0.5&�62  $��Molbe��6R  $��	0,0,0,0.3q�6b  $��Century Gothic)�6~  ���	#DDFFFFFF��6�   Z� 6�  5*      � 5+   
   -   5        $ GlavniPanel��5+      $��1��6$   $
��Left=�64   $
��1017��6O   $	��Top=�6]   $
��1604��6u   5.      5/      