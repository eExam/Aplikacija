   M S B A M L   `   `   `  ����@  <eStud, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:eStudeStud  5          eStud.DodajReferenta   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:eStud     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $	��659��68   $��616.562��6D   .��5      � 
�������$��	-1,-6,0,0q�6   .+�5   
   �� $
��Left=�6   $	��599��60   $��57,3.562,0,0q�6=   $	��Top=�6S   $��411.5��6k   .+�5      �� -   5         ��Name$ txtUsername��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Korisničko ime��6K    % !MaterialDesignFloatingHintTextBox#��[ 6{   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6  $��Segoe UI Light)�6   �� 
CaretBrush �	#FF3AB75C��6�   Z� 67  �� 5      -   5        $ txtPassword��5      $ Lozinka��6K   #��[ 6t   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C6  �� 5      -   5        $ txtUsertype��5      $ Tip korisnika��6,   #��[ 6[   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   $��Referent��6  {�.   �	#FF3AB75C6#  �� 5      -   5        $ txtIme��5      $	 Ime��6F   #��[ 6k   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�   $��45.44��6   �	#FF3AB75C6   �� 5      -   5        $ 
txtPrezime��5      $ Prezime��6J   #��[ 6s   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6�    �	#FF3AB75C6  �� 5      $	��Pol��6    J� IsHitTestVisible .  $��20(�6<   ���	#DD939393$��Segoe UI Light)�6a   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ Hidden=�67   	 �� Triggers	 5      �� 5      
 �� Binding
 6*   �� *SelectedItem+ �� ElementName$ txtPol�� �� Value 6_   Z� .a�5   "   ��  � y�$ Visible=�6?   5      5       5"      �� 5$      -   5         ��Name$ txtPol��5$      $
��Left=�6(   $	��Top=�6C   $	��412��6[   $��36��6g   $��20(�6s   ���	#FFF5804B.@�5&      �� $��Zenski��6   $��20(�60   ���	#FF9393936>   �� 5'      $��Muski��6   $��20(�6/   ���	#FF8585856=   5(      (  "System.Windows.Controls.DatePicker  5)      -   5          Name$ txtDatumRodj��5)      $
��Left=�6`   $	��Top=�6{   $��45��6�   $	��412��6�   $��20(�6�   ���	#FFF5804B6�   �� 5+      -   5        $ txtDepartman��5+      $ 	Departman��6M   #��[ 6x   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $��Segoe UI Light)�6   �	#FF3AB75C6  �� 5,      -	   5        $ txtStudijskiProgram��5,      $ Studijski program��6S   #��[ 6�   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6  $
��45.6��6  $��Segoe UI Light)�6   �	#FF3AB75C6:  �� 5-      -
   5        $ txtGrad��5-      $
 Grad��6F   #��[ 6l   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $
��45.6��6�   $��Segoe UI Light)�6   �	#FF3AB75C6   �� 5.      -   5        $ 	txtAdresa��5.      $ Adresa��6H   #��[ 6p   ���	#FFF5804B���	#DD191919$
��Bold"�6�   $��18(�6�   $
��45.6��6�   $��Segoe UI Light)�6   �	#FF3AB75C6$  �� 5/      -   5        $��Sacuvaj��5/      $
��Left=�6'   $	��Top=�6B   $��411.5��6Z   $��0,20,0,0q�6~   ���	#FFF5804B$��50��6�   $��30(�6�   $��Segoe UI Light)�6�   ��6�   Z� 6�   50      52      53      