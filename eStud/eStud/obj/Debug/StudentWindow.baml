   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5   	       eStud.StudentWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:eStud     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      
�������  MaterialDesignFont#���  5       � Icon$ Slike/HomeIcon.png��5      $
��1104��6"   $
��1932��60    � WindowStyle$ ThreeDBorderWindow=�6=    � 
ResizeMode$ NoResize=�6^    � WindowState$ 	Maximized=�6t    � WindowStartupLocation$ CenterScreen=�6�   .��5      �� ���	#FF7A7A7A$��1q�6%   $
��Left=�69   $
��1076��6T   $	��Top=�6b   $
��1930��6z   $��	0,0,-4,-1q�6�   ._�5   
   � $��	0,0,2,1.5q�6    � RowDefinitions 5      �� 5      �� 5      $��0* �6    .+�5      � -   5         �Name$ GlavniPanel��5      $��
331,0,4,55q�6(   
�������$
��1591��6O   $
��1017��6\   	 � ColumnDefinitions	 5      �� 5      �� 5      $��0* �6'   5      � 5      -   5        $ pnlLeft��5      $
��Left=�6$   $
��1072��6?   $	��Top=�6M   $	��331��6e   ���	#FF1E262C	 5       �� 5!      $
��317* �6'   �� 5"      $	��11* �6'   .+�5$      �� -   5        
 ��Name$
 	btnOdjava��5$      ���	#FFF56C2D$��Center=�6C   $��0q�6`   $��34.258,804.1,25.641,153.9q�6�   $��60��6�   $	��260��6�   $��
Odjavi se
��6�   $��22(�6�   $��Center=�6  $��Center=�6)  $��16q�6D  $��Century Gothic)�6Q  ��6�   Z� 6Q  �� 5%      -   5         ��Name$	 ime��5%      $��24(�6%   
�������$��Ime i prezime��6F   $��Center=�6`   $��48��6{   $
��Left=�6�   $	��242��6�   $��34,1001,0,23q�6�   $��Center=�6�   $��0q�6�   ��. $��Center=�6/  $��Century Gothic)�6Q  ��6�   Z� 6Q  �� 5&      $��eSTUD��6   $
��Left=�6(   $��96.008,22,0,0q�6C   $	��Top=�6Z   $��36(�6r   ���	#DDFDF9F9$��147.07��6�   $��Century Gothic)�6�   �� 5'      $
��Left=�6   $��0��67   $��	3,996,0,0q�6B     SimpleSeparator#���  6U   $	��Top=�6   $	��328��6�   $��2��6�   �� 5)       �� Orientation$ Vertical=�5*      $��	4,4,4,258q�5+      .+�5,      	� -   5         	�Name$ 
btnPocetna��51         MaterialDesignTabRadioButton#��[ 5-       d� 	IsChecked$
 TrueY�50      $
��Left=�51   A   $��35,102.5,0,0q�6\   $	��Top=�6r   $	��237��6�   $��50��6�   ���	#FFF56C2D$��Početna��6�   $
��Left=�6�   $��	0,0,0,0.3q�6  $��22(�6!  $��Century Gothic)�6/  ���	#DDF1F1F1��6�   Z� 6K  	� 52      -   5        $ 	btnPodaci��57      #��[ 53      $��0,4,39.899,0q�54      $ FalseY�55      ���	#FFF56C2D$��Right=�57   V   $	��Top=�6r   $��237.101��6�   $��45��6�   $��Lični podaci��6�   $
��Left=�6�   $��	0,0,0,0.3q�6�   $��22(�6  $��Century Gothic)�6"  ���	#DDF7F7F7��6(   Z� 6U  	� 59      -   5        $ btnPrijaviIspit��5=   8   #��[ 5:      $��0,4,39.899,0q�5;      $ FalseY�5<      ���	#FFF56C2D$	��Top=�5=   Q   $��44��6�   $��Right=�6�   $��237.101��6�   $��Prijavi ispit��6�   $
��Left=�6�   $��	0,0,0,0.3q�6�   $��22(�6  $��Century Gothic)�6$  ���	#DDFFFFFF��6   Z� 6@  	� 5>      -   5        $ btnPrijavljeniIspiti_Copy��5>   �   $��82,4,0,0q�6'   $ FalseY�69   #��[ 6K   ���	#FFF56C2D$	��Top=�6�   $��48��6  $
��Left=�6  $	��190��64  $��Prijavljeni ispiti��6A  $
��Left=�6^  $��	0,0,0,0.3q�6�  $��20(�6�  $��Century Gothic)�6�  ���	#DDFFFFFF��6�   Z� 6�  	� 5?      -	   5        $ btnPolozeniIspiti��5?   �   $ FalseY�6)   $��0,4,39.899,0q�6;   #��[ 6Q   $��Right=�6�   $	��Top=�6�   $��190.101��6�   $��50��6�   ���	#FFF56C2D$��Polozeni ispiti��6"  $
��Left=�6<  $��	0,0,0,0.3q�6^  $��20(�6z  $��Century Gothic)�6�  ���	#DDFDFBFB��6�   Z� 6�  	� 5@      -
   5        $ btnPredmeti��5@   �   $��0,0,39.899,0q�6"   $ FalseY�68   #��[ 6J   $��Right=�6�   $	��Top=�6�   $��237.101��6�   $��50��6�   ���	#FFF56C2D$��Moji predmeti��6.  $
��Left=�6F  $��	0,0,0,0.3q�6h  $��22(�6�  $��Century Gothic)�6�  ���	#DDFFFFFF��6�   Z� 6�  	� 5A      -   5        $ btnIzborniPredmeti��5C      #��[ 5A   #   $��82,0,0,0q�5B      $ FalseY�5C      $
��Left=�63   $	��Top=�6N   $	��190��6f   $��50��6r   ���	#FFF56C2D$��Izborni predmeti��6�   $��	0,0,0,0.3q�6�   $��Center=�6�   $
��Left=�6  $��20(�6(  $��Century Gothic)�6W  ���	#DDFFFFFF��6~   Z� 6s  	� 5D      -   5        $ btnESPB��5F      #��[ 5D   "   $��35,0,0,0q�5E      $ FalseY�5F      $
��Left=�6(   $	��Top=�6C   $	��237��6[   $��50��6g   ���	#FFF56C2D$��Osvojeni ESPB ��6�   $
��Left=�6�   $��	0,0,0,0.3q�6�   $��22(�6�   $��Century Gothic)�6  ���	#DDFFFFFF��6s   Z� 6:  	� 5G      -   5        $ 	btnStatus��5I      #��[ 5G   #   $��35,0,0,0q�5H      $ FalseY�5I      $
��Left=�6*   $	��Top=�6F   $	��237��6^   $��50��6j   ���	#FFF56C2D$��Status��6�   $
��Left=�6�   $��	0,0,0,0.3q�6�   $��22(�6�   $��Century Gothic)�6  ���	#DDFFFFFF��6v   Z� 65  	� 5J      -   5        $ btnIspitniRokovi��5L      #��[ 5J   "   $��35,0,0,0q�5K      $ FalseY�5L      $
��Left=�61   $	��Top=�6M   $	��237��6e   $��50��6q   ���	#FFF56C2D$��Ispitni rokovi��6�   $
��Left=�6�   $��	0,0,0,0.3q�6�   $��22(�6  $��Century Gothic)�6  ���	#DDFFFFFF��6}   Z� 6K  	� 5M      -   5        $ btnPotvrdeUverenja��5M   4   $ FalseY�6"   #��[ 6P   $��35,4,0,0q�6�   $��Podnesi zahtev��6�   $��22(�6�   $��Century Gothic)�6�   ���	#DDFFFFFF$
��Left=�6�   $��50��6  $	��237��6  $
��Left=�6%  ���	#FFF56C2D6_  	� 5N      -   5        $ btnPromenaLozinke��5N   "   #��[ 6=   $ FalseY�6s   $
��Left=�6�   $��
35,95,0,10q�6�   $	��Top=�6�   $	��237��6�   $��52��6�   ���	#FFF56C2D$��Promena lozinke��6  $��Center=�6-  $��1q�6Q  $��22(�6e  ���	#DDE6E0E0$��Century Gothic)�6�  ��6�   Z� 6�  5P      5Q      5U      5V      5W      