   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5          eStud.StudentPrijaviIspit   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $
��1591��5   7   $��1017.5��6D   .��5      � -   5         �Name$ 	ComboProf��5      
�������.+�5   
   �� $	��444��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFF56C2D��6#   � 5      $ 	#FFF56C2D��6#    � Offset$ 1Q�65   � 5      $ 	#FFF5804B��6#   $	 0.5Q�65   5      5      �� 5   
   $��588.3��6   ���	#FFFDF9F6$��Bottom=�64   $��269.904,0,339.705,264.2q�6O    �� RadiusX$ 15��6p    �� RadiusY$ 15��6}   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$
 	#FFB4B4B4��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S   5!      �� 5"   
   -   5         ��Name$ txtDepartman��5"      $
��Left=�6)   $��51��6D   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	DEPARTMAN��6P    % !MaterialDesignFloatingHintTextBox#��[ 6{   $��353.295,197.8,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $��260.705��6�   $��20(�6   J� RenderTransformOrigin$ 0.498,0.811&�6  {�.  $��Century Gothic)�6Q  �� 5#   
   $��PRIJAVA ZA ISPIT��6   $
��Left=�6+   $��556.5,314,0,0q�6F   $	��Top=�6]   $��48(�6u   $	��418��6�   ���	#DD5554546�   �� 5$   
   -   5        $ txtImePrezime��5$      $
��Left=�6)   $��51��6D   $ Ime i prezime��6P   #��[ 6   $��353.295,436.6,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��384��6  $��20(�6  $ 0.498,0.811&�6  $
��Left=�6?  $��Center=�6a  ���	#DD171717{�.  $��Century Gothic)�6�  �� 5%   
   -   5        $ txtBrIndeksa��5%      $
��Left=�6(   $��51��6C   $ Broj indeksa��6O   #��[ 6}   $��786,433.6,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��384.705��6�   $��20(�6  $ 0.498,0.811&�6  $
��Left=�6=  {�.  $��Century Gothic)�6q  �� 5&   
   -   5        $ txtStudijskiProgram��5&      $
��Left=�6/   $��51��6J   $ STUDIJSKI PROGRAM��6V   #��[ 6�   $��924,197.8,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��246.705��6  $��20(�6  $ 0.498,0.811&�6%  {�.  $��Century Gothic)�6[  �� 5'   
   -   5        $ txtBrPrijave��5'      $
��Left=�6Y   $��53��6t   $ Broj prijave��6�   #��[ 6�   $��1057.705,544,0,0q�6�   $
 Wrap=�6  $	��Top=�6  $	��113��6/  $��20(�6;  $ 0.349,0.804&�6I  $
��Left=�6m  ���	#89616161 �� 
CaretBrush �	#FF4AB64F��6�  Z� 6�  �� 5(   
   -   5         ��Name$ 
btnPrijavi��5(      $��PRIJAVI��6%   $
��Left=�67   $��600,711,0,0q�6R   $	��Top=�6g   $	��303��6   $��63��6�   $��36(�6�   ���	#FF3AB745���	#FFA2A1A16�   �� 5*   
   -   5         ��Name$ ClassicModeCheckBox��5+       d� IsThreeState .   d� 	IsChecked$
 TrueY�5-      $��71,594,1468,386q�5.      $��38��6   $ 9.375,16.259&�6*   
�������6O   �� 5/   
   -	   5         ��Name$ ComboPredmeti��5/   v   $
��Left=�6�   $��353.295,559,0,0q�6�   $	��Top=�6�   $	��384��6�   $��38��6�   ���	#89616161$��20(�6	  -  'MaterialDesignThemes.Wpf.ComboBoxAssist   ClassicMode 6   �� *	IsChecked+ �� ElementName$ ClassicModeCheckBox��51      �� 52   
   $��Izaberi predmet��6   $
��Left=�6*   $��353.295,523,0,0q�6E   $	��Top=�6^   $��20(�6v   ���	#DD707070$��36��6�   $	��180��6�   $��Century Gothic)�6�   �� 53   
   $��Profesor��6   $
��Left=�6#   $��786,526.4,0,0q�6>   $	��Top=�6U   $��20(�6m   ���	#DD6A6A6A$��36��6�   $��90��6�   $��Century Gothic)�6�   �� 54   
   -
   5        $ 
ComboProf1��54      $
��Left=�6'   $��786,559,0,0q�6B   $	��Top=�6W   $��218.5��6o   $��38��6}   ���	#896C6C6C$��20(�6�   6�   59      5:      